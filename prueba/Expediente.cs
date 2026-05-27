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
    public partial class Expediente : Form
    {
        ConexionYMetodos cym = new ConexionYMetodos();
        public Expediente()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString("D");
            OrgDatosTabla();
            GrafGastos();
            GrafGanancias();
            GrafIngresos();

        }
        private void Expediente_Load(object sender, EventArgs e)
        {
            
        }
        public void OrgDatosTabla()
        {
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
            /*
            Luego de agrupar la información arreglo se representará en la tabla DGV
            DataTable dt = new DataTable();
            for (int i = 0; i <= ingresos.Length; i++)
            {
                dt.Rows.Add("Enero", Convert.ToString(ingresos[i]), Convert.ToString(gastos[i]), Convert.ToString(ingresos[i] - gastos[i]));
            }
            */
        }
        private void GrafGastos()
        {
            double[] gastos = { 45.46, 31.43, 21.23, 46.8, 24.33, 36.71 };
            var series = new Series("Gastos");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { Convert.ToDouble(gastos[0]), Convert.ToDouble(gastos[1]), Convert.ToDouble(gastos[2]), Convert.ToDouble(gastos[3]), Convert.ToDouble(gastos[4]), Convert.ToDouble(gastos[5]) });
            chaGanancias.Series.Add(series);
            chaGastos.Series.Add(series);
        }
        private void GrafGanancias()
        {
            double[] ingresos = { 46.45, 41.33, 12.32, 48.6, 43.32, 61.37 };
            var series = new Series("Ganancias");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { Convert.ToDouble(ingresos[0]), Convert.ToDouble(ingresos[1]), Convert.ToDouble(ingresos[2]), Convert.ToDouble(ingresos[3]), Convert.ToDouble(ingresos[4]), Convert.ToDouble(ingresos[5]) });
            chaGanancias.Series.Add(series);
        }
        private void GrafIngresos()
        {
            double[] ingresos = { 46.45, 41.33, 12.32, 48.6, 43.32, 61.37 };
            double[] gastos = { 45.46, 31.43, 21.23, 46.8, 24.33, 36.71 };
            var series = new Series("Ingresos");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { Convert.ToDouble(ingresos[0] - gastos[0]), Convert.ToDouble(ingresos[1] - gastos[1]), Convert.ToDouble(ingresos[2] - gastos[2]), Convert.ToDouble(ingresos[3] - gastos[3]), Convert.ToDouble(ingresos[4] - gastos[4]), Convert.ToDouble(ingresos[5] - gastos[5]) });
            chaIngresos.Series.Add(series);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
