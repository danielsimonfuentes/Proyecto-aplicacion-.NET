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
    public partial class FrancesForm : Form
    {
        public FrancesForm()
        {
            InitializeComponent();
        }
        List<Estudiante> franceses = new List<Estudiante>();
        private void FrancesForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Estudiante.listaEstudiantes.Count; i++)
            {
                if (Estudiante.listaEstudiantes[i].Idioma.Equals("francés"))
                {
                    franceses.Add(Estudiante.listaEstudiantes[i]);
                }
            }
            for (int i = 0; i < franceses.Count; i++)
            {
                crearEtiqueta((Estudiante)franceses[i], 80 + (i * 30), i);
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
            francesGroupBox.Controls.Add(GrupoLbl);
            posicion += 20;
            contadorNombre++;
        }

        private void ImprimirBut_Click(object sender, EventArgs e)
        {
            ControladorEstudiante.escribirEstudiantesXML(franceses,"franceses.xml");
            ControladorEstudiante.escribirEstudiantesJSON(franceses, "franceses.json");
            ControladorEstudiante.escribirEstudiantesBin(franceses, "franceses.bin");
        }

        private void ordenarApebut_Click(object sender, EventArgs e)
        {
            this.francesGroupBox.Controls.Clear();
            List<Estudiante> ordenadosDesc = franceses.OrderBy(x => x.Apellido1).ToList();
            for (int i = 0; i < ordenadosDesc.Count; i++)
            {
                crearEtiqueta((Estudiante)ordenadosDesc[i], 80 + (i * 30), i);
            }
        }

        private void ordenarClassBut_Click(object sender, EventArgs e)
        {
            this.francesGroupBox.Controls.Clear();
            List<Estudiante> ordenadosDesc = franceses.OrderBy(x => x.Clase).ToList();
            for (int i = 0; i < ordenadosDesc.Count; i++)
            {
                crearEtiqueta((Estudiante)ordenadosDesc[i], 80 + (i * 30), i);
            }
        }
    }
}
