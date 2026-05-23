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
            cym.CargarDatos(dgvIngresos, "SELECT * FROM Ingresos WHERE IdUsuario LIKE @Usuario", frmInicio.IdUsuario);
            using (SqlConnection connection = new SqlConnection(cym._connectionString))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Ingresos WHERE IdUsuario LIKE @Usuario", connection);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();

                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "IdIngreso";
                comboBox1.DisplayMember = "IdIngreso";
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int mes = dateTimePicker2.Value.Month;
            int anio = dateTimePicker2.Value.Year;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ingresos WHERE " +
                $"(FechaIngreso >= '{anio}-{mes}-01') AND (FechaIngreso < '{anio}-{mes + 1}-01')" +
                $" AND (IdUsuario = {frmInicio.IdUsuario})" +
                $" ORDER BY EventDate ASC;", cym._connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvIngresos.DataSource = dt;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbAgregar.Show();
            gbMod.Hide();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbAgregar.Hide();
            gbMod.Show();
        }

        private void volverAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
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
            cym.InsertarDatos("INSERT INTO Ingresos (IdUsuario, NombreIngreso, MontoIngreso, FechaIngreso) VALUES (@IdUsuario, @NombreIngreso, @MontoIngreso, @FechaIngreso)",
                new SqlParameter[]
                {
                    new SqlParameter("@NombreIngreso", txtNom.Text),
                    new SqlParameter("@MontoIngreso", Convert.ToDouble(txtMonto.Text)),
                    new SqlParameter("@FechaIngreso", dateTimePicker1.Value),
                    new SqlParameter("@IdUsuario", frmInicio.IdUsuario)
                });
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            cym.ActualizarDatos("UPDATE Ingresos SET NombreIngreso = @NombreIngreso, MontoIngreso = @MontoIngreso, FechaIngreso = @FechaIngreso WHERE IdIngreso = @IdIngreso AND IdUsuario = @IdUsuario",
                new SqlParameter[]
                {
                    new SqlParameter("@NombreIngreso", txtNomM.Text),
                    new SqlParameter("@MontoIngreso", Convert.ToDouble(txtMontoM.Text)),
                    new SqlParameter("@FechaIngreso", dtpFecha.Value),
                    new SqlParameter("@IdIngreso", comboBox1.SelectedValue),
                    new SqlParameter("@IdUsuario", frmInicio.IdUsuario)
                });
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cym.EliminarDatos("DELETE FROM Ingresos WHERE IdIngreso = @IdIngreso AND IdUsuario = @IdUsuario",
                new SqlParameter[]
                {
                    new SqlParameter("@IdIngreso", comboBox1.SelectedValue),
                    new SqlParameter("@IdUsuario", frmInicio.IdUsuario)
                });
        }
    }
}
