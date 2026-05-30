namespace prueba
{
    partial class frmPresupuestoMensual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresupuestoMensual));
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.txtNombreTransaccion = new System.Windows.Forms.TextBox();
            this.cbTipoGasto = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblTotalEspeculado = new System.Windows.Forms.Label();
            this.lblTotalReal = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlMenúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.lblmespresu = new System.Windows.Forms.Label();
            this.lblpresemensual = new System.Windows.Forms.Label();
            this.lblgasto = new System.Windows.Forms.Label();
            this.lblmonto = new System.Windows.Forms.Label();
            this.lblnombretransaccion = new System.Windows.Forms.Label();
            this.lblingreso = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblreal = new System.Windows.Forms.Label();
            this.lblporcen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(118, 165);
            this.txtIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(122, 20);
            this.txtIngreso.TabIndex = 2;
            this.txtIngreso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombreTransaccion
            // 
            this.txtNombreTransaccion.Location = new System.Drawing.Point(118, 188);
            this.txtNombreTransaccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreTransaccion.Name = "txtNombreTransaccion";
            this.txtNombreTransaccion.Size = new System.Drawing.Size(122, 20);
            this.txtNombreTransaccion.TabIndex = 3;
            // 
            // cbTipoGasto
            // 
            this.cbTipoGasto.FormattingEnabled = true;
            this.cbTipoGasto.Location = new System.Drawing.Point(118, 210);
            this.cbTipoGasto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipoGasto.Name = "cbTipoGasto";
            this.cbTipoGasto.Size = new System.Drawing.Size(122, 21);
            this.cbTipoGasto.TabIndex = 4;
            this.cbTipoGasto.SelectedIndexChanged += new System.EventHandler(this.cbTipoGasto_SelectedIndexChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(118, 235);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(122, 20);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(244, 75);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(468, 268);
            this.dgvDetalle.TabIndex = 7;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // lblTotalEspeculado
            // 
            this.lblTotalEspeculado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEspeculado.AutoSize = true;
            this.lblTotalEspeculado.Location = new System.Drawing.Point(160, 378);
            this.lblTotalEspeculado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalEspeculado.Name = "lblTotalEspeculado";
            this.lblTotalEspeculado.Size = new System.Drawing.Size(37, 13);
            this.lblTotalEspeculado.TabIndex = 8;
            this.lblTotalEspeculado.Text = " $0.00";
            this.lblTotalEspeculado.Click += new System.EventHandler(this.lblTotalEspeculado_Click);
            // 
            // lblTotalReal
            // 
            this.lblTotalReal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalReal.AutoSize = true;
            this.lblTotalReal.Location = new System.Drawing.Point(311, 378);
            this.lblTotalReal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalReal.Name = "lblTotalReal";
            this.lblTotalReal.Size = new System.Drawing.Size(37, 13);
            this.lblTotalReal.TabIndex = 9;
            this.lblTotalReal.Text = " $0.00";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(542, 378);
            this.lblPorcentaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(21, 13);
            this.lblPorcentaje.TabIndex = 10;
            this.lblPorcentaje.Text = "0%";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.calcularToolStripMenuItem1,
            this.guardarToolStripMenuItem,
            this.volverAlMenúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click_2);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // calcularToolStripMenuItem1
            // 
            this.calcularToolStripMenuItem1.Name = "calcularToolStripMenuItem1";
            this.calcularToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.calcularToolStripMenuItem1.Text = "Calcular";
            this.calcularToolStripMenuItem1.Click += new System.EventHandler(this.calcularToolStripMenuItem1_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // volverAlMenúToolStripMenuItem
            // 
            this.volverAlMenúToolStripMenuItem.Name = "volverAlMenúToolStripMenuItem";
            this.volverAlMenúToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.volverAlMenúToolStripMenuItem.Text = "Volver al menú";
            this.volverAlMenúToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenúToolStripMenuItem_Click_1);
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Location = new System.Drawing.Point(118, 141);
            this.cbPeriodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(122, 21);
            this.cbPeriodo.TabIndex = 14;
            this.cbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbPeriodo_SelectedIndexChanged);
            // 
            // lblmespresu
            // 
            this.lblmespresu.AutoSize = true;
            this.lblmespresu.Location = new System.Drawing.Point(9, 141);
            this.lblmespresu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmespresu.Name = "lblmespresu";
            this.lblmespresu.Size = new System.Drawing.Size(108, 13);
            this.lblmespresu.TabIndex = 15;
            this.lblmespresu.Text = "Presupuesto del mes:";
            // 
            // lblpresemensual
            // 
            this.lblpresemensual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpresemensual.AutoSize = true;
            this.lblpresemensual.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpresemensual.Location = new System.Drawing.Point(408, 36);
            this.lblpresemensual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpresemensual.Name = "lblpresemensual";
            this.lblpresemensual.Size = new System.Drawing.Size(196, 19);
            this.lblpresemensual.TabIndex = 16;
            this.lblpresemensual.Text = "Detalle del presupuesto";
            // 
            // lblgasto
            // 
            this.lblgasto.AutoSize = true;
            this.lblgasto.Location = new System.Drawing.Point(9, 217);
            this.lblgasto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgasto.Name = "lblgasto";
            this.lblgasto.Size = new System.Drawing.Size(60, 13);
            this.lblgasto.TabIndex = 17;
            this.lblgasto.Text = "Tipo gasto:\n";
            // 
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.Location = new System.Drawing.Point(9, 240);
            this.lblmonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(40, 13);
            this.lblmonto.TabIndex = 18;
            this.lblmonto.Text = "Monto:\n";
            // 
            // lblnombretransaccion
            // 
            this.lblnombretransaccion.AutoSize = true;
            this.lblnombretransaccion.Location = new System.Drawing.Point(9, 193);
            this.lblnombretransaccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombretransaccion.Name = "lblnombretransaccion";
            this.lblnombretransaccion.Size = new System.Drawing.Size(112, 13);
            this.lblnombretransaccion.TabIndex = 19;
            this.lblnombretransaccion.Text = "Descripción del gasto:";
            // 
            // lblingreso
            // 
            this.lblingreso.AutoSize = true;
            this.lblingreso.Location = new System.Drawing.Point(9, 165);
            this.lblingreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(88, 13);
            this.lblingreso.TabIndex = 20;
            this.lblingreso.Text = "Ingreso Mensual:";
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(68, 378);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(92, 13);
            this.lbltotal.TabIndex = 21;
            this.lbltotal.Text = "Total especulado:";
            // 
            // lblreal
            // 
            this.lblreal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblreal.AutoSize = true;
            this.lblreal.Location = new System.Drawing.Point(256, 378);
            this.lblreal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblreal.Name = "lblreal";
            this.lblreal.Size = new System.Drawing.Size(57, 13);
            this.lblreal.TabIndex = 22;
            this.lblreal.Text = "Total real: ";
            // 
            // lblporcen
            // 
            this.lblporcen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblporcen.AutoSize = true;
            this.lblporcen.Location = new System.Drawing.Point(464, 378);
            this.lblporcen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblporcen.Name = "lblporcen";
            this.lblporcen.Size = new System.Drawing.Size(83, 13);
            this.lblporcen.TabIndex = 23;
            this.lblporcen.Text = "Porcentaje final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "INFORMACIÓN DEL PRESUPUESTO";
            // 
            // frmPresupuestoMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(721, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblTotalReal);
            this.Controls.Add(this.lblreal);
            this.Controls.Add(this.lblTotalEspeculado);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblingreso);
            this.Controls.Add(this.lblnombretransaccion);
            this.Controls.Add(this.lblmonto);
            this.Controls.Add(this.lblgasto);
            this.Controls.Add(this.lblpresemensual);
            this.Controls.Add(this.lblmespresu);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cbTipoGasto);
            this.Controls.Add(this.txtNombreTransaccion);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblporcen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPresupuestoMensual";
            this.Text = "Presupuesto Mensual";
            this.Load += new System.EventHandler(this.frmPresupuestoMensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox txtNombreTransaccion;
        private System.Windows.Forms.ComboBox cbTipoGasto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblTotalEspeculado;
        private System.Windows.Forms.Label lblTotalReal;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.Label lblmespresu;
        private System.Windows.Forms.Label lblpresemensual;
        private System.Windows.Forms.Label lblgasto;
        private System.Windows.Forms.Label lblmonto;
        private System.Windows.Forms.Label lblnombretransaccion;
        private System.Windows.Forms.Label lblingreso;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblreal;
        private System.Windows.Forms.Label lblporcen;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}