namespace prueba
{
    partial class Gastos
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
            this.dgGastos = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarOEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlMenúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGastos = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.gbMod = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.lblDato = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnLimpiar1 = new System.Windows.Forms.Button();
            this.txtMontoM = new System.Windows.Forms.TextBox();
            this.txtNomM = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.lblTipoM = new System.Windows.Forms.Label();
            this.lblFechaM = new System.Windows.Forms.Label();
            this.lblMontoM = new System.Windows.Forms.Label();
            this.lblNomM = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgGastos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbAgregar.SuspendLayout();
            this.gbMod.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgGastos
            // 
            this.dgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGastos.Location = new System.Drawing.Point(12, 65);
            this.dgGastos.Name = "dgGastos";
            this.dgGastos.Size = new System.Drawing.Size(604, 179);
            this.dgGastos.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM / yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(533, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarOEliminarToolStripMenuItem,
            this.filtrarToolStripMenuItem,
            this.volverAlMenúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.agregarToolStripMenuItem.Text = "Agregar ";
            // 
            // modificarOEliminarToolStripMenuItem
            // 
            this.modificarOEliminarToolStripMenuItem.Name = "modificarOEliminarToolStripMenuItem";
            this.modificarOEliminarToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.modificarOEliminarToolStripMenuItem.Text = "Modificar o eliminar";
            // 
            // filtrarToolStripMenuItem
            // 
            this.filtrarToolStripMenuItem.Name = "filtrarToolStripMenuItem";
            this.filtrarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.filtrarToolStripMenuItem.Text = "Filtrar";
            // 
            // volverAlMenúToolStripMenuItem
            // 
            this.volverAlMenúToolStripMenuItem.Name = "volverAlMenúToolStripMenuItem";
            this.volverAlMenúToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.volverAlMenúToolStripMenuItem.Text = "Volver al menú";
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.Location = new System.Drawing.Point(261, 34);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(73, 24);
            this.lblGastos.TabIndex = 3;
            this.lblGastos.Text = "Gastos";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(434, 42);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(93, 13);
            this.lblMes.TabIndex = 4;
            this.lblMes.Text = "Registros del mes:";
            // 
            // gbAgregar
            // 
            this.gbAgregar.Controls.Add(this.gbMod);
            this.gbAgregar.Controls.Add(this.btnAgregar);
            this.gbAgregar.Controls.Add(this.btnLimpiar);
            this.gbAgregar.Controls.Add(this.txtMonto);
            this.gbAgregar.Controls.Add(this.txtNom);
            this.gbAgregar.Controls.Add(this.comboBox1);
            this.gbAgregar.Controls.Add(this.dateTimePicker2);
            this.gbAgregar.Controls.Add(this.lblTipo);
            this.gbAgregar.Controls.Add(this.lblFecha);
            this.gbAgregar.Controls.Add(this.lblMonto);
            this.gbAgregar.Controls.Add(this.lblNom);
            this.gbAgregar.Location = new System.Drawing.Point(12, 259);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(604, 160);
            this.gbAgregar.TabIndex = 5;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar registro";
            // 
            // gbMod
            // 
            this.gbMod.Controls.Add(this.comboBox3);
            this.gbMod.Controls.Add(this.gbFiltrar);
            this.gbMod.Controls.Add(this.btnEliminar);
            this.gbMod.Controls.Add(this.lblId);
            this.gbMod.Controls.Add(this.btnMod);
            this.gbMod.Controls.Add(this.btnLimpiar1);
            this.gbMod.Controls.Add(this.txtMontoM);
            this.gbMod.Controls.Add(this.txtNomM);
            this.gbMod.Controls.Add(this.comboBox2);
            this.gbMod.Controls.Add(this.dateTimePicker3);
            this.gbMod.Controls.Add(this.lblTipoM);
            this.gbMod.Controls.Add(this.lblFechaM);
            this.gbMod.Controls.Add(this.lblMontoM);
            this.gbMod.Controls.Add(this.lblNomM);
            this.gbMod.Location = new System.Drawing.Point(0, 0);
            this.gbMod.Name = "gbMod";
            this.gbMod.Size = new System.Drawing.Size(604, 160);
            this.gbMod.TabIndex = 10;
            this.gbMod.TabStop = false;
            this.gbMod.Text = "Modificar o eliminar registro";
            this.gbMod.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(151, 21);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(330, 21);
            this.comboBox3.TabIndex = 25;
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Controls.Add(this.lblDato);
            this.gbFiltrar.Controls.Add(this.lblCategorias);
            this.gbFiltrar.Controls.Add(this.checkedListBox1);
            this.gbFiltrar.Location = new System.Drawing.Point(0, 0);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(604, 161);
            this.gbFiltrar.TabIndex = 23;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar datos";
            this.gbFiltrar.Visible = false;
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(391, 72);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(124, 26);
            this.lblDato.TabIndex = 2;
            this.lblDato.Text = "Usted ha gastado: $0.00\r\nEn la/s categoria/s:\r\n";
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(19, 23);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(57, 13);
            this.lblCategorias.TabIndex = 1;
            this.lblCategorias.Text = "Categorias";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(127, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(195, 124);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(511, 106);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(19, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "Id";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(511, 74);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 19;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar1
            // 
            this.btnLimpiar1.Location = new System.Drawing.Point(511, 39);
            this.btnLimpiar1.Name = "btnLimpiar1";
            this.btnLimpiar1.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar1.TabIndex = 18;
            this.btnLimpiar1.Text = "Limpiar";
            this.btnLimpiar1.UseVisualStyleBackColor = true;
            // 
            // txtMontoM
            // 
            this.txtMontoM.Location = new System.Drawing.Point(151, 77);
            this.txtMontoM.Name = "txtMontoM";
            this.txtMontoM.Size = new System.Drawing.Size(330, 20);
            this.txtMontoM.TabIndex = 17;
            // 
            // txtNomM
            // 
            this.txtNomM.Location = new System.Drawing.Point(151, 51);
            this.txtNomM.Name = "txtNomM";
            this.txtNomM.Size = new System.Drawing.Size(330, 20);
            this.txtNomM.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(151, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(330, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(151, 100);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(330, 20);
            this.dateTimePicker3.TabIndex = 14;
            // 
            // lblTipoM
            // 
            this.lblTipoM.AutoSize = true;
            this.lblTipoM.Location = new System.Drawing.Point(19, 130);
            this.lblTipoM.Name = "lblTipoM";
            this.lblTipoM.Size = new System.Drawing.Size(72, 13);
            this.lblTipoM.TabIndex = 13;
            this.lblTipoM.Text = "Tipo de gasto";
            // 
            // lblFechaM
            // 
            this.lblFechaM.AutoSize = true;
            this.lblFechaM.Location = new System.Drawing.Point(19, 106);
            this.lblFechaM.Name = "lblFechaM";
            this.lblFechaM.Size = new System.Drawing.Size(37, 13);
            this.lblFechaM.TabIndex = 12;
            this.lblFechaM.Text = "Fecha";
            // 
            // lblMontoM
            // 
            this.lblMontoM.AutoSize = true;
            this.lblMontoM.Location = new System.Drawing.Point(19, 84);
            this.lblMontoM.Name = "lblMontoM";
            this.lblMontoM.Size = new System.Drawing.Size(37, 13);
            this.lblMontoM.TabIndex = 11;
            this.lblMontoM.Text = "Monto";
            // 
            // lblNomM
            // 
            this.lblNomM.AutoSize = true;
            this.lblNomM.Location = new System.Drawing.Point(19, 58);
            this.lblNomM.Name = "lblNomM";
            this.lblNomM.Size = new System.Drawing.Size(90, 13);
            this.lblNomM.TabIndex = 10;
            this.lblNomM.Text = "Nombre del gasto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(511, 96);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(511, 43);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(151, 58);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(330, 20);
            this.txtMonto.TabIndex = 7;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(151, 22);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(330, 20);
            this.txtNom.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(330, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(151, 96);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(330, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(19, 134);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(72, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de gasto";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(19, 102);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(19, 65);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(19, 29);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(90, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nombre del gasto";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 426);
            this.Controls.Add(this.gbAgregar);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblGastos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgGastos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos";
            ((System.ComponentModel.ISupportInitialize)(this.dgGastos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            this.gbMod.ResumeLayout(false);
            this.gbMod.PerformLayout();
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgGastos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarOEliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenúToolStripMenuItem;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox gbMod;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnLimpiar1;
        private System.Windows.Forms.TextBox txtMontoM;
        private System.Windows.Forms.TextBox txtNomM;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label lblTipoM;
        private System.Windows.Forms.Label lblFechaM;
        private System.Windows.Forms.Label lblMontoM;
        private System.Windows.Forms.Label lblNomM;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}