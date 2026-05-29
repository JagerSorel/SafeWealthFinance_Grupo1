using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class frmDistribucion : Form
    {
        ConexionYMetodos cym = new ConexionYMetodos();
        public frmDistribucion()
        {
            InitializeComponent();
        }

        private void volverAlMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }

            string Seleccion = checkedListBox1.Items[e.Index].ToString();
            if (e.NewValue == CheckState.Checked)
            {
                switch (Seleccion) {
                    case "Regla 50/20/30: 70% necesidades y deseos, 30% ahorro":
                        cym.AsignarPorcentajes(dateTimePicker1.Value, 70, 30);
                        cargarActual();
                        break;

                    case "Regla 70/20/10: 20% ahorro, 80% gastos y deudas":
                        cym.AsignarPorcentajes(dateTimePicker1.Value, 80, 20);
                        cargarActual();
                        break;

                    default:
                        break;
                }
            }
        }

        private void cargarActual() { 
            int mes = dateTimePicker1.Value.Month;
            int anio = dateTimePicker1.Value.Year;
            DataTable dt = new DataTable();
            cym.CargarDatos(dgvDistribucion, "SELECT Id_Distribucion, Mes, Anio" +
                ", MontoIngreso," +
                "PorAhorro, PorPresupuesto FROM Distribucion WHERE " +
                $"(Mes = {mes}) AND (Anio = {anio})" +
                $" AND (Id_Usuario = {frmInicio.IdUsuario})", frmInicio.IdUsuario);
        }

        private void frmDistribucion_Load(object sender, EventArgs e)
        {
            cargarActual();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cargarActual();
        }
    }
}
