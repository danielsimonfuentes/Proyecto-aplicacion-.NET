namespace AcademiaIdiomas
{
    partial class FormMatriculacionEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatriculacionEstudiante));
            this.cancelBut = new System.Windows.Forms.Button();
            this.acceptBut = new System.Windows.Forms.Button();
            this.claseLabel = new System.Windows.Forms.Label();
            this.idiomaLabel = new System.Windows.Forms.Label();
            this.edadLabel = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.dniBox = new System.Windows.Forms.TextBox();
            this.apellido2Label = new System.Windows.Forms.Label();
            this.apellido2Box = new System.Windows.Forms.TextBox();
            this.apellido1Label = new System.Windows.Forms.Label();
            this.apellido1Box = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.edadUpDown = new System.Windows.Forms.NumericUpDown();
            this.idiomaComboBox = new System.Windows.Forms.ComboBox();
            this.claseComboBox = new System.Windows.Forms.ComboBox();
            this.matriculacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edadUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBut
            // 
            this.cancelBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBut.Location = new System.Drawing.Point(299, 463);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(103, 36);
            this.cancelBut.TabIndex = 51;
            this.cancelBut.Text = "Cancelar";
            this.cancelBut.UseVisualStyleBackColor = true;
            // 
            // acceptBut
            // 
            this.acceptBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBut.Location = new System.Drawing.Point(140, 463);
            this.acceptBut.Name = "acceptBut";
            this.acceptBut.Size = new System.Drawing.Size(103, 36);
            this.acceptBut.TabIndex = 50;
            this.acceptBut.Text = "Aceptar";
            this.acceptBut.UseVisualStyleBackColor = true;
            this.acceptBut.Click += new System.EventHandler(this.acceptBut_Click);
            // 
            // claseLabel
            // 
            this.claseLabel.AutoSize = true;
            this.claseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claseLabel.Location = new System.Drawing.Point(114, 389);
            this.claseLabel.Name = "claseLabel";
            this.claseLabel.Size = new System.Drawing.Size(62, 24);
            this.claseLabel.TabIndex = 46;
            this.claseLabel.Text = "Clase:";
            // 
            // idiomaLabel
            // 
            this.idiomaLabel.AutoSize = true;
            this.idiomaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idiomaLabel.Location = new System.Drawing.Point(114, 327);
            this.idiomaLabel.Name = "idiomaLabel";
            this.idiomaLabel.Size = new System.Drawing.Size(71, 24);
            this.idiomaLabel.TabIndex = 44;
            this.idiomaLabel.Text = "Idioma:";
            // 
            // edadLabel
            // 
            this.edadLabel.AutoSize = true;
            this.edadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadLabel.Location = new System.Drawing.Point(114, 271);
            this.edadLabel.Name = "edadLabel";
            this.edadLabel.Size = new System.Drawing.Size(60, 24);
            this.edadLabel.TabIndex = 41;
            this.edadLabel.Text = "Edad:";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniLabel.Location = new System.Drawing.Point(114, 230);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(46, 24);
            this.dniLabel.TabIndex = 39;
            this.dniLabel.Text = "DNI:";
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(318, 234);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(107, 20);
            this.dniBox.TabIndex = 3;
            // 
            // apellido2Label
            // 
            this.apellido2Label.AutoSize = true;
            this.apellido2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido2Label.Location = new System.Drawing.Point(114, 188);
            this.apellido2Label.Name = "apellido2Label";
            this.apellido2Label.Size = new System.Drawing.Size(164, 24);
            this.apellido2Label.TabIndex = 37;
            this.apellido2Label.Text = "Segundo apellido:";
            // 
            // apellido2Box
            // 
            this.apellido2Box.Location = new System.Drawing.Point(318, 192);
            this.apellido2Box.Name = "apellido2Box";
            this.apellido2Box.Size = new System.Drawing.Size(107, 20);
            this.apellido2Box.TabIndex = 2;
            // 
            // apellido1Label
            // 
            this.apellido1Label.AutoSize = true;
            this.apellido1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido1Label.Location = new System.Drawing.Point(114, 145);
            this.apellido1Label.Name = "apellido1Label";
            this.apellido1Label.Size = new System.Drawing.Size(141, 24);
            this.apellido1Label.TabIndex = 35;
            this.apellido1Label.Text = "Primer apellido:";
            // 
            // apellido1Box
            // 
            this.apellido1Box.Location = new System.Drawing.Point(318, 149);
            this.apellido1Box.Name = "apellido1Box";
            this.apellido1Box.Size = new System.Drawing.Size(107, 20);
            this.apellido1Box.TabIndex = 1;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(114, 103);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(84, 24);
            this.nombreLabel.TabIndex = 33;
            this.nombreLabel.Text = "Nombre:";
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(318, 108);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(107, 20);
            this.nombreBox.TabIndex = 0;
            // 
            // edadUpDown
            // 
            this.edadUpDown.Location = new System.Drawing.Point(318, 275);
            this.edadUpDown.Name = "edadUpDown";
            this.edadUpDown.Size = new System.Drawing.Size(107, 20);
            this.edadUpDown.TabIndex = 4;
            // 
            // idiomaComboBox
            // 
            this.idiomaComboBox.FormattingEnabled = true;
            this.idiomaComboBox.Items.AddRange(new object[] {
            "inglés",
            "francés",
            "alemán"});
            this.idiomaComboBox.Location = new System.Drawing.Point(318, 332);
            this.idiomaComboBox.Name = "idiomaComboBox";
            this.idiomaComboBox.Size = new System.Drawing.Size(107, 21);
            this.idiomaComboBox.TabIndex = 5;
            this.idiomaComboBox.Click += new System.EventHandler(this.idiomaComboBox_Click);
            // 
            // claseComboBox
            // 
            this.claseComboBox.FormattingEnabled = true;
            this.claseComboBox.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "C1",
            "C2"});
            this.claseComboBox.Location = new System.Drawing.Point(318, 394);
            this.claseComboBox.Name = "claseComboBox";
            this.claseComboBox.Size = new System.Drawing.Size(107, 21);
            this.claseComboBox.TabIndex = 7;
            this.claseComboBox.Click += new System.EventHandler(this.claseComboBox_Click);
            // 
            // matriculacionLabel
            // 
            this.matriculacionLabel.AutoSize = true;
            this.matriculacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculacionLabel.Location = new System.Drawing.Point(100, 34);
            this.matriculacionLabel.Name = "matriculacionLabel";
            this.matriculacionLabel.Size = new System.Drawing.Size(344, 31);
            this.matriculacionLabel.TabIndex = 55;
            this.matriculacionLabel.Text = "Matriculación de estudiante";
            // 
            // MatriculacionEstudiante
            // 
            this.AcceptButton = this.acceptBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.cancelBut;
            this.ClientSize = new System.Drawing.Size(553, 547);
            this.Controls.Add(this.matriculacionLabel);
            this.Controls.Add(this.claseComboBox);
            this.Controls.Add(this.idiomaComboBox);
            this.Controls.Add(this.edadUpDown);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.acceptBut);
            this.Controls.Add(this.claseLabel);
            this.Controls.Add(this.idiomaLabel);
            this.Controls.Add(this.edadLabel);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.dniBox);
            this.Controls.Add(this.apellido2Label);
            this.Controls.Add(this.apellido2Box);
            this.Controls.Add(this.apellido1Label);
            this.Controls.Add(this.apellido1Box);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombreBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MatriculacionEstudiante";
            this.Text = "Matriculación de Estudiante";
            this.Load += new System.EventHandler(this.MatriculacionEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edadUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Button acceptBut;
        private System.Windows.Forms.Label claseLabel;
        private System.Windows.Forms.Label idiomaLabel;
        private System.Windows.Forms.Label edadLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.Label apellido2Label;
        private System.Windows.Forms.TextBox apellido2Box;
        private System.Windows.Forms.Label apellido1Label;
        private System.Windows.Forms.TextBox apellido1Box;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.NumericUpDown edadUpDown;
        private System.Windows.Forms.ComboBox idiomaComboBox;
        private System.Windows.Forms.ComboBox claseComboBox;
        private System.Windows.Forms.Label matriculacionLabel;
    }
}