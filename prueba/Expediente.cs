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
            // TODO: esta línea de código carga datos en la tabla 'safeWealthFinanceDBDataSet.ExpedienteSemestral' Puede moverla o quitarla según sea necesario.
            this.expedienteSemestralTableAdapter.Fill(this.safeWealthFinanceDBDataSet.ExpedienteSemestral);

        }
        public void OrgDatosTabla()
        {

            //YA FUNCIONARÁ COMO DEBE, PROXIMAMENTE
            //OPCION 1
            /*
            ConexionYMetodos cym = new Conexion();
            SqlCommand cmd = new SqlCommand(
             "SELECT * FROM Usuario WHERE Usuario=@user AND Clave=@pass",
             conexion.AbrirConexion());
            */
            //OPCION 2
            /*
             * using (SqlConnection connection = new SqlConnection("your_connection_string"))
                {
                    string query = "SELECT Name, Age FROM Users WHERE IsActive = 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Access columns by index or name
                                string name = reader["Name"].ToString();
                                int age = reader.GetInt32(reader.GetOrdinal("Age"));
                
                                // Store in variables or objects
                                Console.WriteLine($"Name: {name}, Age: {age}");
                            }
                        }
                    }
                }
             */
            //Estos son los resultados que deberían ser obtenidos tras agrupar gastos por mes
            double[] ingresos = { 46.45, 41.33, 12.32, 48.6, 43.32, 61.37 };
            double[] gastos = { 45.46, 31.43, 21.23, 46.8, 24.33, 36.71 };
            
            DataTable dt = new DataTable();
            for (int i = 0; i <= ingresos.Length; i++)
            {
                dt.Rows.Add("Enero", Convert.ToString(ingresos[i]), Convert.ToString(gastos[i]), Convert.ToString(ingresos[i] - gastos[i]));
            }
        }
        private void GrafGastos()
        {
            /*
             * string[][] Array = new string[100][];
            for(int i = 0; i < 100; i++) // Set some values to test
               Array[i] = new string[2] { "Value 1", "Value 2" };

            dataGridView.DataSource = (from arr in Array select new { Col1 = arr[0], Col2 = arr[1] });
            Page.DataBind();

             */
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
