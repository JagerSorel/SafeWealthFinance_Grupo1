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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            gbCrearCuenta.Show();
            gbIniciarSesion.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            gbIniciarSesion.Show();
            gbCrearCuenta.Hide();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
