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
            this.Hide();
            this.Dispose();
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
                this.Hide();
                this.Dispose();
            }
            else
            {
                intentos++;
                MessageBox.Show("Usuario o contraseña incorrecta", "Revisa el suario o contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usuarioBox.Clear();
                contrasenaBox.Clear();
                if (intentos >= 3)
                {
                    MessageBox.Show("Ya has agotado los tres intentos", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                usuarioBox.Focus();
            }
        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal Form = new Principal();
            Form.Show();
        }

        private void InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void accederBut_Click(object sender, EventArgs e)
        {
            Principal Form = new Principal();
            Form.Show();
            this.Hide();
            this.Dispose();
        }
        //para controlar cuantas veces se ha cargado el formulario y cargar así solo una vez los estudiantes, usuarios y opiniones
        private static int vecesCargado = 0;
        private void InicioSesion_Load(object sender, EventArgs e)
        {
            usuarioBox.Focus();
            if(vecesCargado == 0)
            {
                cargarOpiniones();
                //cargarUsuarios();
                //cargarEstudiantes();
                //ControladorUsuario.escribirUsuarioTXT();
                ControladorUsuario.leerUsuarioTXT();
                ControladorEstudiante.leerEstudiantesXML("ingleses.xml");
                ControladorEstudiante.leerEstudiantesJSON("franceses.json");
                ControladorEstudiante.leerEstudiantesBin("alemanes.bin");
                vecesCargado++;
            }
            
        }
        public static List<String> opiniones = new List<String>();

        public static List<String> getOpiniones()
        {
            return opiniones;
        }
        public static void setOpiniones(List<String> lista)
        {
            opiniones = lista;
        }

        private void cargarOpiniones()
        {
            opiniones.Clear();
            opiniones.Add("Me encanta la profesionalidad de esta página web");
            opiniones.Add("Estuve estudiando hace tiempo y me dieron un trato excelente");
            opiniones.Add("Ofrecen clases ajustadas a tu nivel, muy recomendado");
            opiniones.Add("Los profesores son muy buenos, adaptan sus clases a tus cocimientos");
            opiniones.Add("Tienen una página web muy atrayente seguro que los profesores de interfaces estarían orgullosos");
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

        public void cargarEstudiantes()
        {
            Estudiante.listaEstudiantes.Add(new Estudiante("87654321D", "María", "López", "González", 22, "francés", "B1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("11112222R", "Pedro", "Martínez", "Fernández", 21, "alemán", "C1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("99998888Q", "Ana", "Rodríguez", "Sánchez", 23, "inglés", "A1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("55556666J", "Carlos", "García", "Muñoz", 19, "inglés", "B2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("12345678P", "Juan", "Pérez", "Gómez", 20, "inglés", "A2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("78901234L", "Laura", "Fernández", "Santos", 24, "francés", "C2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("23456789K", "Diego", "Gutiérrez", "Jiménez", 22, "francés", "B2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("34567890S", "Isabel", "Hernández", "Ortega", 20, "alemán", "A2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("45678901A", "Fernando", "Mendoza", "Luna", 21, "inglés", "B1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("56789012C", "Elena", "Ortiz", "Silva", 23, "francés", "C1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("67890123B", "Lucía", "Cruz", "Rojas", 22, "inglés", "A2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("78901234V", "Juan", "Gómez", "Santos", 20, "alemán", "B1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("89012345N", "Marta", "Ferrer", "López", 24, "francés", "C2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("90123456R", "Sergio", "Sánchez", "Jiménez", 21, "inglés", "A1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("12345098T", "Paula", "Martínez", "Herrera", 23, "alemán", "B2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("23450987Y", "Javier", "Vega", "Navarro", 22, "francés", "C1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("34509876Z", "Rocío", "González", "Díaz", 20, "francés", "A2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("45698765G", "Alberto", "Ruíz", "Blanco", 21, "alemán", "B1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("56787654H", "Natalia", "Serrano", "Gálvez", 23, "francés", "C2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("67876543M", "Mario", "Fernández", "Romero", 24, "alemán", "A1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("98765432U", "Luis", "Gómez", "Pérez", 25, "alemán", "C1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("22223333I", "Silvia", "Herrera", "Torres", 19, "alemán", "A2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("77778888O", "Raúl", "Fernández", "Martínez", 22, "francés", "B1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("88887777F", "Carmen", "García", "Rodríguez", 20, "inglés", "C2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("13579246X", "Antonio", "Sánchez", "López", 23, "alemán", "A1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("24681357B", "Eva", "Martínez", "Gómez", 21, "francés", "B2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("65432109W", "Roberto", "González", "Hernández", 24, "inglés", "A1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("78901234Q", "Nuria", "Ortiz", "Serrano", 20, "alemán", "C1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("32109876J", "Miguel", "Ruíz", "Díaz", 22, "inglés", "B2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("98761234S", "Sara", "Gómez", "Fernández", 23, "francés", "C2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("13579135L", "Marina", "López", "García", 21, "alemán", "C2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("24680246J", "Daniel", "Fernández", "Martínez", 22, "inglés", "A1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("98765439A", "Adriana", "García", "Rodríguez", 20, "francés", "B2"));
            Estudiante.listaEstudiantes.Add(new Estudiante("35791357R", "Roberto", "Sánchez", "Ortega", 23, "inglés", "C1"));
            Estudiante.listaEstudiantes.Add(new Estudiante("46812468E", "Laura", "Gómez", "Muñoz", 21, "inglés", "A2"));
            /*Antonio,Rodriguez,García,12345678A,Calle Cualquiera 1,6/2/1980 12:00:00 AM,antonio,antonio,false
            Julio,Sanchez,Moreno,87651234B,Calle Cualquiera 2,29/9/1980 12:00:00 AM,julio,julio,false
            José,González,Ruiz,43215678C,Calle Cualquiera 3,22/12/1980 12:00:00 AM,jose,jose,false
            Luis,Lopez,Martinez,56781234D,Calle Cualquiera 4,11/7/1980 12:00:00 AM,luis,luis,false
            Fernando,Marcos,Martín,87654321E,Calle Cualquiera 5,17/8/1986 12:00:00 AM,fernando,fernando,true
            Daniel,Simón,Fuentes,12348765F,Calle Cualquiera 6,9/3/2004 12:00:00 AM,daniel,daniel,true*/
        }


    }
}
