namespace prueba
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.gbIniciarSesion = new System.Windows.Forms.GroupBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.btnIniciarSecsion = new System.Windows.Forms.Button();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbCrearCuenta = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContraC = new System.Windows.Forms.TextBox();
            this.txtUsuarioC = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContraC = new System.Windows.Forms.Label();
            this.lblUsuarioC = new System.Windows.Forms.Label();
            this.btnCrearC = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProv = new System.Windows.Forms.Button();
            this.gbIniciarSesion.SuspendLayout();
            this.gbCrearCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIniciarSesion
            // 
            this.gbIniciarSesion.Controls.Add(this.btnCrearCuenta);
            this.gbIniciarSesion.Controls.Add(this.btnIniciarSecsion);
            this.gbIniciarSesion.Controls.Add(this.txtContra);
            this.gbIniciarSesion.Controls.Add(this.txtUsuario);
            this.gbIniciarSesion.Controls.Add(this.lblContra);
            this.gbIniciarSesion.Controls.Add(this.lblUsuario);
            this.gbIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIniciarSesion.Location = new System.Drawing.Point(31, 226);
            this.gbIniciarSesion.Name = "gbIniciarSesion";
            this.gbIniciarSesion.Size = new System.Drawing.Size(369, 140);
            this.gbIniciarSesion.TabIndex = 1;
            this.gbIniciarSesion.TabStop = false;
            this.gbIniciarSesion.Text = "Inicio de sesión";
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(31, 101);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(87, 23);
            this.btnCrearCuenta.TabIndex = 5;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // btnIniciarSecsion
            // 
            this.btnIniciarSecsion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnIniciarSecsion.Location = new System.Drawing.Point(242, 101);
            this.btnIniciarSecsion.Name = "btnIniciarSecsion";
            this.btnIniciarSecsion.Size = new System.Drawing.Size(101, 23);
            this.btnIniciarSecsion.TabIndex = 4;
            this.btnIniciarSecsion.Text = "Iniciar sesión";
            this.btnIniciarSecsion.UseVisualStyleBackColor = false;
            this.btnIniciarSecsion.Click += new System.EventHandler(this.btnIniciarSecsion_Click);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(126, 63);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(217, 23);
            this.txtContra.TabIndex = 3;
            this.txtContra.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(126, 35);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(217, 23);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(28, 70);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(67, 15);
            this.lblContra.TabIndex = 1;
            this.lblContra.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(28, 38);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // gbCrearCuenta
            // 
            this.gbCrearCuenta.Controls.Add(this.btnRegresar);
            this.gbCrearCuenta.Controls.Add(this.txtEmail);
            this.gbCrearCuenta.Controls.Add(this.txtNombre);
            this.gbCrearCuenta.Controls.Add(this.txtContraC);
            this.gbCrearCuenta.Controls.Add(this.txtUsuarioC);
            this.gbCrearCuenta.Controls.Add(this.lblEmail);
            this.gbCrearCuenta.Controls.Add(this.lblNombre);
            this.gbCrearCuenta.Controls.Add(this.lblContraC);
            this.gbCrearCuenta.Controls.Add(this.lblUsuarioC);
            this.gbCrearCuenta.Controls.Add(this.btnCrearC);
            this.gbCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrearCuenta.Location = new System.Drawing.Point(31, 202);
            this.gbCrearCuenta.Name = "gbCrearCuenta";
            this.gbCrearCuenta.Size = new System.Drawing.Size(369, 196);
            this.gbCrearCuenta.TabIndex = 2;
            this.gbCrearCuenta.TabStop = false;
            this.gbCrearCuenta.Text = "Crear cuenta";
            this.gbCrearCuenta.Visible = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(31, 158);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 23);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // txtContraC
            // 
            this.txtContraC.Location = new System.Drawing.Point(126, 56);
            this.txtContraC.Name = "txtContraC";
            this.txtContraC.PasswordChar = '*';
            this.txtContraC.Size = new System.Drawing.Size(217, 23);
            this.txtContraC.TabIndex = 6;
            this.txtContraC.UseSystemPasswordChar = true;
            // 
            // txtUsuarioC
            // 
            this.txtUsuarioC.Location = new System.Drawing.Point(126, 22);
            this.txtUsuarioC.Name = "txtUsuarioC";
            this.txtUsuarioC.Size = new System.Drawing.Size(217, 23);
            this.txtUsuarioC.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 98);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblContraC
            // 
            this.lblContraC.AutoSize = true;
            this.lblContraC.Location = new System.Drawing.Point(28, 63);
            this.lblContraC.Name = "lblContraC";
            this.lblContraC.Size = new System.Drawing.Size(67, 15);
            this.lblContraC.TabIndex = 2;
            this.lblContraC.Text = "Contraseña";
            // 
            // lblUsuarioC
            // 
            this.lblUsuarioC.AutoSize = true;
            this.lblUsuarioC.Location = new System.Drawing.Point(28, 29);
            this.lblUsuarioC.Name = "lblUsuarioC";
            this.lblUsuarioC.Size = new System.Drawing.Size(47, 15);
            this.lblUsuarioC.TabIndex = 1;
            this.lblUsuarioC.Text = "Usuario";
            // 
            // btnCrearC
            // 
            this.btnCrearC.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCrearC.Location = new System.Drawing.Point(242, 158);
            this.btnCrearC.Name = "btnCrearC";
            this.btnCrearC.Size = new System.Drawing.Size(101, 23);
            this.btnCrearC.TabIndex = 0;
            this.btnCrearC.Text = "Crear cuenta";
            this.btnCrearC.UseVisualStyleBackColor = false;
            this.btnCrearC.Click += new System.EventHandler(this.btnCrearC_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(138, 27);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(155, 155);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Bisque;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(180, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProv
            // 
            this.btnProv.Location = new System.Drawing.Point(273, 406);
            this.btnProv.Name = "btnProv";
            this.btnProv.Size = new System.Drawing.Size(127, 23);
            this.btnProv.TabIndex = 5;
            this.btnProv.Text = "Inic. sin cuenta (dev)";
            this.btnProv.UseVisualStyleBackColor = true;
            this.btnProv.Visible = false;
            this.btnProv.Click += new System.EventHandler(this.btnProv_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 441);
            this.ControlBox = false;
            this.Controls.Add(this.btnProv);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.gbCrearCuenta);
            this.Controls.Add(this.gbIniciarSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafeWealth Finance";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.gbIniciarSesion.ResumeLayout(false);
            this.gbIniciarSesion.PerformLayout();
            this.gbCrearCuenta.ResumeLayout(false);
            this.gbCrearCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbIniciarSesion;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gbCrearCuenta;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIniciarSecsion;
        private System.Windows.Forms.Label lblContraC;
        private System.Windows.Forms.Label lblUsuarioC;
        private System.Windows.Forms.Button btnCrearC;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContraC;
        private System.Windows.Forms.TextBox txtUsuarioC;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProv;
    }
}

