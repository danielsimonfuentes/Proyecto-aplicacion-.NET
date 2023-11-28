using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaIdiomas
{
    public partial class AdministracionEstudiantes : Form
    {
        public AdministracionEstudiantes()
        {
            InitializeComponent();
        }

        private void AdministracionEstudiantes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Estudiante.listaEstudiantes.Count; i++)
            {
                crearEtiqueta((Estudiante)Estudiante.listaEstudiantes[i], 50 + (i * 30), i);
            }
        }

        void crearEtiqueta(Estudiante estudiante, int posicion, int contadorNombre)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
           System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)
           (0)));
            checkBox.Location = new System.Drawing.Point(50, posicion);
            checkBox.Name = "lblCurso" + contadorNombre;
            checkBox.Size = new System.Drawing.Size(291, 20);
            checkBox.TabIndex = 1;
            checkBox.Tag = estudiante;
            checkBox.Text = estudiante.ToString();
            estudiantesPanel.Controls.Add(checkBox);
            posicion += 20;
            contadorNombre++;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void matricularBut_Click(object sender, EventArgs e)
        {
            MatriculacionEstudiante Form = new MatriculacionEstudiante();
            Form.Show();
            this.Hide();
            this.Dispose();
        }

        private void filtrarBut_Click(object sender, EventArgs e)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            String eleccion = idiomaComboBox.Text;
            for (int i = 0; i < Estudiante.listaEstudiantes.Count; i++)
            {
                if (Estudiante.listaEstudiantes[i].Idioma.Equals(eleccion))
                {
                    estudiantes.Add(Estudiante.listaEstudiantes[i]);
                }
            }
            
            estudiantesPanel.Controls.Clear();
            for (int i = 0; i < estudiantes.Count; i++)
            {
                crearEtiqueta(estudiantes[i], 50 + (i * 30), i);
            }
        }

        private void eliminarBut_Click(object sender, EventArgs e)
        {
            List<Estudiante> listaActual = new List<Estudiante>();
            foreach (Control control in estudiantesPanel.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    Estudiante est = Estudiante.listaEstudiantes.Find(p => p.ToString() == checkBox.Text);
                    if (checkBox.Checked)
                    {
                        
                         Estudiante.listaEstudiantes.Remove(est);
                        
                    }
                    else
                    {
                        listaActual.Add(est);
                    }
                }
                
            }
            estudiantesPanel.Controls.Clear();
            for (int i = 0; i < listaActual.Count; i++)
            {
                crearEtiqueta(listaActual[i], 50 + (i * 30), i);
            }
        }
    }
}
