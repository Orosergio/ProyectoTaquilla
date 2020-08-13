namespace taquillaAdministracion
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlMenuOpciones = new System.Windows.Forms.Panel();
            this.pblTitutlo = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pblTitutlo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuOpciones
            // 
            this.pnlMenuOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.pnlMenuOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuOpciones.Name = "pnlMenuOpciones";
            this.pnlMenuOpciones.Size = new System.Drawing.Size(250, 900);
            this.pnlMenuOpciones.TabIndex = 0;
            // 
            // pblTitutlo
            // 
            this.pblTitutlo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pblTitutlo.Controls.Add(this.pictureBox1);
            this.pblTitutlo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblTitutlo.Location = new System.Drawing.Point(250, 0);
            this.pblTitutlo.Name = "pblTitutlo";
            this.pblTitutlo.Size = new System.Drawing.Size(1480, 63);
            this.pblTitutlo.TabIndex = 1;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(250, 63);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1480, 837);
            this.pnlContenedor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 900);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pblTitutlo);
            this.Controls.Add(this.pnlMenuOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.pblTitutlo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuOpciones;
        private System.Windows.Forms.Panel pblTitutlo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}