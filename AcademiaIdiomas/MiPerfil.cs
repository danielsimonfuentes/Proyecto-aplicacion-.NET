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
    public partial class MiPerfil : Form
    {
        public MiPerfil()
        {
            InitializeComponent();
        }

        private void MiPerfil_Load(object sender, EventArgs e)
        {
            crearEtiqueta(Usuario.usuarioActual[0].Nombre + " " + Usuario.usuarioActual[0].Apellido1 + " " + Usuario.usuarioActual[0].Apellido2, 50 + (0 * 30), 0, datosGroupBox);
            crearEtiqueta("DNI: " + Usuario.usuarioActual[0].Dni, 80 + (1 * 30), 1, datosGroupBox);
            crearEtiqueta("Domicilio: " + Usuario.usuarioActual[0].Domicilio, 80 + (2 * 30), 2, datosGroupBox);
            crearEtiqueta("Fecha de nacimiento: " + Usuario.usuarioActual[0].FechaNac.ToString(), 80 + (3 * 30), 3, datosGroupBox);
            
            if (Usuario.usuarioActual[0].Admin)
            {
                crearBoton(80 + (6 * 30));
            }
            
            crearEtiqueta("Usuario: " + Usuario.usuarioActual[0].NombreUsuario, 20 + (0 * 30), 0, perfilGroupBox);
        }

        void crearEtiqueta(String texto, int posicion, int contadorNombre, GroupBox groupBox)
        {
            Label LblPerfil = new System.Windows.Forms.Label();
            LblPerfil.AutoSize = true;
            LblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            LblPerfil.Location = new System.Drawing.Point(50, posicion);
            LblPerfil.Name = "LblPerfil" + contadorNombre;
            LblPerfil.Size = new System.Drawing.Size(291, 20);
            LblPerfil.TabIndex = 1;
            LblPerfil.Text = texto;
            groupBox.Controls.Add(LblPerfil);
        }

        void crearBoton(int posicion)
        {
            Button button = new System.Windows.Forms.Button();
            button.AutoSize = true;
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            button.Location = new System.Drawing.Point(50, posicion);
            button.Name = "Button";
            button.Size = new System.Drawing.Size(291, 20);
            button.TabIndex = 1;
            button.Text = "Administración";
            datosGroupBox.Controls.Add(button);
        }

        

        private void Button_Click(object sender, EventArgs e)
        {
            Administracion Form = new Administracion();
            Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Usuario.usuarioActual[0].Admin)
            {
                Administracion Form = new Administracion();
                Form.Show();
            }
            else
            {
                MessageBox.Show("No puedes acceder a esta función si no eres administrador", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
