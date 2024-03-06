using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaIdiomas
{
    public class ControladorUsuario
    {
        public static void leerUsuarioTXT()
        {
            Usuario.listaUsuarios.Clear();
            String line;
            try
            {
                StreamReader sr = new StreamReader("usuarios.txt");
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        String[] lista = line.Split(',');
                        if (lista.Length >= 9)
                        {
                            bool admin;
                            if (lista[8].Equals("True"))
                            {
                                admin = true;
                            }
                            else
                            {
                                admin = false;
                            }

                            Usuario.listaUsuarios.Add(new Usuario(lista[0], lista[1], lista[2], lista[3], lista[4], DateTime.Parse(lista[5]), lista[6], lista[7], admin));
                        }
                    }
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void escribirUsuarioTXT()
        {
            try
            {
                StreamWriter sw = new StreamWriter("usuarios.txt");
                foreach (var item in Usuario.listaUsuarios)
                {
                    sw.WriteLine(item.toString2());
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void insertarUsuarioBBDD(String Usuario, String Nombre, String Apellido1, String Apellido2, String Dni, String Domicilio, DateTime FechaNac, String Contrasena, bool Admin)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Usuarios (Usuario, Nombre, Apellido1, Apellido2, Dni, Domicilio, FechaNac, Contrasena, Admin) VALUES(@Usuario, @Nombre, @Apellido1, @Apellido2, @Dni, @Domicilio, @FechaNac, @Contrasena, @Admin)";
            
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
                    command.Parameters.AddWithValue("@Usuario", Usuario);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido1", Apellido1);
                    command.Parameters.AddWithValue("@Apellido2", Apellido2);
                    command.Parameters.AddWithValue("@Dni", Dni);
                    command.Parameters.AddWithValue("@Domicilio", Domicilio);
                    command.Parameters.AddWithValue("@FechaNac", FechaNac);
                    command.Parameters.AddWithValue("@Contrasena", Contrasena);
                    command.Parameters.AddWithValue("@Admin", Admin);
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
