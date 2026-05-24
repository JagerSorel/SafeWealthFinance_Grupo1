using prueba.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prueba
{
    public partial class frmInicio : Form
    {
        public static int IdUsuario;
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
                "SELECT * FROM Cuenta WHERE Usuario = @user AND Contrasena = @pass",
                cym.AbrirConexion());
            cmd.Parameters.AddWithValue("@user", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@pass", txtContra.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frmMenu menu = new frmMenu();
                menu.usuario = dr["Nombre"].ToString();
                IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                menu.Show();
                this.Hide();
            }
            else 
            { 
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
            cym.CerrarConexion();
        }

        private void btnCrearC_Click(object sender, EventArgs e)
        {
            cym.InsertarDatos(
                "INSERT INTO Cuenta (Nombre, Usuario, Contrasena, Email) VALUES (@nombre, @usuario, @contrasena, @Email)",
                new SqlParameter[]
                {
                    new SqlParameter("@nombre", txtNombre.Text),
                    new SqlParameter("@usuario", txtUsuarioC.Text),
                    new SqlParameter("@contrasena", txtContraC.Text),
                    new SqlParameter("@Email", txtEmail.Text)
                });
            MessageBox.Show("Cuenta creada exitosamente\nInicie sesión");
            gbIniciarSesion.Show();
            gbCrearCuenta.Hide(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
