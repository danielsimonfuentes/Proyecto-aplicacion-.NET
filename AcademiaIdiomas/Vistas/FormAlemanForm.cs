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
    public partial class FormAlemanForm : Form
    {
        public FormAlemanForm()
        {
            InitializeComponent();
        }
        List<Estudiante> alemanes = new List<Estudiante>();
        private void AlemanForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Estudiante.listaEstudiantes.Count; i++)
            {
                //forma una lista nueva eligiendo a los estudiantes que tengan como atributo de idioma "alemán"
                if (Estudiante.listaEstudiantes[i].Idioma.Equals("alemán"))
                {
                    alemanes.Add(Estudiante.listaEstudiantes[i]);
                }
            }
            for (int i = 0; i < alemanes.Count; i++)
            {
                crearEtiqueta((Estudiante)alemanes[i], 80 + (i * 30), i);
            }
        }

        void crearEtiqueta(Estudiante estudiante, int posicion, int contadorNombre)
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
            GrupoLbl.Tag = estudiante;
            GrupoLbl.Text = estudiante.ToString();
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
            this.alemanGroupBox.Controls.Clear();
            List<Estudiante> ordenadosDesc = alemanes.OrderBy(x => x.Apellido1).ToList();
            for (int i = 0; i < ordenadosDesc.Count; i++)
            {
                crearEtiqueta((Estudiante)ordenadosDesc[i], 80 + (i * 30), i);
            }
        }

        //ordenar por orden alfabético las clases
        private void ordenarClassBut_Click(object sender, EventArgs e)
        {
            this.alemanGroupBox.Controls.Clear();
            List<Estudiante> ordenadosDesc = alemanes.OrderBy(x => x.Clase).ToList();
            for (int i = 0; i < ordenadosDesc.Count; i++)
            {
                crearEtiqueta((Estudiante)ordenadosDesc[i], 80 + (i * 30), i);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
