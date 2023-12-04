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
    public partial class FormMatriculacionEstudiante : Form
    {
        public FormMatriculacionEstudiante()
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
            if (!idiomaComboBox.Text.Equals("inglés") && !idiomaComboBox.Text.Equals("francés") && !idiomaComboBox.Text.Equals("alemán"))
            {
                idiomaComboBox.BackColor = Color.Red;
                MessageBox.Show("Debes asignar un idioma válido al estudiante", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar = false;
            }
            else
            {
                idiomaComboBox.BackColor = Color.White;
            }
            if (!claseComboBox.Text.Equals("A1") && !claseComboBox.Text.Equals("A2") && !claseComboBox.Text.Equals("B1") && !claseComboBox.Text.Equals("B2") && !claseComboBox.Text.Equals("C1") && !claseComboBox.Text.Equals("C2"))
            {
                claseComboBox.BackColor = Color.Red;
                MessageBox.Show("Debes asignar una clase válida al estudiante", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar = false;
            }
            else
            {
                claseComboBox.BackColor = Color.White;
            }
            //cuando todos los campos se han rellenado correctamente
            if (validar)
            {
                Estudiante.listaEstudiantes.Add(new Estudiante(nombreBox.Text, apellido1Box.Text, apellido2Box.Text, dniBox.Text, (int)edadUpDown.Value, idiomaComboBox.Text, claseComboBox.Text));
                this.Close();
            }
        }

        private void MatriculacionEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void idiomaComboBox_Click(object sender, EventArgs e)
        {
            idiomaComboBox.BackColor = Color.White;
        }

        private void claseComboBox_Click(object sender, EventArgs e)
        {
            claseComboBox.BackColor = Color.White;
        }
    }
}
