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
    public partial class PrincipalSesion : Form
    {
        public PrincipalSesion()
        {
            InitializeComponent();

        }

        private void PrincipalSesion_Load(object sender, EventArgs e)
        {
            
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiPerfil Form = new MiPerfil();
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

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario.usuarioActual.Clear();
            Principal Form = new Principal();
            Form.Show();
            this.Hide();
            this.Dispose();
        }

        private void opinionBut_Click(object sender, EventArgs e)
        {
            Opinion Form = new Opinion();
            Form.Show();
        }
    }
}
