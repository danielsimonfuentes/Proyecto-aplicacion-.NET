namespace AcademiaIdiomas
{
    partial class FormInglesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInglesForm));
            this.tituloLabel = new System.Windows.Forms.Label();
            this.subtituloLabel = new System.Windows.Forms.Label();
            this.inglesGroupBox = new System.Windows.Forms.GroupBox();
            this.ImprimirBut = new System.Windows.Forms.Button();
            this.ordenarApebut = new System.Windows.Forms.Button();
            this.ordenarClassBut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.inglesGroupBox.BackColor = System.Drawing.Color.FloralWhite;
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
            // ordenarApebut
            // 
            this.ordenarApebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenarApebut.Location = new System.Drawing.Point(326, 715);
            this.ordenarApebut.Name = "ordenarApebut";
            this.ordenarApebut.Size = new System.Drawing.Size(98, 43);
            this.ordenarApebut.TabIndex = 4;
            this.ordenarApebut.Text = "Ordenar apellidos";
            this.ordenarApebut.UseVisualStyleBackColor = true;
            this.ordenarApebut.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordenarClassBut
            // 
            this.ordenarClassBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenarClassBut.Location = new System.Drawing.Point(502, 715);
            this.ordenarClassBut.Name = "ordenarClassBut";
            this.ordenarClassBut.Size = new System.Drawing.Size(98, 43);
            this.ordenarClassBut.TabIndex = 5;
            this.ordenarClassBut.Text = "Ordenar por clases";
            this.ordenarClassBut.UseVisualStyleBackColor = true;
            this.ordenarClassBut.Click += new System.EventHandler(this.ordenarClassBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InglesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(742, 770);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ordenarClassBut);
            this.Controls.Add(this.ordenarApebut);
            this.Controls.Add(this.ImprimirBut);
            this.Controls.Add(this.inglesGroupBox);
            this.Controls.Add(this.subtituloLabel);
            this.Controls.Add(this.tituloLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InglesForm";
            this.Text = "Clase de Inglés";
            this.Load += new System.EventHandler(this.InglesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label subtituloLabel;
        private System.Windows.Forms.GroupBox inglesGroupBox;
        private System.Windows.Forms.Button ImprimirBut;
        private System.Windows.Forms.Button ordenarApebut;
        private System.Windows.Forms.Button ordenarClassBut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}