﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaIdiomas
{
    public partial class FormAlemanForm : Form
    {
        public FormAlemanForm()
        {
            InitializeComponent();
        }
        List<Estudiante> alemanes = new List<Estudiante>();
        private void AlemanForm_Load(object sender, EventArgs e)
        {
            CargarDatosEnGroupBox("SELECT * FROM Estudiantes where Idioma = 'Alemán'");
        }
        private void CargarDatosEnGroupBox(String q)
        {
            alemanGroupBox.Controls.Clear();
            string connectionString = ControladorEstudiante.construirCadenaConexión(); // Reemplaza con tu cadena de conexión
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
                            int i = 0;
                            while (reader.Read())
                            {
                                crearEtiqueta("DNI: " + reader["DNI"] + ". " + reader["Nombre"] + " " + reader["Apellido1"] + " " + reader["Apellido2"] + " -> " + reader["Idioma"] + ", " + reader["Clase"], 80 + (i * 30), i);
                                i++;
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

        void crearEtiqueta(String texto, int posicion, int contadorNombre)
        {
            Label GrupoLbl = new System.Windows.Forms.Label();
            GrupoLbl.AutoSize = true;
            GrupoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
           System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)
           (0)));
            GrupoLbl.Location = new System.Drawing.Point(75, posicion);
            GrupoLbl.Name = "lblCurso" + contadorNombre;
            GrupoLbl.Size = new System.Drawing.Size(291, 20);
            GrupoLbl.TabIndex = 1;
            GrupoLbl.Tag = texto;
            GrupoLbl.Text = texto;
            alemanGroupBox.Controls.Add(GrupoLbl);
            posicion += 20;
            contadorNombre++;
        }

        private void ImprimirBut_Click(object sender, EventArgs e)
        {
            ControladorEstudiante.escribirEstudiantesXML(alemanes, "alemanes.xml");
            ControladorEstudiante.escribirEstudiantesJSON(alemanes, "alemanes.json");
            ControladorEstudiante.escribirEstudiantesBin(alemanes, "alemanes.bin");
        }

        //ordenar por orden alfabético los apellidos
        private void ordenarApebut_Click(object sender, EventArgs e)
        {
            CargarDatosEnGroupBox("SELECT * FROM Estudiantes where Idioma = 'Alemán' order by Apellido1");
        }

        //ordenar por orden alfabético las clases
        private void ordenarClassBut_Click(object sender, EventArgs e)
        {
            CargarDatosEnGroupBox("SELECT * FROM Estudiantes where Idioma = 'Alemán' order by Clase");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
