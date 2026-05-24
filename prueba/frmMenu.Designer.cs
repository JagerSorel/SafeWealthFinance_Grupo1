namespace prueba
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ahorroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuicionDeIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestoMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteFinancieroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerClass = new System.Windows.Forms.Timer(this.components);
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblHoy = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ahorroToolStripMenuItem,
            this.ingresosToolStripMenuItem,
            this.distribuicionDeIngresosToolStripMenuItem,
            this.expedienteToolStripMenuItem,
            this.gastosToolStripMenuItem,
            this.presupuestoMensualToolStripMenuItem,
            this.reporteFinancieroToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ahorroToolStripMenuItem
            // 
            this.ahorroToolStripMenuItem.Name = "ahorroToolStripMenuItem";
            this.ahorroToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ahorroToolStripMenuItem.Text = "Ahorro";
            this.ahorroToolStripMenuItem.Click += new System.EventHandler(this.ahorroToolStripMenuItem_Click);
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // distribuicionDeIngresosToolStripMenuItem
            // 
            this.distribuicionDeIngresosToolStripMenuItem.Name = "distribuicionDeIngresosToolStripMenuItem";
            this.distribuicionDeIngresosToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.distribuicionDeIngresosToolStripMenuItem.Text = "Distribuicion de ingresos";
            this.distribuicionDeIngresosToolStripMenuItem.Click += new System.EventHandler(this.distribuicionDeIngresosToolStripMenuItem_Click);
            // 
            // expedienteToolStripMenuItem
            // 
            this.expedienteToolStripMenuItem.Name = "expedienteToolStripMenuItem";
            this.expedienteToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.expedienteToolStripMenuItem.Text = "Expediente";
            // 
            // gastosToolStripMenuItem
            // 
            this.gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            this.gastosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.gastosToolStripMenuItem.Text = "Gastos";
            this.gastosToolStripMenuItem.Click += new System.EventHandler(this.gastosToolStripMenuItem_Click);
            // 
            // presupuestoMensualToolStripMenuItem
            // 
            this.presupuestoMensualToolStripMenuItem.Name = "presupuestoMensualToolStripMenuItem";
            this.presupuestoMensualToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.presupuestoMensualToolStripMenuItem.Text = "Presupuesto mensual";
            this.presupuestoMensualToolStripMenuItem.Click += new System.EventHandler(this.presupuestoMensualToolStripMenuItem_Click);
            // 
            // reporteFinancieroToolStripMenuItem
            // 
            this.reporteFinancieroToolStripMenuItem.Name = "reporteFinancieroToolStripMenuItem";
            this.reporteFinancieroToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.reporteFinancieroToolStripMenuItem.Text = "Reporte financiero";
            this.reporteFinancieroToolStripMenuItem.Click += new System.EventHandler(this.reporteFinancieroToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // timerClass
            // 
            this.timerClass.Interval = 50;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(39, 58);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(117, 23);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido:";
            // 
            // lblHoy
            // 
            this.lblHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoy.AutoSize = true;
            this.lblHoy.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoy.Location = new System.Drawing.Point(463, 370);
            this.lblHoy.Name = "lblHoy";
            this.lblHoy.Size = new System.Drawing.Size(25, 42);
            this.lblHoy.TabIndex = 2;
            this.lblHoy.Text = " ";
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(43, 212);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 200);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblHoy);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafeWealth Finance";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestoMensualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ahorroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteFinancieroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuicionDeIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expedienteToolStripMenuItem;
        private System.Windows.Forms.Timer timerClass;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblHoy;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}