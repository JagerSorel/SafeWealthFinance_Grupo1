namespace prueba
{
    partial class frmExpediente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpediente));
            this.expedienteSemestralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.safeWealthFinanceDBDataSet = new prueba.SafeWealthFinanceDBDataSet();
            this.chaIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chaGastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chaGanancias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.safeWealthFinanceDBDataSet1 = new prueba.SafeWealthFinanceDBDataSet1();
            this.expedienteSemestralTableAdapter = new prueba.SafeWealthFinanceDBDataSetTableAdapters.ExpedienteSemestralTableAdapter();
            this.dgvSemestre = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlMenúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.expedienteSemestralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeWealthFinanceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaGanancias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeWealthFinanceDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemestre)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // expedienteSemestralBindingSource
            // 
            this.expedienteSemestralBindingSource.DataMember = "ExpedienteSemestral";
            this.expedienteSemestralBindingSource.DataSource = this.safeWealthFinanceDBDataSet;
            // 
            // safeWealthFinanceDBDataSet
            // 
            this.safeWealthFinanceDBDataSet.DataSetName = "SafeWealthFinanceDBDataSet";
            this.safeWealthFinanceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chaIngresos
            // 
            chartArea1.Name = "ChartArea1";
            this.chaIngresos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chaIngresos.Legends.Add(legend1);
            this.chaIngresos.Location = new System.Drawing.Point(47, 392);
            this.chaIngresos.Name = "chaIngresos";
            this.chaIngresos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chaIngresos.Series.Add(series1);
            this.chaIngresos.Size = new System.Drawing.Size(300, 300);
            this.chaIngresos.TabIndex = 1;
            this.chaIngresos.Text = "chart1";
            // 
            // chaGastos
            // 
            chartArea2.Name = "ChartArea1";
            this.chaGastos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chaGastos.Legends.Add(legend2);
            this.chaGastos.Location = new System.Drawing.Point(353, 392);
            this.chaGastos.Name = "chaGastos";
            this.chaGastos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chaGastos.Series.Add(series2);
            this.chaGastos.Size = new System.Drawing.Size(300, 300);
            this.chaGastos.TabIndex = 2;
            this.chaGastos.Text = "chart2";
            // 
            // chaGanancias
            // 
            chartArea3.Name = "ChartArea1";
            this.chaGanancias.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chaGanancias.Legends.Add(legend3);
            this.chaGanancias.Location = new System.Drawing.Point(659, 392);
            this.chaGanancias.Name = "chaGanancias";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chaGanancias.Series.Add(series3);
            this.chaGanancias.Size = new System.Drawing.Size(300, 300);
            this.chaGanancias.TabIndex = 3;
            this.chaGanancias.Text = "chart3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gráfico de Gastos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gráfico de Ingresos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(716, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gráfico de Ganancias/Pérdidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Control de Gastos";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(286, 80);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(287, 21);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Semestre correspondiente a la fecha: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Expresado en dólares estadounidenses ($USD)";
            // 
            // safeWealthFinanceDBDataSet1
            // 
            this.safeWealthFinanceDBDataSet1.DataSetName = "SafeWealthFinanceDBDataSet1";
            this.safeWealthFinanceDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expedienteSemestralTableAdapter
            // 
            this.expedienteSemestralTableAdapter.ClearBeforeFill = true;
            // 
            // dgvSemestre
            // 
            this.dgvSemestre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSemestre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSemestre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemestre.Location = new System.Drawing.Point(47, 157);
            this.dgvSemestre.Name = "dgvSemestre";
            this.dgvSemestre.Size = new System.Drawing.Size(912, 192);
            this.dgvSemestre.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem,
            this.volverAlMenúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // volverAlMenúToolStripMenuItem
            // 
            this.volverAlMenúToolStripMenuItem.Name = "volverAlMenúToolStripMenuItem";
            this.volverAlMenúToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.volverAlMenúToolStripMenuItem.Text = "Volver al menú";
            this.volverAlMenúToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenúToolStripMenuItem_Click);
            // 
            // frmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dgvSemestre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chaGanancias);
            this.Controls.Add(this.chaGastos);
            this.Controls.Add(this.chaIngresos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmExpediente";
            this.Text = "Expediente";
            this.Load += new System.EventHandler(this.Expediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expedienteSemestralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeWealthFinanceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaGanancias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeWealthFinanceDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemestre)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chaIngresos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chaGastos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chaGanancias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label6;
        private SafeWealthFinanceDBDataSet safeWealthFinanceDBDataSet;
        private SafeWealthFinanceDBDataSet1 safeWealthFinanceDBDataSet1;
        private System.Windows.Forms.BindingSource expedienteSemestralBindingSource;
        private SafeWealthFinanceDBDataSetTableAdapters.ExpedienteSemestralTableAdapter expedienteSemestralTableAdapter;
        private System.Windows.Forms.DataGridView dgvSemestre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenúToolStripMenuItem;
    }
}