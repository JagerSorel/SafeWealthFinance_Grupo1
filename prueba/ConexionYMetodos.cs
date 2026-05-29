using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    internal class ConexionYMetodos
    {

        //public readonly string _connectionString = "Server=PC-ELite\\SQLEXPRESS;Database=SafeWealthFinanceDB;Trusted_Connection=True;";
        public readonly string _connectionString = "Data Source=DESKTOP-NFDMETJ\\SQLEXPRESS;Initial Catalog=SafeWealthFinanceDB;Integrated Security=True;";

        public void InsertarDatos(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro insertado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
        }

        public void CargarDatos(DataGridView panel, string query, int Idusuario)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@Id_Usuario", Idusuario);

                conn.Open();

                using (var da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    panel.DataSource = dt;
                }
            }
        }

        public void ActualizarDatos(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente.");
            }
        }

        public void BorrarDatos(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente.");
            }
        }

        public SqlConnection AbrirConexion()
        {
            SqlConnection cn = new SqlConnection(_connectionString);
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
            return cn;
        }
        public SqlConnection CerrarConexion()
        {
            SqlConnection cn = new SqlConnection(_connectionString);
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
            return cn;
        }

        public void ProcesarMovimientosMensuales(
        DateTime fecha,
        int idUsuario,
        string query,
        string columnaDestino)
        {
            int mes = fecha.Month;
            int anio = fecha.Year;

            DateTime fechaInicio = new DateTime(anio, mes, 1);
            DateTime fechaFin = fechaInicio.AddMonths(1);

            SqlDataAdapter da = new SqlDataAdapter(query, _connectionString);
            da.SelectCommand.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            da.SelectCommand.Parameters.AddWithValue("@FechaFin", fechaFin);
            da.SelectCommand.Parameters.AddWithValue("@Id_Usuario", frmInicio.IdUsuario);

            DataTable dt = new DataTable();
            da.Fill(dt);

            decimal total = dt.AsEnumerable().Sum(row => row.Field<decimal>("Monto"));

            // Verificar si ya existe registro para ese mes/año
            using (SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM GastosMensuales WHERE Id_Usuario = @IdUsuario AND Mes = @Mes AND Anio = @Anio",
                AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@Mes", mes);
                cmd.Parameters.AddWithValue("@Anio", anio);

                int existeRegistro = (int)cmd.ExecuteScalar();

                if (existeRegistro > 0)
                {
                    ActualizarDatos(
                        $"UPDATE GastosMensuales SET {columnaDestino} = @Total WHERE Id_Usuario = @IdUsuario AND Mes = @Mes AND Anio = @Anio",
                        new SqlParameter[]
                        {
                    new SqlParameter("@IdUsuario", idUsuario),
                    new SqlParameter("@Mes", mes),
                    new SqlParameter("@Anio", anio),
                    new SqlParameter("@Total", total)
                        });
                }
                else
                {
                    InsertarDatos(
                        $"INSERT INTO GastosMensuales (Id_Usuario, Mes, Anio, {columnaDestino}) VALUES (@IdUsuario, @Mes, @Anio, @Total)",
                        new SqlParameter[]
                        {
                    new SqlParameter("@IdUsuario", idUsuario),
                    new SqlParameter("@Mes", mes),
                    new SqlParameter("@Anio", anio),
                    new SqlParameter("@Total", total)
                        });
                }
            }
        }

    }
}

