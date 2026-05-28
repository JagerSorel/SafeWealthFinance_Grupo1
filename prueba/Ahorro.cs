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
    public partial class frmAhorro : Form
    {
        ConexionYMetodos cym = new ConexionYMetodos();
        public frmAhorro()
        {
            InitializeComponent();
        }

        private void frmAhorro_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            cargarDatos();
            gbAbono.Hide();
            groupBox1.Hide();
            gbAgregar.Show();
            comboBox1.DisplayMember = "Texto";
            comboBox1.ValueMember = "Valor";

            comboBox1.DataSource = new[]
            {
                new { Texto = "En proceso", Valor = "En proceso" },
                new { Texto = "Completa", Valor = "Completa" }
            };
        }

        private void cargarDatos() 
        {
            cym.CargarDatos(dgvMetasAhorro, "SELECT * FROM Metas_Ahorro WHERE Id_Usuario = @Id_Usuario", frmInicio.IdUsuario);
            using (SqlConnection connection = new SqlConnection(cym._connectionString))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Metas_Ahorro WHERE Id_Usuario LIKE @Id_Usuario", connection);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();

                comando.Parameters.AddWithValue("@Id_Usuario", frmInicio.IdUsuario);
                da.Fill(dt);

                comboBox2.DataSource = dt;
                comboBox2.ValueMember = "Id_Meta";
                comboBox2.DisplayMember = "Id_Meta";

                comboBox3.DataSource = dt;
                comboBox3.ValueMember = "Id_Meta";
                comboBox3.DisplayMember = "Id_Meta";
            }
        }

        private void limpiarCampos()
        {
            txtMontoAbono.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            txtMontoMeta.Text = "";
            txtNom.Text = "";
            txtNomM.Text = "";
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal cero = 0;
            String estado = "En proceso";
            cym.InsertarDatos("INSERT INTO Metas_Ahorro (Id_Usuario, NombreMeta, MontoMeta, MontoRealizado, EstadoMeta, FechaInicio, FechaObjetivo) VALUES (@Id_Usuario, @NombreMeta, @MontoMeta, @MontoRealizado, @EstadoMeta, @FechaInicio, @FechaObjetivo)",
                new SqlParameter[]
                {
                    new SqlParameter("@NombreMeta", txtNom.Text),
                    new SqlParameter("@MontoMeta", Convert.ToDecimal(txtMontoMeta.Text)),
                    new SqlParameter("@MontoRealizado", cero),
                    new SqlParameter("@EstadoMeta", estado),
                    new SqlParameter("@FechaInicio", dateTimePicker2.Value.ToString("yyyy-MM-dd")),
                    new SqlParameter("@FechaObjetivo", dateTimePicker1.Value.ToString("yyyy-MM-dd")),
                    new SqlParameter("@Id_Usuario", frmInicio.IdUsuario)
                });
            limpiarCampos();
            cargarDatos();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            cym.ActualizarDatos("UPDATE Metas_Ahorro SET MontoMeta = @MontoMeta, EstadoMeta = @EstadoMeta, FechaObjetivo = @FechaObjetivo WHERE Id_Meta = @Id_Meta",
                new SqlParameter[]
                {
                    new SqlParameter("@MontoMeta", Convert.ToDecimal(txtMontoMetaM.Text)),
                    new SqlParameter("@EstadoMeta", "En proceso"),
                    new SqlParameter("@FechaObjetivo", dateTimePicker2.Value.ToString("yyyy-MM-dd")),
                    new SqlParameter("@Id_Meta", comboBox2.SelectedValue)
                });
            limpiarCampos();
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cym.BorrarDatos("DELETE FROM Metas_Ahorro WHERE Id_Meta = @Id_Meta",
                new SqlParameter[]
                {
                    new SqlParameter("@Id_Meta", comboBox2.SelectedValue)
                });
            limpiarCampos();
            cargarDatos();
        }

        private void btnAbono_Click(object sender, EventArgs e)
        {
            cym.ActualizarDatos("UPDATE Metas_Ahorro SET MontoRealizado = MontoRealizado + @MontoAbono WHERE Id_Meta = @Id_Meta",
                new SqlParameter[]
                {
                    new SqlParameter("@MontoAbono", Convert.ToDecimal(txtMontoAbono.Text)),
                    new SqlParameter("@Id_Meta", comboBox3.SelectedValue)
                });
            SqlCommand cmd = new SqlCommand("SELECT MontoMeta, MontoRealizado FROM Metas_Ahorro WHERE Id_Meta = @Id_Meta", cym.AbrirConexion());
            cmd.Parameters.AddWithValue("@Id_Meta", comboBox3.SelectedValue);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                decimal montoMeta = reader.GetDecimal(reader.GetOrdinal("MontoMeta"));
                decimal montoRealizado = reader.GetDecimal(reader.GetOrdinal("MontoRealizado"));
                if (montoRealizado >= montoMeta)
                {
                    cym.ActualizarDatos("UPDATE Metas_Ahorro SET EstadoMeta = 'Completa' WHERE Id_Meta = @Id_Meta",
                        new SqlParameter[]
                        {
                            new SqlParameter("@Id_Meta", comboBox3.SelectedValue)
                        });
                    MessageBox.Show("¡Felicidades! Has alcanzado tu meta de ahorro.");
                }
            }
            reader.Close();
            cargarDatos();
            limpiarCampos();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbAgregar.Show();
            gbAgregar.BringToFront();
            gbAbono.Hide();
            groupBox1.Hide();
        }

        private void modificarOEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbAgregar.Hide();
            gbAbono.Hide();
            groupBox1.Show();
            groupBox1.BringToFront();
        }

        private void abonarAMetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbAbono.Show();
            gbAbono.BringToFront();
            gbAgregar.Hide();
            groupBox1.Hide();
        }

        private void volverAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idSeleccionado = comboBox2.SelectedValue.ToString();
            if (comboBox2.SelectedValue != null && int.TryParse(comboBox2.SelectedValue.ToString(), out int idSeleccionadoInt))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Metas_Ahorro WHERE Id_Meta = @IdMeta AND Id_Usuario = @IdUsuario", cym.AbrirConexion());
                cmd.Parameters.AddWithValue("@IdMeta", Convert.ToInt32(idSeleccionado));
                cmd.Parameters.AddWithValue("@IdUsuario", frmInicio.IdUsuario);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNomM.Text = dr["NombreMeta"].ToString();
                    txtMontoMetaM.Text = dr["MontoMeta"].ToString();
                    dateTimePicker2.Value = Convert.ToDateTime(dr["FechaObjetivo"]);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string EstadoSeleccionado = comboBox1.SelectedValue.ToString();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Metas_Ahorro WHERE " +
                $"EstadoMeta LIKE '%{EstadoSeleccionado}%' " +
                $" AND (Id_Usuario = {frmInicio.IdUsuario})" +
                $" ORDER BY FechaInicio" +
                $" ASC;", cym._connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMetasAhorro.DataSource = dt;
        }
    }
}
