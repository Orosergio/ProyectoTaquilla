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
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnBoleto = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnCine = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnDescuento = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFunciones = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.btnSLIDE = new System.Windows.Forms.PictureBox();
            this.Submenurepor = new System.Windows.Forms.Panel();
            this.btnReportePuntos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPeliculaTaquilla = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnreportventa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.TituloBarra = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
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
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.Location = new System.Drawing.Point(333, 49);
            this.Principal.Margin = new System.Windows.Forms.Padding(4);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(1400, 838);
            this.Principal.TabIndex = 102;
            this.Principal.Paint += new System.Windows.Forms.PaintEventHandler(this.Principal_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbFecha);
            this.panel4.Controls.Add(this.lblHora);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(333, 887);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1400, 98);
            this.panel4.TabIndex = 101;
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(995, 70);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(369, 27);
            this.lbFecha.TabIndex = 8;
            this.lbFecha.Text = "Domingo, 9 de septiembre 2019";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(1072, 4);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(263, 68);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "21:49:45";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.Menu.Controls.Add(this.panel12);
            this.Menu.Controls.Add(this.btnBoleto);
            this.Menu.Controls.Add(this.panel11);
            this.Menu.Controls.Add(this.btnCine);
            this.Menu.Controls.Add(this.panel9);
            this.Menu.Controls.Add(this.btnDescuento);
            this.Menu.Controls.Add(this.panel5);
            this.Menu.Controls.Add(this.btnReportes);
            this.Menu.Controls.Add(this.panel8);
            this.Menu.Controls.Add(this.btnUsuario);
            this.Menu.Controls.Add(this.panel3);
            this.Menu.Controls.Add(this.btnFunciones);
            this.Menu.Controls.Add(this.panel10);
            this.Menu.Controls.Add(this.btnPeliculas);
            this.Menu.Controls.Add(this.btnSLIDE);
            this.Menu.Controls.Add(this.Submenurepor);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Controls.Add(this.btnEmpleado);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 49);
            this.Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(333, 936);
            this.Menu.TabIndex = 100;
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel12.Location = new System.Drawing.Point(0, 414);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(7, 39);
            this.panel12.TabIndex = 22;
            // 
            // btnBoleto
            // 
            this.btnBoleto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoleto.FlatAppearance.BorderSize = 0;
            this.btnBoleto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnBoleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoleto.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoleto.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBoleto.Image = ((System.Drawing.Image)(resources.GetObject("btnBoleto.Image")));
            this.btnBoleto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoleto.Location = new System.Drawing.Point(29, 411);
            this.btnBoleto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBoleto.Name = "btnBoleto";
            this.btnBoleto.Size = new System.Drawing.Size(347, 50);
            this.btnBoleto.TabIndex = 23;
            this.btnBoleto.Text = "     Boleto";
            this.btnBoleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoleto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoleto.UseVisualStyleBackColor = true;
            this.btnBoleto.Click += new System.EventHandler(this.btnBoleto_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel11.Location = new System.Drawing.Point(0, 356);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(7, 39);
            this.panel11.TabIndex = 20;
            // 
            // btnCine
            // 
            this.btnCine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCine.FlatAppearance.BorderSize = 0;
            this.btnCine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnCine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCine.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCine.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCine.Image = ((System.Drawing.Image)(resources.GetObject("btnCine.Image")));
            this.btnCine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCine.Location = new System.Drawing.Point(29, 353);
            this.btnCine.Margin = new System.Windows.Forms.Padding(4);
            this.btnCine.Name = "btnCine";
            this.btnCine.Size = new System.Drawing.Size(347, 50);
            this.btnCine.TabIndex = 21;
            this.btnCine.Text = "     Cine";
            this.btnCine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCine.UseVisualStyleBackColor = true;
            this.btnCine.Click += new System.EventHandler(this.btnCine_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel9.Location = new System.Drawing.Point(0, 70);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(7, 39);
            this.panel9.TabIndex = 12;
            // 
            // btnDescuento
            // 
            this.btnDescuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescuento.FlatAppearance.BorderSize = 0;
            this.btnDescuento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuento.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescuento.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDescuento.Image = ((System.Drawing.Image)(resources.GetObject("btnDescuento.Image")));
            this.btnDescuento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescuento.Location = new System.Drawing.Point(29, 56);
            this.btnDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Size = new System.Drawing.Size(351, 53);
            this.btnDescuento.TabIndex = 11;
            this.btnDescuento.Text = "   Descuentos";
            this.btnDescuento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescuento.UseVisualStyleBackColor = true;
            this.btnDescuento.Click += new System.EventHandler(this.btnDescuento_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel5.Location = new System.Drawing.Point(0, 485);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 39);
            this.panel5.TabIndex = 18;
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(29, 480);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(347, 50);
            this.btnReportes.TabIndex = 19;
            this.btnReportes.Text = "   Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click_1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel8.Location = new System.Drawing.Point(0, 298);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(7, 39);
            this.panel8.TabIndex = 16;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(29, 295);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(347, 50);
            this.btnUsuario.TabIndex = 17;
            this.btnUsuario.Text = "     Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel3.Location = new System.Drawing.Point(0, 177);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 39);
            this.panel3.TabIndex = 15;
            // 
            // btnFunciones
            // 
            this.btnFunciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunciones.FlatAppearance.BorderSize = 0;
            this.btnFunciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnFunciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunciones.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunciones.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFunciones.Image = ((System.Drawing.Image)(resources.GetObject("btnFunciones.Image")));
            this.btnFunciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunciones.Location = new System.Drawing.Point(29, 177);
            this.btnFunciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnFunciones.Name = "btnFunciones";
            this.btnFunciones.Size = new System.Drawing.Size(351, 53);
            this.btnFunciones.TabIndex = 14;
            this.btnFunciones.Text = "   Funciones";
            this.btnFunciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFunciones.UseVisualStyleBackColor = true;
            this.btnFunciones.Click += new System.EventHandler(this.btnFunciones_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel10.Location = new System.Drawing.Point(0, 117);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(7, 39);
            this.panel10.TabIndex = 11;
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeliculas.FlatAppearance.BorderSize = 0;
            this.btnPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeliculas.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeliculas.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPeliculas.Image = ((System.Drawing.Image)(resources.GetObject("btnPeliculas.Image")));
            this.btnPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeliculas.Location = new System.Drawing.Point(29, 117);
            this.btnPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(351, 53);
            this.btnPeliculas.TabIndex = 10;
            this.btnPeliculas.Text = "   Películas";
            this.btnPeliculas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPeliculas.UseVisualStyleBackColor = true;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // btnSLIDE
            // 
            this.btnSLIDE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSLIDE.Image = ((System.Drawing.Image)(resources.GetObject("btnSLIDE.Image")));
            this.btnSLIDE.Location = new System.Drawing.Point(0, 0);
            this.btnSLIDE.Margin = new System.Windows.Forms.Padding(4);
            this.btnSLIDE.Name = "btnSLIDE";
            this.btnSLIDE.Size = new System.Drawing.Size(47, 43);
            this.btnSLIDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSLIDE.TabIndex = 4;
            this.btnSLIDE.TabStop = false;
            this.btnSLIDE.Click += new System.EventHandler(this.BtnSLIDE_Click);
            // 
            // Submenurepor
            // 
            this.Submenurepor.Controls.Add(this.btnReportePuntos);
            this.Submenurepor.Controls.Add(this.panel2);
            this.Submenurepor.Controls.Add(this.panel7);
            this.Submenurepor.Controls.Add(this.btnPeliculaTaquilla);
            this.Submenurepor.Controls.Add(this.panel6);
            this.Submenurepor.Controls.Add(this.btnreportventa);
            this.Submenurepor.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submenurepor.Location = new System.Drawing.Point(29, 550);
            this.Submenurepor.Margin = new System.Windows.Forms.Padding(4);
            this.Submenurepor.Name = "Submenurepor";
            this.Submenurepor.Size = new System.Drawing.Size(304, 316);
            this.Submenurepor.TabIndex = 7;
            this.Submenurepor.Visible = false;
            this.Submenurepor.Paint += new System.Windows.Forms.PaintEventHandler(this.Submenurepor_Paint);
            // 
            // btnReportePuntos
            // 
            this.btnReportePuntos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportePuntos.FlatAppearance.BorderSize = 0;
            this.btnReportePuntos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnReportePuntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePuntos.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePuntos.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnReportePuntos.Image = ((System.Drawing.Image)(resources.GetObject("btnReportePuntos.Image")));
            this.btnReportePuntos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReportePuntos.Location = new System.Drawing.Point(16, 177);
            this.btnReportePuntos.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportePuntos.Name = "btnReportePuntos";
            this.btnReportePuntos.Size = new System.Drawing.Size(288, 117);
            this.btnReportePuntos.TabIndex = 20;
            this.btnReportePuntos.Text = "Reporte de Puntos del Cliente";
            this.btnReportePuntos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportePuntos.UseVisualStyleBackColor = true;
            this.btnReportePuntos.Click += new System.EventHandler(this.btnReportePuntos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel2.Location = new System.Drawing.Point(0, 193);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 39);
            this.panel2.TabIndex = 14;
            this.panel2.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel7.Location = new System.Drawing.Point(0, 82);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 39);
            this.panel7.TabIndex = 13;
            this.panel7.Visible = false;
            // 
            // btnPeliculaTaquilla
            // 
            this.btnPeliculaTaquilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeliculaTaquilla.FlatAppearance.BorderSize = 0;
            this.btnPeliculaTaquilla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnPeliculaTaquilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeliculaTaquilla.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeliculaTaquilla.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPeliculaTaquilla.Image = ((System.Drawing.Image)(resources.GetObject("btnPeliculaTaquilla.Image")));
            this.btnPeliculaTaquilla.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPeliculaTaquilla.Location = new System.Drawing.Point(12, 63);
            this.btnPeliculaTaquilla.Margin = new System.Windows.Forms.Padding(4);
            this.btnPeliculaTaquilla.Name = "btnPeliculaTaquilla";
            this.btnPeliculaTaquilla.Size = new System.Drawing.Size(288, 123);
            this.btnPeliculaTaquilla.TabIndex = 12;
            this.btnPeliculaTaquilla.Text = "Reporte Pelicula más taquillera";
            this.btnPeliculaTaquilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeliculaTaquilla.UseVisualStyleBackColor = true;
            this.btnPeliculaTaquilla.Click += new System.EventHandler(this.Btnreportcompra_Click);
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
            this.btnreportventa.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportventa.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnreportventa.Image = ((System.Drawing.Image)(resources.GetObject("btnreportventa.Image")));
            this.btnreportventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportventa.Location = new System.Drawing.Point(12, 4);
            this.btnreportventa.Margin = new System.Windows.Forms.Padding(4);
            this.btnreportventa.Name = "btnreportventa";
            this.btnreportventa.Size = new System.Drawing.Size(279, 39);
            this.btnreportventa.TabIndex = 10;
            this.btnreportventa.Text = "Reporte Ventas";
            this.btnreportventa.UseVisualStyleBackColor = true;
            this.btnreportventa.Click += new System.EventHandler(this.Btnreportventa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.panel1.Location = new System.Drawing.Point(0, 235);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 39);
            this.panel1.TabIndex = 2;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(29, 235);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(351, 53);
            this.btnEmpleado.TabIndex = 1;
            this.btnEmpleado.Text = "   Empleados";
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.BtnEmpleado_Click);
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
        private System.Windows.Forms.PictureBox btnSLIDE;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFunciones;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnReportePuntos;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnDescuento;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnCine;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnBoleto;
    }
}

