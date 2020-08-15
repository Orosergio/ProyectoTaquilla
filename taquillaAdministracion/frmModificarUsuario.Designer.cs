namespace taquillaAdministracion
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
            this.lblCodigoA = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.cboCoEmp = new System.Windows.Forms.ComboBox();
            this.lblEs = new System.Windows.Forms.Label();
            this.lblNA = new System.Windows.Forms.Label();
            this.lblCa = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoA
            // 
            this.lblCodigoA.AutoSize = true;
            this.lblCodigoA.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoA.ForeColor = System.Drawing.Color.White;
            this.lblCodigoA.Location = new System.Drawing.Point(768, 221);
            this.lblCodigoA.Name = "lblCodigoA";
            this.lblCodigoA.Size = new System.Drawing.Size(21, 22);
            this.lblCodigoA.TabIndex = 200;
            this.lblCodigoA.Text = "a";
            this.lblCodigoA.Visible = false;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(772, 320);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(229, 24);
            this.cboEmpleado.TabIndex = 199;
            this.cboEmpleado.SelectedIndexChanged += new System.EventHandler(this.cboEmpleado_SelectedIndexChanged);
            // 
            // cboEstatus
            // 
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstatus.Location = new System.Drawing.Point(774, 512);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(227, 24);
            this.cboEstatus.TabIndex = 198;
            // 
            // cboCoEmp
            // 
            this.cboCoEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCoEmp.FormattingEnabled = true;
            this.cboCoEmp.Location = new System.Drawing.Point(1007, 320);
            this.cboCoEmp.Name = "cboCoEmp";
            this.cboCoEmp.Size = new System.Drawing.Size(59, 24);
            this.cboCoEmp.TabIndex = 195;
            this.cboCoEmp.Visible = false;
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEs.ForeColor = System.Drawing.Color.White;
            this.lblEs.Location = new System.Drawing.Point(219, 510);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(0, 22);
            this.lblEs.TabIndex = 186;
            // 
            // lblNA
            // 
            this.lblNA.AutoSize = true;
            this.lblNA.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNA.ForeColor = System.Drawing.Color.White;
            this.lblNA.Location = new System.Drawing.Point(220, 476);
            this.lblNA.Name = "lblNA";
            this.lblNA.Size = new System.Drawing.Size(0, 22);
            this.lblNA.TabIndex = 185;
            // 
            // lblCa
            // 
            this.lblCa.AutoSize = true;
            this.lblCa.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCa.ForeColor = System.Drawing.Color.White;
            this.lblCa.Location = new System.Drawing.Point(220, 439);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(0, 22);
            this.lblCa.TabIndex = 184;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.White;
            this.lblA.Location = new System.Drawing.Point(219, 365);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 22);
            this.lblA.TabIndex = 182;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.White;
            this.lblP.Location = new System.Drawing.Point(220, 403);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(0, 22);
            this.lblP.TabIndex = 183;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.ForeColor = System.Drawing.Color.White;
            this.lblN.Location = new System.Drawing.Point(219, 326);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 22);
            this.lblN.TabIndex = 181;
            // 
            // lblEstatusA
            // 
            this.lblEstatusA.AutoSize = true;
            this.lblEstatusA.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusA.ForeColor = System.Drawing.Color.White;
            this.lblEstatusA.Location = new System.Drawing.Point(35, 476);
            this.lblEstatusA.Name = "lblEstatusA";
            this.lblEstatusA.Size = new System.Drawing.Size(75, 22);
            this.lblEstatusA.TabIndex = 180;
            this.lblEstatusA.Text = "Estatus";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(35, 439);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(114, 22);
            this.lblContraseña.TabIndex = 178;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(34, 365);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(39, 22);
            this.lblRol.TabIndex = 177;
            this.lblRol.Text = "Rol";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(35, 403);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 22);
            this.lblUsuario.TabIndex = 176;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblNombreA
            // 
            this.lblNombreA.AutoSize = true;
            this.lblNombreA.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreA.ForeColor = System.Drawing.Color.White;
            this.lblNombreA.Location = new System.Drawing.Point(34, 326);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(105, 22);
            this.lblNombreA.TabIndex = 175;
            this.lblNombreA.Text = "Empleado";
            // 
            // cboCodigoU
            // 
            this.cboCodigoU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoU.FormattingEnabled = true;
            this.cboCodigoU.Location = new System.Drawing.Point(466, 86);
            this.cboCodigoU.Name = "cboCodigoU";
            this.cboCodigoU.Size = new System.Drawing.Size(82, 24);
            this.cboCodigoU.TabIndex = 174;
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(145, 86);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(315, 24);
            this.cboUsuario.TabIndex = 173;
            this.cboUsuario.SelectedIndexChanged += new System.EventHandler(this.cboUsuario_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(655, 221);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 22);
            this.txtCodigo.TabIndex = 172;
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
            this.btnModificar.Location = new System.Drawing.Point(644, 112);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(226, 47);
            this.btnModificar.TabIndex = 171;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.ForeColor = System.Drawing.Color.White;
            this.lblTitulo3.Location = new System.Drawing.Point(462, 284);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(134, 22);
            this.lblTitulo3.TabIndex = 170;
            this.lblTitulo3.Text = "Datos Nuevos";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(35, 284);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(159, 22);
            this.lblTitulo2.TabIndex = 169;
            this.lblTitulo2.Text = "Datos anteriores";
            // 
            // dgtDatos
            // 
            this.dgtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDatos.Location = new System.Drawing.Point(38, 116);
            this.dgtDatos.Name = "dgtDatos";
            this.dgtDatos.ReadOnly = true;
            this.dgtDatos.RowHeadersWidth = 51;
            this.dgtDatos.RowTemplate.Height = 24;
            this.dgtDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtDatos.Size = new System.Drawing.Size(596, 150);
            this.dgtDatos.TabIndex = 168;
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
            this.btnBuscar.Location = new System.Drawing.Point(644, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(226, 47);
            this.btnBuscar.TabIndex = 167;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(33, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(283, 27);
            this.lblTitulo.TabIndex = 166;
            this.lblTitulo.Text = "Modificacion de Usuario";
            // 
            // lblUsuario1
            // 
            this.lblUsuario1.AutoSize = true;
            this.lblUsuario1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario1.ForeColor = System.Drawing.Color.White;
            this.lblUsuario1.Location = new System.Drawing.Point(34, 84);
            this.lblUsuario1.Name = "lblUsuario1";
            this.lblUsuario1.Size = new System.Drawing.Size(80, 22);
            this.lblUsuario1.TabIndex = 165;
            this.lblUsuario1.Text = "Usuario";
            // 
            // lblEstatusC
            // 
            this.lblEstatusC.AutoSize = true;
            this.lblEstatusC.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusC.ForeColor = System.Drawing.Color.White;
            this.lblEstatusC.Location = new System.Drawing.Point(189, 476);
            this.lblEstatusC.Name = "lblEstatusC";
            this.lblEstatusC.Size = new System.Drawing.Size(0, 22);
            this.lblEstatusC.TabIndex = 205;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(189, 439);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(0, 22);
            this.lblC.TabIndex = 204;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.ForeColor = System.Drawing.Color.White;
            this.lblR.Location = new System.Drawing.Point(188, 365);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(0, 22);
            this.lblR.TabIndex = 203;
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU.ForeColor = System.Drawing.Color.White;
            this.lblU.Location = new System.Drawing.Point(189, 403);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(0, 22);
            this.lblU.TabIndex = 202;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.ForeColor = System.Drawing.Color.White;
            this.lblE.Location = new System.Drawing.Point(188, 326);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(0, 22);
            this.lblE.TabIndex = 201;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(462, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 210;
            this.label1.Text = "Estatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(462, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 209;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(461, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 22);
            this.label3.TabIndex = 208;
            this.label3.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(462, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 207;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(461, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 206;
            this.label5.Text = "Empleado";
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(772, 359);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(229, 24);
            this.cboRol.TabIndex = 211;
            this.cboRol.SelectedIndexChanged += new System.EventHandler(this.cboRol_SelectedIndexChanged);
            // 
            // cboCodigoR
            // 
            this.cboCodigoR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoR.FormattingEnabled = true;
            this.cboCodigoR.Location = new System.Drawing.Point(1007, 359);
            this.cboCodigoR.Name = "cboCodigoR";
            this.cboCodigoR.Size = new System.Drawing.Size(59, 24);
            this.cboCodigoR.TabIndex = 212;
            this.cboCodigoR.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(772, 399);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(229, 22);
            this.txtUsuario.TabIndex = 213;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(772, 437);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(229, 22);
            this.txtContraseña.TabIndex = 214;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtContraseñaCon
            // 
            this.txtContraseñaCon.Location = new System.Drawing.Point(772, 476);
            this.txtContraseñaCon.Name = "txtContraseñaCon";
            this.txtContraseñaCon.Size = new System.Drawing.Size(229, 22);
            this.txtContraseñaCon.TabIndex = 215;
            this.txtContraseñaCon.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(462, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 22);
            this.label6.TabIndex = 216;
            this.label6.Text = "Confirmacion Contraseña";
            // 
            // frmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1104, 573);
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
            this.Controls.Add(this.lblEs);
            this.Controls.Add(this.lblNA);
            this.Controls.Add(this.lblCa);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblN);
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
            this.Name = "frmModificarUsuario";
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
        private System.Windows.Forms.Label lblEs;
        private System.Windows.Forms.Label lblNA;
        private System.Windows.Forms.Label lblCa;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblN;
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
    }
}