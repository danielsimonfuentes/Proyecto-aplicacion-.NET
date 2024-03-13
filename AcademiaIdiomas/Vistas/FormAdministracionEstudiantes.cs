using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaIdiomas
{
    public partial class FormAdministracionEstudiantes : Form
    {
        public FormAdministracionEstudiantes()
        {
            InitializeComponent();
        }

        private void AdministracionEstudiantes_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView("SELECT * FROM Estudiantes");
        }

        private void CargarDatosEnDataGridView(String q)
        {
            string connectionString = ControladorUsuario.construirCadenaConexión(); // Reemplaza con tu cadena de conexión
            // En este caso, solo realiza un select del campo CódigoProyecto y nombreProyecto
            // Sería necesario adaptarlo si queremos todos los campos de un proyecto.
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("DNI", "DNI");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido1", "Apellido1");
            dataGridView1.Columns.Add("Apellido2", "Apellido2");
            dataGridView1.Columns.Add("Edad", "Edad");
            dataGridView1.Columns.Add("Idioma", "Idioma");
            dataGridView1.Columns.Add("Clase", "Clase");
            string query = q;
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
                                dataGridView1.Rows.Add(reader["DNI"].ToString(), reader["Nombre"].ToString(), reader["Apellido1"].ToString(), reader["Apellido2"].ToString(), reader["Edad"].ToString(), reader["Idioma"].ToString(), reader["Clase"].ToString());
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void matricularBut_Click(object sender, EventArgs e)
        {
            FormMatriculacionEstudiante Form = new FormMatriculacionEstudiante();
            Form.Show();
            this.Hide();
            this.Dispose();
        }

        //para filtrar por el idioma elegido en el comboBox
        private void filtrarBut_Click(object sender, EventArgs e)
        {
            String eleccion = idiomaComboBox.Text;
            if (eleccion != "inglés" && eleccion != "francés" && eleccion != "alemán")
            {
                MessageBox.Show("No puedes filtrar por ese campo, pueba a escoger otro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CargarDatosEnDataGridView("SELECT * FROM Estudiantes where Idioma='" + eleccion + "'");
            }
        }

        private void eliminarBut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                int registrosAfectados;
                try
                {
                    using (SqlConnection cnn = new SqlConnection(ControladorUsuario.construirCadenaConexión()))
                    {
                        cnn.Open();

                        SqlCommand comando = cnn.CreateCommand();
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "DELETE FROM Estudiantes WHERE DNI='" + dataGridView1.SelectedRows[0].Cells["DNI"].Value.ToString() + "'";
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
                        CargarDatosEnDataGridView("SELECT * FROM Estudiantes");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Solo puedes seleccionar un estudiante", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                Form form = new FormModificarEstudiante(dataGridView1.SelectedRows[0].Cells["DNI"].Value.ToString());
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Solo puedes seleccionar un estudiante", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
