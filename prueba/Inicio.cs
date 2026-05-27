using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prueba
{
    public partial class frmInicio : Form
    {
        public static int IdUsuario = Convert.ToInt32(DateTime.Now.ToString("dHHmmss"));
        ConexionYMetodos cym = new ConexionYMetodos();
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            gbCrearCuenta.Show();
            gbIniciarSesion.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            gbIniciarSesion.Show();
            gbCrearCuenta.Hide();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSecsion_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Usuario WHERE Usuario = @usuario AND Contrasena = @contrasena",
                cym.AbrirConexion());
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@contrasena", txtContra.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frmMenu menu = new frmMenu();
                menu.usuario = dr["Nombre"].ToString();
                IdUsuario = Convert.ToInt32(dr["Id_Usuario"]);
                this.Hide();
                LimpiarIniSes();
                menu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
            cym.CerrarConexion();
        }

        private void btnCrearC_Click(object sender, EventArgs e)
        {
            try
            {
                bool mailat = txtEmail.Text.Contains('@');
                bool maildot = txtEmail.Text.Contains('.');
                if (mailat == true || maildot == true)
                {
                    cym.InsertarDatos(
                    "INSERT INTO Usuario (Usuario, Contrasena, Nombre, Email) VALUES (@usuario, @contrasena, @nombre, @Email)",
                    new SqlParameter[]
                    {
                    new SqlParameter("@usuario", txtUsuarioC.Text),
                    new SqlParameter("@contrasena", txtContraC.Text),
                    new SqlParameter("@nombre", txtNombre.Text),
                    new SqlParameter("@Email", txtEmail.Text)
                    });
                    MessageBox.Show("Cuenta creada exitosamente\nProceda a iniciar sesión");
                    gbIniciarSesion.Show();
                    gbCrearCuenta.Hide();
                    LimpiarCrearCuenta();
                }
                else
                {
                    MessageBox.Show("Correo no válido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear cuenta: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProv_Click(object sender, EventArgs e)
        {
            //BOTÓN PRESENTE POR CONVENIENCIA, DEBE BORRARSE AL TERMINAR EL TRABAJO
            frmMenu menu = new frmMenu();
            this.Hide();
            LimpiarIniSes();
            menu.ShowDialog();
            this.Show();
        }
        private void LimpiarCrearCuenta()
        {
            txtUsuarioC.Text = "";
            txtContraC.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
        }
        private void LimpiarIniSes()
        {
            txtUsuario.Text = "";
            txtContra.Text = "";
        }
    }
}
