﻿using System;
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
    public partial class PrincipalSesion : Form
    {
        private String user;
        public PrincipalSesion(string user)
        {
            this.user = user;
            InitializeComponent();

        }

        private void PrincipalSesion_Load(object sender, EventArgs e)
        {
            
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiPerfil Form = new MiPerfil();
            Form.Show();
        }
        private bool confirma = false;
        private void PrincipalSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!confirma)
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar el programa?", "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogo == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    confirma = true;
                    Application.Exit();

                }
            }
        }
    }
}