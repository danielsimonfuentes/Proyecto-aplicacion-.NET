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
            this.Hide();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private bool confirma = false;
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!confirma)
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar el programa?", "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogo == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    confirma = true;
                    Application.ExitThread();

                }
            }
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cuentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("¡Debes iniciar sesión antes!", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void inglésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InglesForm Form = new InglesForm();
            Form.Show();
        }

        private void francésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrancesForm Form = new FrancesForm();
            Form.Show();
        }

        private void alemánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlemanForm Form = new AlemanForm();
            Form.Show();
        }
    }
}
