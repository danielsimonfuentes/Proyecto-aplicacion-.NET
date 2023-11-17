namespace AcademiaIdiomas
{
    partial class InglesForm
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.subtituloLabel = new System.Windows.Forms.Label();
            this.inglesGroupBox = new System.Windows.Forms.GroupBox();
            this.ImprimirBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(147, 54);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(453, 37);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Bienvenido a la clase de inglés";
            // 
            // subtituloLabel
            // 
            this.subtituloLabel.AutoSize = true;
            this.subtituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtituloLabel.Location = new System.Drawing.Point(119, 133);
            this.subtituloLabel.Name = "subtituloLabel";
            this.subtituloLabel.Size = new System.Drawing.Size(512, 25);
            this.subtituloLabel.TabIndex = 1;
            this.subtituloLabel.Text = "Aquí tienes a los alumnos que pertenecen a la clase";
            // 
            // inglesGroupBox
            // 
            this.inglesGroupBox.Location = new System.Drawing.Point(90, 198);
            this.inglesGroupBox.Name = "inglesGroupBox";
            this.inglesGroupBox.Size = new System.Drawing.Size(570, 498);
            this.inglesGroupBox.TabIndex = 2;
            this.inglesGroupBox.TabStop = false;
            // 
            // ImprimirBut
            // 
            this.ImprimirBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirBut.Location = new System.Drawing.Point(154, 721);
            this.ImprimirBut.Name = "ImprimirBut";
            this.ImprimirBut.Size = new System.Drawing.Size(95, 37);
            this.ImprimirBut.TabIndex = 3;
            this.ImprimirBut.Text = "Imprimir";
            this.ImprimirBut.UseVisualStyleBackColor = true;
            this.ImprimirBut.Click += new System.EventHandler(this.ImprimirBut_Click);
            // 
            // InglesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 770);
            this.Controls.Add(this.ImprimirBut);
            this.Controls.Add(this.inglesGroupBox);
            this.Controls.Add(this.subtituloLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "InglesForm";
            this.Text = "InglesForm";
            this.Load += new System.EventHandler(this.InglesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label subtituloLabel;
        private System.Windows.Forms.GroupBox inglesGroupBox;
        private System.Windows.Forms.Button ImprimirBut;
    }
}