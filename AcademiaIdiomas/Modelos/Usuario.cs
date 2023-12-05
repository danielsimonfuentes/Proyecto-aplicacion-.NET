using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaIdiomas
{
    public class Usuario
    {
        private String nombre;
        private String apellido1; 
        private String apellido2;
        private String dni;
        private String domicilio;
        private DateTime fechaNac;
        private String nombreUsuario;
        private String contrasena;
        private bool admin;
        
        public static List<Usuario> usuarioActual = new List<Usuario>();

        public static List<Usuario> listaUsuarios = new List<Usuario>();

        public Usuario(string nombre, string apellido1, string apellido2, string dni, string domicilio, DateTime fechaNac, string usuario, string contrasena, bool admin)
        {
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Dni = dni;
            this.Domicilio = domicilio;
            this.FechaNac = fechaNac;
            this.nombreUsuario = usuario;
            this.Contrasena = contrasena;
            this.Admin = admin;
        }
        public Usuario()
        {

        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public bool Admin { get => admin; set => admin = value; }

        public override String ToString()
        {
            String administrador = "";
            if (admin)
            {
                administrador = " -> ADMIN";
            }
            return (nombreUsuario + " - " + nombre + " " + apellido1 + " " + apellido2 + " " + dni + administrador);
        }

        public String toString2()
        {
            return (nombre + "," + apellido1 + "," + apellido2 + "," + dni + "," + domicilio + "," + fechaNac + "," + nombreUsuario + "," + contrasena + "," + admin);
        }

    }

}
