namespace AcademiaIdiomas
{
    partial class FormModificarEstudiante
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
            this.claseComboBox = new System.Windows.Forms.ComboBox();
            this.idiomaComboBox = new System.Windows.Forms.ComboBox();
            this.cancelBut = new System.Windows.Forms.Button();
            this.acceptBut = new System.Windows.Forms.Button();
            this.claseLabel = new System.Windows.Forms.Label();
            this.idiomaLabel = new System.Windows.Forms.Label();
            this.modificacionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.claseComboBox.Location = new System.Drawing.Point(377, 206);
            this.claseComboBox.Name = "claseComboBox";
            this.claseComboBox.Size = new System.Drawing.Size(107, 21);
            this.claseComboBox.TabIndex = 53;
            // 
            // idiomaComboBox
            // 
            this.idiomaComboBox.FormattingEnabled = true;
            this.idiomaComboBox.Items.AddRange(new object[] {
            "inglés",
            "francés",
            "alemán"});
            this.idiomaComboBox.Location = new System.Drawing.Point(377, 144);
            this.idiomaComboBox.Name = "idiomaComboBox";
            this.idiomaComboBox.Size = new System.Drawing.Size(107, 21);
            this.idiomaComboBox.TabIndex = 52;
            // 
            // cancelBut
            // 
            this.cancelBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBut.Location = new System.Drawing.Point(358, 275);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(103, 36);
            this.cancelBut.TabIndex = 57;
            this.cancelBut.Text = "Cancelar";
            this.cancelBut.UseVisualStyleBackColor = true;
            // 
            // acceptBut
            // 
            this.acceptBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBut.Location = new System.Drawing.Point(199, 275);
            this.acceptBut.Name = "acceptBut";
            this.acceptBut.Size = new System.Drawing.Size(103, 36);
            this.acceptBut.TabIndex = 56;
            this.acceptBut.Text = "Aceptar";
            this.acceptBut.UseVisualStyleBackColor = true;
            this.acceptBut.Click += new System.EventHandler(this.acceptBut_Click);
            // 
            // claseLabel
            // 
            this.claseLabel.AutoSize = true;
            this.claseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claseLabel.Location = new System.Drawing.Point(173, 201);
            this.claseLabel.Name = "claseLabel";
            this.claseLabel.Size = new System.Drawing.Size(62, 24);
            this.claseLabel.TabIndex = 55;
            this.claseLabel.Text = "Clase:";
            // 
            // idiomaLabel
            // 
            this.idiomaLabel.AutoSize = true;
            this.idiomaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idiomaLabel.Location = new System.Drawing.Point(173, 139);
            this.idiomaLabel.Name = "idiomaLabel";
            this.idiomaLabel.Size = new System.Drawing.Size(71, 24);
            this.idiomaLabel.TabIndex = 54;
            this.idiomaLabel.Text = "Idioma:";
            // 
            // modificacionLabel
            // 
            this.modificacionLabel.AutoSize = true;
            this.modificacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificacionLabel.Location = new System.Drawing.Point(12, 40);
            this.modificacionLabel.Name = "modificacionLabel";
            this.modificacionLabel.Size = new System.Drawing.Size(449, 31);
            this.modificacionLabel.TabIndex = 58;
            this.modificacionLabel.Text = "Modificación de estudiante con DNI:";
            // 
            // FormModificarEstudiante
            // 
            this.AcceptButton = this.acceptBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.cancelBut;
            this.ClientSize = new System.Drawing.Size(663, 387);
            this.Controls.Add(this.modificacionLabel);
            this.Controls.Add(this.claseComboBox);
            this.Controls.Add(this.idiomaComboBox);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.acceptBut);
            this.Controls.Add(this.claseLabel);
            this.Controls.Add(this.idiomaLabel);
            this.Name = "FormModificarEstudiante";
            this.Text = "FormModificarEstudiante";
            this.Load += new System.EventHandler(this.FormModificarEstudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox claseComboBox;
        private System.Windows.Forms.ComboBox idiomaComboBox;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Button acceptBut;
        private System.Windows.Forms.Label claseLabel;
        private System.Windows.Forms.Label idiomaLabel;
        private System.Windows.Forms.Label modificacionLabel;
    }
}