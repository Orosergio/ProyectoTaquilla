﻿namespace AdministrativoReportes
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
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(926, 244);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(95, 27);
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
            this.btnModificar.Location = new System.Drawing.Point(572, 90);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(227, 47);
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
            this.cboEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstatus.Location = new System.Drawing.Point(564, 620);
            this.cboEstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(335, 35);
            this.cboEstatus.TabIndex = 109;
            // 
            // cboEmpleadoN
            // 
            this.cboEmpleadoN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleadoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpleadoN.FormattingEnabled = true;
            this.cboEmpleadoN.Location = new System.Drawing.Point(564, 575);
            this.cboEmpleadoN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEmpleadoN.Name = "cboEmpleadoN";
            this.cboEmpleadoN.Size = new System.Drawing.Size(335, 35);
            this.cboEmpleadoN.TabIndex = 108;
            // 
            // txtCorreoN
            // 
            this.txtCorreoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoN.Location = new System.Drawing.Point(564, 521);
            this.txtCorreoN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreoN.Name = "txtCorreoN";
            this.txtCorreoN.Size = new System.Drawing.Size(335, 35);
            this.txtCorreoN.TabIndex = 107;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.ForeColor = System.Drawing.Color.White;
            this.lblE.Location = new System.Drawing.Point(209, 569);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(0, 27);
            this.lblE.TabIndex = 106;
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEs.ForeColor = System.Drawing.Color.White;
            this.lblEs.Location = new System.Drawing.Point(209, 617);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(0, 27);
            this.lblEs.TabIndex = 105;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.ForeColor = System.Drawing.Color.White;
            this.lblT.Location = new System.Drawing.Point(207, 524);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(0, 27);
            this.lblT.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(567, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 27);
            this.label3.TabIndex = 103;
            this.label3.Text = "Datos Nuevos";
            // 
            // lblEmpleadoN
            // 
            this.lblEmpleadoN.AutoSize = true;
            this.lblEmpleadoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoN.ForeColor = System.Drawing.Color.White;
            this.lblEmpleadoN.Location = new System.Drawing.Point(425, 572);
            this.lblEmpleadoN.Name = "lblEmpleadoN";
            this.lblEmpleadoN.Size = new System.Drawing.Size(126, 27);
            this.lblEmpleadoN.TabIndex = 102;
            this.lblEmpleadoN.Text = "Empleado";
            // 
            // lblEstatusN
            // 
            this.lblEstatusN.AutoSize = true;
            this.lblEstatusN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusN.ForeColor = System.Drawing.Color.White;
            this.lblEstatusN.Location = new System.Drawing.Point(425, 620);
            this.lblEstatusN.Name = "lblEstatusN";
            this.lblEstatusN.Size = new System.Drawing.Size(90, 27);
            this.lblEstatusN.TabIndex = 101;
            this.lblEstatusN.Text = "Estatus";
            // 
            // lblCorreoN
            // 
            this.lblCorreoN.AutoSize = true;
            this.lblCorreoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoN.ForeColor = System.Drawing.Color.White;
            this.lblCorreoN.Location = new System.Drawing.Point(423, 528);
            this.lblCorreoN.Name = "lblCorreoN";
            this.lblCorreoN.Size = new System.Drawing.Size(110, 27);
            this.lblCorreoN.TabIndex = 100;
            this.lblCorreoN.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 27);
            this.label2.TabIndex = 99;
            this.label2.Text = "Datos anteriores";
            // 
            // lblEmpleadoA
            // 
            this.lblEmpleadoA.AutoSize = true;
            this.lblEmpleadoA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoA.ForeColor = System.Drawing.Color.White;
            this.lblEmpleadoA.Location = new System.Drawing.Point(73, 566);
            this.lblEmpleadoA.Name = "lblEmpleadoA";
            this.lblEmpleadoA.Size = new System.Drawing.Size(126, 27);
            this.lblEmpleadoA.TabIndex = 98;
            this.lblEmpleadoA.Text = "Empleado";
            // 
            // lblEstatusA
            // 
            this.lblEstatusA.AutoSize = true;
            this.lblEstatusA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusA.ForeColor = System.Drawing.Color.White;
            this.lblEstatusA.Location = new System.Drawing.Point(73, 614);
            this.lblEstatusA.Name = "lblEstatusA";
            this.lblEstatusA.Size = new System.Drawing.Size(90, 27);
            this.lblEstatusA.TabIndex = 97;
            this.lblEstatusA.Text = "Estatus";
            // 
            // lblCorreoA
            // 
            this.lblCorreoA.AutoSize = true;
            this.lblCorreoA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoA.ForeColor = System.Drawing.Color.White;
            this.lblCorreoA.Location = new System.Drawing.Point(71, 522);
            this.lblCorreoA.Name = "lblCorreoA";
            this.lblCorreoA.Size = new System.Drawing.Size(92, 27);
            this.lblCorreoA.TabIndex = 96;
            this.lblCorreoA.Text = "Correo";
            // 
            // dgtDatos
            // 
            this.dgtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDatos.Location = new System.Drawing.Point(27, 164);
            this.dgtDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgtDatos.Name = "dgtDatos";
            this.dgtDatos.ReadOnly = true;
            this.dgtDatos.RowHeadersWidth = 51;
            this.dgtDatos.RowTemplate.Height = 24;
            this.dgtDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtDatos.Size = new System.Drawing.Size(893, 254);
            this.dgtDatos.TabIndex = 95;
            this.dgtDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtDatos_CellContentClick);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(135, 92);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(371, 35);
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
            this.btnBuscar.Location = new System.Drawing.Point(572, 25);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(227, 47);
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
            this.lblTitulo.Location = new System.Drawing.Point(21, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 31);
            this.lblTitulo.TabIndex = 92;
            this.lblTitulo.Text = "Modificacion de Correo";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(21, 101);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(92, 27);
            this.lblCorreo.TabIndex = 91;
            this.lblCorreo.Text = "Correo";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(728, 192);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(0, 27);
            this.lblC.TabIndex = 112;
            this.lblC.Visible = false;
            // 
            // cboCodigoN
            // 
            this.cboCodigoN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoN.FormattingEnabled = true;
            this.cboCodigoN.Location = new System.Drawing.Point(917, 575);
            this.cboCodigoN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCodigoN.Name = "cboCodigoN";
            this.cboCodigoN.Size = new System.Drawing.Size(73, 35);
            this.cboCodigoN.TabIndex = 113;
            this.cboCodigoN.Visible = false;
            this.cboCodigoN.SelectedIndexChanged += new System.EventHandler(this.cboCodigoN_SelectedIndexChanged);
            // 
            // frmModificarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1136, 718);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}