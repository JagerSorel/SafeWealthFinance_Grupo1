namespace prueba
{
    partial class frmAhorro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAhorro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarOEliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonarAMetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblAhorro = new System.Windows.Forms.Label();
            this.dgvMetasAhorro = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMontoMeta = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblFechaO = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnLimpiar1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtMontoMetaM = new System.Windows.Forms.TextBox();
            this.txtNomM = new System.Windows.Forms.TextBox();
            this.lblFechaM = new System.Windows.Forms.Label();
            this.lblMontoMetaM = new System.Windows.Forms.Label();
            this.lblNomM = new System.Windows.Forms.Label();
            this.gbAbono = new System.Windows.Forms.GroupBox();
            this.lblSaldoDisponible = new System.Windows.Forms.Label();
            this.btnAbono = new System.Windows.Forms.Button();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.txtMontoAbono = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblMontoAbonar = new System.Windows.Forms.Label();
            this.lblIdAbono = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetasAhorro)).BeginInit();
            this.gbAgregar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAbono.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarOEliminarToolStripMenuItem,
            this.abonarAMetaToolStripMenuItem,
            this.volverAlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarOEliminarToolStripMenuItem
            // 
            this.modificarOEliminarToolStripMenuItem.Name = "modificarOEliminarToolStripMenuItem";
            this.modificarOEliminarToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.modificarOEliminarToolStripMenuItem.Text = "Modificar o eliminar";
            this.modificarOEliminarToolStripMenuItem.Click += new System.EventHandler(this.modificarOEliminarToolStripMenuItem_Click);
            // 
            // abonarAMetaToolStripMenuItem
            // 
            this.abonarAMetaToolStripMenuItem.Name = "abonarAMetaToolStripMenuItem";
            this.abonarAMetaToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.abonarAMetaToolStripMenuItem.Text = "Abonar a meta";
            this.abonarAMetaToolStripMenuItem.Click += new System.EventHandler(this.abonarAMetaToolStripMenuItem_Click);
            // 
            // volverAlToolStripMenuItem
            // 
            this.volverAlToolStripMenuItem.Name = "volverAlToolStripMenuItem";
            this.volverAlToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.volverAlToolStripMenuItem.Text = "Volver al menú";
            this.volverAlToolStripMenuItem.Click += new System.EventHandler(this.volverAlToolStripMenuItem_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(423, 38);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(53, 13);
            this.lblFiltro.TabIndex = 16;
            this.lblFiltro.Text = "Filtrar por:";
            // 
            // lblAhorro
            // 
            this.lblAhorro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAhorro.AutoSize = true;
            this.lblAhorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAhorro.Location = new System.Drawing.Point(233, 30);
            this.lblAhorro.Name = "lblAhorro";
            this.lblAhorro.Size = new System.Drawing.Size(165, 24);
            this.lblAhorro.TabIndex = 14;
            this.lblAhorro.Text = "Metas de Ahorro";
            // 
            // dgvMetasAhorro
            // 
            this.dgvMetasAhorro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMetasAhorro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMetasAhorro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetasAhorro.Location = new System.Drawing.Point(12, 57);
            this.dgvMetasAhorro.Name = "dgvMetasAhorro";
            this.dgvMetasAhorro.Size = new System.Drawing.Size(604, 179);
            this.dgvMetasAhorro.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(495, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gbAgregar
            // 
            this.gbAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregar.Controls.Add(this.btnAgregar);
            this.gbAgregar.Controls.Add(this.btnLimpiar);
            this.gbAgregar.Controls.Add(this.dateTimePicker1);
            this.gbAgregar.Controls.Add(this.txtMontoMeta);
            this.gbAgregar.Controls.Add(this.txtNom);
            this.gbAgregar.Controls.Add(this.lblFechaO);
            this.gbAgregar.Controls.Add(this.lblMonto);
            this.gbAgregar.Controls.Add(this.lblNombre);
            this.gbAgregar.Location = new System.Drawing.Point(12, 254);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(603, 165);
            this.gbAgregar.TabIndex = 18;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar registro";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(508, 95);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(508, 57);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(346, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2026, 5, 26, 20, 36, 19, 0);
            // 
            // txtMontoMeta
            // 
            this.txtMontoMeta.Location = new System.Drawing.Point(129, 77);
            this.txtMontoMeta.Name = "txtMontoMeta";
            this.txtMontoMeta.Size = new System.Drawing.Size(346, 20);
            this.txtMontoMeta.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(129, 39);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(346, 20);
            this.txtNom.TabIndex = 3;
            // 
            // lblFechaO
            // 
            this.lblFechaO.AutoSize = true;
            this.lblFechaO.Location = new System.Drawing.Point(21, 120);
            this.lblFechaO.Name = "lblFechaO";
            this.lblFechaO.Size = new System.Drawing.Size(77, 13);
            this.lblFechaO.TabIndex = 2;
            this.lblFechaO.Text = "Fecha objetivo";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(21, 84);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(63, 13);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto meta";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.btnMod);
            this.groupBox1.Controls.Add(this.btnLimpiar1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.txtMontoMetaM);
            this.groupBox1.Controls.Add(this.txtNomM);
            this.groupBox1.Controls.Add(this.lblFechaM);
            this.groupBox1.Controls.Add(this.lblMontoMetaM);
            this.groupBox1.Controls.Add(this.lblNomM);
            this.groupBox1.Location = new System.Drawing.Point(11, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 165);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar o eliminar registro";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(508, 113);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(129, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(346, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(21, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "ID";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(508, 75);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 15;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnLimpiar1
            // 
            this.btnLimpiar1.Location = new System.Drawing.Point(508, 36);
            this.btnLimpiar1.Name = "btnLimpiar1";
            this.btnLimpiar1.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar1.TabIndex = 14;
            this.btnLimpiar1.Text = "Limpiar";
            this.btnLimpiar1.UseVisualStyleBackColor = true;
            this.btnLimpiar1.Click += new System.EventHandler(this.btnLimpiar1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(129, 125);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(346, 20);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.Value = new System.DateTime(2026, 5, 26, 20, 36, 40, 0);
            // 
            // txtMontoMetaM
            // 
            this.txtMontoMetaM.Location = new System.Drawing.Point(129, 89);
            this.txtMontoMetaM.Name = "txtMontoMetaM";
            this.txtMontoMetaM.Size = new System.Drawing.Size(346, 20);
            this.txtMontoMetaM.TabIndex = 12;
            // 
            // txtNomM
            // 
            this.txtNomM.Location = new System.Drawing.Point(129, 51);
            this.txtNomM.Name = "txtNomM";
            this.txtNomM.Size = new System.Drawing.Size(346, 20);
            this.txtNomM.TabIndex = 11;
            // 
            // lblFechaM
            // 
            this.lblFechaM.AutoSize = true;
            this.lblFechaM.Location = new System.Drawing.Point(21, 132);
            this.lblFechaM.Name = "lblFechaM";
            this.lblFechaM.Size = new System.Drawing.Size(77, 13);
            this.lblFechaM.TabIndex = 10;
            this.lblFechaM.Text = "Fecha objetivo";
            // 
            // lblMontoMetaM
            // 
            this.lblMontoMetaM.AutoSize = true;
            this.lblMontoMetaM.Location = new System.Drawing.Point(21, 96);
            this.lblMontoMetaM.Name = "lblMontoMetaM";
            this.lblMontoMetaM.Size = new System.Drawing.Size(63, 13);
            this.lblMontoMetaM.TabIndex = 9;
            this.lblMontoMetaM.Text = "Monto meta";
            // 
            // lblNomM
            // 
            this.lblNomM.AutoSize = true;
            this.lblNomM.Location = new System.Drawing.Point(21, 58);
            this.lblNomM.Name = "lblNomM";
            this.lblNomM.Size = new System.Drawing.Size(44, 13);
            this.lblNomM.TabIndex = 8;
            this.lblNomM.Text = "Nombre";
            // 
            // gbAbono
            // 
            this.gbAbono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAbono.Controls.Add(this.lblSaldoDisponible);
            this.gbAbono.Controls.Add(this.btnAbono);
            this.gbAbono.Controls.Add(this.btnLimpiar2);
            this.gbAbono.Controls.Add(this.txtMontoAbono);
            this.gbAbono.Controls.Add(this.comboBox3);
            this.gbAbono.Controls.Add(this.lblMontoAbonar);
            this.gbAbono.Controls.Add(this.lblIdAbono);
            this.gbAbono.Location = new System.Drawing.Point(17, 254);
            this.gbAbono.Name = "gbAbono";
            this.gbAbono.Size = new System.Drawing.Size(604, 165);
            this.gbAbono.TabIndex = 19;
            this.gbAbono.TabStop = false;
            this.gbAbono.Text = "Abonar meta";
            // 
            // lblSaldoDisponible
            // 
            this.lblSaldoDisponible.AutoSize = true;
            this.lblSaldoDisponible.Location = new System.Drawing.Point(34, 136);
            this.lblSaldoDisponible.Name = "lblSaldoDisponible";
            this.lblSaldoDisponible.Size = new System.Drawing.Size(130, 13);
            this.lblSaldoDisponible.TabIndex = 6;
            this.lblSaldoDisponible.Text = "Saldo destinado al ahorro:";
            // 
            // btnAbono
            // 
            this.btnAbono.Location = new System.Drawing.Point(508, 87);
            this.btnAbono.Name = "btnAbono";
            this.btnAbono.Size = new System.Drawing.Size(75, 23);
            this.btnAbono.TabIndex = 5;
            this.btnAbono.Text = "Abono";
            this.btnAbono.UseVisualStyleBackColor = true;
            this.btnAbono.Click += new System.EventHandler(this.btnAbono_Click);
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Location = new System.Drawing.Point(508, 41);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar2.TabIndex = 4;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // txtMontoAbono
            // 
            this.txtMontoAbono.Location = new System.Drawing.Point(156, 89);
            this.txtMontoAbono.Name = "txtMontoAbono";
            this.txtMontoAbono.Size = new System.Drawing.Size(326, 20);
            this.txtMontoAbono.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(156, 43);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(326, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // lblMontoAbonar
            // 
            this.lblMontoAbonar.AutoSize = true;
            this.lblMontoAbonar.Location = new System.Drawing.Point(34, 96);
            this.lblMontoAbonar.Name = "lblMontoAbonar";
            this.lblMontoAbonar.Size = new System.Drawing.Size(87, 13);
            this.lblMontoAbonar.TabIndex = 1;
            this.lblMontoAbonar.Text = "Monto del abono";
            // 
            // lblIdAbono
            // 
            this.lblIdAbono.AutoSize = true;
            this.lblIdAbono.Location = new System.Drawing.Point(34, 46);
            this.lblIdAbono.Name = "lblIdAbono";
            this.lblIdAbono.Size = new System.Drawing.Size(18, 13);
            this.lblIdAbono.TabIndex = 0;
            this.lblIdAbono.Text = "ID";
            // 
            // frmAhorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAbono);
            this.Controls.Add(this.gbAgregar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblAhorro);
            this.Controls.Add(this.dgvMetasAhorro);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAhorro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahorro";
            this.Load += new System.EventHandler(this.frmAhorro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetasAhorro)).EndInit();
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAbono.ResumeLayout(false);
            this.gbAbono.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarOEliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonarAMetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlToolStripMenuItem;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblAhorro;
        private System.Windows.Forms.DataGridView dgvMetasAhorro;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMontoMeta;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblFechaO;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnLimpiar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtMontoMetaM;
        private System.Windows.Forms.TextBox txtNomM;
        private System.Windows.Forms.Label lblFechaM;
        private System.Windows.Forms.Label lblMontoMetaM;
        private System.Windows.Forms.Label lblNomM;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbAbono;
        private System.Windows.Forms.Label lblMontoAbonar;
        private System.Windows.Forms.Label lblIdAbono;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnAbono;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.TextBox txtMontoAbono;
        private System.Windows.Forms.Label lblSaldoDisponible;
    }
}