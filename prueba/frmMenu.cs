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
    public partial class frmMenu : Form
    {
        public string usuario;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e) { 
            lblBienvenida.Text = "Bienvenid@, " + usuario;
        }
        private void expedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expediente ex = new Expediente();
            ex.Show();
            this.Hide();
            if (ex != null) {
                this.Show();
            }
        }

        private void timerClass_Tick(object sender, EventArgs e)
        {

        }

        private void ahorroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAhorro frmAhorro = new frmAhorro();
            frmAhorro.Show();
            this.Hide();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresos frmIngresos = new frmIngresos();
            frmIngresos.Show();
            this.Hide();
        }

        private void distribuicionDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDistribucion frmDistribucion = new frmDistribucion();
            frmDistribucion.Show();
            this.Hide();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGastos frmGastos = new frmGastos();
            frmGastos.Show();
            this.Hide();
        }

        private void presupuestoMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reporteFinancieroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
            this.Hide();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            this.Hide();
            frmInicio.IdUsuario = 0;
        }
    }
}
