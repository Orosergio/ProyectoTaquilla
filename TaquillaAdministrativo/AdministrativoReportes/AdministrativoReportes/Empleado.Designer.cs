namespace FinalProyecto
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpnacimiento = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpcontratacion = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbpuesto = new System.Windows.Forms.ComboBox();
            this.cmbjornada = new System.Windows.Forms.ComboBox();
            this.cmbidpuesto = new System.Windows.Forms.ComboBox();
            this.cmbidjornada = new System.Windows.Forms.ComboBox();
            this.lookemp = new System.Windows.Forms.Button();
            this.addemail = new System.Windows.Forms.Button();
            this.addphone = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnjornada = new System.Windows.Forms.Button();
            this.btnpuesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(366, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLEADOS";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(80, 460);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(170, 38);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.AutoSize = true;
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(840, 9);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(20, 20);
            this.btncerrar.TabIndex = 3;
            this.btncerrar.Text = "X";
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombres:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(139, 197);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(244, 26);
            this.txtdireccion.TabIndex = 12;
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(140, 84);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(244, 26);
            this.txtapellido.TabIndex = 11;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(140, 55);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(244, 26);
            this.txtnombre.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Puesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // dtpnacimiento
            // 
            this.dtpnacimiento.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpnacimiento.Location = new System.Drawing.Point(171, 158);
            this.dtpnacimiento.Name = "dtpnacimiento";
            this.dtpnacimiento.Size = new System.Drawing.Size(105, 26);
            this.dtpnacimiento.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 30);
            this.panel1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Salario";
            // 
            // txtsalario
            // 
            this.txtsalario.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(139, 240);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 26);
            this.txtsalario.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Fecha Contratación";
            // 
            // dtpcontratacion
            // 
            this.dtpcontratacion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpcontratacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcontratacion.Location = new System.Drawing.Point(184, 279);
            this.dtpcontratacion.Name = "dtpcontratacion";
            this.dtpcontratacion.Size = new System.Drawing.Size(112, 26);
            this.dtpcontratacion.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Jornada";
            // 
            // cmbpuesto
            // 
            this.cmbpuesto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpuesto.FormattingEnabled = true;
            this.cmbpuesto.Location = new System.Drawing.Point(139, 121);
            this.cmbpuesto.Name = "cmbpuesto";
            this.cmbpuesto.Size = new System.Drawing.Size(121, 27);
            this.cmbpuesto.TabIndex = 30;
            this.cmbpuesto.SelectedIndexChanged += new System.EventHandler(this.Cmbpuesto_SelectedIndexChanged);
            // 
            // cmbjornada
            // 
            this.cmbjornada.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbjornada.FormattingEnabled = true;
            this.cmbjornada.Location = new System.Drawing.Point(139, 316);
            this.cmbjornada.Name = "cmbjornada";
            this.cmbjornada.Size = new System.Drawing.Size(121, 27);
            this.cmbjornada.TabIndex = 31;
            this.cmbjornada.SelectedIndexChanged += new System.EventHandler(this.Cmbjornada_SelectedIndexChanged);
            // 
            // cmbidpuesto
            // 
            this.cmbidpuesto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbidpuesto.FormattingEnabled = true;
            this.cmbidpuesto.Location = new System.Drawing.Point(275, 121);
            this.cmbidpuesto.Name = "cmbidpuesto";
            this.cmbidpuesto.Size = new System.Drawing.Size(50, 27);
            this.cmbidpuesto.TabIndex = 32;
            this.cmbidpuesto.Visible = false;
            // 
            // cmbidjornada
            // 
            this.cmbidjornada.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbidjornada.FormattingEnabled = true;
            this.cmbidjornada.Location = new System.Drawing.Point(275, 316);
            this.cmbidjornada.Name = "cmbidjornada";
            this.cmbidjornada.Size = new System.Drawing.Size(65, 27);
            this.cmbidjornada.TabIndex = 33;
            this.cmbidjornada.Visible = false;
            // 
            // lookemp
            // 
            this.lookemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.lookemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookemp.FlatAppearance.BorderSize = 0;
            this.lookemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.lookemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lookemp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookemp.ForeColor = System.Drawing.Color.White;
            this.lookemp.Image = ((System.Drawing.Image)(resources.GetObject("lookemp.Image")));
            this.lookemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lookemp.Location = new System.Drawing.Point(633, 383);
            this.lookemp.Name = "lookemp";
            this.lookemp.Size = new System.Drawing.Size(212, 38);
            this.lookemp.TabIndex = 34;
            this.lookemp.Text = "Ver Empleados";
            this.lookemp.UseVisualStyleBackColor = false;
            this.lookemp.Click += new System.EventHandler(this.Lookemp_Click);
            // 
            // addemail
            // 
            this.addemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.addemail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addemail.FlatAppearance.BorderSize = 0;
            this.addemail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.addemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemail.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemail.ForeColor = System.Drawing.Color.White;
            this.addemail.Image = ((System.Drawing.Image)(resources.GetObject("addemail.Image")));
            this.addemail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addemail.Location = new System.Drawing.Point(633, 240);
            this.addemail.Name = "addemail";
            this.addemail.Size = new System.Drawing.Size(212, 38);
            this.addemail.TabIndex = 35;
            this.addemail.Text = "Agregar Correo";
            this.addemail.UseVisualStyleBackColor = false;
            this.addemail.Click += new System.EventHandler(this.Addemail_Click);
            // 
            // addphone
            // 
            this.addphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.addphone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addphone.FlatAppearance.BorderSize = 0;
            this.addphone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.addphone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addphone.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addphone.ForeColor = System.Drawing.Color.White;
            this.addphone.Image = ((System.Drawing.Image)(resources.GetObject("addphone.Image")));
            this.addphone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addphone.Location = new System.Drawing.Point(633, 316);
            this.addphone.Name = "addphone";
            this.addphone.Size = new System.Drawing.Size(212, 38);
            this.addphone.TabIndex = 36;
            this.addphone.Text = "Agregar Telefono";
            this.addphone.UseVisualStyleBackColor = false;
            this.addphone.Click += new System.EventHandler(this.Addphone_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(315, 460);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(170, 38);
            this.btncancel.TabIndex = 37;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 39;
            this.label10.Text = "Telefono";
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(140, 367);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(244, 26);
            this.txttel.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 41;
            this.label11.Text = "Correo";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(139, 407);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(244, 26);
            this.txtemail.TabIndex = 40;
            // 
            // btnjornada
            // 
            this.btnjornada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnjornada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnjornada.FlatAppearance.BorderSize = 0;
            this.btnjornada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnjornada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnjornada.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjornada.ForeColor = System.Drawing.Color.White;
            this.btnjornada.Image = ((System.Drawing.Image)(resources.GetObject("btnjornada.Image")));
            this.btnjornada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnjornada.Location = new System.Drawing.Point(633, 508);
            this.btnjornada.Name = "btnjornada";
            this.btnjornada.Size = new System.Drawing.Size(212, 38);
            this.btnjornada.TabIndex = 42;
            this.btnjornada.Text = "Agregar Jornada";
            this.btnjornada.UseVisualStyleBackColor = false;
            this.btnjornada.Click += new System.EventHandler(this.Btnjornada_Click);
            // 
            // btnpuesto
            // 
            this.btnpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnpuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpuesto.FlatAppearance.BorderSize = 0;
            this.btnpuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpuesto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpuesto.ForeColor = System.Drawing.Color.White;
            this.btnpuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnpuesto.Image")));
            this.btnpuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpuesto.Location = new System.Drawing.Point(633, 448);
            this.btnpuesto.Name = "btnpuesto";
            this.btnpuesto.Size = new System.Drawing.Size(212, 38);
            this.btnpuesto.TabIndex = 43;
            this.btnpuesto.Text = "Agregar Puesto";
            this.btnpuesto.UseVisualStyleBackColor = false;
            this.btnpuesto.Click += new System.EventHandler(this.Btnpuesto_Click);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(872, 558);
            this.Controls.Add(this.btnpuesto);
            this.Controls.Add(this.btnjornada);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.addphone);
            this.Controls.Add(this.addemail);
            this.Controls.Add(this.lookemp);
            this.Controls.Add(this.cmbidjornada);
            this.Controls.Add(this.cmbidpuesto);
            this.Controls.Add(this.cmbjornada);
            this.Controls.Add(this.cmbpuesto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpcontratacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpnacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnguardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d";
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label btncerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtdireccion;
        public System.Windows.Forms.TextBox txtapellido;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpnacimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpcontratacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbpuesto;
        private System.Windows.Forms.ComboBox cmbjornada;
        private System.Windows.Forms.ComboBox cmbidpuesto;
        private System.Windows.Forms.ComboBox cmbidjornada;
        private System.Windows.Forms.Button lookemp;
        private System.Windows.Forms.Button addemail;
        private System.Windows.Forms.Button addphone;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnjornada;
        private System.Windows.Forms.Button btnpuesto;
    }
}