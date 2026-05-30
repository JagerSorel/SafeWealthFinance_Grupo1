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
using System.Windows.Forms.DataVisualization.Charting;

namespace prueba
{
    public partial class frmExpediente : Form
    {
        ConexionYMetodos cym = new ConexionYMetodos();
        public decimal[] gastoMensual = new decimal[6];
        public decimal[] ingresoMensual = new decimal[6];
        public decimal[] gananciaMensual = new decimal[6];
        public frmExpediente()
        {
            InitializeComponent();
            lblFecha.Text = lblFecha.Text + DateTime.Now.ToString("D");
        }
        private void Expediente_Load(object sender, EventArgs e)
        {
            OrgGastos();
            OrgIngresos();
            OrgGanancias();
            GenTabla();
            GenGraficas();
        }
        private void OrgGastos()
        {
            try
            {
                string query = "SELECT Id_Usuario, FechaGasto, MontoGasto FROM Gastos";
                using (SqlConnection cn = new SqlConnection(cym._connectionString))
                {
                    cn.Open();
                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime fechaGasto = reader.GetDateTime(reader.GetOrdinal("FechaGasto"));
                        int id = Convert.ToInt32(reader["Id_Usuario"]);
                        int anio = fechaGasto.Year;
                        int mes = fechaGasto.Month - 1;
                        if (id == frmInicio.IdUsuario)
                        {
                            if (anio == DateTime.Now.Year)
                            {
                                if (mes >= 0 && mes < 6)
                                {
                                    decimal monto = decimal.Parse(reader["MontoGasto"].ToString());
                                    gastoMensual[mes] += monto;
                                }
                            }
                        }
                    }
                    reader.Close();
                    for (int i = 0; i < gastoMensual.Length; i++)
                    {
                        Console.WriteLine($"Mes {i + 1}: {gastoMensual[i]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void OrgIngresos()
        {
            try
            {
                string query = "SELECT Id_Usuario, FechaIngreso, MontoIngreso FROM Ingreso";
                using (SqlConnection cn = new SqlConnection(cym._connectionString))
                {
                    cn.Open();
                    SqlCommand command = new SqlCommand(query, cn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime fechaIngreso = reader.GetDateTime(reader.GetOrdinal("FechaIngreso"));
                        int id = Convert.ToInt32(reader["Id_Usuario"]);
                        int anio = fechaIngreso.Year;
                        int mes = fechaIngreso.Month - 1;
                        if (id == frmInicio.IdUsuario)
                        {
                            if (anio == DateTime.Now.Year)
                            {
                                if (mes >= 0 && mes < 6)
                                {
                                    decimal monto = decimal.Parse(reader["MontoIngreso"].ToString());
                                    ingresoMensual[mes] += monto;
                                }
                            }
                        }
                    }
                    reader.Close();
                    for (int i = 0; i < ingresoMensual.Length; i++)
                    {
                        Console.WriteLine($"Mes {i + 1}: {ingresoMensual[i]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        private void OrgGanancias()
        {
            for (int h = 0; h <= 5; h++)
            {
                gananciaMensual[h] = ingresoMensual[h] - gastoMensual[h];
            }
        }
        private void GenTabla()
        {
             string[] nommes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio" };
             DataTable dt = new DataTable();
             dt.Columns.Add("Mes");
             dt.Columns.Add("Gastos", typeof(decimal));
             dt.Columns.Add("Ingresos", typeof(decimal));
             dt.Columns.Add("Ganancias", typeof(decimal));
             for (int i = 0; i <= 5; i++)
             {
                 dt.Rows.Add(nommes[i], gastoMensual[i], ingresoMensual[i], gananciaMensual[i]);
             }
             dgvSemestre.DataSource = dt;
        }
            private void GenGraficas() {
                var serieGastos = new Series("Gastos");
                serieGastos.ChartType = SeriesChartType.Line;
                serieGastos.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { Convert.ToDouble(gastoMensual[0]), Convert.ToDouble(gastoMensual[1]), Convert.ToDouble(gastoMensual[2]), Convert.ToDouble(gastoMensual[3]), Convert.ToDouble(gastoMensual[4]), Convert.ToDouble(gastoMensual[5]) });
                chaGastos.Series.Add(serieGastos);

                var serieIngresos = new Series("Ingresos");
                serieIngresos.ChartType = SeriesChartType.Line;
                serieIngresos.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { Convert.ToDouble(ingresoMensual[0]), Convert.ToDouble(ingresoMensual[1]), Convert.ToDouble(ingresoMensual[2]), Convert.ToDouble(ingresoMensual[3]), Convert.ToDouble(ingresoMensual[4]), Convert.ToDouble(ingresoMensual[5]) });
                chaIngresos.Series.Add(serieIngresos);

                var serieGanancias = new Series("Ganancias");
                serieGanancias.ChartType = SeriesChartType.Line;
                serieGanancias.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { Convert.ToDouble(gananciaMensual[0]), Convert.ToDouble(gananciaMensual[1]), Convert.ToDouble(gananciaMensual[2]), Convert.ToDouble(gananciaMensual[3]), Convert.ToDouble(gananciaMensual[4]), Convert.ToDouble(gananciaMensual[5]) });
                chaGanancias.Series.Add(serieGanancias);
            }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void volverAlMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpediente nex = new frmExpediente();
            nex.Show();
            this.Close();
        }
    }
}
