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
    public partial class Registro : Form
    {
        public Registro()
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

            for(int i = 0; i < Usuario.listaUsuarios.Count; i++)
            {
                if (nombreUsuarioBox.Equals(Usuario.listaUsuarios[i]))
                {
                    MessageBox.Show("El usuario ya está usado, prueba a cambiarlo");
                    validar = false;
                }
            }
            if(contrasena1Box.Text != contrasena2Box.Text)
            {
                MessageBox.Show("Las contraseñas no coincidena");
                contrasena1Box.Clear();
                contrasena2Box.Clear();
                validar = false;
            }

            if (validar)
            {
                Usuario.listaUsuarios.Add(new Usuario(nombreBox.Text, apellido1Box.Text, apellido2Box.Text, dniBox.Text, domicilioBox.Text, fechaNacDateTimePicker.Value,nombreUsuarioBox.Text,contrasena1Box.Text));
                this.Close();
                InicioSesion Form = new InicioSesion();
                Form.ShowDialog();
            }
        }
    }
}
