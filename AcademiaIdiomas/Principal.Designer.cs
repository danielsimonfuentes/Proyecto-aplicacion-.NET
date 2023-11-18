namespace AcademiaIdiomas
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.francésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alemánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idiomasToolStripMenuItem,
            this.cuentaToolStripMenuItem,
            this.iniciarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarSesiónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            this.iniciarSesiónToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.iniciarSesiónToolStripMenuItem.Text = "Iniciar sesión";
            this.iniciarSesiónToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesiónToolStripMenuItem_Click);
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            this.cuentaToolStripMenuItem.Click += new System.EventHandler(this.cuentaToolStripMenuItem_Click_1);
            // 
            // idiomasToolStripMenuItem
            // 
            this.idiomasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inglésToolStripMenuItem,
            this.francésToolStripMenuItem,
            this.alemánToolStripMenuItem});
            this.idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            this.idiomasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.idiomasToolStripMenuItem.Text = "Idiomas";
            // 
            // inglésToolStripMenuItem
            // 
            this.inglésToolStripMenuItem.Name = "inglésToolStripMenuItem";
            this.inglésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inglésToolStripMenuItem.Text = "Inglés";
            this.inglésToolStripMenuItem.Click += new System.EventHandler(this.inglésToolStripMenuItem_Click);
            // 
            // francésToolStripMenuItem
            // 
            this.francésToolStripMenuItem.Name = "francésToolStripMenuItem";
            this.francésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.francésToolStripMenuItem.Text = "Francés";
            this.francésToolStripMenuItem.Click += new System.EventHandler(this.francésToolStripMenuItem_Click);
            // 
            // alemánToolStripMenuItem
            // 
            this.alemánToolStripMenuItem.Name = "alemánToolStripMenuItem";
            this.alemánToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alemánToolStripMenuItem.Text = "Alemán";
            this.alemánToolStripMenuItem.Click += new System.EventHandler(this.alemánToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem francésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alemánToolStripMenuItem;
    }
}