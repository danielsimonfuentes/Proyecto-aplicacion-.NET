﻿namespace AcademiaIdiomas
{
    partial class FormAdministracionEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministracionEstudiantes));
            this.eliminarBut = new System.Windows.Forms.Button();
            this.adminEstudiantesLabel = new System.Windows.Forms.Label();
            this.idiomaComboBox = new System.Windows.Forms.ComboBox();
            this.filtrarIdioma = new System.Windows.Forms.Label();
            this.filtrarBut = new System.Windows.Forms.Button();
            this.matricularBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modificarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // eliminarBut
            // 
            this.eliminarBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBut.Location = new System.Drawing.Point(665, 611);
            this.eliminarBut.Name = "eliminarBut";
            this.eliminarBut.Size = new System.Drawing.Size(115, 48);
            this.eliminarBut.TabIndex = 7;
            this.eliminarBut.Text = "Eliminar";
            this.eliminarBut.UseVisualStyleBackColor = true;
            this.eliminarBut.Click += new System.EventHandler(this.eliminarBut_Click);
            // 
            // adminEstudiantesLabel
            // 
            this.adminEstudiantesLabel.AutoSize = true;
            this.adminEstudiantesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEstudiantesLabel.Location = new System.Drawing.Point(39, 32);
            this.adminEstudiantesLabel.Name = "adminEstudiantesLabel";
            this.adminEstudiantesLabel.Size = new System.Drawing.Size(336, 29);
            this.adminEstudiantesLabel.TabIndex = 6;
            this.adminEstudiantesLabel.Text = "Administración de Estudiantes";
            // 
            // idiomaComboBox
            // 
            this.idiomaComboBox.FormattingEnabled = true;
            this.idiomaComboBox.Items.AddRange(new object[] {
            "inglés",
            "francés",
            "alemán"});
            this.idiomaComboBox.Location = new System.Drawing.Point(148, 623);
            this.idiomaComboBox.Name = "idiomaComboBox";
            this.idiomaComboBox.Size = new System.Drawing.Size(121, 21);
            this.idiomaComboBox.TabIndex = 10;
            this.idiomaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // filtrarIdioma
            // 
            this.filtrarIdioma.AutoSize = true;
            this.filtrarIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarIdioma.Location = new System.Drawing.Point(60, 623);
            this.filtrarIdioma.Name = "filtrarIdioma";
            this.filtrarIdioma.Size = new System.Drawing.Size(80, 20);
            this.filtrarIdioma.TabIndex = 11;
            this.filtrarIdioma.Text = "Filtrar por:";
            // 
            // filtrarBut
            // 
            this.filtrarBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarBut.Location = new System.Drawing.Point(290, 620);
            this.filtrarBut.Name = "filtrarBut";
            this.filtrarBut.Size = new System.Drawing.Size(91, 31);
            this.filtrarBut.TabIndex = 13;
            this.filtrarBut.Text = "Filtrar";
            this.filtrarBut.UseVisualStyleBackColor = true;
            this.filtrarBut.Click += new System.EventHandler(this.filtrarBut_Click);
            // 
            // matricularBut
            // 
            this.matricularBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricularBut.Location = new System.Drawing.Point(403, 611);
            this.matricularBut.Name = "matricularBut";
            this.matricularBut.Size = new System.Drawing.Size(115, 48);
            this.matricularBut.TabIndex = 14;
            this.matricularBut.Text = "Matricular";
            this.matricularBut.UseVisualStyleBackColor = true;
            this.matricularBut.Click += new System.EventHandler(this.matricularBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 471);
            this.dataGridView1.TabIndex = 15;
            // 
            // modificarButton
            // 
            this.modificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarButton.Location = new System.Drawing.Point(533, 611);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(115, 48);
            this.modificarButton.TabIndex = 16;
            this.modificarButton.Text = "Cambiar datos";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // FormAdministracionEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(852, 702);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.matricularBut);
            this.Controls.Add(this.filtrarBut);
            this.Controls.Add(this.filtrarIdioma);
            this.Controls.Add(this.idiomaComboBox);
            this.Controls.Add(this.eliminarBut);
            this.Controls.Add(this.adminEstudiantesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdministracionEstudiantes";
            this.Text = "Administración de Estudiantes";
            this.Load += new System.EventHandler(this.AdministracionEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button eliminarBut;
        private System.Windows.Forms.Label adminEstudiantesLabel;
        private System.Windows.Forms.ComboBox idiomaComboBox;
        private System.Windows.Forms.Label filtrarIdioma;
        private System.Windows.Forms.Button filtrarBut;
        private System.Windows.Forms.Button matricularBut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button modificarButton;
    }
}