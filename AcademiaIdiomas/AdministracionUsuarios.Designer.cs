namespace AcademiaIdiomas
{
    partial class AdministracionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionUsuarios));
            this.usersGroupBox = new System.Windows.Forms.GroupBox();
            this.adminUsersLabel = new System.Windows.Forms.Label();
            this.eliminarBut = new System.Windows.Forms.Button();
            this.adminBut = new System.Windows.Forms.Button();
            this.noadminBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersGroupBox
            // 
            this.usersGroupBox.AutoSize = true;
            this.usersGroupBox.BackColor = System.Drawing.Color.GhostWhite;
            this.usersGroupBox.Location = new System.Drawing.Point(44, 90);
            this.usersGroupBox.Name = "usersGroupBox";
            this.usersGroupBox.Size = new System.Drawing.Size(577, 413);
            this.usersGroupBox.TabIndex = 0;
            this.usersGroupBox.TabStop = false;
            // 
            // adminUsersLabel
            // 
            this.adminUsersLabel.AutoSize = true;
            this.adminUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUsersLabel.Location = new System.Drawing.Point(39, 34);
            this.adminUsersLabel.Name = "adminUsersLabel";
            this.adminUsersLabel.Size = new System.Drawing.Size(306, 29);
            this.adminUsersLabel.TabIndex = 1;
            this.adminUsersLabel.Text = "Administración de Usuarios";
            // 
            // eliminarBut
            // 
            this.eliminarBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBut.Location = new System.Drawing.Point(427, 540);
            this.eliminarBut.Name = "eliminarBut";
            this.eliminarBut.Size = new System.Drawing.Size(115, 48);
            this.eliminarBut.TabIndex = 2;
            this.eliminarBut.Text = "Eliminar";
            this.eliminarBut.UseVisualStyleBackColor = true;
            this.eliminarBut.Click += new System.EventHandler(this.eliminarBut_Click);
            // 
            // adminBut
            // 
            this.adminBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBut.Location = new System.Drawing.Point(113, 541);
            this.adminBut.Name = "adminBut";
            this.adminBut.Size = new System.Drawing.Size(115, 48);
            this.adminBut.TabIndex = 3;
            this.adminBut.Text = "Hacer administrador";
            this.adminBut.UseVisualStyleBackColor = true;
            this.adminBut.Click += new System.EventHandler(this.adminBut_Click);
            // 
            // noadminBut
            // 
            this.noadminBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noadminBut.Location = new System.Drawing.Point(272, 541);
            this.noadminBut.Name = "noadminBut";
            this.noadminBut.Size = new System.Drawing.Size(115, 48);
            this.noadminBut.TabIndex = 4;
            this.noadminBut.Text = "Quitar administrador";
            this.noadminBut.UseVisualStyleBackColor = true;
            this.noadminBut.Click += new System.EventHandler(this.noadminBut_Click);
            // 
            // AdministracionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(668, 623);
            this.Controls.Add(this.noadminBut);
            this.Controls.Add(this.adminBut);
            this.Controls.Add(this.eliminarBut);
            this.Controls.Add(this.adminUsersLabel);
            this.Controls.Add(this.usersGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdministracionUsuarios";
            this.Text = "Administración de Usuarios";
            this.Load += new System.EventHandler(this.AdministracionUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox usersGroupBox;
        private System.Windows.Forms.Label adminUsersLabel;
        private System.Windows.Forms.Button eliminarBut;
        private System.Windows.Forms.Button adminBut;
        private System.Windows.Forms.Button noadminBut;
    }
}