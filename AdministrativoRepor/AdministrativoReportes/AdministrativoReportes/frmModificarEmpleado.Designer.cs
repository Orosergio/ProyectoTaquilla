namespace AdministrativoReportes
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
            this.btnBuscar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(633, 189);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 22);
            this.txtCodigo.TabIndex = 134;
            this.txtCodigo.Text = "Codigo";
            this.txtCodigo.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(622, 80);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(226, 47);
            this.btnModificar.TabIndex = 133;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.ForeColor = System.Drawing.Color.White;
            this.lblTitulo3.Location = new System.Drawing.Point(440, 252);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(134, 22);
            this.lblTitulo3.TabIndex = 126;
            this.lblTitulo3.Text = "Datos Nuevos";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(13, 252);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(159, 22);
            this.lblTitulo2.TabIndex = 122;
            this.lblTitulo2.Text = "Datos anteriores";
            // 
            // dgtDatos
            // 
            this.dgtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDatos.Location = new System.Drawing.Point(16, 84);
            this.dgtDatos.Name = "dgtDatos";
            this.dgtDatos.ReadOnly = true;
            this.dgtDatos.RowHeadersWidth = 51;
            this.dgtDatos.RowTemplate.Height = 24;
            this.dgtDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtDatos.Size = new System.Drawing.Size(596, 150);
            this.dgtDatos.TabIndex = 118;
            this.dgtDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtDatos_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(622, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(226, 47);
            this.btnBuscar.TabIndex = 116;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(312, 27);
            this.lblTitulo.TabIndex = 115;
            this.lblTitulo.Text = "Modificacion de Empleado";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblEmpleado.Location = new System.Drawing.Point(12, 52);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(105, 22);
            this.lblEmpleado.TabIndex = 114;
            this.lblEmpleado.Text = "Empleado";
            // 
            // cboNombre
            // 
            this.cboNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombre.FormattingEnabled = true;
            this.cboNombre.Location = new System.Drawing.Point(123, 54);
            this.cboNombre.Name = "cboNombre";
            this.cboNombre.Size = new System.Drawing.Size(315, 24);
            this.cboNombre.TabIndex = 137;
            this.cboNombre.SelectedIndexChanged += new System.EventHandler(this.cboNombre_SelectedIndexChanged);
            // 
            // cboCodigoE
            // 
            this.cboCodigoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoE.FormattingEnabled = true;
            this.cboCodigoE.Location = new System.Drawing.Point(444, 54);
            this.cboCodigoE.Name = "cboCodigoE";
            this.cboCodigoE.Size = new System.Drawing.Size(82, 24);
            this.cboCodigoE.TabIndex = 138;
            // 
            // lblNombreA
            // 
            this.lblNombreA.AutoSize = true;
            this.lblNombreA.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreA.ForeColor = System.Drawing.Color.White;
            this.lblNombreA.Location = new System.Drawing.Point(12, 294);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(84, 22);
            this.lblNombreA.TabIndex = 139;
            this.lblNombreA.Text = "Nombre";
            // 
            // lblPuestoA
            // 
            this.lblPuestoA.AutoSize = true;
            this.lblPuestoA.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoA.ForeColor = System.Drawing.Color.White;
            this.lblPuestoA.Location = new System.Drawing.Point(13, 371);
            this.lblPuestoA.Name = "lblPuestoA";
            this.lblPuestoA.Size = new System.Drawing.Size(69, 22);
            this.lblPuestoA.TabIndex = 140;
            this.lblPuestoA.Text = "Puesto";
            // 
            // lblApellidoA
            // 
            this.lblApellidoA.AutoSize = true;
            this.lblApellidoA.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoA.ForeColor = System.Drawing.Color.White;
            this.lblApellidoA.Location = new System.Drawing.Point(12, 333);
            this.lblApellidoA.Name = "lblApellidoA";
            this.lblApellidoA.Size = new System.Drawing.Size(90, 22);
            this.lblApellidoA.TabIndex = 140;
            this.lblApellidoA.Text = "Apellido";
            // 
            // lblFechaAC
            // 
            this.lblFechaAC.AutoSize = true;
            this.lblFechaAC.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAC.ForeColor = System.Drawing.Color.White;
            this.lblFechaAC.Location = new System.Drawing.Point(13, 407);
            this.lblFechaAC.Name = "lblFechaAC";
            this.lblFechaAC.Size = new System.Drawing.Size(186, 22);
            this.lblFechaAC.TabIndex = 141;
            this.lblFechaAC.Text = "Fecha Contratacion";
            // 
            // lblFechaAN
            // 
            this.lblFechaAN.AutoSize = true;
            this.lblFechaAN.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAN.ForeColor = System.Drawing.Color.White;
            this.lblFechaAN.Location = new System.Drawing.Point(13, 444);
            this.lblFechaAN.Name = "lblFechaAN";
            this.lblFechaAN.Size = new System.Drawing.Size(172, 22);
            this.lblFechaAN.TabIndex = 142;
            this.lblFechaAN.Text = "Fecha Nacimiento";
            // 
            // lblEstatusA
            // 
            this.lblEstatusA.AutoSize = true;
            this.lblEstatusA.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusA.ForeColor = System.Drawing.Color.White;
            this.lblEstatusA.Location = new System.Drawing.Point(12, 478);
            this.lblEstatusA.Name = "lblEstatusA";
            this.lblEstatusA.Size = new System.Drawing.Size(75, 22);
            this.lblEstatusA.TabIndex = 143;
            this.lblEstatusA.Text = "Estatus";
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEs.ForeColor = System.Drawing.Color.White;
            this.lblEs.Location = new System.Drawing.Point(197, 478);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(0, 22);
            this.lblEs.TabIndex = 149;
            // 
            // lblNA
            // 
            this.lblNA.AutoSize = true;
            this.lblNA.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNA.ForeColor = System.Drawing.Color.White;
            this.lblNA.Location = new System.Drawing.Point(198, 444);
            this.lblNA.Name = "lblNA";
            this.lblNA.Size = new System.Drawing.Size(0, 22);
            this.lblNA.TabIndex = 148;
            // 
            // lblCa
            // 
            this.lblCa.AutoSize = true;
            this.lblCa.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCa.ForeColor = System.Drawing.Color.White;
            this.lblCa.Location = new System.Drawing.Point(198, 407);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(0, 22);
            this.lblCa.TabIndex = 147;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.White;
            this.lblA.Location = new System.Drawing.Point(197, 333);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 22);
            this.lblA.TabIndex = 145;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.White;
            this.lblP.Location = new System.Drawing.Point(198, 371);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(0, 22);
            this.lblP.TabIndex = 146;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.ForeColor = System.Drawing.Color.White;
            this.lblN.Location = new System.Drawing.Point(197, 294);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 22);
            this.lblN.TabIndex = 144;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(440, 469);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(75, 22);
            this.lblEstatus.TabIndex = 155;
            this.lblEstatus.Text = "Estatus";
            // 
            // lblFechaNN
            // 
            this.lblFechaNN.AutoSize = true;
            this.lblFechaNN.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNN.ForeColor = System.Drawing.Color.White;
            this.lblFechaNN.Location = new System.Drawing.Point(441, 435);
            this.lblFechaNN.Name = "lblFechaNN";
            this.lblFechaNN.Size = new System.Drawing.Size(172, 22);
            this.lblFechaNN.TabIndex = 154;
            this.lblFechaNN.Text = "Fecha Nacimiento";
            // 
            // lblFechaCN
            // 
            this.lblFechaCN.AutoSize = true;
            this.lblFechaCN.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCN.ForeColor = System.Drawing.Color.White;
            this.lblFechaCN.Location = new System.Drawing.Point(441, 398);
            this.lblFechaCN.Name = "lblFechaCN";
            this.lblFechaCN.Size = new System.Drawing.Size(186, 22);
            this.lblFechaCN.TabIndex = 153;
            this.lblFechaCN.Text = "Fecha Contratacion";
            // 
            // lblApellidoN
            // 
            this.lblApellidoN.AutoSize = true;
            this.lblApellidoN.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoN.ForeColor = System.Drawing.Color.White;
            this.lblApellidoN.Location = new System.Drawing.Point(440, 324);
            this.lblApellidoN.Name = "lblApellidoN";
            this.lblApellidoN.Size = new System.Drawing.Size(90, 22);
            this.lblApellidoN.TabIndex = 151;
            this.lblApellidoN.Text = "Apellido";
            // 
            // lblPuestoN
            // 
            this.lblPuestoN.AutoSize = true;
            this.lblPuestoN.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoN.ForeColor = System.Drawing.Color.White;
            this.lblPuestoN.Location = new System.Drawing.Point(441, 362);
            this.lblPuestoN.Name = "lblPuestoN";
            this.lblPuestoN.Size = new System.Drawing.Size(69, 22);
            this.lblPuestoN.TabIndex = 152;
            this.lblPuestoN.Text = "Puesto";
            // 
            // lblNombreN
            // 
            this.lblNombreN.AutoSize = true;
            this.lblNombreN.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreN.ForeColor = System.Drawing.Color.White;
            this.lblNombreN.Location = new System.Drawing.Point(440, 285);
            this.lblNombreN.Name = "lblNombreN";
            this.lblNombreN.Size = new System.Drawing.Size(84, 22);
            this.lblNombreN.TabIndex = 150;
            this.lblNombreN.Text = "Nombre";
            // 
            // txtNombreN
            // 
            this.txtNombreN.Location = new System.Drawing.Point(650, 285);
            this.txtNombreN.Name = "txtNombreN";
            this.txtNombreN.Size = new System.Drawing.Size(228, 22);
            this.txtNombreN.TabIndex = 156;
            // 
            // txtApellidoN
            // 
            this.txtApellidoN.Location = new System.Drawing.Point(648, 324);
            this.txtApellidoN.Name = "txtApellidoN";
            this.txtApellidoN.Size = new System.Drawing.Size(230, 22);
            this.txtApellidoN.TabIndex = 157;
            // 
            // cboCodigoPnuevo
            // 
            this.cboCodigoPnuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoPnuevo.FormattingEnabled = true;
            this.cboCodigoPnuevo.Location = new System.Drawing.Point(883, 369);
            this.cboCodigoPnuevo.Name = "cboCodigoPnuevo";
            this.cboCodigoPnuevo.Size = new System.Drawing.Size(59, 24);
            this.cboCodigoPnuevo.TabIndex = 159;
            // 
            // dtpContratacionN
            // 
            this.dtpContratacionN.Location = new System.Drawing.Point(650, 407);
            this.dtpContratacionN.Name = "dtpContratacionN";
            this.dtpContratacionN.Size = new System.Drawing.Size(274, 22);
            this.dtpContratacionN.TabIndex = 160;
            // 
            // dtpNacimientoN
            // 
            this.dtpNacimientoN.Location = new System.Drawing.Point(650, 435);
            this.dtpNacimientoN.Name = "dtpNacimientoN";
            this.dtpNacimientoN.Size = new System.Drawing.Size(271, 22);
            this.dtpNacimientoN.TabIndex = 161;
            // 
            // cboEstatus
            // 
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstatus.Location = new System.Drawing.Point(650, 471);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(227, 24);
            this.cboEstatus.TabIndex = 162;
            // 
            // cboPuestoN
            // 
            this.cboPuestoN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuestoN.FormattingEnabled = true;
            this.cboPuestoN.Location = new System.Drawing.Point(648, 369);
            this.cboPuestoN.Name = "cboPuestoN";
            this.cboPuestoN.Size = new System.Drawing.Size(229, 24);
            this.cboPuestoN.TabIndex = 163;
            this.cboPuestoN.SelectedIndexChanged += new System.EventHandler(this.cboPuestoN_SelectedIndexChanged);
            // 
            // lblCodigoA
            // 
            this.lblCodigoA.AutoSize = true;
            this.lblCodigoA.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoA.ForeColor = System.Drawing.Color.White;
            this.lblCodigoA.Location = new System.Drawing.Point(746, 189);
            this.lblCodigoA.Name = "lblCodigoA";
            this.lblCodigoA.Size = new System.Drawing.Size(21, 22);
            this.lblCodigoA.TabIndex = 164;
            this.lblCodigoA.Text = "a";
            this.lblCodigoA.Visible = false;
            // 
            // frmModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(954, 546);
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
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblEmpleado);
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
        private System.Windows.Forms.Button btnBuscar;
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
    }
}