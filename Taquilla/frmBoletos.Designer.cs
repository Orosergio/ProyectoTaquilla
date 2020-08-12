namespace Taquilla
{
    partial class frmBoletos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoletos));
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlAsientos = new System.Windows.Forms.Panel();
            this.lblPantalla = new System.Windows.Forms.Label();
            this.lblJ = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.pnlDatosElegidos = new System.Windows.Forms.Panel();
            this.lblCantTiempoRestante = new System.Windows.Forms.Label();
            this.lblBoletosRes = new System.Windows.Forms.Label();
            this.lblCantBoletosRes = new System.Windows.Forms.Label();
            this.lblBoletos = new System.Windows.Forms.Label();
            this.lblTiempoRestante = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblCantBoletos = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblCine = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.lblI = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.lblNoSala = new System.Windows.Forms.Label();
            this.lblHoraFuncion = new System.Windows.Forms.Label();
            this.lblNombrePelicula = new System.Windows.Forms.Label();
            this.lblDiaPelicula = new System.Windows.Forms.Label();
            this.lblCineElegido = new System.Windows.Forms.Label();
            this.picVerde = new System.Windows.Forms.PictureBox();
            this.picRojo = new System.Windows.Forms.PictureBox();
            this.picAzul = new System.Windows.Forms.PictureBox();
            this.pnlSignificadoColores = new System.Windows.Forms.Panel();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.lblNoDisponible = new System.Windows.Forms.Label();
            this.lblElegido = new System.Windows.Forms.Label();
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlDatosElegidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAzul)).BeginInit();
            this.pnlSignificadoColores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.pnlBarraSuperior.Controls.Add(this.btnRestaurar);
            this.pnlBarraSuperior.Controls.Add(this.btnMin);
            this.pnlBarraSuperior.Controls.Add(this.btnMax);
            this.pnlBarraSuperior.Controls.Add(this.btnCerrar);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(1249, 41);
            this.pnlBarraSuperior.TabIndex = 0;
            this.pnlBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraSuperior_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1168, 6);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(32, 32);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1127, 6);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(32, 32);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 6;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1166, 11);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(19, 21);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 5;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1209, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlAsientos
            // 
            this.pnlAsientos.Location = new System.Drawing.Point(441, 104);
            this.pnlAsientos.Name = "pnlAsientos";
            this.pnlAsientos.Size = new System.Drawing.Size(512, 501);
            this.pnlAsientos.TabIndex = 1;
            this.pnlAsientos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlAsientos_MouseClick);
            // 
            // lblPantalla
            // 
            this.lblPantalla.BackColor = System.Drawing.Color.Black;
            this.lblPantalla.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantalla.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPantalla.Location = new System.Drawing.Point(441, 654);
            this.lblPantalla.Name = "lblPantalla";
            this.lblPantalla.Size = new System.Drawing.Size(512, 39);
            this.lblPantalla.TabIndex = 3;
            this.lblPantalla.Text = "Pantalla";
            this.lblPantalla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJ
            // 
            this.lblJ.AutoSize = true;
            this.lblJ.BackColor = System.Drawing.Color.Transparent;
            this.lblJ.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJ.Location = new System.Drawing.Point(402, 117);
            this.lblJ.Name = "lblJ";
            this.lblJ.Size = new System.Drawing.Size(16, 21);
            this.lblJ.TabIndex = 8;
            this.lblJ.Text = "J";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl1.Location = new System.Drawing.Point(453, 60);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(20, 21);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl2.Location = new System.Drawing.Point(505, 60);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(20, 21);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl3.Location = new System.Drawing.Point(553, 60);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(20, 21);
            this.lbl3.TabIndex = 11;
            this.lbl3.Text = "3";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl4.Location = new System.Drawing.Point(604, 60);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(20, 21);
            this.lbl4.TabIndex = 12;
            this.lbl4.Text = "4";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl5.Location = new System.Drawing.Point(655, 60);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(20, 21);
            this.lbl5.TabIndex = 13;
            this.lbl5.Text = "5";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.Transparent;
            this.lbl6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl6.Location = new System.Drawing.Point(707, 60);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(20, 21);
            this.lbl6.TabIndex = 14;
            this.lbl6.Text = "6";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.Color.Transparent;
            this.lbl7.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl7.Location = new System.Drawing.Point(757, 60);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(20, 21);
            this.lbl7.TabIndex = 15;
            this.lbl7.Text = "7";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.Transparent;
            this.lbl8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl8.Location = new System.Drawing.Point(805, 60);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(20, 21);
            this.lbl8.TabIndex = 16;
            this.lbl8.Text = "8";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.BackColor = System.Drawing.Color.Transparent;
            this.lbl9.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl9.Location = new System.Drawing.Point(854, 60);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(20, 21);
            this.lbl9.TabIndex = 17;
            this.lbl9.Text = "9";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.BackColor = System.Drawing.Color.Transparent;
            this.lbl10.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl10.Location = new System.Drawing.Point(902, 60);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(30, 21);
            this.lbl10.TabIndex = 18;
            this.lbl10.Text = "10";
            // 
            // pnlDatosElegidos
            // 
            this.pnlDatosElegidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnlDatosElegidos.Controls.Add(this.lblCineElegido);
            this.pnlDatosElegidos.Controls.Add(this.lblDiaPelicula);
            this.pnlDatosElegidos.Controls.Add(this.lblNombrePelicula);
            this.pnlDatosElegidos.Controls.Add(this.lblHoraFuncion);
            this.pnlDatosElegidos.Controls.Add(this.lblNoSala);
            this.pnlDatosElegidos.Controls.Add(this.lblCantTiempoRestante);
            this.pnlDatosElegidos.Controls.Add(this.lblBoletosRes);
            this.pnlDatosElegidos.Controls.Add(this.lblCantBoletosRes);
            this.pnlDatosElegidos.Controls.Add(this.lblBoletos);
            this.pnlDatosElegidos.Controls.Add(this.lblTiempoRestante);
            this.pnlDatosElegidos.Controls.Add(this.lblPelicula);
            this.pnlDatosElegidos.Controls.Add(this.lblDatos);
            this.pnlDatosElegidos.Controls.Add(this.lblFuncion);
            this.pnlDatosElegidos.Controls.Add(this.lblDia);
            this.pnlDatosElegidos.Controls.Add(this.lblCantBoletos);
            this.pnlDatosElegidos.Controls.Add(this.lblSala);
            this.pnlDatosElegidos.Controls.Add(this.lblCine);
            this.pnlDatosElegidos.Location = new System.Drawing.Point(25, 75);
            this.pnlDatosElegidos.Name = "pnlDatosElegidos";
            this.pnlDatosElegidos.Size = new System.Drawing.Size(351, 404);
            this.pnlDatosElegidos.TabIndex = 25;
            // 
            // lblCantTiempoRestante
            // 
            this.lblCantTiempoRestante.AutoSize = true;
            this.lblCantTiempoRestante.BackColor = System.Drawing.Color.Transparent;
            this.lblCantTiempoRestante.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTiempoRestante.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantTiempoRestante.Location = new System.Drawing.Point(205, 354);
            this.lblCantTiempoRestante.Name = "lblCantTiempoRestante";
            this.lblCantTiempoRestante.Size = new System.Drawing.Size(0, 21);
            this.lblCantTiempoRestante.TabIndex = 36;
            // 
            // lblBoletosRes
            // 
            this.lblBoletosRes.AutoSize = true;
            this.lblBoletosRes.BackColor = System.Drawing.Color.Transparent;
            this.lblBoletosRes.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoletosRes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBoletosRes.Location = new System.Drawing.Point(17, 313);
            this.lblBoletosRes.Name = "lblBoletosRes";
            this.lblBoletosRes.Size = new System.Drawing.Size(209, 21);
            this.lblBoletosRes.TabIndex = 35;
            this.lblBoletosRes.Text = "BOLETOS RESTANTES:";
            // 
            // lblCantBoletosRes
            // 
            this.lblCantBoletosRes.AutoSize = true;
            this.lblCantBoletosRes.BackColor = System.Drawing.Color.Transparent;
            this.lblCantBoletosRes.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantBoletosRes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantBoletosRes.Location = new System.Drawing.Point(232, 313);
            this.lblCantBoletosRes.Name = "lblCantBoletosRes";
            this.lblCantBoletosRes.Size = new System.Drawing.Size(20, 21);
            this.lblCantBoletosRes.TabIndex = 34;
            this.lblCantBoletosRes.Text = "2";
            // 
            // lblBoletos
            // 
            this.lblBoletos.AutoSize = true;
            this.lblBoletos.BackColor = System.Drawing.Color.Transparent;
            this.lblBoletos.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoletos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBoletos.Location = new System.Drawing.Point(17, 282);
            this.lblBoletos.Name = "lblBoletos";
            this.lblBoletos.Size = new System.Drawing.Size(105, 21);
            this.lblBoletos.TabIndex = 33;
            this.lblBoletos.Text = "BOLETOS: ";
            // 
            // lblTiempoRestante
            // 
            this.lblTiempoRestante.AutoSize = true;
            this.lblTiempoRestante.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempoRestante.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRestante.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTiempoRestante.Location = new System.Drawing.Point(17, 354);
            this.lblTiempoRestante.Name = "lblTiempoRestante";
            this.lblTiempoRestante.Size = new System.Drawing.Size(192, 21);
            this.lblTiempoRestante.TabIndex = 32;
            this.lblTiempoRestante.Text = "TIEMPO RESTANTE: ";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.BackColor = System.Drawing.Color.Transparent;
            this.lblPelicula.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPelicula.Location = new System.Drawing.Point(17, 162);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(105, 21);
            this.lblPelicula.TabIndex = 31;
            this.lblPelicula.Text = "PELICULA:";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDatos.Location = new System.Drawing.Point(85, 29);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(93, 27);
            this.lblDatos.TabIndex = 30;
            this.lblDatos.Text = "DATOS";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncion.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFuncion.Location = new System.Drawing.Point(17, 206);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(107, 21);
            this.lblFuncion.TabIndex = 29;
            this.lblFuncion.Text = "FUNCIÓN: ";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDia.Location = new System.Drawing.Point(17, 122);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(54, 21);
            this.lblDia.TabIndex = 28;
            this.lblDia.Text = "DIA: ";
            // 
            // lblCantBoletos
            // 
            this.lblCantBoletos.AutoSize = true;
            this.lblCantBoletos.BackColor = System.Drawing.Color.Transparent;
            this.lblCantBoletos.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantBoletos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantBoletos.Location = new System.Drawing.Point(121, 282);
            this.lblCantBoletos.Name = "lblCantBoletos";
            this.lblCantBoletos.Size = new System.Drawing.Size(20, 21);
            this.lblCantBoletos.TabIndex = 27;
            this.lblCantBoletos.Text = "2";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.BackColor = System.Drawing.Color.Transparent;
            this.lblSala.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSala.Location = new System.Drawing.Point(17, 244);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(62, 21);
            this.lblSala.TabIndex = 26;
            this.lblSala.Text = "SALA:";
            // 
            // lblCine
            // 
            this.lblCine.AutoSize = true;
            this.lblCine.BackColor = System.Drawing.Color.Transparent;
            this.lblCine.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCine.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCine.Location = new System.Drawing.Point(17, 78);
            this.lblCine.Name = "lblCine";
            this.lblCine.Size = new System.Drawing.Size(62, 21);
            this.lblCine.TabIndex = 25;
            this.lblCine.Text = "CINE:";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAtras.Location = new System.Drawing.Point(68, 501);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(98, 39);
            this.btnAtras.TabIndex = 26;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = false;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.Info;
            this.btnFacturacion.Location = new System.Drawing.Point(172, 501);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(169, 39);
            this.btnFacturacion.TabIndex = 27;
            this.btnFacturacion.Text = "FACTURACION";
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.BackColor = System.Drawing.Color.Transparent;
            this.lblI.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.ForeColor = System.Drawing.SystemColors.Control;
            this.lblI.Location = new System.Drawing.Point(401, 168);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(16, 21);
            this.lblI.TabIndex = 28;
            this.lblI.Text = "I";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.BackColor = System.Drawing.Color.Transparent;
            this.lblH.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.ForeColor = System.Drawing.SystemColors.Control;
            this.lblH.Location = new System.Drawing.Point(398, 214);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(23, 21);
            this.lblH.TabIndex = 29;
            this.lblH.Text = "H";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.Color.Transparent;
            this.lblG.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.ForeColor = System.Drawing.SystemColors.Control;
            this.lblG.Location = new System.Drawing.Point(397, 266);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(25, 21);
            this.lblG.TabIndex = 30;
            this.lblG.Text = "G";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.BackColor = System.Drawing.Color.Transparent;
            this.lblF.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.ForeColor = System.Drawing.SystemColors.Control;
            this.lblF.Location = new System.Drawing.Point(397, 313);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(20, 21);
            this.lblF.TabIndex = 31;
            this.lblF.Text = "F";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.BackColor = System.Drawing.Color.Transparent;
            this.lblE.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.ForeColor = System.Drawing.SystemColors.Control;
            this.lblE.Location = new System.Drawing.Point(397, 366);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(22, 21);
            this.lblE.TabIndex = 32;
            this.lblE.Text = "E";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.Color.Transparent;
            this.lblD.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblD.Location = new System.Drawing.Point(397, 415);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(24, 21);
            this.lblD.TabIndex = 33;
            this.lblD.Text = "D";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.Transparent;
            this.lblC.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblC.Location = new System.Drawing.Point(397, 467);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(24, 21);
            this.lblC.TabIndex = 34;
            this.lblC.Text = "C";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.Transparent;
            this.lblB.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblB.Location = new System.Drawing.Point(397, 519);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(21, 21);
            this.lblB.TabIndex = 35;
            this.lblB.Text = "B";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblA.Location = new System.Drawing.Point(396, 569);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(23, 21);
            this.lblA.TabIndex = 36;
            this.lblA.Text = "A";
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Interval = 1000;
            this.tmrTiempo.Tick += new System.EventHandler(this.tmrTiempo_Tick);
            // 
            // lblNoSala
            // 
            this.lblNoSala.AutoSize = true;
            this.lblNoSala.BackColor = System.Drawing.Color.Transparent;
            this.lblNoSala.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSala.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNoSala.Location = new System.Drawing.Point(74, 244);
            this.lblNoSala.Name = "lblNoSala";
            this.lblNoSala.Size = new System.Drawing.Size(20, 21);
            this.lblNoSala.TabIndex = 37;
            this.lblNoSala.Text = "2";
            // 
            // lblHoraFuncion
            // 
            this.lblHoraFuncion.AutoSize = true;
            this.lblHoraFuncion.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraFuncion.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFuncion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHoraFuncion.Location = new System.Drawing.Point(121, 206);
            this.lblHoraFuncion.Name = "lblHoraFuncion";
            this.lblHoraFuncion.Size = new System.Drawing.Size(20, 21);
            this.lblHoraFuncion.TabIndex = 38;
            this.lblHoraFuncion.Text = "2";
            // 
            // lblNombrePelicula
            // 
            this.lblNombrePelicula.AutoSize = true;
            this.lblNombrePelicula.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrePelicula.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePelicula.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombrePelicula.Location = new System.Drawing.Point(121, 162);
            this.lblNombrePelicula.Name = "lblNombrePelicula";
            this.lblNombrePelicula.Size = new System.Drawing.Size(20, 21);
            this.lblNombrePelicula.TabIndex = 39;
            this.lblNombrePelicula.Text = "2";
            // 
            // lblDiaPelicula
            // 
            this.lblDiaPelicula.AutoSize = true;
            this.lblDiaPelicula.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaPelicula.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaPelicula.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDiaPelicula.Location = new System.Drawing.Point(59, 122);
            this.lblDiaPelicula.Name = "lblDiaPelicula";
            this.lblDiaPelicula.Size = new System.Drawing.Size(20, 21);
            this.lblDiaPelicula.TabIndex = 40;
            this.lblDiaPelicula.Text = "2";
            // 
            // lblCineElegido
            // 
            this.lblCineElegido.AutoSize = true;
            this.lblCineElegido.BackColor = System.Drawing.Color.Transparent;
            this.lblCineElegido.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCineElegido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCineElegido.Location = new System.Drawing.Point(74, 78);
            this.lblCineElegido.Name = "lblCineElegido";
            this.lblCineElegido.Size = new System.Drawing.Size(20, 21);
            this.lblCineElegido.TabIndex = 41;
            this.lblCineElegido.Text = "2";
            // 
            // picVerde
            // 
            this.picVerde.Image = ((System.Drawing.Image)(resources.GetObject("picVerde.Image")));
            this.picVerde.Location = new System.Drawing.Point(19, 29);
            this.picVerde.Name = "picVerde";
            this.picVerde.Size = new System.Drawing.Size(45, 45);
            this.picVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerde.TabIndex = 37;
            this.picVerde.TabStop = false;
            // 
            // picRojo
            // 
            this.picRojo.Image = ((System.Drawing.Image)(resources.GetObject("picRojo.Image")));
            this.picRojo.Location = new System.Drawing.Point(19, 98);
            this.picRojo.Name = "picRojo";
            this.picRojo.Size = new System.Drawing.Size(45, 45);
            this.picRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRojo.TabIndex = 38;
            this.picRojo.TabStop = false;
            // 
            // picAzul
            // 
            this.picAzul.Image = ((System.Drawing.Image)(resources.GetObject("picAzul.Image")));
            this.picAzul.Location = new System.Drawing.Point(19, 167);
            this.picAzul.Name = "picAzul";
            this.picAzul.Size = new System.Drawing.Size(45, 45);
            this.picAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAzul.TabIndex = 39;
            this.picAzul.TabStop = false;
            // 
            // pnlSignificadoColores
            // 
            this.pnlSignificadoColores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnlSignificadoColores.Controls.Add(this.lblElegido);
            this.pnlSignificadoColores.Controls.Add(this.lblNoDisponible);
            this.pnlSignificadoColores.Controls.Add(this.lblDisponible);
            this.pnlSignificadoColores.Controls.Add(this.picVerde);
            this.pnlSignificadoColores.Controls.Add(this.picAzul);
            this.pnlSignificadoColores.Controls.Add(this.picRojo);
            this.pnlSignificadoColores.Location = new System.Drawing.Point(975, 75);
            this.pnlSignificadoColores.Name = "pnlSignificadoColores";
            this.pnlSignificadoColores.Size = new System.Drawing.Size(253, 240);
            this.pnlSignificadoColores.TabIndex = 40;
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.BackColor = System.Drawing.Color.Transparent;
            this.lblDisponible.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDisponible.Location = new System.Drawing.Point(80, 43);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(119, 21);
            this.lblDisponible.TabIndex = 40;
            this.lblDisponible.Text = "DISPONIBLE";
            // 
            // lblNoDisponible
            // 
            this.lblNoDisponible.AutoSize = true;
            this.lblNoDisponible.BackColor = System.Drawing.Color.Transparent;
            this.lblNoDisponible.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDisponible.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNoDisponible.Location = new System.Drawing.Point(80, 116);
            this.lblNoDisponible.Name = "lblNoDisponible";
            this.lblNoDisponible.Size = new System.Drawing.Size(153, 21);
            this.lblNoDisponible.TabIndex = 41;
            this.lblNoDisponible.Text = "NO DISPONIBLE";
            // 
            // lblElegido
            // 
            this.lblElegido.AutoSize = true;
            this.lblElegido.BackColor = System.Drawing.Color.Transparent;
            this.lblElegido.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblElegido.Location = new System.Drawing.Point(80, 183);
            this.lblElegido.Name = "lblElegido";
            this.lblElegido.Size = new System.Drawing.Size(94, 21);
            this.lblElegido.TabIndex = 42;
            this.lblElegido.Text = "ELEGIDO";
            // 
            // frmBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1249, 710);
            this.Controls.Add(this.pnlSignificadoColores);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pnlDatosElegidos);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblJ);
            this.Controls.Add(this.lblPantalla);
            this.Controls.Add(this.pnlAsientos);
            this.Controls.Add(this.pnlBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBoletos";
            this.Opacity = 0.96D;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlDatosElegidos.ResumeLayout(false);
            this.pnlDatosElegidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAzul)).EndInit();
            this.pnlSignificadoColores.ResumeLayout(false);
            this.pnlSignificadoColores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.Panel pnlAsientos;
        private System.Windows.Forms.Label lblPantalla;
        private System.Windows.Forms.Label lblJ;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Panel pnlDatosElegidos;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblCantBoletos;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblCine;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblTiempoRestante;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblBoletosRes;
        private System.Windows.Forms.Label lblCantBoletosRes;
        private System.Windows.Forms.Label lblBoletos;
        private System.Windows.Forms.Label lblCantTiempoRestante;
        private System.Windows.Forms.Timer tmrTiempo;
        private System.Windows.Forms.Label lblCineElegido;
        private System.Windows.Forms.Label lblDiaPelicula;
        private System.Windows.Forms.Label lblNombrePelicula;
        private System.Windows.Forms.Label lblHoraFuncion;
        private System.Windows.Forms.Label lblNoSala;
        private System.Windows.Forms.PictureBox picVerde;
        private System.Windows.Forms.PictureBox picRojo;
        private System.Windows.Forms.PictureBox picAzul;
        private System.Windows.Forms.Panel pnlSignificadoColores;
        private System.Windows.Forms.Label lblElegido;
        private System.Windows.Forms.Label lblNoDisponible;
        private System.Windows.Forms.Label lblDisponible;
    }
}

