namespace AdministrativoReportes
{
    partial class frmModificacionBoleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacionBoleto));
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.lblCodigoBoleto = new System.Windows.Forms.Label();
            this.lblTipoBoleto = new System.Windows.Forms.Label();
            this.cboCodigoB = new System.Windows.Forms.ComboBox();
            this.cboBoleto = new System.Windows.Forms.ComboBox();
            this.cboCodigoF = new System.Windows.Forms.ComboBox();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(597, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 75);
            this.btnAyuda.TabIndex = 77;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(350, 338);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(283, 47);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(44, 338);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(283, 47);
            this.btnModificar.TabIndex = 75;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(202, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(282, 31);
            this.lblTitulo.TabIndex = 78;
            this.lblTitulo.Text = "Modificacion Boletos";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.ForeColor = System.Drawing.Color.White;
            this.lblFormato.Location = new System.Drawing.Point(39, 160);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(104, 27);
            this.lblFormato.TabIndex = 87;
            this.lblFormato.Text = "Formato";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.ForeColor = System.Drawing.Color.White;
            this.Precio.Location = new System.Drawing.Point(39, 216);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(84, 27);
            this.Precio.TabIndex = 85;
            this.Precio.Text = "Precio";
            // 
            // lblCodigoBoleto
            // 
            this.lblCodigoBoleto.AutoSize = true;
            this.lblCodigoBoleto.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBoleto.ForeColor = System.Drawing.Color.White;
            this.lblCodigoBoleto.Location = new System.Drawing.Point(39, 271);
            this.lblCodigoBoleto.Name = "lblCodigoBoleto";
            this.lblCodigoBoleto.Size = new System.Drawing.Size(82, 27);
            this.lblCodigoBoleto.TabIndex = 84;
            this.lblCodigoBoleto.Text = "Boleto";
            this.lblCodigoBoleto.Visible = false;
            // 
            // lblTipoBoleto
            // 
            this.lblTipoBoleto.AutoSize = true;
            this.lblTipoBoleto.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoBoleto.ForeColor = System.Drawing.Color.White;
            this.lblTipoBoleto.Location = new System.Drawing.Point(39, 103);
            this.lblTipoBoleto.Name = "lblTipoBoleto";
            this.lblTipoBoleto.Size = new System.Drawing.Size(82, 27);
            this.lblTipoBoleto.TabIndex = 83;
            this.lblTipoBoleto.Text = "Boleto";
            // 
            // cboCodigoB
            // 
            this.cboCodigoB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoB.FormattingEnabled = true;
            this.cboCodigoB.Location = new System.Drawing.Point(537, 100);
            this.cboCodigoB.Name = "cboCodigoB";
            this.cboCodigoB.Size = new System.Drawing.Size(80, 37);
            this.cboCodigoB.TabIndex = 89;
            this.cboCodigoB.Visible = false;
            // 
            // cboBoleto
            // 
            this.cboBoleto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoleto.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoleto.FormattingEnabled = true;
            this.cboBoleto.Location = new System.Drawing.Point(166, 100);
            this.cboBoleto.Name = "cboBoleto";
            this.cboBoleto.Size = new System.Drawing.Size(365, 34);
            this.cboBoleto.TabIndex = 88;
            this.cboBoleto.SelectedIndexChanged += new System.EventHandler(this.cboBoleto_SelectedIndexChanged);
            // 
            // cboCodigoF
            // 
            this.cboCodigoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoF.FormattingEnabled = true;
            this.cboCodigoF.Location = new System.Drawing.Point(537, 153);
            this.cboCodigoF.Name = "cboCodigoF";
            this.cboCodigoF.Size = new System.Drawing.Size(80, 37);
            this.cboCodigoF.TabIndex = 91;
            this.cboCodigoF.Visible = false;
            // 
            // cboFormato
            // 
            this.cboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormato.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Location = new System.Drawing.Point(166, 153);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(365, 34);
            this.cboFormato.TabIndex = 90;
            this.cboFormato.SelectedIndexChanged += new System.EventHandler(this.cboFormato_SelectedIndexChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(166, 208);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(365, 35);
            this.txtPrecio.TabIndex = 92;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // frmModificacionBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(704, 437);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboCodigoF);
            this.Controls.Add(this.cboFormato);
            this.Controls.Add(this.cboCodigoB);
            this.Controls.Add(this.cboBoleto);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.lblCodigoBoleto);
            this.Controls.Add(this.lblTipoBoleto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Name = "frmModificacionBoleto";
            this.Text = "frmModificacionBoleto";
            this.Load += new System.EventHandler(this.frmModificacionBoleto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label lblCodigoBoleto;
        private System.Windows.Forms.Label lblTipoBoleto;
        private System.Windows.Forms.ComboBox cboCodigoB;
        private System.Windows.Forms.ComboBox cboBoleto;
        private System.Windows.Forms.ComboBox cboCodigoF;
        private System.Windows.Forms.ComboBox cboFormato;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}