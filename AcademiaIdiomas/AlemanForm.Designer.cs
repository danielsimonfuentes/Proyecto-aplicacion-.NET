﻿namespace AcademiaIdiomas
{
    partial class AlemanForm
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
            this.alemanGroupBox = new System.Windows.Forms.GroupBox();
            this.subtituloLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alemanGroupBox
            // 
            this.alemanGroupBox.Location = new System.Drawing.Point(89, 199);
            this.alemanGroupBox.Name = "alemanGroupBox";
            this.alemanGroupBox.Size = new System.Drawing.Size(570, 515);
            this.alemanGroupBox.TabIndex = 5;
            this.alemanGroupBox.TabStop = false;
            // 
            // subtituloLabel
            // 
            this.subtituloLabel.AutoSize = true;
            this.subtituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtituloLabel.Location = new System.Drawing.Point(118, 134);
            this.subtituloLabel.Name = "subtituloLabel";
            this.subtituloLabel.Size = new System.Drawing.Size(512, 25);
            this.subtituloLabel.TabIndex = 4;
            this.subtituloLabel.Text = "Aquí tienes a los alumnos que pertenecen a la clase";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(137, 56);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(475, 37);
            this.tituloLabel.TabIndex = 3;
            this.tituloLabel.Text = "Bienvenido a la clase de alemán";
            // 
            // AlemanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 827);
            this.Controls.Add(this.alemanGroupBox);
            this.Controls.Add(this.subtituloLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "AlemanForm";
            this.Text = "AlemanForm";
            this.Load += new System.EventHandler(this.AlemanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox alemanGroupBox;
        private System.Windows.Forms.Label subtituloLabel;
        private System.Windows.Forms.Label tituloLabel;
    }
}