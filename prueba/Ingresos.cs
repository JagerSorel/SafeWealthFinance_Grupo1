using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class frmIngresos : Form
    {
        ConexionYMetodos cym = new ConexionYMetodos();
        public frmIngresos()
        {
            InitializeComponent();
        }

        private void frmIngresos_Load(object sender, EventArgs e)
        {
            cym.CargarDatos(dgvIngresos, "SELECT * FROM Ingreso WHERE Id_Usuario LIKE @Id_Usuario", frmInicio.IdUsuario);
            using (SqlConnection connection = new SqlConnection(cym._connectionString))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Ingreso WHERE Id_Usuario LIKE @Id_Usuario", connection);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();

                comando.Parameters.AddWithValue("@Id_Usuario", frmInicio.IdUsuario);
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "Id_Ingreso";
                comboBox1.DisplayMember = "Id_Ingreso";
            }
            gbAgregar.Show();
            gbMod.Hide();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int mes = dateTimePicker2.Value.Month;
            int anio = dateTimePicker2.Value.Year;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ingreso WHERE " +
                $"(FechaIngreso >= '{anio}-{mes}-01') AND (FechaIngreso < '{anio}-{mes + 1}-01')" +
                $" AND (Id_Usuario = {frmInicio.IdUsuario})" +
                $" ORDER BY FechaIngreso" +
                $" ASC;", cym._connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvIngresos.DataSource = dt;
        }
        private void cargaActual() {
            int mes = dateTimePicker2.Value.Month;
            int anio = dateTimePicker2.Value.Year;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ingreso WHERE " +
                $"(FechaIngreso >= '{anio}-{mes}-01') AND (FechaIngreso < '{anio}-{mes + 1}-01')" +
                $" AND (Id_Usuario = {frmInicio.IdUsuario})" +
                $" ORDER BY FechaIngreso" +
                $" ASC;", cym._connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvIngresos.DataSource = dt;
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbAgregar.Visible = true;
            gbAgregar.BringToFront();
            gbMod.Visible = false;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbMod.Visible = true;
            gbMod.BringToFront();
            gbAgregar.Visible = false;
        }

        private void volverAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiarCampos()
        {
            txtMonto.Text = "";
            txtNom.Text = "";
            txtMontoM.Text = "";
            txtNomM.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dtpFecha.Value = DateTime.Now;
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cym.InsertarDatos("INSERT INTO Ingreso (Id_Usuario, NombreIngreso, MontoIngreso, FechaIngreso) VALUES (@IdUsuario, @NombreIngreso, @MontoIngreso, @FechaIngreso)",
                new SqlParameter[]
                {
                    new SqlParameter("@NombreIngreso", txtNom.Text),
                    new SqlParameter("@MontoIngreso", Convert.ToDouble(txtMonto.Text)),
                    new SqlParameter("@FechaIngreso", dtpFecha.Value.ToString("yyyy-MM-dd")),
                    new SqlParameter("@IdUsuario", frmInicio.IdUsuario)
                });
            cargaActual();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            cym.ActualizarDatos("UPDATE Ingreso SET NombreIngreso = @NombreIngreso, MontoIngreso = @MontoIngreso, FechaIngreso = @FechaIngreso WHERE Id_Ingreso = @IdIngreso ",
                new SqlParameter[]
                {
                    new SqlParameter("@NombreIngreso", txtNomM.Text),
                    new SqlParameter("@MontoIngreso", Convert.ToDouble(txtMontoM.Text)),
                    new SqlParameter("@FechaIngreso", dateTimePicker1.Value.ToString("yyyy-MM-dd")),
                    new SqlParameter("@IdIngreso", Convert.ToInt32(comboBox1.SelectedValue)),
                    //new SqlParameter("@IdUsuario", frmInicio.IdUsuario)
                });
            cargaActual();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cym.BorrarDatos("DELETE FROM Ingreso WHERE Id_Ingreso = @IdIngreso AND Id_Usuario = @IdUsuario",
                new SqlParameter[]
                {
                    new SqlParameter("@IdIngreso", comboBox1.SelectedValue),
                    new SqlParameter("@IdUsuario", frmInicio.IdUsuario)
                });
            cargaActual();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idSeleccionado = comboBox1.SelectedValue.ToString();
            if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out int idSeleccionadoInt))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ingreso WHERE Id_Ingreso = @IdIngreso AND Id_Usuario = @IdUsuario", cym.AbrirConexion());
                cmd.Parameters.AddWithValue("@IdIngreso", Convert.ToInt32(idSeleccionado));
                cmd.Parameters.AddWithValue("@IdUsuario", frmInicio.IdUsuario);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNomM.Text = dr["NombreIngreso"].ToString();
                    txtMontoM.Text = dr["MontoIngreso"].ToString();
                    dtpFecha.Value = Convert.ToDateTime(dr["FechaIngreso"]);
                }
            }
        }
    }
}
