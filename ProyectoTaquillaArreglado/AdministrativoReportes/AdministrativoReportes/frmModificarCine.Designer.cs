namespace AdministrativoReportes
{
    partial class frmModificarCine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarCine));
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cboCodigoM = new System.Windows.Forms.ComboBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cboMunicipio = new System.Windows.Forms.ComboBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtCine = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblCine = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCineA = new System.Windows.Forms.Label();
            this.cboCine = new System.Windows.Forms.ComboBox();
            this.cboCodigoD = new System.Windows.Forms.ComboBox();
            this.cboCodigoCine = new System.Windows.Forms.ComboBox();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(787, 16);
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
            this.btnCancelar.Location = new System.Drawing.Point(579, 341);
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
            this.btnModificar.Location = new System.Drawing.Point(579, 278);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(283, 47);
            this.btnModificar.TabIndex = 75;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cboCodigoM
            // 
            this.cboCodigoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoM.FormattingEnabled = true;
            this.cboCodigoM.Location = new System.Drawing.Point(579, 233);
            this.cboCodigoM.Name = "cboCodigoM";
            this.cboCodigoM.Size = new System.Drawing.Size(80, 37);
            this.cboCodigoM.TabIndex = 101;
            this.cboCodigoM.Visible = false;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(208, 356);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(365, 35);
            this.txtTiempo.TabIndex = 99;
            this.txtTiempo.TextChanged += new System.EventHandler(this.txtTiempo_TextChanged);
            this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempo_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(208, 304);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(365, 35);
            this.txtDireccion.TabIndex = 98;
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMunicipio.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMunicipio.FormattingEnabled = true;
            this.cboMunicipio.Location = new System.Drawing.Point(208, 254);
            this.cboMunicipio.Name = "cboMunicipio";
            this.cboMunicipio.Size = new System.Drawing.Size(365, 34);
            this.cboMunicipio.TabIndex = 97;
            this.cboMunicipio.SelectedIndexChanged += new System.EventHandler(this.cboMunicipio_SelectedIndexChanged);
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(208, 201);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(365, 34);
            this.cboDepartamento.TabIndex = 96;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.White;
            this.lblDepartamento.Location = new System.Drawing.Point(15, 208);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(172, 27);
            this.lblDepartamento.TabIndex = 95;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtCine
            // 
            this.txtCine.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCine.Location = new System.Drawing.Point(208, 150);
            this.txtCine.Name = "txtCine";
            this.txtCine.Size = new System.Drawing.Size(365, 35);
            this.txtCine.TabIndex = 94;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(15, 364);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(97, 27);
            this.lblTiempo.TabIndex = 93;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(15, 312);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(122, 27);
            this.lblDireccion.TabIndex = 92;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.ForeColor = System.Drawing.Color.White;
            this.lblMunicipio.Location = new System.Drawing.Point(15, 261);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(124, 27);
            this.lblMunicipio.TabIndex = 91;
            this.lblMunicipio.Text = "Municipio";
            // 
            // lblCine
            // 
            this.lblCine.AutoSize = true;
            this.lblCine.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCine.ForeColor = System.Drawing.Color.White;
            this.lblCine.Location = new System.Drawing.Point(15, 158);
            this.lblCine.Name = "lblCine";
            this.lblCine.Size = new System.Drawing.Size(182, 27);
            this.lblCine.TabIndex = 90;
            this.lblCine.Text = "Nombre Nuevo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(220, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(298, 31);
            this.lblTitulo.TabIndex = 89;
            this.lblTitulo.Text = "Modificacion de cines";
            // 
            // lblCineA
            // 
            this.lblCineA.AutoSize = true;
            this.lblCineA.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCineA.ForeColor = System.Drawing.Color.White;
            this.lblCineA.Location = new System.Drawing.Point(15, 95);
            this.lblCineA.Name = "lblCineA";
            this.lblCineA.Size = new System.Drawing.Size(163, 27);
            this.lblCineA.TabIndex = 102;
            this.lblCineA.Text = "Nombre Cine";
            // 
            // cboCine
            // 
            this.cboCine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCine.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCine.FormattingEnabled = true;
            this.cboCine.Location = new System.Drawing.Point(208, 92);
            this.cboCine.Name = "cboCine";
            this.cboCine.Size = new System.Drawing.Size(365, 34);
            this.cboCine.TabIndex = 103;
            this.cboCine.SelectedIndexChanged += new System.EventHandler(this.cboCine_SelectedIndexChanged);
            // 
            // cboCodigoD
            // 
            this.cboCodigoD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoD.FormattingEnabled = true;
            this.cboCodigoD.Location = new System.Drawing.Point(579, 180);
            this.cboCodigoD.Name = "cboCodigoD";
            this.cboCodigoD.Size = new System.Drawing.Size(80, 37);
            this.cboCodigoD.TabIndex = 100;
            this.cboCodigoD.Visible = false;
            // 
            // cboCodigoCine
            // 
            this.cboCodigoCine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoCine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoCine.FormattingEnabled = true;
            this.cboCodigoCine.Location = new System.Drawing.Point(579, 92);
            this.cboCodigoCine.Name = "cboCodigoCine";
            this.cboCodigoCine.Size = new System.Drawing.Size(80, 37);
            this.cboCodigoCine.TabIndex = 104;
            this.cboCodigoCine.Visible = false;
            // 
            // cboEstatus
            // 
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(208, 406);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(365, 34);
            this.cboEstatus.TabIndex = 106;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(15, 413);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(90, 27);
            this.lblEstatus.TabIndex = 105;
            this.lblEstatus.Text = "Estatus";
            // 
            // frmModificarCine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(880, 533);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.cboCodigoCine);
            this.Controls.Add(this.cboCine);
            this.Controls.Add(this.lblCineA);
            this.Controls.Add(this.cboCodigoM);
            this.Controls.Add(this.cboCodigoD);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cboMunicipio);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.txtCine);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.lblCine);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Name = "frmModificarCine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarCine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboCodigoM;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cboMunicipio;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtCine;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblCine;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCineA;
        private System.Windows.Forms.ComboBox cboCine;
        private System.Windows.Forms.ComboBox cboCodigoD;
        private System.Windows.Forms.ComboBox cboCodigoCine;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.Label lblEstatus;
    }
}