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
        // ──────────────────────────────────────────────
        //  Constructor
        // ──────────────────────────────────────────────
        public GraphForm()
        {
            InitializeComponent();

            // El botón de cerrar solo oculta, no destruye el formulario
            btnCerrar.Click += (s, e) => this.Hide();
        }

        // ──────────────────────────────────────────────
        //  API pública — llamada desde ProcessForm
        // ──────────────────────────────────────────────

        /// <summary>
        /// Recibe los historiales de la simulación y rellena las 7 gráficas.
        /// Incluye marcadores especiales para los puntos de rebote.
        /// </summary>
        public void CargarDatos(
            List<double> t,
            List<double> x,
            List<double> y,
            List<double> vx,
            List<double> vy,
            List<double> vmag,
            List<double> ang,
            List<int> indicesRebote)   // índices en la lista donde ocurrieron rebotes
        {
            // Limpiar todas las gráficas antes de cargar nuevos datos
            LimpiarTodos();

            // ── Cargar cada gráfica ───────────────────
            CargarSerie(chartYT, t, y, "y(t)", "Tiempo (s)", "Posición Y (m)", Color.DeepSkyBlue);
            CargarSerie(chartXT, t, x, "x(t)", "Tiempo (s)", "Posición X (m)", Color.LimeGreen);
            CargarSerie(chartYX, x, y, "y(x)", "Posición X (m)", "Posición Y (m)", Color.Gold);
            CargarSerie(chartVxT, t, vx, "Vx(t)", "Tiempo (s)", "Vx (m/s)", Color.Coral);
            CargarSerie(chartVyT, t, vy, "Vy(t)", "Tiempo (s)", "Vy (m/s)", Color.MediumPurple);
            CargarSerie(chartVmagT, t, vmag, "|V|(t)", "Tiempo (s)", "|V| (m/s)", Color.Orange);
            CargarSerie(chartAngT, t, ang, "θ(t)", "Tiempo (s)", "Ángulo (°)", Color.HotPink);

            // ── Marcar puntos de rebote en cada gráfica ───
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

        // ──────────────────────────────────────────────
        //  Helpers privados
        // ──────────────────────────────────────────────

        /// <summary>
        /// Carga una serie de datos en un Chart, configurando ejes,
        /// título, color de línea y estilo visual.
        /// </summary>
        private void CargarSerie(
            Chart chart,
            List<double> ejeX,
            List<double> ejeY,
            string nombreSerie,
            string tituloX,
            string tituloY,
            Color colorLinea)
        {
            chart.Series.Clear();
            chart.Titles.Clear();

            // ── Título del chart ──────────────────────
            var titulo = chart.Titles.Add(nombreSerie);
            titulo.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
            titulo.ForeColor = Color.White;

            // ── Configurar ejes ───────────────────────
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

            // ── Serie principal ───────────────────────
            var serie = new Series(nombreSerie);
            serie.ChartType = SeriesChartType.Line;
            serie.Color = colorLinea;
            serie.BorderWidth = 2;
            serie.MarkerStyle = MarkerStyle.None;

            for (int i = 0; i < ejeX.Count && i < ejeY.Count; i++)
                serie.Points.AddXY(ejeX[i], ejeY[i]);

            chart.Series.Add(serie);
        }

        /// <summary>
        /// Agrega un punto marcador (estrella roja) en la posición del rebote
        /// sobre el chart indicado, como una serie separada de un solo punto.
        /// </summary>
        private void AgregarMarcadorRebote(Chart chart, double px, double py)
        {
            string nombreMarcador = $"Rebote_{chart.Series.Count}";
            var marcador = new Series(nombreMarcador);
            marcador.ChartType = SeriesChartType.Point;
            marcador.Color = Color.OrangeRed;
            marcador.MarkerStyle = MarkerStyle.Star4;
            marcador.MarkerSize = 10;
            marcador.MarkerBorderColor = Color.Yellow;
            marcador.Points.AddXY(px, py);
            chart.Series.Add(marcador);
        }

        /// <summary>
        /// Limpia series y títulos de todos los charts.
        /// </summary>
        private void LimpiarTodos()
        {
            Chart[] todos = { chartYT, chartXT, chartYX, chartVxT, chartVyT, chartVmagT, chartAngT };
            foreach (var c in todos)
            {
                c.Series.Clear();
                c.Titles.Clear();
            }
        }

        // ──────────────────────────────────────────────
        //  Eventos del formulario
        // ──────────────────────────────────────────────

        private void GraphForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Evitar que se destruya; solo ocultar
            e.Cancel = true;
            this.Hide();
        }
    }
}