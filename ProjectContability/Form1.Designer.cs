namespace ProjectContability
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoDeDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tablaDeBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeDatosToolStripMenuItem1,
            this.balanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoDeDatosToolStripMenuItem1
            // 
            this.ingresoDeDatosToolStripMenuItem1.CheckOnClick = true;
            this.ingresoDeDatosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeDatosToolStripMenuItem});
            this.ingresoDeDatosToolStripMenuItem1.Name = "ingresoDeDatosToolStripMenuItem1";
            this.ingresoDeDatosToolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.ingresoDeDatosToolStripMenuItem1.Text = "Datos";
            // 
            // ingresoDeDatosToolStripMenuItem
            // 
            this.ingresoDeDatosToolStripMenuItem.Name = "ingresoDeDatosToolStripMenuItem";
            this.ingresoDeDatosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ingresoDeDatosToolStripMenuItem.Text = "Ingreso de Datos";
            this.ingresoDeDatosToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeDatosToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ProjectContability.Properties.Resources.LOGO_UMES_COLOR;
            this.pictureBox1.Location = new System.Drawing.Point(359, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Modern No. 20", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(215, 454);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(762, 137);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Bienvenidos!";
            // 
            // tablaDeBalanceToolStripMenuItem
            // 
            this.tablaDeBalanceToolStripMenuItem.Name = "tablaDeBalanceToolStripMenuItem";
            this.tablaDeBalanceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tablaDeBalanceToolStripMenuItem.Text = "Tabla de balance";
            this.tablaDeBalanceToolStripMenuItem.Click += new System.EventHandler(this.tablaDeBalanceToolStripMenuItem_Click);
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaDeBalanceToolStripMenuItem});
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.balanceToolStripMenuItem.Text = "Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1203, 638);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto de Contabilidad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ingresoDeDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeDatosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDeBalanceToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}

