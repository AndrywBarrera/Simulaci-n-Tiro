namespace TiroParabolico
{
    partial class BackForm
    {
        /// <summary>
        /// Contenedor de componentes administrados por el diseñador.
        /// Requerido para la liberación correcta de recursos.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libera los recursos administrados y no administrados del formulario.
        /// Este método es llamado automáticamente al cerrar el formulario.
        /// </summary>
        /// <param name="disposing">
        /// true  → liberar recursos administrados (components, etc.)
        /// false → solo liberar recursos no administrados
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms
        // ──────────────────────────────────────────────────────────────
        //  ¡ADVERTENCIA! No modificar el contenido de este método
        //  manualmente. Use el Diseñador de formularios de Visual Studio.
        // ──────────────────────────────────────────────────────────────

        /// <summary>
        /// Inicializa y configura todos los controles visuales del formulario.
        /// Método generado automáticamente por el Diseñador de Windows Forms.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackForm));
            this.picTejo = new System.Windows.Forms.PictureBox();
            this.picObjetivo = new System.Windows.Forms.PictureBox();
            this.picObstaculo = new System.Windows.Forms.PictureBox();
            this.picSuelo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjetivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // picTejo
            // 
            this.picTejo.BackColor = System.Drawing.Color.Transparent;
            this.picTejo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTejo.BackgroundImage")));
            this.picTejo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTejo.Location = new System.Drawing.Point(102, 320);
            this.picTejo.Name = "picTejo";
            this.picTejo.Size = new System.Drawing.Size(95, 56);
            this.picTejo.TabIndex = 0;
            this.picTejo.TabStop = false;
            this.picTejo.Visible = false;
            // 
            // picObjetivo
            // 
            this.picObjetivo.BackColor = System.Drawing.Color.Transparent;
            this.picObjetivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picObjetivo.BackgroundImage")));
            this.picObjetivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picObjetivo.Location = new System.Drawing.Point(622, 336);
            this.picObjetivo.Name = "picObjetivo";
            this.picObjetivo.Size = new System.Drawing.Size(137, 63);
            this.picObjetivo.TabIndex = 1;
            this.picObjetivo.TabStop = false;
            this.picObjetivo.Visible = false;
            // 
            // picObstaculo
            // 
            this.picObstaculo.BackColor = System.Drawing.Color.Transparent;
            this.picObstaculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picObstaculo.BackgroundImage")));
            this.picObstaculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picObstaculo.Location = new System.Drawing.Point(285, 250);
            this.picObstaculo.Name = "picObstaculo";
            this.picObstaculo.Size = new System.Drawing.Size(87, 159);
            this.picObstaculo.TabIndex = 2;
            this.picObstaculo.TabStop = false;
            this.picObstaculo.Visible = false;
            // 
            // picSuelo
            // 
            this.picSuelo.BackColor = System.Drawing.Color.Transparent;
            this.picSuelo.Location = new System.Drawing.Point(-3, 405);
            this.picSuelo.Name = "picSuelo";
            this.picSuelo.Size = new System.Drawing.Size(801, 33);
            this.picSuelo.TabIndex = 3;
            this.picSuelo.TabStop = false;
            this.picSuelo.Visible = false;
            // 
            // BackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picSuelo);
            this.Controls.Add(this.picObstaculo);
            this.Controls.Add(this.picObjetivo);
            this.Controls.Add(this.picTejo);
            this.DoubleBuffered = true;
            this.Name = "BackForm";
            this.Text = "TiroParabolico - Fondo";
            this.Load += new System.EventHandler(this.BackForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picTejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjetivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuelo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Declaración de controles ──────────────────────────────────
        // Campos privados que el Diseñador genera automáticamente.
        // No renombrar sin actualizar también InitializeComponent().

        /// <summary>Sprite visual e hitbox del tejo (objeto lanzado).</summary>
        private System.Windows.Forms.PictureBox picTejo;

        /// <summary>Sprite visual del objetivo/blanco a alcanzar.</summary>
        private System.Windows.Forms.PictureBox picObjetivo;

        /// <summary>Sprite visual del obstáculo que bloquea la trayectoria.</summary>
        private System.Windows.Forms.PictureBox picObstaculo;

        /// <summary>Hitbox invisible del suelo para detección de colisión.</summary>
        private System.Windows.Forms.PictureBox picSuelo;
    }
}