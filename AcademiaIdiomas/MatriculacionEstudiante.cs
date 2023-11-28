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
    public partial class MatriculacionEstudiante : Form
    {
        public MatriculacionEstudiante()
        {
            InitializeComponent();
        }

        private void acceptBut_Click(object sender, EventArgs e)
        {
            bool validar = true;
            if (nombreBox.Text == "")
            {
                nombreBox.BackColor = Color.Red;
                validar = false;
            }
            else
            {
                nombreBox.BackColor = Color.White;
            }
            if (apellido1Box.Text == "")
            {
                apellido1Box.BackColor = Color.Red;
                validar = false;
            }
            else
            {
                apellido1Box.BackColor = Color.White;
            }
            if (apellido2Box.Text == "")
            {
                apellido2Box.BackColor = Color.Red;
                validar = false;
            }
            else
            {
                apellido2Box.BackColor = Color.White;
            }
            if (dniBox.Text == "")
            {
                dniBox.BackColor = Color.Red;
                validar = false;
            }
            else
            {
                dniBox.BackColor = Color.White;
            }
            if (edadUpDown.Value == 0)
            {
                edadUpDown.BackColor = Color.Red;
                validar = false;
            }
            else
            {
                edadUpDown.BackColor = Color.White;
            }

            if (validar)
            {
                Estudiante.listaEstudiantes.Add(new Estudiante(nombreBox.Text, apellido1Box.Text, apellido2Box.Text, dniBox.Text, (int)edadUpDown.Value, idiomaComboBox.Text, claseComboBox.Text));
                this.Close();
            }
        }

        private void MatriculacionEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
