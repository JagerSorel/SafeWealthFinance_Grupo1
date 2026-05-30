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
        //private string connectionString = "Server=ELite-PC;Database=SafeWealthFinanceDB;Integrated Security=True;";
        ConexionYMetodos conexion = new ConexionYMetodos();
        
        public frmGastos()
        {
            InitializeComponent();
            CargarGastos();
            using (SqlConnection connection = new SqlConnection(conexion._connectionString))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Gastos WHERE Id_Usuario LIKE @Id_Usuario", connection);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();

                comando.Parameters.AddWithValue("@Id_Usuario", frmInicio.IdUsuario);
                da.Fill(dt);

                comboBox4.DataSource = dt;
                comboBox4.ValueMember = "Id_Gasto";
                comboBox4.DisplayMember = "Id_Gasto";
            }
            using (SqlConnection connection = new SqlConnection(conexion._connectionString))
            {
                SqlCommand comando = new SqlCommand("select * from Tipo_Gasto", connection);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();

                da.Fill(dt);
                da.Fill(dt1);

                comboBox2.DataSource = dt;
                comboBox2.ValueMember = "Id_TipoGasto";
                comboBox2.DisplayMember = "TipoGasto";

                comboBox3.DataSource = dt1;
                comboBox3.ValueMember = "Id_TipoGasto";
                comboBox3.DisplayMember = "TipoGasto";

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "Id_TipoGasto";
                comboBox1.DisplayMember = "TipoGasto";
            }
        }

        private void CargarGastos()
        {
            conexion.CargarDatos(dgvGastos, "SELECT g.Id_Gasto 'Id Gasto', g.NombreTransaccion 'Nombre', g.MontoGasto 'Monto', g.FechaGasto 'Fecha', tp.TipoGasto 'Tipo de gasto'" +
                "FROM Gastos g INNER JOIN Tipo_Gasto tp ON g.TipoGasto = tp.Id_TipoGasto WHERE Id_Usuario = @Id_Usuario", frmInicio.IdUsuario);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.InsertarDatos("INSERT INTO Gastos (Id_Usuario, NombreTransaccion, MontoGasto, FechaGasto, TipoGasto) VALUES (@IdUsuario, @Nombre, @Monto, @Fecha, @Tipo)",
                new SqlParameter[]
                {
                    new SqlParameter("@IdUsuario", frmInicio.IdUsuario),
                    new SqlParameter("@Nombre", txtNom.Text),
                    new SqlParameter("@Monto", decimal.Parse(txtMonto.Text)),
                    new SqlParameter("@Fecha", dateTimePicker2.Value.ToString("yyyy-MM-dd")),
                    new SqlParameter("@Tipo", Convert.ToInt32(comboBox1.SelectedValue))
                });
            CargarGastos();
            conexion.ProcesarMovimientosMensuales(dateTimePicker2.Value, frmInicio.IdUsuario,
                "SELECT i.MontoGasto AS Monto FROM Gastos i WHERE Id_Usuario = @Id_Usuario AND " +
                "FechaGasto >= @FechaInicio AND FechaGasto < @FechaFin", "Gastos");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            conexion.ActualizarDatos("UPDATE Gastos SET NombreTransaccion=@Nombre, MontoGasto=@Monto, FechaGasto=@Fecha, TipoGasto=@Tipo WHERE Id_Gasto=@Id",
                new SqlParameter[]
                {
                    new SqlParameter("@Id", Convert.ToInt32(comboBox4.SelectedValue)),
                    new SqlParameter("@Nombre", txtNomM.Text),
                    new SqlParameter("@Monto", decimal.Parse(txtMontoM.Text)),
                    new SqlParameter("@Fecha", dateTimePicker3.Value.ToString("yyyy-MM-dd")),
                    new SqlParameter("@Tipo", Convert.ToInt32(comboBox2.SelectedValue))
                });
            CargarGastos();
            conexion.ProcesarMovimientosMensuales(dateTimePicker3.Value, frmInicio.IdUsuario,
                "SELECT i.MontoGasto AS Monto FROM Gastos i WHERE Id_Usuario = @Id_Usuario AND " +
                "FechaGasto >= @FechaInicio AND FechaGasto < @FechaFin", "Gastos");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.BorrarDatos("DELETE FROM Gastos WHERE Id_Gasto=@Id",
                new SqlParameter[]
                {
                    new SqlParameter("@Id", Convert.ToInt32(comboBox4.SelectedValue))
                });
            CargarGastos();
            conexion.ProcesarMovimientosMensuales(dateTimePicker3.Value, frmInicio.IdUsuario,
                "SELECT i.MontoGasto AS Monto FROM Gastos i WHERE Id_Usuario = @Id_Usuario AND " +
                "FechaGasto >= @FechaInicio AND FechaGasto < @FechaFin", "Gastos");
        }

        private void limpiarCampos()
        { 
            txtNom.Text = "";
            txtMonto.Text = "";
            dateTimePicker2.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            txtNomM.Text = "";
            txtMontoM.Text = "";
            dateTimePicker3.Value = DateTime.Now;
            comboBox2.SelectedIndex = 0;
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbAgregar.Visible = true;
            gbMod.Visible = false;
            gbFiltrar.Visible = false;
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
            gbFiltrar.Visible = true;
            gbAgregar.Visible = false;
            gbMod.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int mes = dateTimePicker1.Value.Month;
            int anio = dateTimePicker1.Value.Year;
            SqlDataAdapter da = new SqlDataAdapter("SELECT g.Id_Gasto 'Id Gasto', g.NombreTransaccion 'Nombre', g.MontoGasto 'Monto', g.FechaGasto 'Fecha', tp.TipoGasto 'Tipo de gasto'" +
                "FROM Gastos g INNER JOIN Tipo_Gasto tp ON g.TipoGasto = tp.Id_TipoGasto " +
                " WHERE " +
                $"(FechaGasto >= '{anio}-{mes}-01') AND (FechaGasto < '{anio}-{mes + 1}-01')" +
                $" AND (Id_Usuario = {frmInicio.IdUsuario})" +
                $" ORDER BY FechaGasto" +
                $" ASC;", conexion._connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGastos.DataSource = dt;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idSeleccionado = comboBox4.SelectedValue.ToString();
            if (comboBox1.SelectedValue != null && int.TryParse(comboBox4.SelectedValue.ToString(), out int idSeleccionadoInt))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Gastos WHERE Id_Gasto = @IdGasto AND Id_Usuario = @IdUsuario", conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@IdGasto", Convert.ToInt32(idSeleccionado));
                cmd.Parameters.AddWithValue("@IdUsuario", frmInicio.IdUsuario);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNomM.Text = dr["NombreTransaccion"].ToString();
                    txtMontoM.Text = dr["MontoGasto"].ToString();
                    dateTimePicker3.Value = Convert.ToDateTime(dr["FechaGasto"]);
                    comboBox2.SelectedValue = dr["TipoGasto"].ToString();
                }
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
            string seleccion = checkedListBox1.Items[e.Index].ToString();
            if (e.NewValue == CheckState.Checked)
            {
                switch (seleccion)
                {
                    case "Gastos hormiga (menos de $5.00)":
                        SqlDataAdapter da = new SqlDataAdapter("SELECT g.Id_Gasto 'Id Gasto', g.NombreTransaccion 'Nombre', g.MontoGasto 'Monto', g.FechaGasto 'Fecha', tp.TipoGasto 'Tipo de gasto'" +
                        " FROM Gastos g INNER " +
                        " JOIN Tipo_Gasto tp ON g.TipoGasto = tp.Id_TipoGasto " +
                        $" WHERE g.MontoGasto <= 5.00 AND Id_Usuario = {frmInicio.IdUsuario} ORDER BY FechaGasto ASC;", conexion._connectionString);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvGastos.DataSource = dt;
                        lblDato.Text = $"Usted ha gastado: ${dt.Compute("SUM(Monto)", string.Empty)} \nen la categoria {seleccion}";
                        break;
                    default:
                        break;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.SelectedValue != null && int.TryParse(comboBox3.SelectedValue.ToString(), out int tipoGastoSeleccionado))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT g.Id_Gasto 'Id Gasto', g.NombreTransaccion 'Nombre', g.MontoGasto 'Monto', g.FechaGasto 'Fecha', tp.TipoGasto 'Tipo de gasto'" +
                    " FROM Gastos g INNER " +
                    " JOIN Tipo_Gasto tp ON g.TipoGasto = tp.Id_TipoGasto " +
                    $" WHERE g.TipoGasto = {tipoGastoSeleccionado} AND Id_Usuario = {frmInicio.IdUsuario} AND g.FechaGasto >= @FechaInicio AND g.FechaGasto < @FechaFin ORDER BY FechaGasto ASC;", conexion._connectionString);
                int mes = DateTime.Now.Month;
                DateTime fechaInicio = new DateTime(DateTime.Now.Year, mes, 1);
                DateTime fechaFin = fechaInicio.AddMonths(1);
                da.SelectCommand.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                da.SelectCommand.Parameters.AddWithValue("@FechaFin", fechaFin);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGastos.DataSource = dt;
                lblDato.Text = $"Usted ha gastado: ${dt.Compute("SUM(Monto)", string.Empty)} \nen la categoria {comboBox3.Text}";
            }
        }

    }
}