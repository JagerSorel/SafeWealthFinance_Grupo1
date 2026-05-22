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
            GrafGastos();
            GrafGanancias();
            GrafIngresos();

        }
        private void GrafGastos()
        {
            var series = new Series("Gastos");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4 }, new[] { 100, 200, 90, 150 });
            chaGastos.Series.Add(series);
        }
        private void GrafGanancias()
        {
            var series = new Series("Ganancias");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4 }, new[] { 100, 200, 90, 150 });
            chaGanancias.Series.Add(series);
        }
        private void GrafIngresos()
        {
            var series = new Series("Ingresos");
            series.ChartType = SeriesChartType.Line;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4 }, new[] { 100, 200, 90, 150 });
            chaIngresos.Series.Add(series);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
