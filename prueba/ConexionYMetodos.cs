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
        /*public string _connStr = "";
        public void CargarDatos(String tabla, DataGridView panel, int usuario)
        {
            try
            {
                using (var conn = new SqlConnection(_connStr))
                using (var cmd = new SqlCommand($"SELECT * FROM {tabla} WHERE Id_Usuario = @usuario ORDER BY Fecha ASC", conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        panel.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        public void AgregarDatos(String tabla, String descripcion, double monto, DateTime fecha, int usuario)
        {
            try
            {
                using (var conn = new SqlConnection(_connStr))
                using (var cmd = new SqlCommand($"INSERT INTO {tabla} (Descripcion, Monto, Fecha, Id_Usuario) VALUES (@descripcion, @monto, @fecha, @usuario)", conn))
                {
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar datos: " + ex.Message);
            }
        }*/

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

        
        public void CargarDatos(DataGridView panel,string query,int usuario)
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
    }
}

