using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaIdiomas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioSesion Form = new InicioSesion();
            Form.Show();
            this.Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
