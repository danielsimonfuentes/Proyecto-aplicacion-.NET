using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace AcademiaIdiomas
{
    public partial class FormAdministracionUsuarios : Form
    {
        public FormAdministracionUsuarios()
        {
            InitializeComponent();
        }

        private void AdministracionUsuarios_Load(object sender, EventArgs e)
        { 
            CargarDatosEnDataGridView();
        }

        private void CargarDatosEnDataGridView()
        {
            string connectionString = ControladorUsuario.construirCadenaConexión(); // Reemplaza con tu cadena de conexión
            // En este caso, solo realiza un select del campo CódigoProyecto y nombreProyecto
            // Sería necesario adaptarlo si queremos todos los campos de un proyecto.
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Usuario", "Usuario");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido1", "Apellido1");
            dataGridView1.Columns.Add("Apellido2", "Apellido2");
            dataGridView1.Columns.Add("DNI", "DNI");
            dataGridView1.Columns.Add("Domicilio", "Domicilio");
            dataGridView1.Columns.Add("Fecha Nacimiento", "Fecha Nacimiento");
            dataGridView1.Columns.Add("Admin", "Admin");
            string query = "SELECT * FROM Usuarios";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregar una nueva fila al DataGridView con el código y el nombre del proyecto
                                dataGridView1.Rows.Add(reader["Usuario"].ToString(), reader["Nombre"].ToString(), reader["Apellido1"].ToString(), reader["Apellido2"].ToString(), reader["Dni"].ToString(), reader["Domicilio"].ToString(), reader["FechaNac"].ToString(), reader["Admin"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ex.StackTrace}");
                }
            }
        }

        private void eliminarBut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (!dataGridView1.SelectedRows[0].Cells["Usuario"].Value.ToString().Equals(Usuario.usuarioActual[0].NombreUsuario))
                {
                    int registrosAfectados;
                    try
                    {
                        using (SqlConnection cnn = new SqlConnection(ControladorUsuario.construirCadenaConexión()))
                        {
                            cnn.Open();

                            SqlCommand comando = cnn.CreateCommand();
                            comando.CommandType = CommandType.Text;
                            comando.CommandText = "DELETE FROM Usuarios WHERE Usuario='" + dataGridView1.SelectedRows[0].Cells["Usuario"].Value.ToString() + "'";
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.DeleteCommand = comando;
                            if ((registrosAfectados = adaptador.DeleteCommand.ExecuteNonQuery()) == 0)
                            {
                                MessageBox.Show($"No se pudo eliminar. Registros afectados: {registrosAfectados}");
                            }
                            else
                            {
                                MessageBox.Show($"Se eliminó correctamente el registro. Registros afectados: {registrosAfectados}");
                            }

                            adaptador.Dispose();
                            comando.Dispose();
                            dataGridView1.Controls.Clear();
                            CargarDatosEnDataGridView();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al eliminar " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No puedes hacer esta acción con tu propio usuario", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Solo puedes seleccionar un usuario", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void adminBut_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                bool resultado = true;
                try
                {
                    using (SqlConnection cnn = new SqlConnection(ControladorUsuario.construirCadenaConexión()))
                    {
                        cnn.Open();
                        SqlCommand comando = cnn.CreateCommand();
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "UPDATE Usuarios SET Admin='True' WHERE Usuario ='" + dataGridView1.SelectedRows[0].Cells["Usuario"].Value.ToString() + "'";
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.UpdateCommand = comando;
                        if (adaptador.UpdateCommand.ExecuteNonQuery() == 0)
                        {
                            resultado = false;
                        }
                        adaptador.Dispose();
                        comando.Dispose();
                        dataGridView1.Controls.Clear();
                        CargarDatosEnDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar " + ex.Message);
                    resultado = false;
                }
                MessageBox.Show(resultado.ToString());
            }
            else
            {
                MessageBox.Show("Solo puedes seleccionar un usuario", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void noadminBut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (!dataGridView1.SelectedRows[0].Cells["Usuario"].Value.ToString().Equals(Usuario.usuarioActual[0].NombreUsuario))
                {
                    bool resultado = true;
                    try
                    {

                        using (SqlConnection cnn = new SqlConnection(ControladorUsuario.construirCadenaConexión()))
                        {
                            cnn.Open();
                            SqlCommand comando = cnn.CreateCommand();
                            comando.CommandType = CommandType.Text;
                            comando.CommandText = "UPDATE Usuarios SET Admin='False' WHERE Usuario ='" + dataGridView1.SelectedRows[0].Cells["Usuario"].Value.ToString() + "'";
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.UpdateCommand = comando;
                            if (adaptador.UpdateCommand.ExecuteNonQuery() == 0)
                            {
                                resultado = false;
                            }
                            adaptador.Dispose();
                            comando.Dispose();
                            dataGridView1.Controls.Clear();
                            CargarDatosEnDataGridView();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al actualizar " + ex.Message);
                        resultado = false;
                    }
                    MessageBox.Show(resultado.ToString());
                }
                else
                {
                    MessageBox.Show("No puedes hacer esta acción con tu propio usuario", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Solo puedes seleccionar un usuario", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
