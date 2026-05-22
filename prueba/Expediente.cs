using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            lblFecha.Text = Convert.ToString(DateTime.Now);
            ObtDatos();
            GrafGastos();
            GrafGanancias();
            GrafIngresos();

        }
        private void ObtDatos()
        {
            double []ingresos = { 44.65, 43.33, 21.32, 64.8 };
            double []gastos = { 46.45, 41.33, 12.32, 48.6 };
            DataTable dt = new DataTable();
            dt.Columns.Add("Ganancias/Pérdidas");
            for (int i = 0; i < ingresos.Length; i++)
            {
                dt.Rows.Add("Enero", Convert.ToString(ingresos[i]), Convert.ToString(gastos[i]), Convert.ToString(ingresos[i] - gastos[i]));
            }
        }
        private void GrafGastos()
        {
            var series = new Series("Gastos");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { dgvExpediente});
            chaGastos.Series.Add(series);
        }
        private void GrafGanancias()
        {
            var series = new Series("Ganancias");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 100, 200, 90, 150 });
            chaGanancias.Series.Add(series);
        }
        private void GrafIngresos()
        {
            var series = new Series("Ingresos");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 100, 200, 90, 150 });
            chaIngresos.Series.Add(series);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Expediente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'safeWealthFinanceDBDataSet.ExpedienteSemestral' Puede moverla o quitarla según sea necesario.
            this.expedienteSemestralTableAdapter.Fill(this.safeWealthFinanceDBDataSet.ExpedienteSemestral);

        }
    }
}
