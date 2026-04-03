using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TiroParabolico
{
    /// <summary>
    /// Formulario principal del juego de tiro parabólico.
    ///
    /// REGLAS DE COLISIÓN:
    ///   • Objetivo  (picObjetivoF)  → rebota (1 rebote). Después cae al suelo
    ///                                  y rebota 2 veces más en el suelo → fin.
    ///   • Suelo     (picSueloF)     → rebota hasta completar 2 rebotes en suelo → fin.
    ///   • Obstáculo (picObstaculoF) → fin inmediato del vuelo, sin rebote.
    ///
    /// REBOTE (AplicarRebote):
    ///   - Vy se invierte  (rebote vertical).
    ///   - Vx y Vy se reducen al 60 % (pérdida del 40 % de energía).
    /// </summary>
    public partial class ProcessForm : Form
    {
        // ══════════════════════════════════════════════════════════════
        //  REFERENCIAS A OTROS FORMULARIOS
        // ══════════════════════════════════════════════════════════════

        BackForm backForm;
        GraphForm graphForm;

        // ══════════════════════════════════════════════════════════════
        //  ESTADO DEL ARRASTRE CON EL MOUSE
        // ══════════════════════════════════════════════════════════════

        int startMouseX, startMouseY;
        int deltaX, deltaY;
        int initialTejoX, initialTejoY;

        /// <summary>
        /// True mientras el usuario mantiene presionado el mouse.
        /// Desactiva todas las colisiones para evitar falsas detecciones
        /// mientras el tejo aún no ha sido lanzado.
        /// </summary>
        bool estaArrastrando = false;

        // ══════════════════════════════════════════════════════════════
        //  VARIABLES CINEMÁTICAS — SEGMENTO DE VUELO ACTUAL
        //
        //  Cada rebote reinicia x0, y0, v0x, v0y y t = 0.
        //  El segmento sigue la parábola:
        //    x(t) = v0x·t  + x0
        //    y(t) = -½g·t² + v0y·t + y0
        //    Vx   = v0x                   (constante)
        //    Vy   = v0y - g·t
        // ══════════════════════════════════════════════════════════════

        double x0, y0;     // Posición inicial del segmento actual (px)
        double v0x, v0y;   // Velocidad inicial del segmento actual (px/tick)
        double t = 0;      // Tiempo dentro del segmento (s; cada tick suma 0.1)

        /// <summary>Gravedad de la simulación (px/s²).</summary>
        double gravity = 9.8;

        // ══════════════════════════════════════════════════════════════
        //  ESCALA PÍXELES → METROS  (para mostrar en labels y gráficas)
        // ══════════════════════════════════════════════════════════════

        /// <summary>1 px = SCALE m → con 0.1: 10 px = 1 m.</summary>
        const double SCALE = 0.1;

        // ══════════════════════════════════════════════════════════════
        //  TIEMPO TOTAL ACUMULADO (para el eje X de las gráficas)
        // ══════════════════════════════════════════════════════════════

        /// <summary>
        /// Suma de todos los ticks desde el lanzamiento, en segundos.
        /// Se reinicia en cero al soltar el tejo; no se borra en los rebotes.
        /// </summary>
        double tiempoTotal = 0;

        // ══════════════════════════════════════════════════════════════
        //  DELAY DE COLISIONES POST-LANZAMIENTO
        // ══════════════════════════════════════════════════════════════

        /// <summary>
        /// Segundos que deben pasar tras el lanzamiento antes de activar
        /// la detección de colisiones.  Evita detecciones falsas inmediatas
        /// (p. ej. el tejo superpuesto con el suelo al soltarlo hacia abajo).
        /// </summary>
        const double DELAY_COLISION = 1.0;

        // ══════════════════════════════════════════════════════════════
        //  ESTADO DE REBOTES
        // ══════════════════════════════════════════════════════════════

        /// <summary>
        /// Fase del vuelo.  Determina qué colisiones se procesan y cuándo
        /// termina la simulación.
        ///
        ///   LIBRE       → tejo en vuelo, aún no tocó nada.
        ///   REBOTO_OBJ  → tocó el objetivo y rebotó; ahora busca el suelo.
        ///   SUELO_1     → primer rebote en suelo completado.
        ///   SUELO_2     → segundo rebote en suelo completado → próximo suelo = fin.
        ///   FIN         → vuelo terminado (timer parado).
        /// </summary>
        enum FaseVuelo { LIBRE, REBOTO_OBJ, SUELO_1, SUELO_2, FIN }
        FaseVuelo fase = FaseVuelo.LIBRE;

        /// <summary>
        /// Bandera anti-doble-detección: se activa justo después de procesar
        /// un rebote y se desactiva en ReiniciarFisica(), impidiendo que el
        /// mismo impacto se registre en dos ticks consecutivos.
        /// </summary>
        bool enRebote = false;

        // Datos cinemáticos guardados en cada rebote (labels del panel)
        double rebote1X, rebote1Y, rebote1Vx, rebote1Vy;
        double rebote2X, rebote2Y, rebote2Vx, rebote2Vy;
        double rebote3X, rebote3Y, rebote3Vx, rebote3Vy;

        // ══════════════════════════════════════════════════════════════
        //  HISTORIAL PARA GRÁFICAS
        // ══════════════════════════════════════════════════════════════

        List<double> histT = new List<double>();
        List<double> histX = new List<double>();
        List<double> histY = new List<double>();
        List<double> histVx = new List<double>();
        List<double> histVy = new List<double>();
        List<double> histVmag = new List<double>();
        List<double> histAng = new List<double>();

        /// <summary>Índices del historial donde ocurrió un rebote (marcadores en gráficas).</summary>
        List<int> histIndicesRebote = new List<int>();

        // ══════════════════════════════════════════════════════════════
        //  CONSTRUCTOR
        // ══════════════════════════════════════════════════════════════

        public ProcessForm()
        {
            InitializeComponent();
        }

        // ══════════════════════════════════════════════════════════════
        //  CARGA DEL FORMULARIO
        // ══════════════════════════════════════════════════════════════

        private void ProcessForm_Load(object sender, EventArgs e)
        {
            // Crear formulario de fondo detrás de ProcessForm
            backForm = new BackForm()
            {
                StartPosition = FormStartPosition.Manual,
                Size = this.Size,
                Location = this.Location,
                ShowInTaskbar = false
            };
            backForm.Show();
            this.BringToFront();

            // Clonar geometría desde BackForm
            picTejoF.Location = backForm.TejoLocation;
            picTejoF.Size = backForm.TejoSize;
            picSueloF.Location = backForm.SueloLocation;
            picSueloF.Size = backForm.SueloSize;
            picObjetivoF.Location = backForm.ObjetivoLocation;
            picObjetivoF.Size = backForm.ObjetivoSize;
            picObstaculoF.Location = backForm.ObstaculoLocation;
            picObstaculoF.Size = backForm.ObstaculoSize;

            initialTejoX = picTejoF.Location.X;
            initialTejoY = picTejoF.Location.Y;

            // Objetivo ESTÁTICO; obstáculo aleatorio cada partida
            PosicionarObstaculoAleatorio();

            panelCalculos.Visible = false;   // Panel oculto al arrancar

            graphForm = new GraphForm();
            graphForm.Owner = this;

            picTejoF.BringToFront();
            lblEstado.Text = "Arrastra el tejo y suéltalo para lanzar";
        }

        // ══════════════════════════════════════════════════════════════
        //  BOTONES — gráficas y panel de estadísticas
        // ══════════════════════════════════════════════════════════════

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            if (graphForm == null) return;
            if (graphForm.Visible) graphForm.Hide();
            else { graphForm.Show(); graphForm.BringToFront(); }
        }

        private void btnMostrarStats_Click(object sender, EventArgs e)
        {
            panelCalculos.Visible = true;
            picTejoF.BringToFront();
        }

        private void btnOcultarStats_Click(object sender, EventArgs e)
        {
            panelCalculos.Visible = false;
        }

        // ══════════════════════════════════════════════════════════════
        //  POSICIONAMIENTO ALEATORIO DEL OBSTÁCULO
        // ══════════════════════════════════════════════════════════════

        private void PosicionarObstaculoAleatorio()
        {
            Random rnd = new Random();
            picObstaculoF.Location = new Point(
                rnd.Next(250, 441),   // X ∈ [250, 440]
                rnd.Next(50, 251)    // Y ∈ [50, 250]
            );
        }

        // ══════════════════════════════════════════════════════════════
        //  ARRASTRE DEL TEJO
        // ══════════════════════════════════════════════════════════════

        private void picTejoF_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startMouseX = e.X;
                startMouseY = e.Y;
                estaArrastrando = true;
                picTejoF.BringToFront();
            }
        }

        private void picTejoF_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picTejoF.Location = new Point(
                    picTejoF.Location.X + e.X - startMouseX,
                    picTejoF.Location.Y + e.Y - startMouseY
                );
                // Distancia de estiramiento respecto a la posición de reposo
                deltaX = initialTejoX - picTejoF.Location.X;
                deltaY = picTejoF.Location.Y - initialTejoY;
                picTejoF.BringToFront();
            }
        }

        private void picTejoF_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                estaArrastrando = false;

                // La velocidad inicial es proporcional al estiramiento del arrastre.
                // x0/y0 compensan que el tejo parte físicamente desde su reposo.
                x0 = -deltaX;
                y0 = -deltaY;
                v0x = deltaX;
                v0y = deltaY;

                // Reiniciar toda la simulación
                t = 0;
                tiempoTotal = 0;
                fase = FaseVuelo.LIBRE;
                enRebote = false;
                LimpiarHistorial();
                LimpiarLabelsRebotes();

                double v0mag = Math.Sqrt(v0x * v0x + v0y * v0y) * SCALE;
                double v0ang = Math.Atan2(v0y, v0x) * 180.0 / Math.PI;
                lblV0x.Text = $"V0x: {v0x * SCALE:F2} m/s";
                lblV0y.Text = $"V0y: {v0y * SCALE:F2} m/s";
                lblV0mag.Text = $"|V0|: {v0mag:F2} m/s";
                lblV0ang.Text = $"θ0: {v0ang:F1}°";

                lblEstado.Text = "En vuelo...";
                picTejoF.BringToFront();
                timer1.Enabled = true;
            }
        }

        // ══════════════════════════════════════════════════════════════
        //  TICK DEL TIMER
        // ══════════════════════════════════════════════════════════════

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ── 1. Cinemática del segmento actual ─────────────────────────
            double xt = v0x * t + x0;
            double yt = -0.5 * gravity * t * t + v0y * t + y0;
            double vx = v0x;
            double vy = v0y - gravity * t;
            double vmag = Math.Sqrt(vx * vx + vy * vy);
            double ang = Math.Atan2(vy, vx) * 180.0 / Math.PI;

            // ── 2. Mover sprite (Y invertida: física↑ = pantalla↓) ────────
            picTejoF.Location = new Point(
                initialTejoX + (int)xt,
                initialTejoY - (int)yt
            );
            picTejoF.BringToFront();

            // ── 3. Registrar historial y actualizar labels ─────────────────
            histT.Add(tiempoTotal);
            histX.Add(xt * SCALE);
            histY.Add(yt * SCALE);
            histVx.Add(vx * SCALE);
            histVy.Add(vy * SCALE);
            histVmag.Add(vmag * SCALE);
            histAng.Add(ang);
            ActualizarCalculos(vx, vy, vmag, ang);

            // ── 4. Avanzar tiempo ─────────────────────────────────────────
            t += 0.1;
            tiempoTotal += 0.1;

            // ── 5. Ignorar colisiones durante el delay inicial ────────────
            if (tiempoTotal < DELAY_COLISION) return;

            // ── 6. Si el tejo ya abandonó el área del último rebote ────────
            //       (anti-doble-detección), liberar la bandera enRebote
            if (enRebote)
            {
                // Se considera "fuera" cuando deja de intersectar con suelo y objetivo
                bool sobreObjetivo = picTejoF.Bounds.IntersectsWith(picObjetivoF.Bounds);
                bool sobreSuelo = picTejoF.Bounds.IntersectsWith(picSueloF.Bounds);
                if (!sobreObjetivo && !sobreSuelo)
                    enRebote = false;
                // Mientras sigue superpuesto, no procesar más colisiones este tick
                return;
            }

            // ══════════════════════════════════════════════════════════════
            //  DETECCIÓN DE COLISIONES
            // ══════════════════════════════════════════════════════════════

            // ── OBSTÁCULO: fin inmediato, sin rebote ──────────────────────
            if (picTejoF.Bounds.IntersectsWith(picObstaculoF.Bounds))
            {
                FinDelVuelo(xt, yt, vx, vy, vmag, ang, "obstáculo");
                return;
            }

            // ── OBJETIVO: un rebote → cambia a fase REBOTO_OBJ ───────────
            if (fase == FaseVuelo.LIBRE &&
                picTejoF.Bounds.IntersectsWith(picObjetivoF.Bounds))
            {
                GuardarDatosRebote(1, xt, yt, vx, vy);
                lblRebote1.Text = FormatRebote("Rebote 1 (objetivo)", rebote1X, rebote1Y, rebote1Vx, rebote1Vy);

                AplicarRebote(ref vx, ref vy);
                ReiniciarSegmento(xt, yt, vx, vy);
                fase = FaseVuelo.REBOTO_OBJ;
                return;
            }

            // ── SUELO ─────────────────────────────────────────────────────
            if (picTejoF.Bounds.IntersectsWith(picSueloF.Bounds))
            {
                switch (fase)
                {
                    // ── Cayó al suelo sin tocar el objetivo ───────────────
                    // → primer rebote en suelo
                    case FaseVuelo.LIBRE:
                        GuardarDatosRebote(1, xt, yt, vx, vy);
                        lblRebote1.Text = FormatRebote("Rebote 1 (suelo)", rebote1X, rebote1Y, rebote1Vx, rebote1Vy);
                        AplicarRebote(ref vx, ref vy);
                        ReiniciarSegmento(xt, yt, vx, vy);
                        fase = FaseVuelo.SUELO_1;
                        return;

                    // ── Rebotó en objetivo y ahora toca suelo ─────────────
                    // → primer rebote en suelo (el rebote en objetivo ya fue el rebote 1)
                    case FaseVuelo.REBOTO_OBJ:
                        GuardarDatosRebote(2, xt, yt, vx, vy);
                        lblRebote2.Text = FormatRebote("Rebote 2 (suelo)", rebote2X, rebote2Y, rebote2Vx, rebote2Vy);
                        AplicarRebote(ref vx, ref vy);
                        ReiniciarSegmento(xt, yt, vx, vy);
                        fase = FaseVuelo.SUELO_1;
                        return;

                    // ── Segundo toque al suelo ────────────────────────────
                    // → último rebote en suelo
                    case FaseVuelo.SUELO_1:
                        // Elegir el label correcto según cuántos rebotes hubo antes
                        int numRebote = (rebote2X != 0) ? 3 : 2;
                        GuardarDatosRebote(numRebote, xt, yt, vx, vy);
                        if (numRebote == 2)
                            lblRebote2.Text = FormatRebote("Rebote 2 (suelo)", rebote2X, rebote2Y, rebote2Vx, rebote2Vy);
                        else
                            lblRebote2.Text = FormatRebote("Rebote 3 (suelo)", rebote3X, rebote3Y, rebote3Vx, rebote3Vy);
                        AplicarRebote(ref vx, ref vy);
                        ReiniciarSegmento(xt, yt, vx, vy);
                        fase = FaseVuelo.SUELO_2;
                        return;

                    // ── Tercer toque al suelo → fin del vuelo ─────────────
                    case FaseVuelo.SUELO_2:
                        FinDelVuelo(xt, yt, vx, vy, vmag, ang, "suelo");
                        return;
                }
            }
        }

        // ══════════════════════════════════════════════════════════════
        //  HELPERS DE FÍSICA
        // ══════════════════════════════════════════════════════════════

        /// <summary>
        /// Aplica el rebote:
        ///   • Invierte Vy (choque con superficie horizontal).
        ///   • Reduce |Vx| y |Vy| al 60 % (−40 % de energía).
        /// Registra el índice en el historial para el marcador de gráficas.
        /// </summary>
        private void AplicarRebote(ref double vx, ref double vy)
        {
            histIndicesRebote.Add(histT.Count - 1);
            vx = vx * 0.6;
            vy = -vy * 0.6;   // Inversión + atenuación del 40 %
        }

        /// <summary>
        /// Inicia un nuevo segmento parabólico desde el punto de rebote.
        /// Reinicia t = 0 para la ecuación de posición del nuevo tramo.
        /// tiempoTotal NO se reinicia: mantiene el eje de tiempo continuo.
        /// enRebote se activa para evitar doble-detección en el mismo tick.
        /// </summary>
        private void ReiniciarSegmento(double xt, double yt, double vx, double vy)
        {
            x0 = xt;
            y0 = yt;
            v0x = vx;
            v0y = vy;
            t = 0;
            enRebote = true;   // Se liberará cuando el tejo salga del área de colisión
        }

        /// <summary>Guarda los datos cinemáticos del rebote n (1, 2 ó 3).</summary>
        private void GuardarDatosRebote(int n, double xt, double yt, double vx, double vy)
        {
            double rx = xt * SCALE, ry = yt * SCALE;
            double rvx = vx * SCALE, rvy = vy * SCALE;
            if (n == 1) { rebote1X = rx; rebote1Y = ry; rebote1Vx = rvx; rebote1Vy = rvy; }
            else if (n == 2) { rebote2X = rx; rebote2Y = ry; rebote2Vx = rvx; rebote2Vy = rvy; }
            else { rebote3X = rx; rebote3Y = ry; rebote3Vx = rvx; rebote3Vy = rvy; }
        }

        /// <summary>Formatea la línea de texto de un rebote para el label.</summary>
        private string FormatRebote(string titulo, double rx, double ry, double rvx, double rvy)
            => $"{titulo} → x:{rx:F2}m  y:{ry:F2}m  Vx:{rvx:F2}  Vy:{rvy:F2}";

        // ══════════════════════════════════════════════════════════════
        //  FIN DEL VUELO
        // ══════════════════════════════════════════════════════════════

        private void FinDelVuelo(double xt, double yt, double vx, double vy,
                                  double vmag, double ang, string causa)
        {
            timer1.Enabled = false;
            fase = FaseVuelo.FIN;

            lblEstado.Text = $"¡Impacto ({causa})! — Arrastra para relanzar o presiona Reiniciar";
            lblVfx.Text = $"Vfx: {vx * SCALE:F2} m/s";
            lblVfy.Text = $"Vfy: {vy * SCALE:F2} m/s";
            lblVfmag.Text = $"|Vf|: {vmag * SCALE:F2} m/s";
            lblVfang.Text = $"θf: {ang:F1}°";
            lblTiempoVuelo.Text = $"Tiempo: {tiempoTotal:F2} s";

            graphForm.CargarDatos(
                histT, histX, histY,
                histVx, histVy, histVmag, histAng,
                histIndicesRebote
            );
            graphForm.Show();
            graphForm.BringToFront();
        }

        // ══════════════════════════════════════════════════════════════
        //  ACTUALIZACIÓN DE LABELS EN TIEMPO REAL
        // ══════════════════════════════════════════════════════════════

        private void ActualizarCalculos(double vx, double vy, double vmag, double ang)
        {
            lblTiempoVuelo.Text = $"Tiempo: {tiempoTotal:F2} s";

            double yMax = double.MinValue, xMax = double.MinValue;
            for (int i = 0; i < histY.Count; i++)
            {
                if (histY[i] > yMax) yMax = histY[i];
                if (histX[i] > xMax) xMax = histX[i];
            }
            lblAlturaMax.Text = $"Alt. max: {(yMax == double.MinValue ? 0 : yMax):F2} m";
            lblAlcance.Text = $"Alcance:  {(xMax == double.MinValue ? 0 : xMax):F2} m";

            // Velocidad en altura máxima: Vy cruza de ≥0 a <0
            if (histVy.Count >= 2 &&
                histVy[histVy.Count - 2] >= 0 &&
                histVy[histVy.Count - 1] < 0)
            {
                lblVelMaxVx.Text = $"Vx: {vx * SCALE:F2} m/s";
                lblVelMaxVy.Text = $"Vy: {vy * SCALE:F2} m/s";
                lblVelMaxMag.Text = $"|V|: {vmag * SCALE:F2} m/s";
                lblVelMaxAng.Text = $"θ: {ang:F1}°";
            }
        }

        // ══════════════════════════════════════════════════════════════
        //  LIMPIEZA ENTRE LANZAMIENTOS
        // ══════════════════════════════════════════════════════════════

        private void LimpiarHistorial()
        {
            histT.Clear(); histX.Clear(); histY.Clear();
            histVx.Clear(); histVy.Clear();
            histVmag.Clear(); histAng.Clear();
            histIndicesRebote.Clear();
        }

        private void LimpiarLabelsRebotes()
        {
            lblRebote1.Text = "Rebote 1: --";
            lblRebote2.Text = "Rebote 2: --";
            // Reiniciar datos de rebotes
            rebote1X = rebote1Y = rebote1Vx = rebote1Vy = 0;
            rebote2X = rebote2Y = rebote2Vx = rebote2Vy = 0;
            rebote3X = rebote3Y = rebote3Vx = rebote3Vy = 0;
        }

        // ══════════════════════════════════════════════════════════════
        //  SINCRONIZACIÓN CON BACKFORM
        // ══════════════════════════════════════════════════════════════

        private void ProcessForm_Move(object sender, EventArgs e)
        {
            if (backForm != null) backForm.Location = this.Location;
        }

        // ══════════════════════════════════════════════════════════════
        //  BOTÓN REINICIAR
        // ══════════════════════════════════════════════════════════════

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            t = 0;
            tiempoTotal = 0;
            fase = FaseVuelo.LIBRE;
            enRebote = false;
            estaArrastrando = false;
            deltaX = 0;
            deltaY = 0;
            LimpiarHistorial();
            LimpiarLabelsRebotes();

            picTejoF.Location = new Point(initialTejoX, initialTejoY);
            picTejoF.BringToFront();

            // Obstáculo en nueva posición aleatoria; objetivo permanece estático
            PosicionarObstaculoAleatorio();

            lblV0x.Text = "V0x: --"; lblV0y.Text = "V0y: --";
            lblV0mag.Text = "|V0|: --"; lblV0ang.Text = "θ0: --";
            lblTiempoVuelo.Text = "Tiempo: --";
            lblAlcance.Text = "Alcance:  --"; lblAlturaMax.Text = "Alt. max: --";
            lblVelMaxVx.Text = "Vx: --"; lblVelMaxVy.Text = "Vy: --";
            lblVelMaxMag.Text = "|V|: --"; lblVelMaxAng.Text = "θ: --";
            lblVfx.Text = "Vfx: --"; lblVfy.Text = "Vfy: --";
            lblVfmag.Text = "|Vf|: --"; lblVfang.Text = "θf: --";

            if (graphForm != null && graphForm.Visible) graphForm.Hide();

            lblEstado.Text = "Arrastra el tejo y suéltalo para lanzar";
        }

        private void picSueloF_Click(object sender, EventArgs e) { }
    }
}