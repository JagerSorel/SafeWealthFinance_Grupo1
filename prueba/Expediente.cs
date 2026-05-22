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
            OrgDatosTabla();
            GrafGastos();
            GrafGanancias();
            GrafIngresos();

        }
        public void OrgDatosTabla()
        {
            double []ingresos = { 46.45, 41.33, 12.32, 48.6, 43.32, 61.37 };
            double []gastos = { 0, 0, 0, 0, 0, 0 };
            DataTable dt = new DataTable();
            dt.Columns.Add("Ganancias/Pérdidas");
            for (int i = 0; i <= ingresos.Length; i++)
            {
                dt.Rows.Add("Enero", Convert.ToString(ingresos[i]), Convert.ToString(gastos[i]), Convert.ToString(ingresos[i] - gastos[i]));
            }
        }
        private void GrafGastos()
        {
            double[] gastos = { 0, 0, 0, 0, 0, 0 };
            var series = new Series("Gastos");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { gastos[0], gastos[1], gastos[2], gastos[3], gastos[4], gastos[5] });
            chaGanancias.Series.Add(series);
            chaGastos.Series.Add(series);
        }
        private void GrafGanancias()
        {
            double[] ingresos = { 46.45, 41.33, 12.32, 48.6, 43.32, 61.37 };
            var series = new Series("Ganancias");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { ingresos[0], ingresos[1], ingresos[2], ingresos[3], ingresos[4], ingresos[5] });
            chaGanancias.Series.Add(series);
        }
        private void GrafIngresos()
        {
            double[] ingresos = { 46.45, 41.33, 12.32, 48.6, 43.32, 61.37 };
            double[] gastos = { 0, 0, 0, 0, 0, 0 };
            var series = new Series("Ingresos");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6 }, new[] { (ingresos[0] - gastos[0]), (ingresos[1] - gastos[1]), (ingresos[2] - gastos[2]), (ingresos[3] - gastos[3]), (ingresos[4] - gastos[4]), (ingresos[5] - gastos[5]) });
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
