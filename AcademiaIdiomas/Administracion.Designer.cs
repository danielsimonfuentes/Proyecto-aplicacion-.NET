namespace AcademiaIdiomas
{
    partial class Administracion
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
            this.adminLabel = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.usersBut = new System.Windows.Forms.Button();
            this.estudiantesBut = new System.Windows.Forms.Button();
            this.estudiantesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.Location = new System.Drawing.Point(39, 36);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(171, 29);
            this.adminLabel.TabIndex = 0;
            this.adminLabel.Text = "Administración";
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLabel.Location = new System.Drawing.Point(93, 125);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(157, 20);
            this.usersLabel.TabIndex = 1;
            this.usersLabel.Text = "Administrar usuarios:";
            // 
            // usersBut
            // 
            this.usersBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBut.Location = new System.Drawing.Point(300, 119);
            this.usersBut.Name = "usersBut";
            this.usersBut.Size = new System.Drawing.Size(103, 34);
            this.usersBut.TabIndex = 2;
            this.usersBut.Text = "Administrar...";
            this.usersBut.UseVisualStyleBackColor = true;
            this.usersBut.Click += new System.EventHandler(this.usersBut_Click);
            // 
            // estudiantesBut
            // 
            this.estudiantesBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudiantesBut.Location = new System.Drawing.Point(300, 191);
            this.estudiantesBut.Name = "estudiantesBut";
            this.estudiantesBut.Size = new System.Drawing.Size(103, 34);
            this.estudiantesBut.TabIndex = 4;
            this.estudiantesBut.Text = "Administrar...";
            this.estudiantesBut.UseVisualStyleBackColor = true;
            this.estudiantesBut.Click += new System.EventHandler(this.estudiantesBut_Click);
            // 
            // estudiantesLabel
            // 
            this.estudiantesLabel.AutoSize = true;
            this.estudiantesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudiantesLabel.Location = new System.Drawing.Point(93, 197);
            this.estudiantesLabel.Name = "estudiantesLabel";
            this.estudiantesLabel.Size = new System.Drawing.Size(180, 20);
            this.estudiantesLabel.TabIndex = 3;
            this.estudiantesLabel.Text = "Administrar estudiantes:";
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(497, 316);
            this.Controls.Add(this.estudiantesBut);
            this.Controls.Add(this.estudiantesLabel);
            this.Controls.Add(this.usersBut);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.adminLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Administracion";
            this.Text = "Administración";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Button usersBut;
        private System.Windows.Forms.Button estudiantesBut;
        private System.Windows.Forms.Label estudiantesLabel;
    }
}