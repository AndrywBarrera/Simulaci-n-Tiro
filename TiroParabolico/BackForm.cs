using System;
using System.Drawing;
using System.Windows.Forms;

namespace TiroParabolico
{
    /// <summary>
    /// Formulario de fondo (escenario visual del juego).
    /// Actúa como "pantalla de diseño": contiene los PictureBox con los
    /// sprites del tejo, suelo, obstáculo y objetivo, y expone sus
    /// posiciones/tamaños para que ProcessForm los consuma.
    /// Se muestra detrás de ProcessForm y no aparece en la barra de tareas.
    /// </summary>
    public partial class BackForm : Form
    {
        // ──────────────────────────────────────────────
        //  Constructor
        // ──────────────────────────────────────────────

        public BackForm()
        {
            InitializeComponent();

            // Ocultar este formulario de la barra de tareas de Windows
            this.ShowInTaskbar = false;
        }

        // ──────────────────────────────────────────────
        //  Propiedades públicas — exponen la geometría
        //  de cada PictureBox para que ProcessForm pueda
        //  clonar posición y tamaño en sus propios controles.
        // ──────────────────────────────────────────────

        /// <summary>Posición del tejo en el escenario.</summary>
        public Point TejoLocation
        {
            get { return picBalon.Location; }
            set { picBalon.Location = value; }
        }

        /// <summary>Tamaño del sprite del tejo.</summary>
        public Size TejoSize
        {
            get { return picBalon.Size; }
            set { picBalon.Size = value; }
        }

        /// <summary>Posición del obstáculo en el escenario.</summary>
        public Point ObstaculoLocation
        {
            get { return picObstaculo.Location; }
            set { picObstaculo.Location = value; }
        }

        /// <summary>Tamaño del sprite del obstáculo.</summary>
        public Size ObstaculoSize
        {
            get { return picObstaculo.Size; }
            set { picObstaculo.Size = value; }
        }

        /// <summary>Posición del suelo en el escenario.</summary>
        public Point SueloLocation
        {
            get { return picSuelo.Location; }
            set { picSuelo.Location = value; }
        }

        /// <summary>Tamaño del sprite del suelo.</summary>
        public Size SueloSize
        {
            get { return picSuelo.Size; }
            set { picSuelo.Size = value; }
        }

        /// <summary>Posición del objetivo/blanco en el escenario.</summary>
        public Point ObjetivoLocation
        {
            get { return picObjetivo.Location; }
            set { picObjetivo.Location = value; }
        }

        /// <summary>Tamaño del sprite del objetivo.</summary>
        public Size ObjetivoSize
        {
            get { return picObjetivo.Size; }
            set { picObjetivo.Size = value; }
        }

        // ──────────────────────────────────────────────
        //  Eventos del formulario
        // ──────────────────────────────────────────────

        /// <summary>
        /// Evento de carga del formulario.
        /// Reservado para inicializaciones adicionales si se requieren.
        /// </summary>
        private void BackForm_Load(object sender, EventArgs e)
        {
            // Sin lógica adicional por ahora
        }

        /// <summary>
        /// Evento de movimiento del mouse sobre el fondo.
        /// Reservado para uso futuro (p. ej. efectos de hover).
        /// </summary>
        private void BackForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Sin lógica adicional por ahora
        }

        /// <summary>
        /// Cuando el usuario hace clic sobre el fondo, trae al frente
        /// el formulario de juego (ProcessForm) para que la interacción
        /// no quede bloqueada por este formulario de fondo.
        /// </summary>
        private void BackForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Buscar ProcessForm entre los formularios abiertos
            var processForm = Application.OpenForms["ProcessForm"];

            // Si existe, traerlo al frente
            processForm?.BringToFront();
        }
    }
}