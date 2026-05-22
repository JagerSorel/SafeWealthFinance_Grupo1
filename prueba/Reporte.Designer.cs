namespace prueba
{
    partial class Reporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlDeGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblReporte = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbReporte = new System.Windows.Forms.GroupBox();
            this.gbGraficos = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbReporte.SuspendLayout();
            this.gbGraficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeGastosToolStripMenuItem,
            this.diagramasToolStripMenuItem,
            this.volverAlMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlDeGastosToolStripMenuItem
            // 
            this.controlDeGastosToolStripMenuItem.Name = "controlDeGastosToolStripMenuItem";
            this.controlDeGastosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.controlDeGastosToolStripMenuItem.Text = "Reporte";
            // 
            // diagramasToolStripMenuItem
            // 
            this.diagramasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gastosToolStripMenuItem,
            this.ingresosToolStripMenuItem,
            this.gananciasToolStripMenuItem});
            this.diagramasToolStripMenuItem.Name = "diagramasToolStripMenuItem";
            this.diagramasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.diagramasToolStripMenuItem.Text = "Diagramas";
            // 
            // gastosToolStripMenuItem
            // 
            this.gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            this.gastosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.gastosToolStripMenuItem.Text = "Gastos";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // gananciasToolStripMenuItem
            // 
            this.gananciasToolStripMenuItem.Name = "gananciasToolStripMenuItem";
            this.gananciasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.gananciasToolStripMenuItem.Text = "Ganancias/Perdidas";
            // 
            // volverAlMeToolStripMenuItem
            // 
            this.volverAlMeToolStripMenuItem.Name = "volverAlMeToolStripMenuItem";
            this.volverAlMeToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.volverAlMeToolStripMenuItem.Text = "Volver al menú";
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.Location = new System.Drawing.Point(223, 39);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(180, 24);
            this.lblReporte.TabIndex = 4;
            this.lblReporte.Text = "Reporte de gastos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 312);
            this.dataGridView1.TabIndex = 1;
            // 
            // gbReporte
            // 
            this.gbReporte.Controls.Add(this.gbGraficos);
            this.gbReporte.Controls.Add(this.dataGridView1);
            this.gbReporte.Location = new System.Drawing.Point(12, 66);
            this.gbReporte.Name = "gbReporte";
            this.gbReporte.Size = new System.Drawing.Size(604, 348);
            this.gbReporte.TabIndex = 2;
            this.gbReporte.TabStop = false;
            this.gbReporte.Text = "Reporte";
            // 
            // gbGraficos
            // 
            this.gbGraficos.Controls.Add(this.chart1);
            this.gbGraficos.Location = new System.Drawing.Point(0, 0);
            this.gbGraficos.Name = "gbGraficos";
            this.gbGraficos.Size = new System.Drawing.Size(604, 348);
            this.gbGraficos.TabIndex = 2;
            this.gbGraficos.TabStop = false;
            this.gbGraficos.Text = "Graficos";
            this.gbGraficos.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 30);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(592, 312);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 426);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.gbReporte);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbReporte.ResumeLayout(false);
            this.gbGraficos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlDeGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagramasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasToolStripMenuItem;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbReporte;
        private System.Windows.Forms.GroupBox gbGraficos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}