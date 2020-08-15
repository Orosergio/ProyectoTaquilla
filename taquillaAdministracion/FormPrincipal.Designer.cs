namespace taquillaAdministracion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.Principal = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPuesto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnFuncionesN = new System.Windows.Forms.Button();
            this.btnPelicula = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnSLIDE = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.design = new System.Windows.Forms.Button();
            this.Submenurepor = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnreportventa = new System.Windows.Forms.Button();
            this.btnreportcompra = new System.Windows.Forms.Button();
            this.TituloBarra = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelContenedor.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSLIDE)).BeginInit();
            this.Submenurepor.SuspendLayout();
            this.TituloBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelContenedor.Controls.Add(this.Principal);
            this.PanelContenedor.Controls.Add(this.panel4);
            this.PanelContenedor.Controls.Add(this.Menu);
            this.PanelContenedor.Controls.Add(this.TituloBarra);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1733, 985);
            this.PanelContenedor.TabIndex = 2;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.Location = new System.Drawing.Point(375, 49);
            this.Principal.Margin = new System.Windows.Forms.Padding(4);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(1358, 838);
            this.Principal.TabIndex = 102;
            this.Principal.Paint += new System.Windows.Forms.PaintEventHandler(this.Principal_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbFecha);
            this.panel4.Controls.Add(this.lblHora);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(375, 887);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1358, 98);
            this.panel4.TabIndex = 101;
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(989, 70);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(288, 25);
            this.lbFecha.TabIndex = 8;
            this.lbFecha.Text = "Domingo, 9 de septiembre 2019";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(1030, 4);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(259, 67);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "21:49:45";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.Menu.Controls.Add(this.panel3);
            this.Menu.Controls.Add(this.btnPuesto);
            this.Menu.Controls.Add(this.panel2);
            this.Menu.Controls.Add(this.btnRol);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Controls.Add(this.btnEmpleado);
            this.Menu.Controls.Add(this.btnFuncionesN);
            this.Menu.Controls.Add(this.btnPelicula);
            this.Menu.Controls.Add(this.panel13);
            this.Menu.Controls.Add(this.panel12);
            this.Menu.Controls.Add(this.button8);
            this.Menu.Controls.Add(this.panel11);
            this.Menu.Controls.Add(this.btnSLIDE);
            this.Menu.Controls.Add(this.button6);
            this.Menu.Controls.Add(this.panel8);
            this.Menu.Controls.Add(this.panel5);
            this.Menu.Controls.Add(this.design);
            this.Menu.Controls.Add(this.Submenurepor);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 49);
            this.Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(375, 936);
            this.Menu.TabIndex = 100;
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel3.Location = new System.Drawing.Point(3, 482);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 39);
            this.panel3.TabIndex = 14;
            // 
            // btnPuesto
            // 
            this.btnPuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPuesto.FlatAppearance.BorderSize = 0;
            this.btnPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuesto.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnPuesto.Image")));
            this.btnPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuesto.Location = new System.Drawing.Point(13, 482);
            this.btnPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPuesto.Name = "btnPuesto";
            this.btnPuesto.Size = new System.Drawing.Size(189, 39);
            this.btnPuesto.TabIndex = 15;
            this.btnPuesto.Text = "    Puesto";
            this.btnPuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPuesto.UseVisualStyleBackColor = true;
            this.btnPuesto.Click += new System.EventHandler(this.btnPuesto_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel2.Location = new System.Drawing.Point(3, 415);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 39);
            this.panel2.TabIndex = 12;
            // 
            // btnRol
            // 
            this.btnRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRol.FlatAppearance.BorderSize = 0;
            this.btnRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRol.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRol.Image = ((System.Drawing.Image)(resources.GetObject("btnRol.Image")));
            this.btnRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRol.Location = new System.Drawing.Point(13, 415);
            this.btnRol.Margin = new System.Windows.Forms.Padding(4);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(189, 39);
            this.btnRol.TabIndex = 13;
            this.btnRol.Text = "    Rol";
            this.btnRol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRol.UseVisualStyleBackColor = true;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel1.Location = new System.Drawing.Point(3, 346);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 39);
            this.panel1.TabIndex = 10;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(13, 337);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(204, 61);
            this.btnEmpleado.TabIndex = 11;
            this.btnEmpleado.Text = "    Empleado";
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click_1);
            // 
            // btnFuncionesN
            // 
            this.btnFuncionesN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionesN.FlatAppearance.BorderSize = 0;
            this.btnFuncionesN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnFuncionesN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionesN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionesN.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFuncionesN.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionesN.Image")));
            this.btnFuncionesN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionesN.Location = new System.Drawing.Point(13, 118);
            this.btnFuncionesN.Margin = new System.Windows.Forms.Padding(4);
            this.btnFuncionesN.Name = "btnFuncionesN";
            this.btnFuncionesN.Size = new System.Drawing.Size(204, 60);
            this.btnFuncionesN.TabIndex = 9;
            this.btnFuncionesN.Text = "    Funciones";
            this.btnFuncionesN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFuncionesN.UseVisualStyleBackColor = true;
            this.btnFuncionesN.Click += new System.EventHandler(this.btnFuncionesN_Click);
            // 
            // btnPelicula
            // 
            this.btnPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPelicula.FlatAppearance.BorderSize = 0;
            this.btnPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelicula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPelicula.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPelicula.Image = ((System.Drawing.Image)(resources.GetObject("btnPelicula.Image")));
            this.btnPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPelicula.Location = new System.Drawing.Point(13, 62);
            this.btnPelicula.Margin = new System.Windows.Forms.Padding(4);
            this.btnPelicula.Name = "btnPelicula";
            this.btnPelicula.Size = new System.Drawing.Size(196, 39);
            this.btnPelicula.TabIndex = 8;
            this.btnPelicula.Text = "    Peliculas";
            this.btnPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPelicula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPelicula.UseVisualStyleBackColor = true;
            this.btnPelicula.Click += new System.EventHandler(this.btnPelicula_Click_1);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel13.Location = new System.Drawing.Point(3, 204);
            this.panel13.Margin = new System.Windows.Forms.Padding(4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(7, 39);
            this.panel13.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel12.Location = new System.Drawing.Point(3, 128);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(7, 39);
            this.panel12.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(13, 196);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(189, 47);
            this.button8.TabIndex = 9;
            this.button8.Text = "    Sucursal";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel11.Location = new System.Drawing.Point(3, 275);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(7, 39);
            this.panel11.TabIndex = 4;
            // 
            // btnSLIDE
            // 
            this.btnSLIDE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSLIDE.Image = ((System.Drawing.Image)(resources.GetObject("btnSLIDE.Image")));
            this.btnSLIDE.Location = new System.Drawing.Point(0, 4);
            this.btnSLIDE.Margin = new System.Windows.Forms.Padding(4);
            this.btnSLIDE.Name = "btnSLIDE";
            this.btnSLIDE.Size = new System.Drawing.Size(63, 50);
            this.btnSLIDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSLIDE.TabIndex = 4;
            this.btnSLIDE.TabStop = false;
            this.btnSLIDE.Click += new System.EventHandler(this.BtnSLIDE_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(13, 275);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 39);
            this.button6.TabIndex = 5;
            this.button6.Text = "    Usuario";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel8.Location = new System.Drawing.Point(4, 62);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(7, 39);
            this.panel8.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel5.Location = new System.Drawing.Point(4, 561);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 39);
            this.panel5.TabIndex = 9;
            // 
            // design
            // 
            this.design.Cursor = System.Windows.Forms.Cursors.Hand;
            this.design.FlatAppearance.BorderSize = 0;
            this.design.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.design.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.design.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.design.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.design.Image = ((System.Drawing.Image)(resources.GetObject("design.Image")));
            this.design.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.design.Location = new System.Drawing.Point(13, 561);
            this.design.Margin = new System.Windows.Forms.Padding(4);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(189, 43);
            this.design.TabIndex = 8;
            this.design.Text = "    Reportes";
            this.design.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.design.UseVisualStyleBackColor = true;
            this.design.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Submenurepor
            // 
            this.Submenurepor.Controls.Add(this.panel14);
            this.Submenurepor.Controls.Add(this.panel7);
            this.Submenurepor.Controls.Add(this.button9);
            this.Submenurepor.Controls.Add(this.panel6);
            this.Submenurepor.Controls.Add(this.btnreportventa);
            this.Submenurepor.Controls.Add(this.btnreportcompra);
            this.Submenurepor.Location = new System.Drawing.Point(104, 612);
            this.Submenurepor.Margin = new System.Windows.Forms.Padding(4);
            this.Submenurepor.Name = "Submenurepor";
            this.Submenurepor.Size = new System.Drawing.Size(283, 159);
            this.Submenurepor.TabIndex = 7;
            this.Submenurepor.Visible = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel14.Location = new System.Drawing.Point(0, 119);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(13, 39);
            this.panel14.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel7.Location = new System.Drawing.Point(0, 62);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 39);
            this.panel7.TabIndex = 13;
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(21, 120);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(262, 39);
            this.button9.TabIndex = 14;
            this.button9.Text = "Reporte Clientes";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel6.Location = new System.Drawing.Point(0, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 39);
            this.panel6.TabIndex = 11;
            // 
            // btnreportventa
            // 
            this.btnreportventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreportventa.FlatAppearance.BorderSize = 0;
            this.btnreportventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnreportventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportventa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportventa.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnreportventa.Image = ((System.Drawing.Image)(resources.GetObject("btnreportventa.Image")));
            this.btnreportventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportventa.Location = new System.Drawing.Point(21, 4);
            this.btnreportventa.Margin = new System.Windows.Forms.Padding(4);
            this.btnreportventa.Name = "btnreportventa";
            this.btnreportventa.Size = new System.Drawing.Size(262, 39);
            this.btnreportventa.TabIndex = 10;
            this.btnreportventa.Text = "Reporte Ventas";
            this.btnreportventa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreportventa.UseVisualStyleBackColor = true;
            this.btnreportventa.Click += new System.EventHandler(this.Btnreportventa_Click);
            // 
            // btnreportcompra
            // 
            this.btnreportcompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreportcompra.FlatAppearance.BorderSize = 0;
            this.btnreportcompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnreportcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportcompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportcompra.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnreportcompra.Image = ((System.Drawing.Image)(resources.GetObject("btnreportcompra.Image")));
            this.btnreportcompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportcompra.Location = new System.Drawing.Point(21, 62);
            this.btnreportcompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnreportcompra.Name = "btnreportcompra";
            this.btnreportcompra.Size = new System.Drawing.Size(262, 39);
            this.btnreportcompra.TabIndex = 12;
            this.btnreportcompra.Text = "Reporte Ganancias";
            this.btnreportcompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreportcompra.UseVisualStyleBackColor = true;
            this.btnreportcompra.Click += new System.EventHandler(this.Btnreportcompra_Click);
            // 
            // TituloBarra
            // 
            this.TituloBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.TituloBarra.Controls.Add(this.btnRestaurar);
            this.TituloBarra.Controls.Add(this.btnMin);
            this.TituloBarra.Controls.Add(this.btnMax);
            this.TituloBarra.Controls.Add(this.btnClose);
            this.TituloBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloBarra.Location = new System.Drawing.Point(0, 0);
            this.TituloBarra.Margin = new System.Windows.Forms.Padding(4);
            this.TituloBarra.Name = "TituloBarra";
            this.TituloBarra.Size = new System.Drawing.Size(1733, 49);
            this.TituloBarra.TabIndex = 11;
            this.TituloBarra.Paint += new System.Windows.Forms.PaintEventHandler(this.TituloBarra_Paint);
            this.TituloBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TituloBarra_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1616, 2);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(47, 43);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1561, 2);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(47, 43);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1616, 2);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(47, 43);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1671, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 43);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.TmFechaHora_Tick_1);
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            this.tmContraerMenu.Tick += new System.EventHandler(this.TmContraerMenu_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 985);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(867, 800);
            this.Name = "FormPrincipal";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PanelContenedor.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSLIDE)).EndInit();
            this.Submenurepor.ResumeLayout(false);
            this.TituloBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel TituloBarra;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox btnSLIDE;
        private System.Windows.Forms.Button design;
        private System.Windows.Forms.Panel Submenurepor;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnreportcompra;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnreportventa;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.Panel Principal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPelicula;
        private System.Windows.Forms.Button btnFuncionesN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPuesto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmpleado;
    }
}

