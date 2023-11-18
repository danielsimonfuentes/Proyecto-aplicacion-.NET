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

        private void cerrarSesionLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
