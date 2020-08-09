namespace FinalProyecto
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSLIDE = new System.Windows.Forms.PictureBox();
            this.design = new System.Windows.Forms.Button();
            this.Submenurepor = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.btnPeliculaTaquilla = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnreportventa = new System.Windows.Forms.Button();
            this.TituloBarra = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.PanelContenedor.SuspendLayout();
            this.Principal.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSLIDE)).BeginInit();
            this.Submenurepor.SuspendLayout();
            this.TituloBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
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
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1300, 800);
            this.PanelContenedor.TabIndex = 2;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Principal.Controls.Add(this.axWindowsMediaPlayer1);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.Location = new System.Drawing.Point(250, 40);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(1050, 680);
            this.Principal.TabIndex = 102;
            this.Principal.Paint += new System.Windows.Forms.PaintEventHandler(this.Principal_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbFecha);
            this.panel4.Controls.Add(this.lblHora);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(250, 720);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1050, 80);
            this.panel4.TabIndex = 101;
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(773, 57);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(235, 20);
            this.lbFecha.TabIndex = 8;
            this.lbFecha.Text = "Domingo, 9 de septiembre 2019";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(804, 3);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(205, 54);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "21:49:45";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.Menu.Controls.Add(this.panel2);
            this.Menu.Controls.Add(this.panel11);
            this.Menu.Controls.Add(this.button6);
            this.Menu.Controls.Add(this.panel5);
            this.Menu.Controls.Add(this.btnSLIDE);
            this.Menu.Controls.Add(this.design);
            this.Menu.Controls.Add(this.Submenurepor);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Controls.Add(this.btnEmpleado);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 40);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(250, 760);
            this.Menu.TabIndex = 100;
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel11.Location = new System.Drawing.Point(0, 193);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 32);
            this.panel11.TabIndex = 4;
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
            this.button6.Location = new System.Drawing.Point(6, 193);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(247, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "    Usuario";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel5.Location = new System.Drawing.Point(3, 239);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 9;
            // 
            // btnSLIDE
            // 
            this.btnSLIDE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSLIDE.Image = ((System.Drawing.Image)(resources.GetObject("btnSLIDE.Image")));
            this.btnSLIDE.Location = new System.Drawing.Point(0, 0);
            this.btnSLIDE.Name = "btnSLIDE";
            this.btnSLIDE.Size = new System.Drawing.Size(35, 35);
            this.btnSLIDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSLIDE.TabIndex = 4;
            this.btnSLIDE.TabStop = false;
            this.btnSLIDE.Click += new System.EventHandler(this.BtnSLIDE_Click);
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
            this.design.Location = new System.Drawing.Point(12, 239);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(247, 48);
            this.design.TabIndex = 8;
            this.design.Text = "    Reportes";
            this.design.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.design.UseVisualStyleBackColor = true;
            this.design.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Submenurepor
            // 
            this.Submenurepor.Controls.Add(this.panel7);
            this.Submenurepor.Controls.Add(this.button9);
            this.Submenurepor.Controls.Add(this.btnPeliculaTaquilla);
            this.Submenurepor.Controls.Add(this.panel6);
            this.Submenurepor.Controls.Add(this.btnreportventa);
            this.Submenurepor.Location = new System.Drawing.Point(41, 293);
            this.Submenurepor.Name = "Submenurepor";
            this.Submenurepor.Size = new System.Drawing.Size(212, 214);
            this.Submenurepor.TabIndex = 7;
            this.Submenurepor.Visible = false;
            this.Submenurepor.Paint += new System.Windows.Forms.PaintEventHandler(this.Submenurepor_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel7.Location = new System.Drawing.Point(0, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 32);
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
            this.button9.Location = new System.Drawing.Point(3, 116);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(209, 32);
            this.button9.TabIndex = 14;
            this.button9.Text = "Reporte Inventario";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // btnPeliculaTaquilla
            // 
            this.btnPeliculaTaquilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeliculaTaquilla.FlatAppearance.BorderSize = 0;
            this.btnPeliculaTaquilla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnPeliculaTaquilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeliculaTaquilla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeliculaTaquilla.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPeliculaTaquilla.Image = ((System.Drawing.Image)(resources.GetObject("btnPeliculaTaquilla.Image")));
            this.btnPeliculaTaquilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeliculaTaquilla.Location = new System.Drawing.Point(3, 41);
            this.btnPeliculaTaquilla.Name = "btnPeliculaTaquilla";
            this.btnPeliculaTaquilla.Size = new System.Drawing.Size(209, 69);
            this.btnPeliculaTaquilla.TabIndex = 12;
            this.btnPeliculaTaquilla.Text = "Reporte Pelicula más taquillera";
            this.btnPeliculaTaquilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeliculaTaquilla.UseVisualStyleBackColor = true;
            this.btnPeliculaTaquilla.Click += new System.EventHandler(this.Btnreportcompra_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel6.Location = new System.Drawing.Point(0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 32);
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
            this.btnreportventa.Location = new System.Drawing.Point(3, 3);
            this.btnreportventa.Name = "btnreportventa";
            this.btnreportventa.Size = new System.Drawing.Size(209, 32);
            this.btnreportventa.TabIndex = 10;
            this.btnreportventa.Text = "Reporte Ventas";
            this.btnreportventa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreportventa.UseVisualStyleBackColor = true;
            this.btnreportventa.Click += new System.EventHandler(this.Btnreportventa_Click);
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
            this.TituloBarra.Name = "TituloBarra";
            this.TituloBarra.Size = new System.Drawing.Size(1300, 40);
            this.TituloBarra.TabIndex = 11;
            this.TituloBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TituloBarra_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1212, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(35, 35);
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
            this.btnMin.Location = new System.Drawing.Point(1171, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 35);
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
            this.btnMax.Location = new System.Drawing.Point(1212, 2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(35, 35);
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
            this.btnClose.Location = new System.Drawing.Point(1253, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel2.Location = new System.Drawing.Point(41, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 32);
            this.panel2.TabIndex = 14;
            this.panel2.Visible = false;
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
            this.btnEmpleado.Location = new System.Drawing.Point(6, 144);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(263, 43);
            this.btnEmpleado.TabIndex = 1;
            this.btnEmpleado.Text = "    Empleados";
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.BtnEmpleado_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(191, 144);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(691, 364);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "FormPrincipal";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PanelContenedor.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
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
        private System.Windows.Forms.Button btnPeliculaTaquilla;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnreportventa;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.Panel Principal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmpleado;
    }
}

