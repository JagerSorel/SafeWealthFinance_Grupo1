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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prueba
{
    public partial class frmGastos : Form
    {
        ConexionYMetodos cym = new ConexionYMetodos();
        //private string connectionString = "Server=ELite-PC;Database=SafeWealthFinanceDB;Integrated Security=True;";

        public frmGastos()
        {
            InitializeComponent();
            CargarGastos();
        }

        private void CargarGastos()
        {
            using (SqlConnection conn = new SqlConnection(cym._connectionString))
            {
                conn.Open();
                string query = "SELECT Id_Gasto, NombreTransaccion, MontoGasto, FechaGasto, Id_TipoGasto FROM Gastos";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGastos.DataSource = dt;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(cym._connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Gastos (Id_Usuario, NombreTransaccion, MontoGasto, FechaGasto, Id_TipoGasto) " +
                               "VALUES (@IdUsuario, @Nombre, @Monto, @Fecha, @Tipo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", 1);
                cmd.Parameters.AddWithValue("@Nombre", txtNom.Text);
                cmd.Parameters.AddWithValue("@Monto", decimal.Parse(txtMonto.Text));
                cmd.Parameters.AddWithValue("@Fecha", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@Tipo", comboBox1.SelectedValue);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Gasto agregado correctamente");
            CargarGastos();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(cym._connectionString))
            {
                conn.Open();
                string query = "UPDATE Gastos SET NombreTransaccion=@Nombre, MontoGasto=@Monto, FechaGasto=@Fecha, Id_TipoGasto=@Tipo " + "WHERE Id_Gasto=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", int.Parse(lblId.Text));
                cmd.Parameters.AddWithValue("@Nombre", txtNomM.Text);
                cmd.Parameters.AddWithValue("@Monto", decimal.Parse(txtMontoM.Text));
                cmd.Parameters.AddWithValue("@Fecha", dateTimePicker3.Value);
                cmd.Parameters.AddWithValue("@Tipo", comboBox2.SelectedValue);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Gasto modificado correctamente");
            CargarGastos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(cym._connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Gastos WHERE Id_Gasto=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", int.Parse(lblId.Text));

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Gasto eliminado correctamente");
            CargarGastos();
        }

        private void volverAlMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarOEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbAgregar.Hide();
            gbFiltrar.Hide();
            gbMod.Show();
        }

        private void filtrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbAgregar.Hide();
            gbMod.Hide();
            gbFiltrar.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbFiltrar.Hide();
            gbMod.Hide();
            gbAgregar.Show();
        }
    }
}