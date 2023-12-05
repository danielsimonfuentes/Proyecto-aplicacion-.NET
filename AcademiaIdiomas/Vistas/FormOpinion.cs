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
    public partial class FormOpinion : Form
    {
        public FormOpinion()
        {
            InitializeComponent();
        }
        
        private void Opinion_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < FormInicioSesion.getOpiniones().Count; i++)
            {
                crearEtiqueta(FormInicioSesion.getOpiniones()[i], 50 + (i * 30), i);
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
            opinionesGroupBox.Controls.Add(GrupoLbl);
            posicion += 20;
            contadorNombre++;
        }

        private void publicarBut_Click(object sender, EventArgs e)
        {
            if (opinionTextBox.Text.Equals(""))
            {
                MessageBox.Show("¡Prueba escribiendo tu opinión!", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                opinionTextBox.Focus();
            }
            else
            {
                opinionesGroupBox.Controls.Clear();
                List<String> lista = ponerPrimero(opinionTextBox.Text);
                for (int i = 0; i < lista.Count; i++)
                {
                    crearEtiqueta(lista[i], 50 + (i * 30), i);
                }
                opinionTextBox.Clear();
            }
        }

        //recibe la opinión recién publicada y la pone la primera desplazando los demás elementos una posición
        private List<String> ponerPrimero(String op1)
        {
            List<String> list = new List<String>();
            list.Add(op1);
            for (int i = 0; i < FormInicioSesion.getOpiniones().Count; i++)
            {
                list.Add(FormInicioSesion.getOpiniones()[i]);
            }
            FormInicioSesion.setOpiniones(list);
            return list;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
