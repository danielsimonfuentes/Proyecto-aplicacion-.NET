using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public static void insertarUsuarioBBDD()
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\daniel\\Source\\Repos\\ProyectoInterfaces\\AcademiaIdiomas\\Academia.mdf;Integrated Security=True";
            // Query de inserción
            string query = "INSERT INTO Usuarios (Usuario, Nombre, Apellido1, Apellido2, Dni, Domicilio, FechaNac, Contrasena, Admin) VALUES(@Usuario, @Nombre, @Apellido1, @Apellido2, @Dni, @Domicilio, @FechaNac, @Contrasena, @Admin)";
            // Valores para los parámetros
            string descripcion = descripBox.Text;
            DateTime fechaInicio = fecIniDateTimePicker.Value;
            DateTime fechaFin = fecFinDateTimePicker.Value;
            string estado = "false";
            if (estadoCheckBox.Checked)
            {
                estado = "true";
            }
            double presupuestoInicial = Convert.ToDouble(preIniNumericUpDown.Text);
            double presupuestoFinal = Convert.ToDouble(preFinNumericUpDown.Text);
            string cambios = Convert.ToString(cambiosTextBox.Text);
            string codigoCliente = codCliNumericUpDown.Text;
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
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.Parameters.AddWithValue("@PresupuestoInicial",
                    presupuestoInicial);
                    command.Parameters.AddWithValue("@PresupuestoFinal",
                    presupuestoFinal);
                    command.Parameters.AddWithValue("@Cambios", cambios);
                    command.Parameters.AddWithValue("@CodigoCliente", codigoCliente);
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
    }
}
