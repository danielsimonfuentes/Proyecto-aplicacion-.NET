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
            this.perfilPictureBox = new System.Windows.Forms.PictureBox();
            this.datosGroupBox = new System.Windows.Forms.GroupBox();
            this.perfilGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.perfilPictureBox)).BeginInit();
            this.SuspendLayout();
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
            // MiPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 453);
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
    }
}