using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public static void insertarEstudianteBBDD(String Dni, String Nombre, String Apellido1, String Apellido2, int Edad, String Idioma, String Clase)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Estudiantes (DNI, Nombre, Apellido1, Apellido2, Edad, Idioma, Clase) VALUES(@DNI, @Nombre, @Apellido1, @Apellido2, @Edad, @Idioma, @Clase)";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    // No se añade a la inserción el campo código proyecto porque es autonumérico, aunque se puede configurar para poder
                    // insertarlo a la fuerza.
                    command.Parameters.AddWithValue("@DNI", Dni);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido1", Apellido1);
                    command.Parameters.AddWithValue("@Apellido2", Apellido2);
                    command.Parameters.AddWithValue("@Edad", Edad);
                    command.Parameters.AddWithValue("@Idioma", Idioma);
                    command.Parameters.AddWithValue("@Clase", Clase);
                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el registro: {ex.Message}");
                    }
                }
            }
        }

        public static string construirCadenaConexión()
        {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            // A diferencia de la anterior version, forzamos a que coja la ruta relativa con el
            // Path.GetFullPath
            string databaseFileName =
            Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Academia.mdf"));
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;
        }
    }
}
