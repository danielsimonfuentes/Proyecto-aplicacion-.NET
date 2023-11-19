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
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void usersBut_Click(object sender, EventArgs e)
        {
            AdministracionUsuarios Form = new AdministracionUsuarios();
            Form.Show();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }
    }
}
