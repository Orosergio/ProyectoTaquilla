namespace Taquilla
{
    partial class frmFuncionesCine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionesCine));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblFunciones = new System.Windows.Forms.Label();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.lstFunciones = new System.Windows.Forms.ListBox();
            this.btnSIguiente = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.picPelicula = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 77);
            this.panel1.TabIndex = 92;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(964, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 43);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 123;
            this.btnClose.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(895, 13);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(47, 43);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 122;
            this.btnMin.TabStop = false;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.White;
            this.lblDia.Location = new System.Drawing.Point(46, 151);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(42, 22);
            this.lblDia.TabIndex = 94;
            this.lblDia.Text = "Dia";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.ForeColor = System.Drawing.Color.White;
            this.lblFormato.Location = new System.Drawing.Point(43, 214);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(85, 22);
            this.lblFormato.TabIndex = 95;
            this.lblFormato.Text = "Formato";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.Color.White;
            this.lblIdioma.Location = new System.Drawing.Point(43, 295);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(74, 22);
            this.lblIdioma.TabIndex = 97;
            this.lblIdioma.Text = "Idioma";
            // 
            // lblFunciones
            // 
            this.lblFunciones.AutoSize = true;
            this.lblFunciones.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunciones.ForeColor = System.Drawing.Color.White;
            this.lblFunciones.Location = new System.Drawing.Point(43, 368);
            this.lblFunciones.Name = "lblFunciones";
            this.lblFunciones.Size = new System.Drawing.Size(101, 22);
            this.lblFunciones.TabIndex = 98;
            this.lblFunciones.Text = "Funciones";
            // 
            // dtpDia
            // 
            this.dtpDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDia.Location = new System.Drawing.Point(241, 143);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(296, 30);
            this.dtpDia.TabIndex = 99;
            // 
            // cboFormato
            // 
            this.cboFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Location = new System.Drawing.Point(241, 212);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(296, 33);
            this.cboFormato.TabIndex = 100;
            this.cboFormato.Text = "IMAX";
            // 
            // cboIdioma
            // 
            this.cboIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(241, 295);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(296, 33);
            this.cboIdioma.TabIndex = 102;
            this.cboIdioma.Text = "Ruso";
            // 
            // lstFunciones
            // 
            this.lstFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFunciones.FormattingEnabled = true;
            this.lstFunciones.ItemHeight = 25;
            this.lstFunciones.Items.AddRange(new object[] {
            "Sala 1: 3:00 PM"});
            this.lstFunciones.Location = new System.Drawing.Point(241, 368);
            this.lstFunciones.Name = "lstFunciones";
            this.lstFunciones.Size = new System.Drawing.Size(296, 154);
            this.lstFunciones.TabIndex = 103;
            // 
            // btnSIguiente
            // 
            this.btnSIguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.btnSIguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSIguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSIguiente.FlatAppearance.BorderSize = 0;
            this.btnSIguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSIguiente.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSIguiente.ForeColor = System.Drawing.Color.White;
            this.btnSIguiente.Location = new System.Drawing.Point(735, 585);
            this.btnSIguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSIguiente.Name = "btnSIguiente";
            this.btnSIguiente.Size = new System.Drawing.Size(208, 45);
            this.btnSIguiente.TabIndex = 117;
            this.btnSIguiente.Text = "Siguiente";
            this.btnSIguiente.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(63, 585);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(208, 45);
            this.btnRegresar.TabIndex = 118;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.ForeColor = System.Drawing.Color.White;
            this.lblPelicula.Location = new System.Drawing.Point(719, 495);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(130, 27);
            this.lblPelicula.TabIndex = 120;
            this.lblPelicula.Text = "Iron man 3";
            // 
            // picPelicula
            // 
            this.picPelicula.BackColor = System.Drawing.Color.White;
            this.picPelicula.Image = ((System.Drawing.Image)(resources.GetObject("picPelicula.Image")));
            this.picPelicula.ImageLocation = "";
            this.picPelicula.Location = new System.Drawing.Point(676, 143);
            this.picPelicula.Name = "picPelicula";
            this.picPelicula.Size = new System.Drawing.Size(237, 342);
            this.picPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPelicula.TabIndex = 121;
            this.picPelicula.TabStop = false;
            // 
            // frmFuncionesCine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1036, 684);
            this.Controls.Add(this.picPelicula);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSIguiente);
            this.Controls.Add(this.lstFunciones);
            this.Controls.Add(this.cboIdioma);
            this.Controls.Add(this.cboFormato);
            this.Controls.Add(this.dtpDia);
            this.Controls.Add(this.lblFunciones);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFuncionesCine";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuncionesCine";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblFunciones;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.ComboBox cboFormato;
        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.ListBox lstFunciones;
        private System.Windows.Forms.Button btnSIguiente;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.PictureBox picPelicula;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnClose;
    }
}