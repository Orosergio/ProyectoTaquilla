﻿namespace AdministrativoReportes
{
    partial class frmModificarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarEmpleado));
            this.txtCodigo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.dgtDatos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cboNombre = new System.Windows.Forms.ComboBox();
            this.cboCodigoE = new System.Windows.Forms.ComboBox();
            this.lblNombreA = new System.Windows.Forms.Label();
            this.lblPuestoA = new System.Windows.Forms.Label();
            this.lblApellidoA = new System.Windows.Forms.Label();
            this.lblFechaAC = new System.Windows.Forms.Label();
            this.lblFechaAN = new System.Windows.Forms.Label();
            this.lblEstatusA = new System.Windows.Forms.Label();
            this.lblEs = new System.Windows.Forms.Label();
            this.lblNA = new System.Windows.Forms.Label();
            this.lblCa = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblFechaNN = new System.Windows.Forms.Label();
            this.lblFechaCN = new System.Windows.Forms.Label();
            this.lblApellidoN = new System.Windows.Forms.Label();
            this.lblPuestoN = new System.Windows.Forms.Label();
            this.lblNombreN = new System.Windows.Forms.Label();
            this.txtNombreN = new System.Windows.Forms.TextBox();
            this.txtApellidoN = new System.Windows.Forms.TextBox();
            this.cboCodigoPnuevo = new System.Windows.Forms.ComboBox();
            this.dtpContratacionN = new System.Windows.Forms.DateTimePicker();
            this.dtpNacimientoN = new System.Windows.Forms.DateTimePicker();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.cboPuestoN = new System.Windows.Forms.ComboBox();
            this.lblCodigoA = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(946, 347);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(95, 27);
            this.txtCodigo.TabIndex = 134;
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
            this.btnModificar.Location = new System.Drawing.Point(946, 154);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(227, 47);
            this.btnModificar.TabIndex = 133;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.ForeColor = System.Drawing.Color.White;
            this.lblTitulo3.Location = new System.Drawing.Point(937, 454);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(164, 27);
            this.lblTitulo3.TabIndex = 126;
            this.lblTitulo3.Text = "Datos Nuevos";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(177, 454);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(195, 27);
            this.lblTitulo2.TabIndex = 122;
            this.lblTitulo2.Text = "Datos anteriores";
            // 
            // dgtDatos
            // 
            this.dgtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDatos.Location = new System.Drawing.Point(35, 154);
            this.dgtDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgtDatos.Name = "dgtDatos";
            this.dgtDatos.ReadOnly = true;
            this.dgtDatos.RowHeadersWidth = 51;
            this.dgtDatos.RowTemplate.Height = 24;
            this.dgtDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtDatos.Size = new System.Drawing.Size(905, 273);
            this.dgtDatos.TabIndex = 118;
            this.dgtDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtDatos_CellContentClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(441, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(346, 31);
            this.lblTitulo.TabIndex = 115;
            this.lblTitulo.Text = "Modificacion de Empleado";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblEmpleado.Location = new System.Drawing.Point(29, 87);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(126, 27);
            this.lblEmpleado.TabIndex = 114;
            this.lblEmpleado.Text = "Empleado";
            // 
            // cboNombre
            // 
            this.cboNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombre.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNombre.FormattingEnabled = true;
            this.cboNombre.Location = new System.Drawing.Point(168, 87);
            this.cboNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNombre.Name = "cboNombre";
            this.cboNombre.Size = new System.Drawing.Size(549, 35);
            this.cboNombre.TabIndex = 137;
            this.cboNombre.SelectedIndexChanged += new System.EventHandler(this.cboNombre_SelectedIndexChanged);
            // 
            // cboCodigoE
            // 
            this.cboCodigoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoE.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoE.FormattingEnabled = true;
            this.cboCodigoE.Location = new System.Drawing.Point(732, 87);
            this.cboCodigoE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCodigoE.Name = "cboCodigoE";
            this.cboCodigoE.Size = new System.Drawing.Size(81, 35);
            this.cboCodigoE.TabIndex = 138;
            this.cboCodigoE.Visible = false;
            // 
            // lblNombreA
            // 
            this.lblNombreA.AutoSize = true;
            this.lblNombreA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreA.ForeColor = System.Drawing.Color.White;
            this.lblNombreA.Location = new System.Drawing.Point(43, 512);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(104, 27);
            this.lblNombreA.TabIndex = 139;
            this.lblNombreA.Text = "Nombre";
            // 
            // lblPuestoA
            // 
            this.lblPuestoA.AutoSize = true;
            this.lblPuestoA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoA.ForeColor = System.Drawing.Color.White;
            this.lblPuestoA.Location = new System.Drawing.Point(43, 587);
            this.lblPuestoA.Name = "lblPuestoA";
            this.lblPuestoA.Size = new System.Drawing.Size(86, 27);
            this.lblPuestoA.TabIndex = 140;
            this.lblPuestoA.Text = "Puesto";
            // 
            // lblApellidoA
            // 
            this.lblApellidoA.AutoSize = true;
            this.lblApellidoA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoA.ForeColor = System.Drawing.Color.White;
            this.lblApellidoA.Location = new System.Drawing.Point(43, 551);
            this.lblApellidoA.Name = "lblApellidoA";
            this.lblApellidoA.Size = new System.Drawing.Size(108, 27);
            this.lblApellidoA.TabIndex = 140;
            this.lblApellidoA.Text = "Apellido";
            // 
            // lblFechaAC
            // 
            this.lblFechaAC.AutoSize = true;
            this.lblFechaAC.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAC.ForeColor = System.Drawing.Color.White;
            this.lblFechaAC.Location = new System.Drawing.Point(43, 625);
            this.lblFechaAC.Name = "lblFechaAC";
            this.lblFechaAC.Size = new System.Drawing.Size(229, 27);
            this.lblFechaAC.TabIndex = 141;
            this.lblFechaAC.Text = "Fecha Contratacion";
            // 
            // lblFechaAN
            // 
            this.lblFechaAN.AutoSize = true;
            this.lblFechaAN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAN.ForeColor = System.Drawing.Color.White;
            this.lblFechaAN.Location = new System.Drawing.Point(43, 661);
            this.lblFechaAN.Name = "lblFechaAN";
            this.lblFechaAN.Size = new System.Drawing.Size(212, 27);
            this.lblFechaAN.TabIndex = 142;
            this.lblFechaAN.Text = "Fecha Nacimiento";
            // 
            // lblEstatusA
            // 
            this.lblEstatusA.AutoSize = true;
            this.lblEstatusA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusA.ForeColor = System.Drawing.Color.White;
            this.lblEstatusA.Location = new System.Drawing.Point(43, 699);
            this.lblEstatusA.Name = "lblEstatusA";
            this.lblEstatusA.Size = new System.Drawing.Size(90, 27);
            this.lblEstatusA.TabIndex = 143;
            this.lblEstatusA.Text = "Estatus";
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEs.ForeColor = System.Drawing.Color.White;
            this.lblEs.Location = new System.Drawing.Point(223, 695);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(0, 27);
            this.lblEs.TabIndex = 149;
            // 
            // lblNA
            // 
            this.lblNA.AutoSize = true;
            this.lblNA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNA.ForeColor = System.Drawing.Color.White;
            this.lblNA.Location = new System.Drawing.Point(300, 661);
            this.lblNA.Name = "lblNA";
            this.lblNA.Size = new System.Drawing.Size(0, 27);
            this.lblNA.TabIndex = 148;
            // 
            // lblCa
            // 
            this.lblCa.AutoSize = true;
            this.lblCa.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCa.ForeColor = System.Drawing.Color.White;
            this.lblCa.Location = new System.Drawing.Point(304, 624);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(0, 27);
            this.lblCa.TabIndex = 147;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.White;
            this.lblA.Location = new System.Drawing.Point(228, 551);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 27);
            this.lblA.TabIndex = 145;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.White;
            this.lblP.Location = new System.Drawing.Point(223, 588);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(0, 27);
            this.lblP.TabIndex = 146;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.ForeColor = System.Drawing.Color.White;
            this.lblN.Location = new System.Drawing.Point(228, 512);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 27);
            this.lblN.TabIndex = 144;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(747, 756);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(90, 27);
            this.lblEstatus.TabIndex = 155;
            this.lblEstatus.Text = "Estatus";
            // 
            // lblFechaNN
            // 
            this.lblFechaNN.AutoSize = true;
            this.lblFechaNN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNN.ForeColor = System.Drawing.Color.White;
            this.lblFechaNN.Location = new System.Drawing.Point(744, 699);
            this.lblFechaNN.Name = "lblFechaNN";
            this.lblFechaNN.Size = new System.Drawing.Size(212, 27);
            this.lblFechaNN.TabIndex = 154;
            this.lblFechaNN.Text = "Fecha Nacimiento";
            // 
            // lblFechaCN
            // 
            this.lblFechaCN.AutoSize = true;
            this.lblFechaCN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCN.ForeColor = System.Drawing.Color.White;
            this.lblFechaCN.Location = new System.Drawing.Point(745, 639);
            this.lblFechaCN.Name = "lblFechaCN";
            this.lblFechaCN.Size = new System.Drawing.Size(229, 27);
            this.lblFechaCN.TabIndex = 153;
            this.lblFechaCN.Text = "Fecha Contratacion";
            // 
            // lblApellidoN
            // 
            this.lblApellidoN.AutoSize = true;
            this.lblApellidoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoN.ForeColor = System.Drawing.Color.White;
            this.lblApellidoN.Location = new System.Drawing.Point(745, 548);
            this.lblApellidoN.Name = "lblApellidoN";
            this.lblApellidoN.Size = new System.Drawing.Size(108, 27);
            this.lblApellidoN.TabIndex = 151;
            this.lblApellidoN.Text = "Apellido";
            // 
            // lblPuestoN
            // 
            this.lblPuestoN.AutoSize = true;
            this.lblPuestoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoN.ForeColor = System.Drawing.Color.White;
            this.lblPuestoN.Location = new System.Drawing.Point(747, 586);
            this.lblPuestoN.Name = "lblPuestoN";
            this.lblPuestoN.Size = new System.Drawing.Size(86, 27);
            this.lblPuestoN.TabIndex = 152;
            this.lblPuestoN.Text = "Puesto";
            // 
            // lblNombreN
            // 
            this.lblNombreN.AutoSize = true;
            this.lblNombreN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreN.ForeColor = System.Drawing.Color.White;
            this.lblNombreN.Location = new System.Drawing.Point(745, 503);
            this.lblNombreN.Name = "lblNombreN";
            this.lblNombreN.Size = new System.Drawing.Size(104, 27);
            this.lblNombreN.TabIndex = 150;
            this.lblNombreN.Text = "Nombre";
            // 
            // txtNombreN
            // 
            this.txtNombreN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreN.Location = new System.Drawing.Point(993, 503);
            this.txtNombreN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreN.Name = "txtNombreN";
            this.txtNombreN.Size = new System.Drawing.Size(373, 35);
            this.txtNombreN.TabIndex = 156;
            this.txtNombreN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreN_KeyPress);
            // 
            // txtApellidoN
            // 
            this.txtApellidoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoN.Location = new System.Drawing.Point(993, 548);
            this.txtApellidoN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoN.Name = "txtApellidoN";
            this.txtApellidoN.Size = new System.Drawing.Size(373, 35);
            this.txtApellidoN.TabIndex = 157;
            this.txtApellidoN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoN_KeyPress);
            // 
            // cboCodigoPnuevo
            // 
            this.cboCodigoPnuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoPnuevo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoPnuevo.FormattingEnabled = true;
            this.cboCodigoPnuevo.Location = new System.Drawing.Point(1308, 594);
            this.cboCodigoPnuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCodigoPnuevo.Name = "cboCodigoPnuevo";
            this.cboCodigoPnuevo.Size = new System.Drawing.Size(59, 35);
            this.cboCodigoPnuevo.TabIndex = 159;
            this.cboCodigoPnuevo.Visible = false;
            // 
            // dtpContratacionN
            // 
            this.dtpContratacionN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpContratacionN.Location = new System.Drawing.Point(995, 649);
            this.dtpContratacionN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpContratacionN.Name = "dtpContratacionN";
            this.dtpContratacionN.Size = new System.Drawing.Size(339, 35);
            this.dtpContratacionN.TabIndex = 160;
            // 
            // dtpNacimientoN
            // 
            this.dtpNacimientoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimientoN.Location = new System.Drawing.Point(993, 699);
            this.dtpNacimientoN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNacimientoN.Name = "dtpNacimientoN";
            this.dtpNacimientoN.Size = new System.Drawing.Size(340, 35);
            this.dtpNacimientoN.TabIndex = 161;
            // 
            // cboEstatus
            // 
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(993, 752);
            this.cboEstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(227, 35);
            this.cboEstatus.TabIndex = 162;
            // 
            // cboPuestoN
            // 
            this.cboPuestoN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuestoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPuestoN.FormattingEnabled = true;
            this.cboPuestoN.Location = new System.Drawing.Point(993, 593);
            this.cboPuestoN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPuestoN.Name = "cboPuestoN";
            this.cboPuestoN.Size = new System.Drawing.Size(308, 35);
            this.cboPuestoN.TabIndex = 163;
            this.cboPuestoN.SelectedIndexChanged += new System.EventHandler(this.cboPuestoN_SelectedIndexChanged);
            // 
            // lblCodigoA
            // 
            this.lblCodigoA.AutoSize = true;
            this.lblCodigoA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoA.ForeColor = System.Drawing.Color.White;
            this.lblCodigoA.Location = new System.Drawing.Point(1059, 347);
            this.lblCodigoA.Name = "lblCodigoA";
            this.lblCodigoA.Size = new System.Drawing.Size(25, 27);
            this.lblCodigoA.TabIndex = 164;
            this.lblCodigoA.Text = "a";
            this.lblCodigoA.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(946, 205);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(227, 47);
            this.btnCancelar.TabIndex = 165;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(1258, 21);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 75);
            this.btnAyuda.TabIndex = 166;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // frmModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1377, 838);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCodigoA);
            this.Controls.Add(this.cboPuestoN);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.dtpNacimientoN);
            this.Controls.Add(this.dtpContratacionN);
            this.Controls.Add(this.cboCodigoPnuevo);
            this.Controls.Add(this.txtApellidoN);
            this.Controls.Add(this.txtNombreN);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.lblFechaNN);
            this.Controls.Add(this.lblFechaCN);
            this.Controls.Add(this.lblApellidoN);
            this.Controls.Add(this.lblPuestoN);
            this.Controls.Add(this.lblNombreN);
            this.Controls.Add(this.lblEs);
            this.Controls.Add(this.lblNA);
            this.Controls.Add(this.lblCa);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblEstatusA);
            this.Controls.Add(this.lblFechaAN);
            this.Controls.Add(this.lblFechaAC);
            this.Controls.Add(this.lblApellidoA);
            this.Controls.Add(this.lblPuestoA);
            this.Controls.Add(this.lblNombreA);
            this.Controls.Add(this.cboCodigoE);
            this.Controls.Add(this.cboNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblTitulo3);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.dgtDatos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblEmpleado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmModificarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarEmpleado";
            this.Load += new System.EventHandler(this.frmModificarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.DataGridView dgtDatos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboNombre;
        private System.Windows.Forms.ComboBox cboCodigoE;
        private System.Windows.Forms.Label lblNombreA;
        private System.Windows.Forms.Label lblPuestoA;
        private System.Windows.Forms.Label lblApellidoA;
        private System.Windows.Forms.Label lblFechaAC;
        private System.Windows.Forms.Label lblFechaAN;
        private System.Windows.Forms.Label lblEstatusA;
        private System.Windows.Forms.Label lblEs;
        private System.Windows.Forms.Label lblNA;
        private System.Windows.Forms.Label lblCa;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblFechaNN;
        private System.Windows.Forms.Label lblFechaCN;
        private System.Windows.Forms.Label lblApellidoN;
        private System.Windows.Forms.Label lblPuestoN;
        private System.Windows.Forms.Label lblNombreN;
        private System.Windows.Forms.TextBox txtNombreN;
        private System.Windows.Forms.TextBox txtApellidoN;
        private System.Windows.Forms.ComboBox cboCodigoPnuevo;
        private System.Windows.Forms.DateTimePicker dtpContratacionN;
        private System.Windows.Forms.DateTimePicker dtpNacimientoN;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.ComboBox cboPuestoN;
        private System.Windows.Forms.Label lblCodigoA;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAyuda;
    }
}