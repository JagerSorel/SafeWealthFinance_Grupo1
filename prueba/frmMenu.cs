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
            lblHoy.Text = DateTime.Now.ToString("D");
        }

        private void frmMenu_Load(object sender, EventArgs e)
        { 
            lblBienvenida.Text = "Bienvenid@, " + usuario;
        }
        private void ahorroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAhorro frmAhorro = new frmAhorro();
            frmAhorro.Show();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresos frmIngresos = new frmIngresos();
            frmIngresos.Show();
        }

        private void distribuicionDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDistribucion frmDistribucion = new frmDistribucion();
            frmDistribucion.Show();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGastos frmGastos = new frmGastos();
            frmGastos.Show();
        }

        private void presupuestoMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresupuestoMensual frm = new frmPresupuestoMensual();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
            this.Hide();
        }

        private void reporteFinancieroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio.IdUsuario = 0;
            this.Close();
        }
        private void expedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpediente exp = new frmExpediente();
            exp.Show();
        }
    }
}