namespace AdministrativoReportes
{
    partial class frmModificarCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarCorreo));
            this.txtCodigo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.cboEmpleadoN = new System.Windows.Forms.ComboBox();
            this.txtCorreoN = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblEs = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmpleadoN = new System.Windows.Forms.Label();
            this.lblEstatusN = new System.Windows.Forms.Label();
            this.lblCorreoN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpleadoA = new System.Windows.Forms.Label();
            this.lblEstatusA = new System.Windows.Forms.Label();
            this.lblCorreoA = new System.Windows.Forms.Label();
            this.dgtDatos = new System.Windows.Forms.DataGridView();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.cboCodigoN = new System.Windows.Forms.ComboBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.lblCodigoCorreo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(11, 395);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 21);
            this.txtCodigo.TabIndex = 111;
            this.txtCodigo.Text = "Codigo";
            this.txtCodigo.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(693, 548);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(170, 38);
            this.btnModificar.TabIndex = 110;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cboEstatus
            // 
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(425, 548);
            this.cboEstatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(252, 29);
            this.cboEstatus.TabIndex = 109;
            // 
            // cboEmpleadoN
            // 
            this.cboEmpleadoN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleadoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpleadoN.FormattingEnabled = true;
            this.cboEmpleadoN.Location = new System.Drawing.Point(425, 511);
            this.cboEmpleadoN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEmpleadoN.Name = "cboEmpleadoN";
            this.cboEmpleadoN.Size = new System.Drawing.Size(362, 29);
            this.cboEmpleadoN.TabIndex = 108;
            this.cboEmpleadoN.SelectedIndexChanged += new System.EventHandler(this.cboEmpleadoN_SelectedIndexChanged);
            // 
            // txtCorreoN
            // 
            this.txtCorreoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoN.Location = new System.Drawing.Point(425, 467);
            this.txtCorreoN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreoN.Name = "txtCorreoN";
            this.txtCorreoN.Size = new System.Drawing.Size(252, 30);
            this.txtCorreoN.TabIndex = 107;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.ForeColor = System.Drawing.Color.White;
            this.lblE.Location = new System.Drawing.Point(114, 506);
            this.lblE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(0, 21);
            this.lblE.TabIndex = 106;
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEs.ForeColor = System.Drawing.Color.White;
            this.lblEs.Location = new System.Drawing.Point(114, 544);
            this.lblEs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(0, 21);
            this.lblEs.TabIndex = 105;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.ForeColor = System.Drawing.Color.White;
            this.lblT.Location = new System.Drawing.Point(113, 469);
            this.lblT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(0, 21);
            this.lblT.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(427, 428);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 103;
            this.label3.Text = "Datos Nuevos";
            // 
            // lblEmpleadoN
            // 
            this.lblEmpleadoN.AutoSize = true;
            this.lblEmpleadoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoN.ForeColor = System.Drawing.Color.White;
            this.lblEmpleadoN.Location = new System.Drawing.Point(321, 509);
            this.lblEmpleadoN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleadoN.Name = "lblEmpleadoN";
            this.lblEmpleadoN.Size = new System.Drawing.Size(100, 21);
            this.lblEmpleadoN.TabIndex = 102;
            this.lblEmpleadoN.Text = "Empleado";
            // 
            // lblEstatusN
            // 
            this.lblEstatusN.AutoSize = true;
            this.lblEstatusN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusN.ForeColor = System.Drawing.Color.White;
            this.lblEstatusN.Location = new System.Drawing.Point(321, 548);
            this.lblEstatusN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstatusN.Name = "lblEstatusN";
            this.lblEstatusN.Size = new System.Drawing.Size(73, 21);
            this.lblEstatusN.TabIndex = 101;
            this.lblEstatusN.Text = "Estatus";
            // 
            // lblCorreoN
            // 
            this.lblCorreoN.AutoSize = true;
            this.lblCorreoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoN.ForeColor = System.Drawing.Color.White;
            this.lblCorreoN.Location = new System.Drawing.Point(319, 473);
            this.lblCorreoN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreoN.Name = "lblCorreoN";
            this.lblCorreoN.Size = new System.Drawing.Size(73, 21);
            this.lblCorreoN.TabIndex = 100;
            this.lblCorreoN.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 428);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 99;
            this.label2.Text = "Datos anteriores";
            // 
            // lblEmpleadoA
            // 
            this.lblEmpleadoA.AutoSize = true;
            this.lblEmpleadoA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoA.ForeColor = System.Drawing.Color.White;
            this.lblEmpleadoA.Location = new System.Drawing.Point(11, 506);
            this.lblEmpleadoA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleadoA.Name = "lblEmpleadoA";
            this.lblEmpleadoA.Size = new System.Drawing.Size(100, 21);
            this.lblEmpleadoA.TabIndex = 98;
            this.lblEmpleadoA.Text = "Empleado";
            // 
            // lblEstatusA
            // 
            this.lblEstatusA.AutoSize = true;
            this.lblEstatusA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusA.ForeColor = System.Drawing.Color.White;
            this.lblEstatusA.Location = new System.Drawing.Point(12, 542);
            this.lblEstatusA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstatusA.Name = "lblEstatusA";
            this.lblEstatusA.Size = new System.Drawing.Size(73, 21);
            this.lblEstatusA.TabIndex = 97;
            this.lblEstatusA.Text = "Estatus";
            // 
            // lblCorreoA
            // 
            this.lblCorreoA.AutoSize = true;
            this.lblCorreoA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoA.ForeColor = System.Drawing.Color.White;
            this.lblCorreoA.Location = new System.Drawing.Point(11, 467);
            this.lblCorreoA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreoA.Name = "lblCorreoA";
            this.lblCorreoA.Size = new System.Drawing.Size(73, 21);
            this.lblCorreoA.TabIndex = 96;
            this.lblCorreoA.Text = "Correo";
            // 
            // dgtDatos
            // 
            this.dgtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDatos.Location = new System.Drawing.Point(20, 133);
            this.dgtDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgtDatos.Name = "dgtDatos";
            this.dgtDatos.ReadOnly = true;
            this.dgtDatos.RowHeadersWidth = 51;
            this.dgtDatos.RowTemplate.Height = 24;
            this.dgtDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtDatos.Size = new System.Drawing.Size(657, 243);
            this.dgtDatos.TabIndex = 95;
            this.dgtDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtDatos_CellContentClick);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(101, 75);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(279, 30);
            this.txtCorreo.TabIndex = 94;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(405, 69);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 38);
            this.btnBuscar.TabIndex = 93;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(16, 10);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 23);
            this.lblTitulo.TabIndex = 92;
            this.lblTitulo.Text = "Modificacion de Correo";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(16, 82);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(73, 21);
            this.lblCorreo.TabIndex = 91;
            this.lblCorreo.Text = "Correo";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(546, 156);
            this.lblC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(0, 21);
            this.lblC.TabIndex = 112;
            this.lblC.Visible = false;
            // 
            // cboCodigoN
            // 
            this.cboCodigoN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoN.FormattingEnabled = true;
            this.cboCodigoN.Location = new System.Drawing.Point(731, 480);
            this.cboCodigoN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCodigoN.Name = "cboCodigoN";
            this.cboCodigoN.Size = new System.Drawing.Size(56, 29);
            this.cboCodigoN.TabIndex = 113;
            this.cboCodigoN.Visible = false;
            this.cboCodigoN.SelectedIndexChanged += new System.EventHandler(this.cboCodigoN_SelectedIndexChanged);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(807, 32);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(56, 61);
            this.btnAyuda.TabIndex = 114;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // lblCodigoCorreo
            // 
            this.lblCodigoCorreo.AutoSize = true;
            this.lblCodigoCorreo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCodigoCorreo.Location = new System.Drawing.Point(83, 395);
            this.lblCodigoCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoCorreo.Name = "lblCodigoCorreo";
            this.lblCodigoCorreo.Size = new System.Drawing.Size(76, 21);
            this.lblCodigoCorreo.TabIndex = 115;
            this.lblCodigoCorreo.Text = "Codigo";
            this.lblCodigoCorreo.Visible = false;
            // 
            // frmModificarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(890, 668);
            this.Controls.Add(this.lblCodigoCorreo);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.cboCodigoN);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.cboEmpleadoN);
            this.Controls.Add(this.txtCorreoN);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblEs);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmpleadoN);
            this.Controls.Add(this.lblEstatusN);
            this.Controls.Add(this.lblCorreoN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmpleadoA);
            this.Controls.Add(this.lblEstatusA);
            this.Controls.Add(this.lblCorreoA);
            this.Controls.Add(this.dgtDatos);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCorreo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmModificarCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarCorreo";
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.ComboBox cboEmpleadoN;
        private System.Windows.Forms.TextBox txtCorreoN;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblEs;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmpleadoN;
        private System.Windows.Forms.Label lblEstatusN;
        private System.Windows.Forms.Label lblCorreoN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpleadoA;
        private System.Windows.Forms.Label lblEstatusA;
        private System.Windows.Forms.Label lblCorreoA;
        private System.Windows.Forms.DataGridView dgtDatos;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.ComboBox cboCodigoN;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblCodigoCorreo;
    }
}