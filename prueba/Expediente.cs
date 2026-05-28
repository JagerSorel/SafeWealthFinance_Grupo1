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
        public frmExpediente()
        {
            InitializeComponent();

        }
        private void Expediente_Load(object sender, EventArgs e)
        {
            OrgDatosTabla();
            GrafGastos();
            GrafIngresos();
            GrafGanancias();
        }
        private void OrgDatosTabla()
        {
            lblFecha.Text = lblFecha.Text + DateTime.Now.ToString("D");
            string[] nommes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio" };
            cym.AbrirConexion();
            decimal[] gastoMensual = new decimal[6];
            {
                try
                {
                    string query = "SELECT FechaGasto, MontoGasto FROM Gastos";
                    SqlCommand command = new SqlCommand(query);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime fechaGasto = DateTime.Parse(reader["FechaGasto"].ToString());
                        int mes = fechaGasto.Month - 1;

                        if (mes >= 0 && mes < 6)
                        {
                            decimal monto = decimal.Parse(reader["MontoGasto"].ToString());
                            gastoMensual[mes] += monto;
                        }
                    }
                    reader.Close();
                    for (int i = 0; i < gastoMensual.Length; i++)
                    {
                        Console.WriteLine($"Mes {i + 1}: {gastoMensual[i]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            decimal[] ingresoMensual = new decimal[6];
            {
                try
                {
                    string query = "SELECT FechaIngreso, MontoIngreso FROM Ingreso";
                    SqlCommand command = new SqlCommand(query);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime fechaIngreso = DateTime.Parse(reader["FechaIngreso"].ToString());
                        int mes = fechaIngreso.Month - 1;

                        if (mes >= 0 && mes < 6)
                        {
                            decimal monto = decimal.Parse(reader["MontoIngreso"].ToString());
                            ingresoMensual[mes] += monto;
                        }
                    }
                    reader.Close();

                    for (int i = 0; i < ingresoMensual.Length; i++)
                    {
                        Console.WriteLine($"Mes {i + 1}: {ingresoMensual[i]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            decimal[] gananciaMensual = new decimal[5];
            for (int h = 0; h <= 5; h++)
            {
                gananciaMensual[h] = (ingresoMensual[h] - gastoMensual[h]);
            }
            //Luego de agrupar la información en arreglos se representará en la tabla DGV
            DataTable dt = new DataTable();
            dt.Columns.Add("Mes");
            dt.Columns.Add("Gastos");
            dt.Columns.Add("Ingresos");
            dt.Columns.Add("Ganancias");
            for (int i = 0; i <= 5; i++)
            {
                dt.Rows.Add(nommes[i], Convert.ToString(gastoMensual[i]), Convert.ToString(ingresoMensual[i]), Convert.ToString(gananciaMensual[i]));
            }
            dgvSemestre.DataSource = dt;
        }
        //Y de la tabla DGV o arreglos a las gráficas
        private void GrafGastos()
        {
            double[] gastos = { 45.46, 31.43, 21.23, 46.8, 24.33, 36.71 };
            var series = new Series("Gastos");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { Convert.ToDouble(gastos[0]), Convert.ToDouble(gastos[1]), Convert.ToDouble(gastos[2]), Convert.ToDouble(gastos[3]), Convert.ToDouble(gastos[4]), Convert.ToDouble(gastos[5]) });
            chaGastos.Series.Add(series);
        }
        private void GrafIngresos()
        {
            double[] ingresos = { 46.45, 41.33, 12.32, 48.6, 43.32, 61.37 };
            var series = new Series("Ingresos");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { Convert.ToDouble(ingresos[0]), Convert.ToDouble(ingresos[1]), Convert.ToDouble(ingresos[2]), Convert.ToDouble(ingresos[3]), Convert.ToDouble(ingresos[4]), Convert.ToDouble(ingresos[5]) });
            chaIngresos.Series.Add(series);
        }
        private void GrafGanancias()
        {
            double[] ingresos = { 46.45, 41.33, 12.32, 48.6, 43.32, 61.37 };
            double[] gastos = { 45.46, 31.43, 21.23, 46.8, 24.33, 36.71 };
            var series = new Series("Ganancias");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { Convert.ToDouble(ingresos[0] - gastos[0]), Convert.ToDouble(ingresos[1] - gastos[1]), Convert.ToDouble(ingresos[2] - gastos[2]), Convert.ToDouble(ingresos[3] - gastos[3]), Convert.ToDouble(ingresos[4] - gastos[4]), Convert.ToDouble(ingresos[5] - gastos[5]) });
            chaGanancias.Series.Add(series);
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
