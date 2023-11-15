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
            this.Close();
        }
        private int intentos = 0;
        
        private void acceptBut_Click(object sender, EventArgs e)
        {
            int posicion = Usuario.listaUsuarios.FindIndex(x => x.NombreUsuario == usuarioBox.Text.ToLower());
            if (posicion != -1 && (Usuario.listaUsuarios[posicion].Contrasena == contrasenaBox.Text))
            {
                usuarioBox.Clear();
                contrasenaBox.Clear();
                this.Close();
            }
            else
            {
                intentos++;
                MessageBox.Show("Usuario o contraseña incorrecta");
                usuarioBox.Clear();
                contrasenaBox.Clear();
                if (intentos >= 3)
                {
                    MessageBox.Show("Ya has agotado los tres intentos");
                    this.Close();
                }
                usuarioBox.Focus();
            }
        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal Form = new Principal(false);
            Form.Show();
        }
    }
}
