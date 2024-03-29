﻿namespace AcademiaIdiomas
{
    partial class FormInicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            this.acceptBut = new System.Windows.Forms.Button();
            this.usuarioBox = new System.Windows.Forms.TextBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.contrasenaLabel = new System.Windows.Forms.Label();
            this.contrasenaBox = new System.Windows.Forms.TextBox();
            this.inicioLabel = new System.Windows.Forms.Label();
            this.cancelBut = new System.Windows.Forms.Button();
            this.registroLabel = new System.Windows.Forms.Label();
            this.registrateLink = new System.Windows.Forms.LinkLabel();
            this.accederBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acceptBut
            // 
            this.acceptBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBut.Location = new System.Drawing.Point(84, 262);
            this.acceptBut.Name = "acceptBut";
            this.acceptBut.Size = new System.Drawing.Size(103, 36);
            this.acceptBut.TabIndex = 2;
            this.acceptBut.Text = "Aceptar";
            this.acceptBut.UseVisualStyleBackColor = true;
            this.acceptBut.Click += new System.EventHandler(this.acceptBut_Click);
            // 
            // usuarioBox
            // 
            this.usuarioBox.Location = new System.Drawing.Point(231, 107);
            this.usuarioBox.Name = "usuarioBox";
            this.usuarioBox.Size = new System.Drawing.Size(107, 20);
            this.usuarioBox.TabIndex = 0;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.Location = new System.Drawing.Point(79, 102);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(92, 25);
            this.usuarioLabel.TabIndex = 3;
            this.usuarioLabel.Text = "Usuario:";
            // 
            // contrasenaLabel
            // 
            this.contrasenaLabel.AutoSize = true;
            this.contrasenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaLabel.Location = new System.Drawing.Point(79, 172);
            this.contrasenaLabel.Name = "contrasenaLabel";
            this.contrasenaLabel.Size = new System.Drawing.Size(129, 25);
            this.contrasenaLabel.TabIndex = 5;
            this.contrasenaLabel.Text = "Contraseña:";
            // 
            // contrasenaBox
            // 
            this.contrasenaBox.Location = new System.Drawing.Point(231, 177);
            this.contrasenaBox.Name = "contrasenaBox";
            this.contrasenaBox.PasswordChar = '*';
            this.contrasenaBox.Size = new System.Drawing.Size(107, 20);
            this.contrasenaBox.TabIndex = 1;
            // 
            // inicioLabel
            // 
            this.inicioLabel.AutoSize = true;
            this.inicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioLabel.Location = new System.Drawing.Point(135, 35);
            this.inicioLabel.Name = "inicioLabel";
            this.inicioLabel.Size = new System.Drawing.Size(164, 31);
            this.inicioLabel.TabIndex = 6;
            this.inicioLabel.Text = "Inicia sesión";
            // 
            // cancelBut
            // 
            this.cancelBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBut.Location = new System.Drawing.Point(235, 262);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(103, 36);
            this.cancelBut.TabIndex = 7;
            this.cancelBut.Text = "Cancelar";
            this.cancelBut.UseVisualStyleBackColor = true;
            // 
            // registroLabel
            // 
            this.registroLabel.AutoSize = true;
            this.registroLabel.Location = new System.Drawing.Point(101, 223);
            this.registroLabel.Name = "registroLabel";
            this.registroLabel.Size = new System.Drawing.Size(125, 13);
            this.registroLabel.TabIndex = 8;
            this.registroLabel.Text = "Si no tienes una cuenta, ";
            // 
            // registrateLink
            // 
            this.registrateLink.AutoSize = true;
            this.registrateLink.Location = new System.Drawing.Point(232, 223);
            this.registrateLink.Name = "registrateLink";
            this.registrateLink.Size = new System.Drawing.Size(57, 13);
            this.registrateLink.TabIndex = 9;
            this.registrateLink.TabStop = true;
            this.registrateLink.Text = "Regístrate";
            this.registrateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrateLink_LinkClicked);
            // 
            // accederBut
            // 
            this.accederBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.accederBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accederBut.Location = new System.Drawing.Point(159, 322);
            this.accederBut.Name = "accederBut";
            this.accederBut.Size = new System.Drawing.Size(100, 40);
            this.accederBut.TabIndex = 10;
            this.accederBut.Text = "Accede sin cuenta";
            this.accederBut.UseVisualStyleBackColor = true;
            this.accederBut.Click += new System.EventHandler(this.accederBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario admin:\r\nfernando\r\nfernando\r\n";
            // 
            // InicioSesion
            // 
            this.AcceptButton = this.acceptBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.cancelBut;
            this.ClientSize = new System.Drawing.Size(425, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accederBut);
            this.Controls.Add(this.registrateLink);
            this.Controls.Add(this.registroLabel);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.inicioLabel);
            this.Controls.Add(this.contrasenaLabel);
            this.Controls.Add(this.contrasenaBox);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.usuarioBox);
            this.Controls.Add(this.acceptBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InicioSesion";
            this.Text = "Inicio de sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InicioSesion_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InicioSesion_FormClosed);
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptBut;
        private System.Windows.Forms.TextBox usuarioBox;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label contrasenaLabel;
        private System.Windows.Forms.TextBox contrasenaBox;
        private System.Windows.Forms.Label inicioLabel;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Label registroLabel;
        private System.Windows.Forms.LinkLabel registrateLink;
        private System.Windows.Forms.Button accederBut;
        private System.Windows.Forms.Label label1;
    }
}