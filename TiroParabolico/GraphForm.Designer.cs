namespace TiroParabolico
{
    partial class GraphForm
    {
        /// <summary>Variable del diseñador necesaria.</summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();

            // ── Instanciar controles ──────────────────────────────────────
            this.panelGraficas = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.lblTituloGraph = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.chartYT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartXT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartYX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVxT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVyT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVmagT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAngT = new System.Windows.Forms.DataVisualization.Charting.Chart();

            ((System.ComponentModel.ISupportInitialize)(this.chartYT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartXT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVxT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVyT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVmagT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAngT)).BeginInit();
            this.panelGraficas.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();

            // ══════════════════════════════════════════════════════════════
            //  chartYT — Posición Y en el tiempo
            // ══════════════════════════════════════════════════════════════
            chartArea1.BackColor = System.Drawing.Color.FromArgb(15, 15, 30);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea1.Name = "Default";
            legend1.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Default";
            this.chartYT.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.chartYT.BorderlineColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.chartYT.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartYT.BorderlineWidth = 1;
            this.chartYT.ChartAreas.Add(chartArea1);
            this.chartYT.Legends.Add(legend1);
            this.chartYT.Location = new System.Drawing.Point(5, 5);
            this.chartYT.Name = "chartYT";
            this.chartYT.Size = new System.Drawing.Size(310, 195);
            this.chartYT.TabIndex = 0;
            this.chartYT.TabStop = false;

            // ══════════════════════════════════════════════════════════════
            //  chartXT — Posición X en el tiempo
            // ══════════════════════════════════════════════════════════════
            chartArea2.BackColor = System.Drawing.Color.FromArgb(15, 15, 30);
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea2.Name = "Default";
            legend2.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Default";
            this.chartXT.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.chartXT.BorderlineColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.chartXT.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartXT.BorderlineWidth = 1;
            this.chartXT.ChartAreas.Add(chartArea2);
            this.chartXT.Legends.Add(legend2);
            this.chartXT.Location = new System.Drawing.Point(320, 5);
            this.chartXT.Name = "chartXT";
            this.chartXT.Size = new System.Drawing.Size(310, 195);
            this.chartXT.TabIndex = 1;
            this.chartXT.TabStop = false;

            // ══════════════════════════════════════════════════════════════
            //  chartYX — Trayectoria (y vs x)
            // ══════════════════════════════════════════════════════════════
            chartArea3.BackColor = System.Drawing.Color.FromArgb(15, 15, 30);
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea3.Name = "Default";
            legend3.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "Default";
            this.chartYX.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.chartYX.BorderlineColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.chartYX.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartYX.BorderlineWidth = 1;
            this.chartYX.ChartAreas.Add(chartArea3);
            this.chartYX.Legends.Add(legend3);
            this.chartYX.Location = new System.Drawing.Point(635, 5);
            this.chartYX.Name = "chartYX";
            this.chartYX.Size = new System.Drawing.Size(310, 195);
            this.chartYX.TabIndex = 2;
            this.chartYX.TabStop = false;

            // ══════════════════════════════════════════════════════════════
            //  chartVxT — Velocidad horizontal en el tiempo
            // ══════════════════════════════════════════════════════════════
            chartArea4.BackColor = System.Drawing.Color.FromArgb(15, 15, 30);
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea4.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea4.Name = "Default";
            legend4.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            legend4.ForeColor = System.Drawing.Color.White;
            legend4.Name = "Default";
            this.chartVxT.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.chartVxT.BorderlineColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.chartVxT.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartVxT.BorderlineWidth = 1;
            this.chartVxT.ChartAreas.Add(chartArea4);
            this.chartVxT.Legends.Add(legend4);
            this.chartVxT.Location = new System.Drawing.Point(5, 210);
            this.chartVxT.Name = "chartVxT";
            this.chartVxT.Size = new System.Drawing.Size(310, 195);
            this.chartVxT.TabIndex = 3;
            this.chartVxT.TabStop = false;

            // ══════════════════════════════════════════════════════════════
            //  chartVyT — Velocidad vertical en el tiempo
            // ══════════════════════════════════════════════════════════════
            chartArea5.BackColor = System.Drawing.Color.FromArgb(15, 15, 30);
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea5.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea5.Name = "Default";
            legend5.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            legend5.ForeColor = System.Drawing.Color.White;
            legend5.Name = "Default";
            this.chartVyT.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.chartVyT.BorderlineColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.chartVyT.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartVyT.BorderlineWidth = 1;
            this.chartVyT.ChartAreas.Add(chartArea5);
            this.chartVyT.Legends.Add(legend5);
            this.chartVyT.Location = new System.Drawing.Point(320, 210);
            this.chartVyT.Name = "chartVyT";
            this.chartVyT.Size = new System.Drawing.Size(310, 195);
            this.chartVyT.TabIndex = 4;
            this.chartVyT.TabStop = false;

            // ══════════════════════════════════════════════════════════════
            //  chartVmagT — Magnitud de la velocidad en el tiempo
            // ══════════════════════════════════════════════════════════════
            chartArea6.BackColor = System.Drawing.Color.FromArgb(15, 15, 30);
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea6.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea6.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea6.Name = "Default";
            legend6.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            legend6.ForeColor = System.Drawing.Color.White;
            legend6.Name = "Default";
            this.chartVmagT.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.chartVmagT.BorderlineColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.chartVmagT.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartVmagT.BorderlineWidth = 1;
            this.chartVmagT.ChartAreas.Add(chartArea6);
            this.chartVmagT.Legends.Add(legend6);
            this.chartVmagT.Location = new System.Drawing.Point(635, 210);
            this.chartVmagT.Name = "chartVmagT";
            this.chartVmagT.Size = new System.Drawing.Size(310, 195);
            this.chartVmagT.TabIndex = 5;
            this.chartVmagT.TabStop = false;

            // ══════════════════════════════════════════════════════════════
            //  chartAngT — Ángulo de la velocidad en el tiempo
            // ══════════════════════════════════════════════════════════════
            chartArea7.BackColor = System.Drawing.Color.FromArgb(15, 15, 30);
            chartArea7.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea7.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightGray;
            chartArea7.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea7.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartArea7.Name = "Default";
            legend7.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            legend7.ForeColor = System.Drawing.Color.White;
            legend7.Name = "Default";
            this.chartAngT.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.chartAngT.BorderlineColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.chartAngT.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartAngT.BorderlineWidth = 1;
            this.chartAngT.ChartAreas.Add(chartArea7);
            this.chartAngT.Legends.Add(legend7);
            this.chartAngT.Location = new System.Drawing.Point(320, 415);
            this.chartAngT.Name = "chartAngT";
            this.chartAngT.Size = new System.Drawing.Size(310, 195);
            this.chartAngT.TabIndex = 6;
            this.chartAngT.TabStop = false;

            // ══════════════════════════════════════════════════════════════
            //  panelGraficas — contenedor scrollable de los charts
            // ══════════════════════════════════════════════════════════════
            this.panelGraficas.AutoScroll = true;
            this.panelGraficas.BackColor = System.Drawing.Color.FromArgb(12, 12, 25);
            this.panelGraficas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraficas.Location = new System.Drawing.Point(0, 45);
            this.panelGraficas.Name = "panelGraficas";
            this.panelGraficas.Size = new System.Drawing.Size(960, 615);
            this.panelGraficas.TabIndex = 0;
            this.panelGraficas.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.chartYT,
                this.chartXT,
                this.chartYX,
                this.chartVxT,
                this.chartVyT,
                this.chartVmagT,
                this.chartAngT
            });

            // ══════════════════════════════════════════════════════════════
            //  panelBotones — barra superior fija
            // ══════════════════════════════════════════════════════════════
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(18, 18, 35);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(960, 45);
            this.panelBotones.TabIndex = 1;
            this.panelBotones.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTituloGraph,
                this.btnCerrar
            });

            // ── lblTituloGraph ────────────────────────────────────────────
            this.lblTituloGraph.AutoSize = false;
            this.lblTituloGraph.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTituloGraph.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloGraph.ForeColor = System.Drawing.Color.Gold;
            this.lblTituloGraph.Location = new System.Drawing.Point(10, 0);
            this.lblTituloGraph.Name = "lblTituloGraph";
            this.lblTituloGraph.Size = new System.Drawing.Size(400, 45);
            this.lblTituloGraph.Text = "Graficas - Tiro Parabolico";
            this.lblTituloGraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── btnCerrar ─────────────────────────────────────────────────
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(120, 0, 0);
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(870, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 45);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Ocultar";
            this.btnCerrar.UseVisualStyleBackColor = false;

            // ══════════════════════════════════════════════════════════════
            //  GraphForm
            // ══════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(12, 12, 25);
            this.ClientSize = new System.Drawing.Size(960, 660);
            this.MinimumSize = new System.Drawing.Size(980, 700);
            this.Name = "GraphForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficas - Tiro Parabolico | UPTC Sogamoso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GraphForm_FormClosing);
            this.Controls.Add(this.panelGraficas);
            this.Controls.Add(this.panelBotones);

            ((System.ComponentModel.ISupportInitialize)(this.chartYT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartXT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVxT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVyT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVmagT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAngT)).EndInit();
            this.panelGraficas.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Declaración de controles ──────────────────────────────────────
        private System.Windows.Forms.Panel panelGraficas;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Label lblTituloGraph;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartXT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVxT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVyT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVmagT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAngT;
    }
}