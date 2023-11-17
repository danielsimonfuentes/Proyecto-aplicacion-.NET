using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

                Usuario.usuarioActual.Add(Usuario.listaUsuarios[posicion]);
                   
                PrincipalSesion Form = new PrincipalSesion();
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
            //cargarEstudiantes();
            ControladorEstudiante.leerEstudiantesXML("ingleses.xml");
            ControladorEstudiante.leerEstudiantesJSON("franceses.json");
            ControladorEstudiante.leerEstudiantesBin("alemanes.bin");
        }

        public void cargarUsuarios()
        {
            Usuario.listaUsuarios.Add(new Usuario("Antonio", "Rodriguez", "García", "12345678A", "Calle Cualquiera 1", DateTime.Parse("6/2/1980 12:00:00 AM"), "antonio", "antonio", false));
            Usuario.listaUsuarios.Add(new Usuario("Julio", "Sanchez", "Moreno", "87651234B", "Calle Cualquiera 2", DateTime.Parse("29/9/1980 12:00:00 AM"), "julio", "julio", false));
            Usuario.listaUsuarios.Add(new Usuario("José", "González", "Ruiz", "43215678C", "Calle Cualquiera 3", DateTime.Parse("22/12/1980 12:00:00 AM"), "jose", "jose", false));
            Usuario.listaUsuarios.Add(new Usuario("Luis", "Lopez", "Martinez", "56781234D", "Calle Cualquiera 4", DateTime.Parse("11/7/1980 12:00:00 AM"), "luis", "luis", false));
            Usuario.listaUsuarios.Add(new Usuario("Fernando", "Marcos", "Martín", "87654321E", "Calle Cualquiera 5", DateTime.Parse("17/8/1986 12:00:00 AM"), "fernando", "fernando", true));
            Usuario.listaUsuarios.Add(new Usuario("Daniel", "Simón", "Fuentes", "12348765F", "Calle Cualquiera 6", DateTime.Parse("9/3/2004 12:00:00 AM"), "daniel", "daniel", true));
        }

        public static void cargarEstudiantes()
        {
            Estudiante.listaEstudiantes.Add(new Estudiante(87654321, "María", "López", "González", 22, "francés", "B1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(11112222, "Pedro", "Martínez", "Fernández", 21, "alemán", "C1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(99998888, "Ana", "Rodríguez", "Sánchez", 23, "inglés", "A1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(55556666, "Carlos", "García", "Muñoz", 19, "inglés", "B2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(12345678, "Juan", "Pérez", "Gómez", 20, "inglés", "A2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(78901234, "Laura", "Fernández", "Santos", 24, "francés", "C2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(23456789, "Diego", "Gutiérrez", "Jiménez", 22, "francés", "B2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(34567890, "Isabel", "Hernández", "Ortega", 20, "alemán", "A2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(45678901, "Fernando", "Mendoza", "Luna", 21, "inglés", "B1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(56789012, "Elena", "Ortiz", "Silva", 23, "francés", "C1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(67890123, "Lucía", "Cruz", "Rojas", 22, "inglés", "A2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(78901234, "Juan", "Gómez", "Santos", 20, "alemán", "B1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(89012345, "Marta", "Ferrer", "López", 24, "francés", "C2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(90123456, "Sergio", "Sánchez", "Jiménez", 21, "inglés", "A1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(12345098, "Paula", "Martínez", "Herrera", 23, "alemán", "B2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(23450987, "Javier", "Vega", "Navarro", 22, "francés", "C1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(34509876, "Rocío", "González", "Díaz", 20, "francés", "A2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(45698765, "Alberto", "Ruíz", "Blanco", 21, "alemán", "B1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(56787654, "Natalia", "Serrano", "Gálvez", 23, "francés", "C2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(67876543, "Mario", "Fernández", "Romero", 24, "alemán", "A1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(98765432, "Luis", "Gómez", "Pérez", 25, "alemán", "C1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(22223333, "Silvia", "Herrera", "Torres", 19, "alemán", "A2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(77778888, "Raúl", "Fernández", "Martínez", 22, "francés", "B1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(88887777, "Carmen", "García", "Rodríguez", 20, "inglés", "C2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(13579246, "Antonio", "Sánchez", "López", 23, "alemán", "A1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(24681357, "Eva", "Martínez", "Gómez", 21, "francés", "B2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(65432109, "Roberto", "González", "Hernández", 24, "inglés", "A1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(78901234, "Nuria", "Ortiz", "Serrano", 20, "alemán", "C1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(32109876, "Miguel", "Ruíz", "Díaz", 22, "inglés", "B2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(98761234, "Sara", "Gómez", "Fernández", 23, "francés", "C2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(13579135, "Marina", "López", "García", 21, "alemán", "C2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(24680246, "Daniel", "Fernández", "Martínez", 22, "inglés", "A1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(98765439, "Adriana", "García", "Rodríguez", 20, "francés", "B2"));
            Estudiante.listaEstudiantes.Add(new Estudiante(35791357, "Roberto", "Sánchez", "Ortega", 23, "inglés", "C1"));
            Estudiante.listaEstudiantes.Add(new Estudiante(46812468, "Laura", "Gómez", "Muñoz", 21, "inglés", "A2"));
        }

        
    }
}
