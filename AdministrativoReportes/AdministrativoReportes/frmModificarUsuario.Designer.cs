﻿namespace AdministrativoReportes
{
    partial class frmModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCodigoA = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.cboCoEmp = new System.Windows.Forms.ComboBox();
            this.lblEstatusA = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombreA = new System.Windows.Forms.Label();
            this.cboCodigoU = new System.Windows.Forms.ComboBox();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.dgtDatos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario1 = new System.Windows.Forms.Label();
            this.lblEstatusC = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblU = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.cboCodigoR = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseñaCon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoA
            // 
            this.lblCodigoA.AutoSize = true;
            this.lblCodigoA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoA.ForeColor = System.Drawing.Color.White;
            this.lblCodigoA.Location = new System.Drawing.Point(1109, 439);
            this.lblCodigoA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoA.Name = "lblCodigoA";
            this.lblCodigoA.Size = new System.Drawing.Size(20, 21);
            this.lblCodigoA.TabIndex = 200;
            this.lblCodigoA.Text = "a";
            this.lblCodigoA.Visible = false;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(703, 523);
            this.cboEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(347, 29);
            this.cboEmpleado.TabIndex = 199;
            this.cboEmpleado.SelectedIndexChanged += new System.EventHandler(this.cboEmpleado_SelectedIndexChanged);
            // 
            // cboEstatus
            // 
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(835, 705);
            this.cboEstatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(213, 29);
            this.cboEstatus.TabIndex = 198;
            // 
            // cboCoEmp
            // 
            this.cboCoEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCoEmp.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCoEmp.FormattingEnabled = true;
            this.cboCoEmp.Location = new System.Drawing.Point(1051, 528);
            this.cboCoEmp.Margin = new System.Windows.Forms.Padding(2);
            this.cboCoEmp.Name = "cboCoEmp";
            this.cboCoEmp.Size = new System.Drawing.Size(45, 29);
            this.cboCoEmp.TabIndex = 195;
            this.cboCoEmp.Visible = false;
            // 
            // lblEstatusA
            // 
            this.lblEstatusA.AutoSize = true;
            this.lblEstatusA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusA.ForeColor = System.Drawing.Color.White;
            this.lblEstatusA.Location = new System.Drawing.Point(29, 612);
            this.lblEstatusA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstatusA.Name = "lblEstatusA";
            this.lblEstatusA.Size = new System.Drawing.Size(73, 21);
            this.lblEstatusA.TabIndex = 180;
            this.lblEstatusA.Text = "Estatus";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(29, 649);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(111, 21);
            this.lblContraseña.TabIndex = 178;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.Visible = false;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(29, 516);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(38, 21);
            this.lblRol.TabIndex = 177;
            this.lblRol.Text = "Rol";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(29, 578);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(78, 21);
            this.lblUsuario.TabIndex = 176;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblNombreA
            // 
            this.lblNombreA.AutoSize = true;
            this.lblNombreA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreA.ForeColor = System.Drawing.Color.White;
            this.lblNombreA.Location = new System.Drawing.Point(29, 548);
            this.lblNombreA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(100, 21);
            this.lblNombreA.TabIndex = 175;
            this.lblNombreA.Text = "Empleado";
            // 
            // cboCodigoU
            // 
            this.cboCodigoU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoU.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoU.FormattingEnabled = true;
            this.cboCodigoU.Location = new System.Drawing.Point(350, 70);
            this.cboCodigoU.Margin = new System.Windows.Forms.Padding(2);
            this.cboCodigoU.Name = "cboCodigoU";
            this.cboCodigoU.Size = new System.Drawing.Size(62, 29);
            this.cboCodigoU.TabIndex = 174;
            this.cboCodigoU.Visible = false;
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(109, 70);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(237, 29);
            this.cboUsuario.TabIndex = 173;
            this.cboUsuario.SelectedIndexChanged += new System.EventHandler(this.cboUsuario_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(1029, 439);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 21);
            this.txtCodigo.TabIndex = 172;
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
            this.btnModificar.Location = new System.Drawing.Point(855, 430);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(170, 38);
            this.btnModificar.TabIndex = 171;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.ForeColor = System.Drawing.Color.White;
            this.lblTitulo3.Location = new System.Drawing.Point(776, 487);
            this.lblTitulo3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(131, 21);
            this.lblTitulo3.TabIndex = 170;
            this.lblTitulo3.Text = "Datos Nuevos";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(105, 465);
            this.lblTitulo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(156, 21);
            this.lblTitulo2.TabIndex = 169;
            this.lblTitulo2.Text = "Datos anteriores";
            // 
            // dgtDatos
            // 
            this.dgtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDatos.Location = new System.Drawing.Point(30, 106);
            this.dgtDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgtDatos.Name = "dgtDatos";
            this.dgtDatos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtDatos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgtDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgtDatos.RowTemplate.Height = 24;
            this.dgtDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtDatos.Size = new System.Drawing.Size(942, 302);
            this.dgtDatos.TabIndex = 168;
            this.dgtDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtDatos_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(431, 64);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 38);
            this.btnBuscar.TabIndex = 167;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(276, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 23);
            this.lblTitulo.TabIndex = 166;
            this.lblTitulo.Text = "Modificacion de Usuario";
            // 
            // lblUsuario1
            // 
            this.lblUsuario1.AutoSize = true;
            this.lblUsuario1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario1.ForeColor = System.Drawing.Color.White;
            this.lblUsuario1.Location = new System.Drawing.Point(26, 68);
            this.lblUsuario1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario1.Name = "lblUsuario1";
            this.lblUsuario1.Size = new System.Drawing.Size(78, 21);
            this.lblUsuario1.TabIndex = 165;
            this.lblUsuario1.Text = "Usuario";
            // 
            // lblEstatusC
            // 
            this.lblEstatusC.AutoSize = true;
            this.lblEstatusC.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusC.ForeColor = System.Drawing.Color.White;
            this.lblEstatusC.Location = new System.Drawing.Point(145, 612);
            this.lblEstatusC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstatusC.Name = "lblEstatusC";
            this.lblEstatusC.Size = new System.Drawing.Size(0, 21);
            this.lblEstatusC.TabIndex = 205;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(145, 649);
            this.lblC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(0, 21);
            this.lblC.TabIndex = 204;
            this.lblC.Visible = false;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.ForeColor = System.Drawing.Color.White;
            this.lblR.Location = new System.Drawing.Point(134, 516);
            this.lblR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(0, 21);
            this.lblR.TabIndex = 203;
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU.ForeColor = System.Drawing.Color.White;
            this.lblU.Location = new System.Drawing.Point(145, 578);
            this.lblU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(0, 21);
            this.lblU.TabIndex = 202;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.ForeColor = System.Drawing.Color.White;
            this.lblE.Location = new System.Drawing.Point(145, 547);
            this.lblE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(0, 21);
            this.lblE.TabIndex = 201;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(575, 704);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 210;
            this.label1.Text = "Estatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(575, 628);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 209;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(576, 560);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 208;
            this.label3.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(576, 592);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 207;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(576, 523);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 206;
            this.label5.Text = "Empleado";
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(703, 555);
            this.cboRol.Margin = new System.Windows.Forms.Padding(2);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(347, 29);
            this.cboRol.TabIndex = 211;
            this.cboRol.SelectedIndexChanged += new System.EventHandler(this.cboRol_SelectedIndexChanged);
            // 
            // cboCodigoR
            // 
            this.cboCodigoR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoR.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoR.FormattingEnabled = true;
            this.cboCodigoR.Location = new System.Drawing.Point(1051, 566);
            this.cboCodigoR.Margin = new System.Windows.Forms.Padding(2);
            this.cboCodigoR.Name = "cboCodigoR";
            this.cboCodigoR.Size = new System.Drawing.Size(45, 29);
            this.cboCodigoR.TabIndex = 212;
            this.cboCodigoR.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(703, 591);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(345, 30);
            this.txtUsuario.TabIndex = 213;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(833, 628);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(215, 30);
            this.txtContraseña.TabIndex = 214;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtContraseñaCon
            // 
            this.txtContraseñaCon.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaCon.Location = new System.Drawing.Point(835, 667);
            this.txtContraseñaCon.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaCon.Name = "txtContraseñaCon";
            this.txtContraseñaCon.Size = new System.Drawing.Size(215, 30);
            this.txtContraseñaCon.TabIndex = 215;
            this.txtContraseñaCon.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(576, 670);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 21);
            this.label6.TabIndex = 216;
            this.label6.Text = "Confirmacion Contraseña";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(1049, 28);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(56, 61);
            this.btnAyuda.TabIndex = 217;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // frmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1124, 786);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContraseñaCon);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cboCodigoR);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEstatusC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblU);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblCodigoA);
            this.Controls.Add(this.cboEmpleado);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.cboCoEmp);
            this.Controls.Add(this.lblEstatusA);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNombreA);
            this.Controls.Add(this.cboCodigoU);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblTitulo3);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.dgtDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarUsuario";
            this.Load += new System.EventHandler(this.frmModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoA;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.ComboBox cboCoEmp;
        private System.Windows.Forms.Label lblEstatusA;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombreA;
        private System.Windows.Forms.ComboBox cboCodigoU;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.DataGridView dgtDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario1;
        private System.Windows.Forms.Label lblEstatusC;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.ComboBox cboCodigoR;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtContraseñaCon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAyuda;
    }
}