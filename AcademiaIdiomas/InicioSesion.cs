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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void registrateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro Form = new Registro();
            Form.Show();
        }
    }
}
