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
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.txtNombreTransaccion = new System.Windows.Forms.TextBox();
            this.cbTipoGasto = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblTotalEspeculado = new System.Windows.Forms.Label();
            this.lblTotalReal = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlMenúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(170, 203);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(121, 22);
            this.txtIngreso.TabIndex = 2;
            this.txtIngreso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombreTransaccion
            // 
            this.txtNombreTransaccion.Location = new System.Drawing.Point(170, 231);
            this.txtNombreTransaccion.Name = "txtNombreTransaccion";
            this.txtNombreTransaccion.Size = new System.Drawing.Size(121, 22);
            this.txtNombreTransaccion.TabIndex = 3;
            // 
            // cbTipoGasto
            // 
            this.cbTipoGasto.FormattingEnabled = true;
            this.cbTipoGasto.Location = new System.Drawing.Point(170, 259);
            this.cbTipoGasto.Name = "cbTipoGasto";
            this.cbTipoGasto.Size = new System.Drawing.Size(121, 24);
            this.cbTipoGasto.TabIndex = 4;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(170, 289);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(121, 22);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(325, 72);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(624, 383);
            this.dgvDetalle.TabIndex = 7;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // lblTotalEspeculado
            // 
            this.lblTotalEspeculado.AutoSize = true;
            this.lblTotalEspeculado.Location = new System.Drawing.Point(208, 480);
            this.lblTotalEspeculado.Name = "lblTotalEspeculado";
            this.lblTotalEspeculado.Size = new System.Drawing.Size(41, 16);
            this.lblTotalEspeculado.TabIndex = 8;
            this.lblTotalEspeculado.Text = " $0.00";
            this.lblTotalEspeculado.Click += new System.EventHandler(this.lblTotalEspeculado_Click);
            // 
            // lblTotalReal
            // 
            this.lblTotalReal.AutoSize = true;
            this.lblTotalReal.Location = new System.Drawing.Point(409, 480);
            this.lblTotalReal.Name = "lblTotalReal";
            this.lblTotalReal.Size = new System.Drawing.Size(41, 16);
            this.lblTotalReal.TabIndex = 9;
            this.lblTotalReal.Text = " $0.00";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(717, 480);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(26, 16);
            this.lblPorcentaje.TabIndex = 10;
            this.lblPorcentaje.Text = "0%";
            // 
            // menuStrip1
            // 
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
            this.menuStrip1.Size = new System.Drawing.Size(961, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Location = new System.Drawing.Point(170, 173);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(121, 24);
            this.cbPeriodo.TabIndex = 14;
            this.cbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbPeriodo_SelectedIndexChanged);
            // 
            // lblmespresu
            // 
            this.lblmespresu.AutoSize = true;
            this.lblmespresu.Location = new System.Drawing.Point(12, 173);
            this.lblmespresu.Name = "lblmespresu";
            this.lblmespresu.Size = new System.Drawing.Size(137, 16);
            this.lblmespresu.TabIndex = 15;
            this.lblmespresu.Text = "Presupuesto del mes:";
            // 
            // lblpresemensual
            // 
            this.lblpresemensual.AutoSize = true;
            this.lblpresemensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpresemensual.Location = new System.Drawing.Point(544, 44);
            this.lblpresemensual.Name = "lblpresemensual";
            this.lblpresemensual.Size = new System.Drawing.Size(239, 25);
            this.lblpresemensual.TabIndex = 16;
            this.lblpresemensual.Text = "Detalle del presupuesto";
            // 
            // lblgasto
            // 
            this.lblgasto.AutoSize = true;
            this.lblgasto.Location = new System.Drawing.Point(12, 267);
            this.lblgasto.Name = "lblgasto";
            this.lblgasto.Size = new System.Drawing.Size(75, 16);
            this.lblgasto.TabIndex = 17;
            this.lblgasto.Text = "Tipo gasto:\n";
            // 
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.Location = new System.Drawing.Point(12, 295);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(47, 16);
            this.lblmonto.TabIndex = 18;
            this.lblmonto.Text = "Monto:\n";
            // 
            // lblnombretransaccion
            // 
            this.lblnombretransaccion.AutoSize = true;
            this.lblnombretransaccion.Location = new System.Drawing.Point(12, 237);
            this.lblnombretransaccion.Name = "lblnombretransaccion";
            this.lblnombretransaccion.Size = new System.Drawing.Size(131, 16);
            this.lblnombretransaccion.TabIndex = 19;
            this.lblnombretransaccion.Text = "Nombre transacción:";
            // 
            // lblingreso
            // 
            this.lblingreso.AutoSize = true;
            this.lblingreso.Location = new System.Drawing.Point(12, 203);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(55, 16);
            this.lblingreso.TabIndex = 20;
            this.lblingreso.Text = "Ingreso:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(84, 480);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(116, 16);
            this.lbltotal.TabIndex = 21;
            this.lbltotal.Text = "Total especulado:";
            // 
            // lblreal
            // 
            this.lblreal.AutoSize = true;
            this.lblreal.Location = new System.Drawing.Point(335, 480);
            this.lblreal.Name = "lblreal";
            this.lblreal.Size = new System.Drawing.Size(70, 16);
            this.lblreal.TabIndex = 22;
            this.lblreal.Text = "Total real: ";
            // 
            // lblporcen
            // 
            this.lblporcen.AutoSize = true;
            this.lblporcen.Location = new System.Drawing.Point(613, 480);
            this.lblporcen.Name = "lblporcen";
            this.lblporcen.Size = new System.Drawing.Size(102, 16);
            this.lblporcen.TabIndex = 23;
            this.lblporcen.Text = "Porcentaje final:";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // calcularToolStripMenuItem1
            // 
            this.calcularToolStripMenuItem1.Name = "calcularToolStripMenuItem1";
            this.calcularToolStripMenuItem1.Size = new System.Drawing.Size(76, 24);
            this.calcularToolStripMenuItem1.Text = "Calcular";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // volverAlMenúToolStripMenuItem
            // 
            this.volverAlMenúToolStripMenuItem.Name = "volverAlMenúToolStripMenuItem";
            this.volverAlMenúToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.volverAlMenúToolStripMenuItem.Text = "Volver al menú";
            this.volverAlMenúToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenúToolStripMenuItem_Click_1);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click_2);
            // 
            // frmPresupuestoMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 588);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPresupuestoMensual";
            this.Text = "frmPresupuestoMensual";
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
    }
}