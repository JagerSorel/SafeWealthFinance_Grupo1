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
    public partial class frmPresupuestoMensual : Form
    {
        //private string connectionString = "Server=.;Database=SafeWealthFinanceDB;Integrated Security=True;";
        ConexionYMetodos conexion = new ConexionYMetodos(); public frmPresupuestoMensual()
        {
            InitializeComponent();
            this.Load += frmPresupuestoMensual_Load;

        }

        private void frmPresupuestoMensual_Load(object sender, EventArgs e)
        {
            dgvDetalle.Columns.Clear();

            dgvDetalle.Columns.Add("NombreTransaccion", "Nombre transacción");
            dgvDetalle.Columns.Add("TipoGasto", "Tipo gasto");
            dgvDetalle.Columns.Add("Monto", "Monto");

            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.ScrollBars = ScrollBars.Both;

            CargarTiposGasto();
            CargarPeriodos();

        }
        private void CargarTiposGasto()
        {
            cbTipoGasto.Items.Clear();

            cbTipoGasto.Items.Add("Mensualidad");
            cbTipoGasto.Items.Add("Compra");
            cbTipoGasto.Items.Add("Alimentos");
            cbTipoGasto.Items.Add("Entretenimiento");
            cbTipoGasto.Items.Add("Transporte");
            cbTipoGasto.Items.Add("Salud");
            cbTipoGasto.Items.Add("Educación");
            cbTipoGasto.Items.Add("Servicios");
            cbTipoGasto.Items.Add("Ahorro");
            cbTipoGasto.Items.Add("Otros");
        }
        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarPeriodos()
        {
            cbPeriodo.Items.Clear();

            for (int mes = 1; mes <= 12; mes++)
            {
                cbPeriodo.Items.Add(mes.ToString("00") + "/2026");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void volverAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios primero
            if (cbPeriodo.Text.Trim() == "" ||
                txtIngreso.Text.Trim() == "" ||
                txtNombreTransaccion.Text.Trim() == "" ||
                cbTipoGasto.Text.Trim() == "" ||
                txtMonto.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos.",
                                "Campos obligatorios",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            dgvDetalle.Rows.Add(
                txtNombreTransaccion.Text,
                cbTipoGasto.Text,
                txtMonto.Text
            );

            txtNombreTransaccion.Clear();
            txtMonto.Clear();
            cbTipoGasto.SelectedIndex = -1;

        }

        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
      
   
        }

        private void lblTotalEspeculado_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            agregarToolStripMenuItem_Click(sender, e);


        }

        private void volverAlMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.Cells["Monto"].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells["Monto"].Value);
                }
            }

            lblTotalEspeculado.Text = "$" + total.ToString("0.00");
        }

        private void volverAlMenúToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.Cells["Monto"].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells["Monto"].Value);
                }
            }

            lblTotalEspeculado.Text = "$" + total.ToString("0.00");

            CalcularTotales();

        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                dgvDetalle.CurrentRow.Cells["NombreTransaccion"].Value = txtNombreTransaccion.Text;
                dgvDetalle.CurrentRow.Cells["TipoGasto"].Value = cbTipoGasto.Text;
                dgvDetalle.CurrentRow.Cells["Monto"].Value = txtMonto.Text;

                MessageBox.Show("Registro modificado correctamente.");
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, control y punto decimal
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if (e.KeyChar == '.' &&
                (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para eliminar.",
                                "Eliminar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);

            MessageBox.Show("Registro eliminado correctamente.",
                            "Eliminar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void agregarToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            if (cbPeriodo.Text.Trim() == "" ||
                txtIngreso.Text.Trim() == "" ||
                txtNombreTransaccion.Text.Trim() == "" ||
                cbTipoGasto.Text.Trim() == "" ||
                txtMonto.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos.",
                                "Campos obligatorios",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            dgvDetalle.Rows.Add(
                txtNombreTransaccion.Text,
                cbTipoGasto.Text,
                txtMonto.Text
            );

            txtNombreTransaccion.Clear();
            txtMonto.Clear();
            cbTipoGasto.SelectedIndex = -1;

            CalcularTotales();

        }
        private void CalcularTotales()
        {
            decimal totalEspeculado = 0;
            decimal ingreso = 0;

            decimal.TryParse(txtIngreso.Text, out ingreso);

            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.Cells["Monto"].Value != null)
                {
                    decimal monto = 0;
                    decimal.TryParse(fila.Cells["Monto"].Value.ToString(), out monto);
                    totalEspeculado += monto;
                }
            }

            decimal totalReal = ingreso - totalEspeculado;
            decimal porcentaje = 0;

            if (ingreso > 0)
            {
                porcentaje = (totalEspeculado / ingreso) * 100;
            }

            lblTotalEspeculado.Text = "$" + totalEspeculado.ToString("0.00");
            lblTotalReal.Text = "$" + totalReal.ToString("0.00");
            lblPorcentaje.Text = porcentaje.ToString("0.00") + "%";
        }

        private void calcularToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoGasto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbPeriodo.Text.Trim() == "" || txtIngreso.Text.Trim() == "" || dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el mes, ingresar el ingreso mensual y agregar al menos un detalle.",
                                "Guardar presupuesto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            CalcularTotales();

            decimal totalEspeculado = 0;
            decimal totalReal = 0;
            decimal porcentaje = 0;

            decimal.TryParse(lblTotalEspeculado.Text.Replace("$", ""), out totalEspeculado);
            decimal.TryParse(lblTotalReal.Text.Replace("$", ""), out totalReal);
            decimal.TryParse(lblPorcentaje.Text.Replace("%", ""), out porcentaje);

            DateTime fecha = DateTime.Parse("01/" + cbPeriodo.Text);

            using (SqlConnection conn = new SqlConnection(conexion._connectionString))
            {
                conn.Open();

                SqlTransaction transaccion = conn.BeginTransaction();

                try
                {
                    string queryPresupuesto = @"
                INSERT INTO Presupuesto_Mensual
                (Id_Usuario, Fecha, TotalEspeculado, TotalReal, PorcentajeFinal)
                VALUES
                (@Id_Usuario, @Fecha, @TotalEspeculado, @TotalReal, @PorcentajeFinal);
                SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdPresupuesto = new SqlCommand(queryPresupuesto, conn, transaccion);

                    cmdPresupuesto.Parameters.AddWithValue("@Id_Usuario", frmInicio.IdUsuario);
                    cmdPresupuesto.Parameters.AddWithValue("@Fecha", fecha);
                    cmdPresupuesto.Parameters.AddWithValue("@TotalEspeculado", totalEspeculado);
                    cmdPresupuesto.Parameters.AddWithValue("@TotalReal", totalReal);
                    cmdPresupuesto.Parameters.AddWithValue("@PorcentajeFinal", porcentaje);

                    int idPresupuesto = Convert.ToInt32(cmdPresupuesto.ExecuteScalar());

                    foreach (DataGridViewRow fila in dgvDetalle.Rows)
                    {
                        if (fila.IsNewRow) continue;

                        string nombre = fila.Cells["NombreTransaccion"].Value.ToString();
                        string tipoGasto = fila.Cells["TipoGasto"].Value.ToString();
                        decimal monto = Convert.ToDecimal(fila.Cells["Monto"].Value);

                        int idTipoGasto = ObtenerIdTipoGasto(tipoGasto, conn, transaccion);

                        string queryDetalle = @"
                    INSERT INTO Presupuesto_Detalle
                    (Id_Presupuesto, NombreTransaccion, TipoGasto, Monto)
                    VALUES
                    (@Id_Presupuesto, @NombreTransaccion, @TipoGasto, @Monto);";

                        SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conn, transaccion);

                        cmdDetalle.Parameters.AddWithValue("@Id_Presupuesto", idPresupuesto);
                        cmdDetalle.Parameters.AddWithValue("@NombreTransaccion", nombre);
                        cmdDetalle.Parameters.AddWithValue("@TipoGasto", tipoGasto);
                        cmdDetalle.Parameters.AddWithValue("@Monto", monto);

                        cmdDetalle.ExecuteNonQuery();
                    }

                    transaccion.Commit();

                    MessageBox.Show("Presupuesto guardado correctamente.",
                                    "Guardar",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }

        }

        private int ObtenerIdTipoGasto(string tipoGasto, SqlConnection conn, SqlTransaction transaccion)
        {
            string query = "SELECT Id_TipoGasto FROM Tipo_Gasto WHERE TipoGasto = @TipoGasto";

            SqlCommand cmd = new SqlCommand(query, conn, transaccion);
            cmd.Parameters.AddWithValue("@TipoGasto", tipoGasto);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        private int ObtenerSiguienteIdDetalle(SqlConnection conn, SqlTransaction transaccion)
        {
            string query = "SELECT ISNULL(MAX(Id_Detalle), 0) + 1 FROM Presupuesto_Detalle";

            SqlCommand cmd = new SqlCommand(query, conn, transaccion);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
            