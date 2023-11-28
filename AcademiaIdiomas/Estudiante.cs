using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaIdiomas
{
    [Serializable]
    public class Estudiante
    {
        private String dni;
        private String nombre;
        private String apellido1;
        private String apellido2;
        private int edad;
        private String idioma;
        private String clase;

        public Estudiante()
        {

        }
        public Estudiante(String dni, string nombre, string apellido1, string apellido2, int edad, string idioma, string clase)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Edad = edad;
            this.Idioma = idioma;
            this.Clase = clase;
        }

        public String Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Idioma { get => idioma; set => idioma = value; }
        public string Clase { get => clase; set => clase = value; }

        public static List<Estudiante> listaEstudiantes = new List<Estudiante>();

        public override String ToString()
        {
            return ("DNI: " + this.Dni + " - " + this.Apellido1 + " " + this.Apellido2 + ", " + this.Nombre + " ---> " + this.Idioma + ", " + this.Clase);
        }
    }

    
}
