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
    public partial class FormRegistro : Form
    {
        public FormRegistro()
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
            if (domicilioBox.Text == "")
            {
                domicilioBox.BackColor = Color.Red;
                validar = false;
            }
            else
            {
                domicilioBox.BackColor = Color.White;
            }
            if (nombreUsuarioBox.Text == "")
            {
                nombreUsuarioBox.BackColor = Color.Red;
                validar = false;
            }
            else
            {
                nombreUsuarioBox.BackColor = Color.White;
            }
            if (contrasena1Box.Text == "")
            {
                contrasena1Box.BackColor = Color.Red;
                validar = false;
            }
            else
            {
                contrasena1Box.BackColor = Color.White;
            }
            if (contrasena2Box.Text == "")
            {
                contrasena2Box.BackColor = Color.Red;
                validar = false;
            }
            else
            {
                contrasena2Box.BackColor = Color.White;
            }

            if (nombreUsuarioBox.Text == "" || compruebaNombreUsuario(nombreUsuarioBox.Text))
            {
                MessageBox.Show("Introduce un nombre de usuario válido");
                nombreUsuarioBox.Clear();
                contrasena1Box.Clear();
                contrasena2Box.Clear();
                validar = false;
            }
            if(contrasena1Box.Text != contrasena2Box.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                contrasena1Box.Clear();
                contrasena2Box.Clear();
                validar = false;
            }
            //cuando todos los campos se han rellenado correctamente
            if (validar)
            {
                Usuario.listaUsuarios.Add(new Usuario(nombreBox.Text, apellido1Box.Text, apellido2Box.Text, dniBox.Text, domicilioBox.Text, fechaNacDateTimePicker.Value,nombreUsuarioBox.Text,contrasena1Box.Text, false));
                ControladorUsuario.insertarUsuarioBBDD(nombreUsuarioBox.Text, nombreBox.Text, apellido1Box.Text, apellido2Box.Text, dniBox.Text, domicilioBox.Text, fechaNacDateTimePicker.Value, contrasena1Box.Text, false);
                this.Close();
            }
        }

        private bool compruebaNombreUsuario(String user)
        {
            bool ok = false;
            string connectionString = ControladorUsuario.construirCadenaConexión(); // Reemplaza con tu cadena de conexión
            string query = "SELECT * FROM Usuarios where Usuario='" + user + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ok = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ex.StackTrace}");
                }
                return ok;
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormInicioSesion Form = new FormInicioSesion();
            Form.Show();
        }
    }
}
