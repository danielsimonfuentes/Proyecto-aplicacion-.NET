namespace AcademiaIdiomas
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
            this.estudiantesPanel = new System.Windows.Forms.Panel();
            this.filtrarBut = new System.Windows.Forms.Button();
            this.matricularBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eliminarBut
            // 
            this.eliminarBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBut.Location = new System.Drawing.Point(510, 615);
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
            this.idiomaComboBox.Location = new System.Drawing.Point(119, 627);
            this.idiomaComboBox.Name = "idiomaComboBox";
            this.idiomaComboBox.Size = new System.Drawing.Size(121, 21);
            this.idiomaComboBox.TabIndex = 10;
            this.idiomaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // filtrarIdioma
            // 
            this.filtrarIdioma.AutoSize = true;
            this.filtrarIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarIdioma.Location = new System.Drawing.Point(31, 627);
            this.filtrarIdioma.Name = "filtrarIdioma";
            this.filtrarIdioma.Size = new System.Drawing.Size(80, 20);
            this.filtrarIdioma.TabIndex = 11;
            this.filtrarIdioma.Text = "Filtrar por:";
            // 
            // estudiantesPanel
            // 
            this.estudiantesPanel.AutoScroll = true;
            this.estudiantesPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.estudiantesPanel.Location = new System.Drawing.Point(44, 103);
            this.estudiantesPanel.Name = "estudiantesPanel";
            this.estudiantesPanel.Size = new System.Drawing.Size(568, 477);
            this.estudiantesPanel.TabIndex = 12;
            // 
            // filtrarBut
            // 
            this.filtrarBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarBut.Location = new System.Drawing.Point(261, 624);
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
            this.matricularBut.Location = new System.Drawing.Point(374, 615);
            this.matricularBut.Name = "matricularBut";
            this.matricularBut.Size = new System.Drawing.Size(115, 48);
            this.matricularBut.TabIndex = 14;
            this.matricularBut.Text = "Matricular";
            this.matricularBut.UseVisualStyleBackColor = true;
            this.matricularBut.Click += new System.EventHandler(this.matricularBut_Click);
            // 
            // AdministracionEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(661, 702);
            this.Controls.Add(this.matricularBut);
            this.Controls.Add(this.filtrarBut);
            this.Controls.Add(this.estudiantesPanel);
            this.Controls.Add(this.filtrarIdioma);
            this.Controls.Add(this.idiomaComboBox);
            this.Controls.Add(this.eliminarBut);
            this.Controls.Add(this.adminEstudiantesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdministracionEstudiantes";
            this.Text = "Administración de Estudiantes";
            this.Load += new System.EventHandler(this.AdministracionEstudiantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button eliminarBut;
        private System.Windows.Forms.Label adminEstudiantesLabel;
        private System.Windows.Forms.ComboBox idiomaComboBox;
        private System.Windows.Forms.Label filtrarIdioma;
        private System.Windows.Forms.Panel estudiantesPanel;
        private System.Windows.Forms.Button filtrarBut;
        private System.Windows.Forms.Button matricularBut;
    }
}