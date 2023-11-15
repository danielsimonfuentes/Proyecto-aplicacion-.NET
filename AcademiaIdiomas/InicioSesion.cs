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
                PrincipalSesion Form = new PrincipalSesion(usuarioBox.Text);
                Form.Show();
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

        }

        private void accederBut_Click(object sender, EventArgs e)
        {
            Principal Form = new Principal();
            Form.Show();
            this.Close();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void cargarUsuarios()
        {
            Usuario.listaUsuarios.Add(new Usuario("Antonio", "Rodriguez", "García", "12345678A", "Calle Cualquiera 1", DateTime.Parse("6/2/1980 12:00:00 AM"), "antonio", "antonio", false));
            Usuario.listaUsuarios.Add(new Usuario("Julio", "Sanchez", "Moreno", "87651234B", "Calle Cualquiera 2", DateTime.Parse("29/9/1980 12:00:00 AM"), "julio", "julio", false));
            Usuario.listaUsuarios.Add(new Usuario("José", "González", "Ruiz", "43215678C", "Calle Cualquiera 3", DateTime.Parse("22/12/1980 12:00:00 AM"), "jose", "jose", false));
            Usuario.listaUsuarios.Add(new Usuario("Luis", "Lopez", "Martinez", "56781234D", "Calle Cualquiera 4", DateTime.Parse("11/7/1980 12:00:00 AM"), "luis", "luis", false));
            Usuario.listaUsuarios.Add(new Usuario("Fernando", "Marcos", "Martín", "87654321E", "Calle Cualquiera 5", DateTime.Parse("17/8/1986 12:00:00 AM"), "fernando", "fernando", true));
            Usuario.listaUsuarios.Add(new Usuario("Daniel", "Simón", "Fuentes", "12348765F", "Calle Cualquiera 6", DateTime.Parse("9/3/2004 12:00:00 AM"), "daniel", "daniel", true));
        }
    }
}
