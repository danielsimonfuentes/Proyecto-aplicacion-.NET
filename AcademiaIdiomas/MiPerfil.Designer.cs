namespace AcademiaIdiomas
{
    partial class MiPerfil
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
            this.datosGroupBox = new System.Windows.Forms.GroupBox();
            this.perfilGroupBox = new System.Windows.Forms.GroupBox();
            this.adminBut = new System.Windows.Forms.Button();
            this.perfilPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.perfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // datosGroupBox
            // 
            this.datosGroupBox.Location = new System.Drawing.Point(277, 43);
            this.datosGroupBox.Name = "datosGroupBox";
            this.datosGroupBox.Size = new System.Drawing.Size(389, 242);
            this.datosGroupBox.TabIndex = 1;
            this.datosGroupBox.TabStop = false;
            // 
            // perfilGroupBox
            // 
            this.perfilGroupBox.Location = new System.Drawing.Point(35, 291);
            this.perfilGroupBox.Name = "perfilGroupBox";
            this.perfilGroupBox.Size = new System.Drawing.Size(228, 54);
            this.perfilGroupBox.TabIndex = 2;
            this.perfilGroupBox.TabStop = false;
            // 
            // adminBut
            // 
            this.adminBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBut.Location = new System.Drawing.Point(361, 307);
            this.adminBut.Name = "adminBut";
            this.adminBut.Size = new System.Drawing.Size(193, 38);
            this.adminBut.TabIndex = 3;
            this.adminBut.Text = "Administrar";
            this.adminBut.UseVisualStyleBackColor = true;
            this.adminBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // perfilPictureBox
            // 
            this.perfilPictureBox.Image = global::AcademiaIdiomas.Properties.Resources.blank_profile_picture_973460_1280_580x580;
            this.perfilPictureBox.Location = new System.Drawing.Point(35, 49);
            this.perfilPictureBox.Name = "perfilPictureBox";
            this.perfilPictureBox.Size = new System.Drawing.Size(228, 236);
            this.perfilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.perfilPictureBox.TabIndex = 0;
            this.perfilPictureBox.TabStop = false;
            // 
            // MiPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 440);
            this.Controls.Add(this.adminBut);
            this.Controls.Add(this.perfilGroupBox);
            this.Controls.Add(this.datosGroupBox);
            this.Controls.Add(this.perfilPictureBox);
            this.Name = "MiPerfil";
            this.Text = "MiPerfil";
            this.Load += new System.EventHandler(this.MiPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfilPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox perfilPictureBox;
        private System.Windows.Forms.GroupBox datosGroupBox;
        private System.Windows.Forms.GroupBox perfilGroupBox;
        private System.Windows.Forms.Button adminBut;
    }
}