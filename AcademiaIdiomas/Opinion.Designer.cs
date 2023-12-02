namespace AcademiaIdiomas
{
    partial class Opinion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opinion));
            this.opinionesGroupBox = new System.Windows.Forms.GroupBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.opinionTextBox = new System.Windows.Forms.TextBox();
            this.publicarBut = new System.Windows.Forms.Button();
            this.publicaLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // opinionesGroupBox
            // 
            this.opinionesGroupBox.BackColor = System.Drawing.Color.FloralWhite;
            this.opinionesGroupBox.Location = new System.Drawing.Point(47, 116);
            this.opinionesGroupBox.Name = "opinionesGroupBox";
            this.opinionesGroupBox.Size = new System.Drawing.Size(867, 366);
            this.opinionesGroupBox.TabIndex = 0;
            this.opinionesGroupBox.TabStop = false;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(129, 46);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(298, 37);
            this.tituloLabel.TabIndex = 1;
            this.tituloLabel.Text = "Opiniones recientes";
            // 
            // opinionTextBox
            // 
            this.opinionTextBox.AccessibleDescription = "";
            this.opinionTextBox.Location = new System.Drawing.Point(136, 558);
            this.opinionTextBox.Name = "opinionTextBox";
            this.opinionTextBox.Size = new System.Drawing.Size(486, 20);
            this.opinionTextBox.TabIndex = 2;
            // 
            // publicarBut
            // 
            this.publicarBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicarBut.Location = new System.Drawing.Point(661, 546);
            this.publicarBut.Name = "publicarBut";
            this.publicarBut.Size = new System.Drawing.Size(108, 40);
            this.publicarBut.TabIndex = 3;
            this.publicarBut.Text = "Publicar";
            this.publicarBut.UseVisualStyleBackColor = true;
            this.publicarBut.Click += new System.EventHandler(this.publicarBut_Click);
            // 
            // publicaLabel
            // 
            this.publicaLabel.AutoSize = true;
            this.publicaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicaLabel.Location = new System.Drawing.Point(131, 510);
            this.publicaLabel.Name = "publicaLabel";
            this.publicaLabel.Size = new System.Drawing.Size(222, 29);
            this.publicaLabel.TabIndex = 4;
            this.publicaLabel.Text = "Publica tu opinión...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Opinion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(956, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.publicaLabel);
            this.Controls.Add(this.publicarBut);
            this.Controls.Add(this.opinionTextBox);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.opinionesGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opinion";
            this.Text = "Opinion";
            this.Load += new System.EventHandler(this.Opinion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox opinionesGroupBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TextBox opinionTextBox;
        private System.Windows.Forms.Button publicarBut;
        private System.Windows.Forms.Label publicaLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}