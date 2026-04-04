namespace TiroParabolico
{
    partial class ProcessForm
    {
        /// <summary>Variable del diseñador necesaria.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Libera los recursos administrados al cerrar el formulario.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms
        // ¡NO modificar manualmente este método!

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessForm));
            this.picSueloF = new System.Windows.Forms.PictureBox();
            this.picObstaculoF = new System.Windows.Forms.PictureBox();
            this.picObjetivoF = new System.Windows.Forms.PictureBox();
            this.picTejoF = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelCalculos = new System.Windows.Forms.Panel();
            this.lblTituloV0 = new System.Windows.Forms.Label();
            this.lblV0x = new System.Windows.Forms.Label();
            this.lblV0y = new System.Windows.Forms.Label();
            this.lblV0mag = new System.Windows.Forms.Label();
            this.lblV0ang = new System.Windows.Forms.Label();
            this.lblTituloVuelo = new System.Windows.Forms.Label();
            this.lblTiempoVuelo = new System.Windows.Forms.Label();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.lblAlturaMax = new System.Windows.Forms.Label();
            this.lblTituloVMax = new System.Windows.Forms.Label();
            this.lblVelMaxVx = new System.Windows.Forms.Label();
            this.lblVelMaxVy = new System.Windows.Forms.Label();
            this.lblVelMaxMag = new System.Windows.Forms.Label();
            this.lblVelMaxAng = new System.Windows.Forms.Label();
            this.lblTituloVf = new System.Windows.Forms.Label();
            this.lblVfx = new System.Windows.Forms.Label();
            this.lblVfy = new System.Windows.Forms.Label();
            this.lblVfmag = new System.Windows.Forms.Label();
            this.lblVfang = new System.Windows.Forms.Label();
            this.lblTituloRebotes = new System.Windows.Forms.Label();
            this.lblRebote1 = new System.Windows.Forms.Label();
            this.lblRebote2 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnGraficas = new System.Windows.Forms.Button();
            this.btnMostrarStats = new System.Windows.Forms.Button();
            this.btnOcultarStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSueloF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculoF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjetivoF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTejoF)).BeginInit();
            this.panelCalculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSueloF
            // 
            this.picSueloF.BackColor = System.Drawing.Color.Transparent;
            this.picSueloF.Location = new System.Drawing.Point(355, 12);
            this.picSueloF.Name = "picSueloF";
            this.picSueloF.Size = new System.Drawing.Size(97, 96);
            this.picSueloF.TabIndex = 7;
            this.picSueloF.TabStop = false;
            this.picSueloF.Click += new System.EventHandler(this.picSueloF_Click);
            // 
            // picObstaculoF
            // 
            this.picObstaculoF.BackColor = System.Drawing.Color.Transparent;
            this.picObstaculoF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picObstaculoF.BackgroundImage")));
            this.picObstaculoF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picObstaculoF.Location = new System.Drawing.Point(35, 12);
            this.picObstaculoF.Name = "picObstaculoF";
            this.picObstaculoF.Size = new System.Drawing.Size(106, 96);
            this.picObstaculoF.TabIndex = 6;
            this.picObstaculoF.TabStop = false;
            // 
            // picObjetivoF
            // 
            this.picObjetivoF.BackColor = System.Drawing.Color.Transparent;
            this.picObjetivoF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picObjetivoF.BackgroundImage")));
            this.picObjetivoF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picObjetivoF.Location = new System.Drawing.Point(257, 12);
            this.picObjetivoF.Name = "picObjetivoF";
            this.picObjetivoF.Size = new System.Drawing.Size(120, 25);
            this.picObjetivoF.TabIndex = 5;
            this.picObjetivoF.TabStop = false;
            // 
            // picTejoF
            // 
            this.picTejoF.BackColor = System.Drawing.Color.Transparent;
            this.picTejoF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTejoF.BackgroundImage")));
            this.picTejoF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTejoF.Location = new System.Drawing.Point(147, 13);
            this.picTejoF.Name = "picTejoF";
            this.picTejoF.Size = new System.Drawing.Size(104, 96);
            this.picTejoF.TabIndex = 30;
            this.picTejoF.TabStop = false;
            this.picTejoF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picTejoF_MouseDown);
            this.picTejoF.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picTejoF_MouseMove_1);
            this.picTejoF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picTejoF_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(610, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "🔄 Reiniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelCalculos
            // 
            this.panelCalculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panelCalculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCalculos.Controls.Add(this.lblTituloV0);
            this.panelCalculos.Controls.Add(this.lblV0x);
            this.panelCalculos.Controls.Add(this.lblV0y);
            this.panelCalculos.Controls.Add(this.lblV0mag);
            this.panelCalculos.Controls.Add(this.lblV0ang);
            this.panelCalculos.Controls.Add(this.lblTituloVuelo);
            this.panelCalculos.Controls.Add(this.lblTiempoVuelo);
            this.panelCalculos.Controls.Add(this.lblAlcance);
            this.panelCalculos.Controls.Add(this.lblAlturaMax);
            this.panelCalculos.Controls.Add(this.lblTituloVMax);
            this.panelCalculos.Controls.Add(this.lblVelMaxVx);
            this.panelCalculos.Controls.Add(this.lblVelMaxVy);
            this.panelCalculos.Controls.Add(this.lblVelMaxMag);
            this.panelCalculos.Controls.Add(this.lblVelMaxAng);
            this.panelCalculos.Controls.Add(this.lblTituloVf);
            this.panelCalculos.Controls.Add(this.lblVfx);
            this.panelCalculos.Controls.Add(this.lblVfy);
            this.panelCalculos.Controls.Add(this.lblVfmag);
            this.panelCalculos.Controls.Add(this.lblVfang);
            this.panelCalculos.Controls.Add(this.lblTituloRebotes);
            this.panelCalculos.Controls.Add(this.lblRebote1);
            this.panelCalculos.Controls.Add(this.lblRebote2);
            this.panelCalculos.Location = new System.Drawing.Point(610, 80);
            this.panelCalculos.Name = "panelCalculos";
            this.panelCalculos.Size = new System.Drawing.Size(180, 375);
            this.panelCalculos.TabIndex = 20;
            this.panelCalculos.Visible = false;
            // 
            // lblTituloV0
            // 
            this.lblTituloV0.AutoSize = true;
            this.lblTituloV0.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloV0.ForeColor = System.Drawing.Color.Gold;
            this.lblTituloV0.Location = new System.Drawing.Point(5, 5);
            this.lblTituloV0.Name = "lblTituloV0";
            this.lblTituloV0.Size = new System.Drawing.Size(103, 12);
            this.lblTituloV0.TabIndex = 0;
            this.lblTituloV0.Text = "-- Velocidad Inicial --";
            // 
            // lblV0x
            // 
            this.lblV0x.AutoSize = true;
            this.lblV0x.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblV0x.ForeColor = System.Drawing.Color.White;
            this.lblV0x.Location = new System.Drawing.Point(5, 22);
            this.lblV0x.Name = "lblV0x";
            this.lblV0x.Size = new System.Drawing.Size(34, 12);
            this.lblV0x.TabIndex = 1;
            this.lblV0x.Text = "V0x: --";
            // 
            // lblV0y
            // 
            this.lblV0y.AutoSize = true;
            this.lblV0y.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblV0y.ForeColor = System.Drawing.Color.White;
            this.lblV0y.Location = new System.Drawing.Point(5, 37);
            this.lblV0y.Name = "lblV0y";
            this.lblV0y.Size = new System.Drawing.Size(34, 12);
            this.lblV0y.TabIndex = 2;
            this.lblV0y.Text = "V0y: --";
            // 
            // lblV0mag
            // 
            this.lblV0mag.AutoSize = true;
            this.lblV0mag.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblV0mag.ForeColor = System.Drawing.Color.White;
            this.lblV0mag.Location = new System.Drawing.Point(5, 52);
            this.lblV0mag.Name = "lblV0mag";
            this.lblV0mag.Size = new System.Drawing.Size(33, 12);
            this.lblV0mag.TabIndex = 3;
            this.lblV0mag.Text = "|V0|: --";
            // 
            // lblV0ang
            // 
            this.lblV0ang.AutoSize = true;
            this.lblV0ang.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblV0ang.ForeColor = System.Drawing.Color.White;
            this.lblV0ang.Location = new System.Drawing.Point(5, 67);
            this.lblV0ang.Name = "lblV0ang";
            this.lblV0ang.Size = new System.Drawing.Size(29, 12);
            this.lblV0ang.TabIndex = 4;
            this.lblV0ang.Text = "θ0: --";
            // 
            // lblTituloVuelo
            // 
            this.lblTituloVuelo.AutoSize = true;
            this.lblTituloVuelo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloVuelo.ForeColor = System.Drawing.Color.Gold;
            this.lblTituloVuelo.Location = new System.Drawing.Point(5, 88);
            this.lblTituloVuelo.Name = "lblTituloVuelo";
            this.lblTituloVuelo.Size = new System.Drawing.Size(97, 12);
            this.lblTituloVuelo.TabIndex = 5;
            this.lblTituloVuelo.Text = "-- Datos de Vuelo --";
            // 
            // lblTiempoVuelo
            // 
            this.lblTiempoVuelo.AutoSize = true;
            this.lblTiempoVuelo.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblTiempoVuelo.ForeColor = System.Drawing.Color.White;
            this.lblTiempoVuelo.Location = new System.Drawing.Point(5, 105);
            this.lblTiempoVuelo.Name = "lblTiempoVuelo";
            this.lblTiempoVuelo.Size = new System.Drawing.Size(51, 12);
            this.lblTiempoVuelo.TabIndex = 6;
            this.lblTiempoVuelo.Text = "Tiempo: --";
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblAlcance.ForeColor = System.Drawing.Color.White;
            this.lblAlcance.Location = new System.Drawing.Point(5, 120);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(52, 12);
            this.lblAlcance.TabIndex = 7;
            this.lblAlcance.Text = "Alcance: --";
            // 
            // lblAlturaMax
            // 
            this.lblAlturaMax.AutoSize = true;
            this.lblAlturaMax.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblAlturaMax.ForeColor = System.Drawing.Color.White;
            this.lblAlturaMax.Location = new System.Drawing.Point(5, 135);
            this.lblAlturaMax.Name = "lblAlturaMax";
            this.lblAlturaMax.Size = new System.Drawing.Size(53, 12);
            this.lblAlturaMax.TabIndex = 8;
            this.lblAlturaMax.Text = "Alt. max: --";
            // 
            // lblTituloVMax
            // 
            this.lblTituloVMax.AutoSize = true;
            this.lblTituloVMax.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloVMax.ForeColor = System.Drawing.Color.Gold;
            this.lblTituloVMax.Location = new System.Drawing.Point(5, 156);
            this.lblTituloVMax.Name = "lblTituloVMax";
            this.lblTituloVMax.Size = new System.Drawing.Size(105, 12);
            this.lblTituloVMax.TabIndex = 9;
            this.lblTituloVMax.Text = "-- Vel. Alt. Maxima --";
            // 
            // lblVelMaxVx
            // 
            this.lblVelMaxVx.AutoSize = true;
            this.lblVelMaxVx.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVelMaxVx.ForeColor = System.Drawing.Color.White;
            this.lblVelMaxVx.Location = new System.Drawing.Point(5, 173);
            this.lblVelMaxVx.Name = "lblVelMaxVx";
            this.lblVelMaxVx.Size = new System.Drawing.Size(29, 12);
            this.lblVelMaxVx.TabIndex = 10;
            this.lblVelMaxVx.Text = "Vx: --";
            // 
            // lblVelMaxVy
            // 
            this.lblVelMaxVy.AutoSize = true;
            this.lblVelMaxVy.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVelMaxVy.ForeColor = System.Drawing.Color.White;
            this.lblVelMaxVy.Location = new System.Drawing.Point(5, 188);
            this.lblVelMaxVy.Name = "lblVelMaxVy";
            this.lblVelMaxVy.Size = new System.Drawing.Size(29, 12);
            this.lblVelMaxVy.TabIndex = 11;
            this.lblVelMaxVy.Text = "Vy: --";
            // 
            // lblVelMaxMag
            // 
            this.lblVelMaxMag.AutoSize = true;
            this.lblVelMaxMag.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVelMaxMag.ForeColor = System.Drawing.Color.White;
            this.lblVelMaxMag.Location = new System.Drawing.Point(5, 203);
            this.lblVelMaxMag.Name = "lblVelMaxMag";
            this.lblVelMaxMag.Size = new System.Drawing.Size(28, 12);
            this.lblVelMaxMag.TabIndex = 12;
            this.lblVelMaxMag.Text = "|V|: --";
            // 
            // lblVelMaxAng
            // 
            this.lblVelMaxAng.AutoSize = true;
            this.lblVelMaxAng.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVelMaxAng.ForeColor = System.Drawing.Color.White;
            this.lblVelMaxAng.Location = new System.Drawing.Point(5, 218);
            this.lblVelMaxAng.Name = "lblVelMaxAng";
            this.lblVelMaxAng.Size = new System.Drawing.Size(24, 12);
            this.lblVelMaxAng.TabIndex = 13;
            this.lblVelMaxAng.Text = "θ: --";
            // 
            // lblTituloVf
            // 
            this.lblTituloVf.AutoSize = true;
            this.lblTituloVf.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloVf.ForeColor = System.Drawing.Color.Gold;
            this.lblTituloVf.Location = new System.Drawing.Point(5, 239);
            this.lblTituloVf.Name = "lblTituloVf";
            this.lblTituloVf.Size = new System.Drawing.Size(97, 12);
            this.lblTituloVf.TabIndex = 14;
            this.lblTituloVf.Text = "-- Velocidad Final --";
            // 
            // lblVfx
            // 
            this.lblVfx.AutoSize = true;
            this.lblVfx.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVfx.ForeColor = System.Drawing.Color.White;
            this.lblVfx.Location = new System.Drawing.Point(5, 256);
            this.lblVfx.Name = "lblVfx";
            this.lblVfx.Size = new System.Drawing.Size(32, 12);
            this.lblVfx.TabIndex = 15;
            this.lblVfx.Text = "Vfx: --";
            // 
            // lblVfy
            // 
            this.lblVfy.AutoSize = true;
            this.lblVfy.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVfy.ForeColor = System.Drawing.Color.White;
            this.lblVfy.Location = new System.Drawing.Point(5, 271);
            this.lblVfy.Name = "lblVfy";
            this.lblVfy.Size = new System.Drawing.Size(32, 12);
            this.lblVfy.TabIndex = 16;
            this.lblVfy.Text = "Vfy: --";
            // 
            // lblVfmag
            // 
            this.lblVfmag.AutoSize = true;
            this.lblVfmag.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVfmag.ForeColor = System.Drawing.Color.White;
            this.lblVfmag.Location = new System.Drawing.Point(5, 286);
            this.lblVfmag.Name = "lblVfmag";
            this.lblVfmag.Size = new System.Drawing.Size(31, 12);
            this.lblVfmag.TabIndex = 17;
            this.lblVfmag.Text = "|Vf|: --";
            // 
            // lblVfang
            // 
            this.lblVfang.AutoSize = true;
            this.lblVfang.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVfang.ForeColor = System.Drawing.Color.White;
            this.lblVfang.Location = new System.Drawing.Point(5, 301);
            this.lblVfang.Name = "lblVfang";
            this.lblVfang.Size = new System.Drawing.Size(27, 12);
            this.lblVfang.TabIndex = 18;
            this.lblVfang.Text = "θf: --";
            // 
            // lblTituloRebotes
            // 
            this.lblTituloRebotes.AutoSize = true;
            this.lblTituloRebotes.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloRebotes.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTituloRebotes.Location = new System.Drawing.Point(5, 322);
            this.lblTituloRebotes.Name = "lblTituloRebotes";
            this.lblTituloRebotes.Size = new System.Drawing.Size(64, 12);
            this.lblTituloRebotes.TabIndex = 19;
            this.lblTituloRebotes.Text = "-- Rebotes --";
            // 
            // lblRebote1
            // 
            this.lblRebote1.AutoSize = true;
            this.lblRebote1.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblRebote1.ForeColor = System.Drawing.Color.Orange;
            this.lblRebote1.Location = new System.Drawing.Point(5, 337);
            this.lblRebote1.Name = "lblRebote1";
            this.lblRebote1.Size = new System.Drawing.Size(57, 12);
            this.lblRebote1.TabIndex = 20;
            this.lblRebote1.Text = "Rebote 1: --";
            // 
            // lblRebote2
            // 
            this.lblRebote2.AutoSize = true;
            this.lblRebote2.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblRebote2.ForeColor = System.Drawing.Color.Orange;
            this.lblRebote2.Location = new System.Drawing.Point(5, 352);
            this.lblRebote2.Name = "lblRebote2";
            this.lblRebote2.Size = new System.Drawing.Size(57, 12);
            this.lblRebote2.TabIndex = 21;
            this.lblRebote2.Text = "Rebote 2: --";
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.LightCyan;
            this.lblEstado.Location = new System.Drawing.Point(5, 425);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(600, 20);
            this.lblEstado.TabIndex = 21;
            this.lblEstado.Text = "Arrastra el tejo y suéltalo para lanzar";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGraficas
            // 
            this.btnGraficas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnGraficas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGraficas.ForeColor = System.Drawing.Color.White;
            this.btnGraficas.Location = new System.Drawing.Point(610, 45);
            this.btnGraficas.Name = "btnGraficas";
            this.btnGraficas.Size = new System.Drawing.Size(180, 22);
            this.btnGraficas.TabIndex = 9;
            this.btnGraficas.Text = "📈 Ver Gráficas";
            this.btnGraficas.UseVisualStyleBackColor = false;
            this.btnGraficas.Click += new System.EventHandler(this.btnGraficas_Click);
            // 
            // btnMostrarStats
            // 
            this.btnMostrarStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.btnMostrarStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarStats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMostrarStats.ForeColor = System.Drawing.Color.White;
            this.btnMostrarStats.Location = new System.Drawing.Point(424, 13);
            this.btnMostrarStats.Name = "btnMostrarStats";
            this.btnMostrarStats.Size = new System.Drawing.Size(180, 22);
            this.btnMostrarStats.TabIndex = 10;
            this.btnMostrarStats.Text = "📊 Mostrar Estadísticas";
            this.btnMostrarStats.UseVisualStyleBackColor = false;
            this.btnMostrarStats.Click += new System.EventHandler(this.btnMostrarStats_Click);
            // 
            // btnOcultarStats
            // 
            this.btnOcultarStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnOcultarStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarStats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOcultarStats.ForeColor = System.Drawing.Color.White;
            this.btnOcultarStats.Location = new System.Drawing.Point(425, 41);
            this.btnOcultarStats.Name = "btnOcultarStats";
            this.btnOcultarStats.Size = new System.Drawing.Size(180, 22);
            this.btnOcultarStats.TabIndex = 11;
            this.btnOcultarStats.Text = "🙈 Ocultar Estadísticas";
            this.btnOcultarStats.UseVisualStyleBackColor = false;
            this.btnOcultarStats.Click += new System.EventHandler(this.btnOcultarStats_Click);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOcultarStats);
            this.Controls.Add(this.btnMostrarStats);
            this.Controls.Add(this.btnGraficas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelCalculos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.picSueloF);
            this.Controls.Add(this.picObstaculoF);
            this.Controls.Add(this.picObjetivoF);
            this.Controls.Add(this.picTejoF);
            this.DoubleBuffered = true;
            this.Name = "ProcessForm";
            this.Text = "Tiro Parabólico — UPTC Sogamoso";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.ProcessForm_Load);
            this.Move += new System.EventHandler(this.ProcessForm_Move);
            ((System.ComponentModel.ISupportInitialize)(this.picSueloF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculoF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjetivoF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTejoF)).EndInit();
            this.panelCalculos.ResumeLayout(false);
            this.panelCalculos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ══════════════════════════════════════════════════════════════
        //  Declaración de todos los controles
        // ══════════════════════════════════════════════════════════════

        // — Sprites del juego —
        private System.Windows.Forms.PictureBox picSueloF;
        private System.Windows.Forms.PictureBox picObstaculoF;
        private System.Windows.Forms.PictureBox picObjetivoF;
        private System.Windows.Forms.PictureBox picTejoF;

        // — Timer de animación —
        private System.Windows.Forms.Timer timer1;

        // — Botones —
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGraficas;
        private System.Windows.Forms.Button btnMostrarStats;  // NUEVO
        private System.Windows.Forms.Button btnOcultarStats;  // NUEVO

        // — Panel contenedor de cálculos —
        private System.Windows.Forms.Panel panelCalculos;

        // — Labels: Velocidad inicial —
        private System.Windows.Forms.Label lblTituloV0;
        private System.Windows.Forms.Label lblV0x;
        private System.Windows.Forms.Label lblV0y;
        private System.Windows.Forms.Label lblV0mag;
        private System.Windows.Forms.Label lblV0ang;

        // — Labels: Datos de vuelo —
        private System.Windows.Forms.Label lblTituloVuelo;
        private System.Windows.Forms.Label lblTiempoVuelo;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.Label lblAlturaMax;

        // — Labels: Velocidad en altura máxima —
        private System.Windows.Forms.Label lblTituloVMax;
        private System.Windows.Forms.Label lblVelMaxVx;
        private System.Windows.Forms.Label lblVelMaxVy;
        private System.Windows.Forms.Label lblVelMaxMag;
        private System.Windows.Forms.Label lblVelMaxAng;

        // — Labels: Velocidad final —
        private System.Windows.Forms.Label lblTituloVf;
        private System.Windows.Forms.Label lblVfx;
        private System.Windows.Forms.Label lblVfy;
        private System.Windows.Forms.Label lblVfmag;
        private System.Windows.Forms.Label lblVfang;

        // — Labels: Rebotes —
        private System.Windows.Forms.Label lblTituloRebotes;
        private System.Windows.Forms.Label lblRebote1;
        private System.Windows.Forms.Label lblRebote2;

        // — Label de estado —
        private System.Windows.Forms.Label lblEstado;
    }
}