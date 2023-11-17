using System;
using System.Collections.Generic;
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
    public class ControladorEstudiante
    {
        public static void escribirEstudiantesXML(List<Estudiante> lista, String archivo)
        {
            try
            {
                using (var writer = new StreamWriter(archivo))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(lista.GetType());
                    serializer.Serialize(writer, lista, namespaces);
                }
            }
            catch (Exception e) 
            {
                MessageBox.Show("Topota: " + e.Message);
            }

        }


        public static void leerEstudiantesXML(String archivo)
        {
            try
            {
                string xml = File.ReadAllText(archivo);
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new
                    XmlSerializer(Estudiante.listaEstudiantes.GetType());
                    Estudiante.listaEstudiantes = (List<Estudiante>)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }
        }

        public static void escribirEstudiantesJSON(List<Estudiante> lista, String archivo)
        {
            try
            {
                if (File.Exists(archivo))
                {
                    string jsonString = JsonSerializer.Serialize(lista);
                    File.WriteAllText(archivo, jsonString);
                }
            }
            catch (Exception e) { }
        }

        public static List<Estudiante> leerEstudiantesJSON(String archivo)
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            try
            {
                if (File.Exists(archivo))
                {
                    string jsonString = File.ReadAllText(archivo);
                    listaEstudiantes = JsonSerializer.Deserialize<List<Estudiante>>(jsonString);
                }
                foreach (var item in listaEstudiantes)
                {
                    Estudiante.listaEstudiantes.Add(item);
                }
            }
            catch (Exception e) { }
            return listaEstudiantes;
        }

        public static void leerEstudiantesBin(String archivo)
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            try
            {
                Stream OpenFileStream = File.OpenRead(archivo);
                BinaryFormatter deserializer = new BinaryFormatter();
                listaEstudiantes = (List<Estudiante>)deserializer.Deserialize(OpenFileStream);
                OpenFileStream.Close();

                foreach (var item in listaEstudiantes)
                {
                    Estudiante.listaEstudiantes.Add(item);
                }
            }
            catch (Exception e)
            { }
        }

        public static void escribirEstudiantesBin(List<Estudiante> lista, String archivo)
        {
            try
            {
                Stream SaveFileStream = File.Create(archivo);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, lista);
                SaveFileStream.Close();
            }
            catch (Exception e) { }

        }
    }
}
