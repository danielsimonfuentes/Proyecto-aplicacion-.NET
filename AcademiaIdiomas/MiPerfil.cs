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
    public partial class MiPerfil : Form
    {
        public MiPerfil()
        {
            InitializeComponent();
        }

        private void MiPerfil_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Usuario.usuarioActual[0].NombreUsuario);
        }
    }
}
