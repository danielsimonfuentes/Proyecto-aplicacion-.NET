using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaIdiomas
{
    public partial class FormModificarEstudiante : Form
    {
        String dni;
        public FormModificarEstudiante(String d)
        {
            InitializeComponent();
            dni = d;
        }

        private void FormModificarEstudiante_Load(object sender, EventArgs e)
        {
            modificacionLabel.Text = "Modificación de estudiante con DNI:" + dni;
        }

        private void acceptBut_Click(object sender, EventArgs e)
        {
            bool validar = true;
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
                modificarEstudiante();
                Form form = new FormAdministracionEstudiantes();
                form.Show();
                this.Close();
            }
        }

        private void modificarEstudiante()
        {
            bool resultado = true;
            try
            {
                using (SqlConnection cnn = new SqlConnection(ControladorEstudiante.construirCadenaConexión()))
                {
                    cnn.Open();
                    SqlCommand comando = cnn.CreateCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE Estudiantes SET Idioma='" + idiomaComboBox.Text + "', Clase='" + claseComboBox.Text + "' WHERE DNI ='" + dni + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.UpdateCommand = comando;
                    if (adaptador.UpdateCommand.ExecuteNonQuery() == 0)
                    {
                        resultado = false;
                    }
                    adaptador.Dispose();
                    comando.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar " + ex.Message);
                resultado = false;
            }
            MessageBox.Show(resultado.ToString());
        }
    }
}
