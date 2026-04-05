using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TiroParabolico
{
    /// <summary>
    /// Formulario de gráficas del tiro parabólico.
    /// Se abre automáticamente al finalizar el vuelo y puede
    /// ocultarse/mostrarse con el botón de ProcessForm.
    /// Contiene 7 gráficas: y(t), x(t), y(x), Vx(t), Vy(t), |V|(t), θ(t).
    /// </summary>
    public partial class GraphForm : Form
    {
        // ── Bandera para inicialización de series ─────────────
        private bool _seriesInicializadas = false;

        public GraphForm()
        {
            InitializeComponent();
            btnCerrar.Click += (s, e) => this.Hide();
        }

        // ──────────────────────────────────────────────────────
        //  API pública — llamada desde ProcessForm
        // ──────────────────────────────────────────────────────

        /// <summary>
        /// Recibe los historiales y actualiza las 7 gráficas.
        /// En tiempo real solo agrega el último punto (más eficiente).
        /// Al finalizar o al reiniciar recarga todo.
        /// </summary>
        public void CargarDatos(
            List<double> t,
            List<double> x,
            List<double> y,
            List<double> vx,
            List<double> vy,
            List<double> vmag,
            List<double> ang,
            List<int> indicesRebote,
            bool forzarRecarga = false)
        {
            if (t == null || t.Count == 0) return;

            // Si no están inicializadas o se fuerza recarga, reiniciar todo
            if (!_seriesInicializadas || forzarRecarga)
            {
                InicializarSeries();
                CargarTodosLosPuntos(t, x, y, vx, vy, vmag, ang, indicesRebote);
                _seriesInicializadas = true;
                return;
            }

            // ── Modo incremental: solo agregar el último punto ─
            int idx = t.Count - 1;
            if (idx < 0) return;

            AgregarPunto(chartYT, "y(t)", t[idx], y[idx]);
            AgregarPunto(chartXT, "x(t)", t[idx], x[idx]);
            AgregarPunto(chartYX, "y(x)", x[idx], y[idx]);
            AgregarPunto(chartVxT, "Vx(t)", t[idx], vx[idx]);
            AgregarPunto(chartVyT, "Vy(t)", t[idx], vy[idx]);
            AgregarPunto(chartVmagT, "|V|(t)", t[idx], vmag[idx]);
            AgregarPunto(chartAngT, "θ(t)", t[idx], ang[idx]);

            // Marcar rebote si el último índice registrado es este punto
            if (indicesRebote != null && indicesRebote.Count > 0 &&
                indicesRebote[indicesRebote.Count - 1] == idx)
            {
                AgregarMarcadorRebote(chartYT, t[idx], y[idx]);
                AgregarMarcadorRebote(chartXT, t[idx], x[idx]);
                AgregarMarcadorRebote(chartYX, x[idx], y[idx]);
                AgregarMarcadorRebote(chartVxT, t[idx], vx[idx]);
                AgregarMarcadorRebote(chartVyT, t[idx], vy[idx]);
                AgregarMarcadorRebote(chartVmagT, t[idx], vmag[idx]);
                AgregarMarcadorRebote(chartAngT, t[idx], ang[idx]);
            }
        }

        /// <summary>Llama esto al reiniciar para que las series se recreen.</summary>
        public void ReiniciarSeries()
        {
            _seriesInicializadas = false;
            LimpiarTodos();
        }

        // ──────────────────────────────────────────────────────
        //  Helpers privados
        // ──────────────────────────────────────────────────────

        private void InicializarSeries()
        {
            LimpiarTodos();

            ConfigurarSerie(chartYT, "y(t)", "Tiempo (s)", "Posición Y (m)", Color.DeepSkyBlue);
            ConfigurarSerie(chartXT, "x(t)", "Tiempo (s)", "Posición X (m)", Color.LimeGreen);
            ConfigurarSerie(chartYX, "y(x)", "Posición X (m)", "Posición Y (m)", Color.Gold);
            ConfigurarSerie(chartVxT, "Vx(t)", "Tiempo (s)", "Vx (m/s)", Color.Coral);
            ConfigurarSerie(chartVyT, "Vy(t)", "Tiempo (s)", "Vy (m/s)", Color.MediumPurple);
            ConfigurarSerie(chartVmagT, "|V|(t)", "Tiempo (s)", "|V| (m/s)", Color.Orange);
            ConfigurarSerie(chartAngT, "θ(t)", "Tiempo (s)", "Ángulo (°)", Color.HotPink);
        }

        private void CargarTodosLosPuntos(
            List<double> t, List<double> x, List<double> y,
            List<double> vx, List<double> vy, List<double> vmag,
            List<double> ang, List<int> indicesRebote)
        {
            for (int i = 0; i < t.Count; i++)
            {
                AgregarPunto(chartYT, "y(t)", t[i], y[i]);
                AgregarPunto(chartXT, "x(t)", t[i], x[i]);
                AgregarPunto(chartYX, "y(x)", x[i], y[i]);
                AgregarPunto(chartVxT, "Vx(t)", t[i], vx[i]);
                AgregarPunto(chartVyT, "Vy(t)", t[i], vy[i]);
                AgregarPunto(chartVmagT, "|V|(t)", t[i], vmag[i]);
                AgregarPunto(chartAngT, "θ(t)", t[i], ang[i]);
            }

            if (indicesRebote != null)
            {
                foreach (int idx in indicesRebote)
                {
                    if (idx < t.Count)
                    {
                        AgregarMarcadorRebote(chartYT, t[idx], y[idx]);
                        AgregarMarcadorRebote(chartXT, t[idx], x[idx]);
                        AgregarMarcadorRebote(chartYX, x[idx], y[idx]);
                        AgregarMarcadorRebote(chartVxT, t[idx], vx[idx]);
                        AgregarMarcadorRebote(chartVyT, t[idx], vy[idx]);
                        AgregarMarcadorRebote(chartVmagT, t[idx], vmag[idx]);
                        AgregarMarcadorRebote(chartAngT, t[idx], ang[idx]);
                    }
                }
            }
        }

        /// <summary>
        /// Configura los títulos, colores y ejes de un Chart y crea su serie principal.
        /// </summary>
        private void ConfigurarSerie(
            Chart chart,
            string nombreSerie,
            string tituloX,
            string tituloY,
            Color colorLinea)
        {
            chart.Series.Clear();
            chart.Titles.Clear();

            // Título
            var titulo = chart.Titles.Add(nombreSerie);
            titulo.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
            titulo.ForeColor = Color.White;

            // Ejes
            var area = chart.ChartAreas[0];
            area.AxisX.Title = tituloX;
            area.AxisY.Title = tituloY;
            area.AxisX.TitleFont = new Font("Segoe UI", 7f);
            area.AxisY.TitleFont = new Font("Segoe UI", 7f);
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 6.5f);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 6.5f);
            area.AxisX.TitleForeColor = Color.LightGray;
            area.AxisY.TitleForeColor = Color.LightGray;
            area.AxisX.LabelStyle.ForeColor = Color.LightGray;
            area.AxisY.LabelStyle.ForeColor = Color.LightGray;
            area.AxisX.LineColor = Color.Gray;
            area.AxisY.LineColor = Color.Gray;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(50, 50, 50);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(50, 50, 50);
            area.BackColor = Color.FromArgb(15, 15, 30);

            // Serie
            var serie = new Series(nombreSerie);
            serie.ChartType = SeriesChartType.Line;
            serie.Color = colorLinea;
            serie.BorderWidth = 2;
            serie.MarkerStyle = MarkerStyle.None;
            chart.Series.Add(serie);
        }

        /// <summary>Agrega un punto a la serie principal del chart.</summary>
        private void AgregarPunto(Chart chart, string nombreSerie, double px, double py)
        {
            if (chart.Series.IsUniqueName(nombreSerie)) return; // serie no existe aún
            chart.Series[nombreSerie].Points.AddXY(px, py);
        }

        /// <summary>
        /// Agrega un marcador de rebote (estrella roja) como serie de un solo punto.
        /// </summary>
        private void AgregarMarcadorRebote(Chart chart, double px, double py)
        {
            string nombre = $"Rebote_{chart.Series.Count}";
            var marcador = new Series(nombre);
            marcador.ChartType = SeriesChartType.Point;
            marcador.Color = Color.OrangeRed;
            marcador.MarkerStyle = MarkerStyle.Star4;
            marcador.MarkerSize = 10;
            marcador.MarkerBorderColor = Color.Yellow;
            marcador.Points.AddXY(px, py);
            chart.Series.Add(marcador);
        }

        private void LimpiarTodos()
        {
            Chart[] todos = { chartYT, chartXT, chartYX, chartVxT, chartVyT, chartVmagT, chartAngT };
            foreach (var c in todos)
            {
                c.Series.Clear();
                c.Titles.Clear();
            }
        }

        private void GraphForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}