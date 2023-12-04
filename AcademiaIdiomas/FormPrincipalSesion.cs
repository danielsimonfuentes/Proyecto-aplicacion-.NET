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
    public partial class FormPrincipalSesion : Form
    {
        public FormPrincipalSesion()
        {
            InitializeComponent();

        }

        private void PrincipalSesion_Load(object sender, EventArgs e)
        {
            
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMiPerfil Form = new FormMiPerfil();
            Form.Show();
        }
        private bool confirma = false;
        private void PrincipalSesion_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario.usuarioActual.Clear();
            FormPrincipal Form = new FormPrincipal();
            Form.Show();
            this.Hide();
            this.Dispose();
        }

        private void opinionBut_Click(object sender, EventArgs e)
        {
            FormOpinion Form = new FormOpinion();
            Form.Show();
        }
    }
}
