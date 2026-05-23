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

        public readonly string _connectionString = "Server=PC-ELite\\SQLEXPRESS;Database=SafeWealthFinanceDB;Trusted_Connection=True;";

        public void InsertarDatos(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
        }


        public void CargarDatos(DataGridView panel, string query, int usuario)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@usuario", usuario);

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
            }
        }

        public void BorrarDatos(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                conn.Open();
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
    }
}

