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

<<<<<<< HEAD:prueba/Menu.cs
        private void frmMenu_Load(object sender, EventArgs e)
=======
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
>>>>>>> 70c9ced56b1982c2e435d86a2d281ef38c844877:prueba/frmMenu.cs
        {

        }
    }
}
