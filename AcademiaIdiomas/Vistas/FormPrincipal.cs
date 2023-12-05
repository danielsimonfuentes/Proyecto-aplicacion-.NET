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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInicioSesion Form = new FormInicioSesion();
            Form.Show();
            this.Hide();
            this.Dispose();
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

        //no se ha iniciado sesión
        private void cuentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("¡Debes iniciar sesión antes!", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void inglésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInglesForm Form = new FormInglesForm();
            Form.Show();
        }

        private void francésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFrancesForm Form = new FormFrancesForm();
            Form.Show();
        }

        private void alemánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlemanForm Form = new FormAlemanForm();
            Form.Show();
        }

        private void opinionBut_Click(object sender, EventArgs e)
        {
            FormOpinion Form = new FormOpinion();
            Form.Show();
        }
    }
}
