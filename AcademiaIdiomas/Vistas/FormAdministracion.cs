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
    public partial class FormAdministracion : Form
    {
        public FormAdministracion()
        {
            InitializeComponent();
        }

        private void usersBut_Click(object sender, EventArgs e)
        {
            FormAdministracionUsuarios Form = new FormAdministracionUsuarios();
            Form.Show();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private void estudiantesBut_Click(object sender, EventArgs e)
        {
            FormAdministracionEstudiantes Form = new FormAdministracionEstudiantes();
            Form.Show();
        }
    }
}
