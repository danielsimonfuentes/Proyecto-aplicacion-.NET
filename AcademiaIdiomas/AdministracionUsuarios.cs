﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace AcademiaIdiomas
{
    public partial class AdministracionUsuarios : Form
    {
        public AdministracionUsuarios()
        {
            InitializeComponent();
        }

        private void AdministracionUsuarios_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Usuario.listaUsuarios.Count; i++)
            {
                crearEtiqueta((Usuario)Usuario.listaUsuarios[i], 50 + (i * 30), i);
            }
        }

        void crearEtiqueta(Usuario user, int posicion, int contadorNombre)
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
            checkBox.Tag = user;
            checkBox.Text = user.ToString();
            usersGroupBox.Controls.Add(checkBox);
            posicion += 20;
            contadorNombre++;
        }

        private void eliminarBut_Click(object sender, EventArgs e)
        {
            foreach (Control control in usersGroupBox.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    Usuario user = Usuario.listaUsuarios.Find(p => p.ToString() == checkBox.Text);
                    if (checkBox.Checked)
                    {
                        if (user.Admin)
                        {
                            MessageBox.Show("No puedes eliminar administradores, prueba quitando el privilegio de administrador al usuario", "Eliminar un administrador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            Usuario.listaUsuarios.Remove(user);
                        }
                    }
                }
            }
            usersGroupBox.Controls.Clear();
            for (int i = 0; i < Usuario.listaUsuarios.Count; i++)
            {
                crearEtiqueta(Usuario.listaUsuarios[i], 50 + (i * 30), i);
            }
        }

        private void adminBut_Click(object sender, EventArgs e)
        {
            foreach (Control control in usersGroupBox.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    Usuario user = Usuario.listaUsuarios.Find(p => p.ToString() == checkBox.Text);
                    if (checkBox.Checked)
                    {
                        foreach (var item in Usuario.listaUsuarios)
                        {
                            if (item.Equals(user))
                            {
                                item.Admin = true;
                            }
                        }
                    }
                }
            }
            usersGroupBox.Controls.Clear();
            for (int i = 0; i < Usuario.listaUsuarios.Count; i++)
            {
                crearEtiqueta(Usuario.listaUsuarios[i], 50 + (i * 30), i);
            }
        }

        private void noadminBut_Click(object sender, EventArgs e)
        {
            foreach (Control control in usersGroupBox.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    Usuario user = Usuario.listaUsuarios.Find(p => p.ToString() == checkBox.Text);
                    if (checkBox.Checked)
                    {
                        foreach (var item in Usuario.listaUsuarios)
                        {
                            if (item.Equals(user))
                            {
                                item.Admin = false;
                            }
                        }
                    }
                }
            }
            usersGroupBox.Controls.Clear();
            for (int i = 0; i < Usuario.listaUsuarios.Count; i++)
            {
                crearEtiqueta(Usuario.listaUsuarios[i], 50 + (i * 30), i);
            }
        }
    }
}