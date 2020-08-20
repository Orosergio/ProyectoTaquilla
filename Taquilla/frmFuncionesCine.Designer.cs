namespace Taquilla
{
    partial class frmFuncionesCine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionesCine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAyuda = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.lblFuncciones = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblFunciones = new System.Windows.Forms.Label();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.btnSIguiente = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.picPelicula = new System.Windows.Forms.PictureBox();
            this.lblNombrePelicula = new System.Windows.Forms.Label();
            this.lblNombreCine = new System.Windows.Forms.Label();
            this.lblCine = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cboCodigoIdioma = new System.Windows.Forms.ComboBox();
            this.cboCodigoFormato = new System.Windows.Forms.ComboBox();
            this.cboFechaFunciones = new System.Windows.Forms.ComboBox();
            this.cboFechasFun = new System.Windows.Forms.ComboBox();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContenedorFunciones = new System.Windows.Forms.Panel();
            this.cboHoraInicio = new System.Windows.Forms.ComboBox();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.pnlContenedorFunciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.picAyuda);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 69);
            this.panel1.TabIndex = 92;
            // 
            // picAyuda
            // 
            this.picAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAyuda.Image = global::Taquilla.Properties.Resources.pregunta;
            this.picAyuda.Location = new System.Drawing.Point(28, 14);
            this.picAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.picAyuda.Name = "picAyuda";
            this.picAyuda.Size = new System.Drawing.Size(43, 39);
            this.picAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAyuda.TabIndex = 124;
            this.picAyuda.TabStop = false;
            this.picAyuda.Click += new System.EventHandler(this.picAyuda_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(964, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 39);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 123;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(895, 14);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(43, 39);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 122;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblFuncciones
            // 
            this.lblFuncciones.AutoSize = true;
            this.lblFuncciones.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncciones.ForeColor = System.Drawing.Color.White;
            this.lblFuncciones.Location = new System.Drawing.Point(49, 136);
            this.lblFuncciones.Name = "lblFuncciones";
            this.lblFuncciones.Size = new System.Drawing.Size(199, 27);
            this.lblFuncciones.TabIndex = 94;
            this.lblFuncciones.Text = "Fecha Funciones";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.ForeColor = System.Drawing.Color.White;
            this.lblFormato.Location = new System.Drawing.Point(51, 252);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(104, 27);
            this.lblFormato.TabIndex = 95;
            this.lblFormato.Text = "Formato";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.Color.White;
            this.lblIdioma.Location = new System.Drawing.Point(51, 331);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(89, 27);
            this.lblIdioma.TabIndex = 97;
            this.lblIdioma.Text = "Idioma";
            // 
            // lblFunciones
            // 
            this.lblFunciones.AutoSize = true;
            this.lblFunciones.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunciones.ForeColor = System.Drawing.Color.White;
            this.lblFunciones.Location = new System.Drawing.Point(53, 397);
            this.lblFunciones.Name = "lblFunciones";
            this.lblFunciones.Size = new System.Drawing.Size(126, 27);
            this.lblFunciones.TabIndex = 98;
            this.lblFunciones.Text = "Funciones";
            // 
            // cboFormato
            // 
            this.cboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Location = new System.Drawing.Point(249, 252);
            this.cboFormato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(296, 37);
            this.cboFormato.TabIndex = 100;
            this.cboFormato.SelectedIndexChanged += new System.EventHandler(this.cboFormato_SelectedIndexChanged_1);
            // 
            // cboIdioma
            // 
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(249, 326);
            this.cboIdioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(169, 37);
            this.cboIdioma.TabIndex = 102;
            this.cboIdioma.SelectedIndexChanged += new System.EventHandler(this.cboIdioma_SelectedIndexChanged_1);
            // 
            // btnSIguiente
            // 
            this.btnSIguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.btnSIguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSIguiente.Enabled = false;
            this.btnSIguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSIguiente.FlatAppearance.BorderSize = 0;
            this.btnSIguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSIguiente.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSIguiente.ForeColor = System.Drawing.Color.White;
            this.btnSIguiente.Location = new System.Drawing.Point(692, 608);
            this.btnSIguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSIguiente.Name = "btnSIguiente";
            this.btnSIguiente.Size = new System.Drawing.Size(208, 46);
            this.btnSIguiente.TabIndex = 117;
            this.btnSIguiente.Text = "Siguiente";
            this.btnSIguiente.UseVisualStyleBackColor = false;
            this.btnSIguiente.Click += new System.EventHandler(this.btnSIguiente_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(63, 608);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(208, 46);
            this.btnRegresar.TabIndex = 118;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // picPelicula
            // 
            this.picPelicula.BackColor = System.Drawing.Color.White;
            this.picPelicula.ImageLocation = "";
            this.picPelicula.Location = new System.Drawing.Point(711, 120);
            this.picPelicula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPelicula.Name = "picPelicula";
            this.picPelicula.Size = new System.Drawing.Size(237, 342);
            this.picPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPelicula.TabIndex = 121;
            this.picPelicula.TabStop = false;
            // 
            // lblNombrePelicula
            // 
            this.lblNombrePelicula.AutoSize = true;
            this.lblNombrePelicula.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePelicula.ForeColor = System.Drawing.Color.White;
            this.lblNombrePelicula.Location = new System.Drawing.Point(705, 476);
            this.lblNombrePelicula.Name = "lblNombrePelicula";
            this.lblNombrePelicula.Size = new System.Drawing.Size(82, 27);
            this.lblNombrePelicula.TabIndex = 123;
            this.lblNombrePelicula.Text = "label2";
            // 
            // lblNombreCine
            // 
            this.lblNombreCine.AutoSize = true;
            this.lblNombreCine.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCine.ForeColor = System.Drawing.Color.White;
            this.lblNombreCine.Location = new System.Drawing.Point(240, 86);
            this.lblNombreCine.Name = "lblNombreCine";
            this.lblNombreCine.Size = new System.Drawing.Size(82, 27);
            this.lblNombreCine.TabIndex = 125;
            this.lblNombreCine.Text = "label2";
            // 
            // lblCine
            // 
            this.lblCine.AutoSize = true;
            this.lblCine.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCine.ForeColor = System.Drawing.Color.White;
            this.lblCine.Location = new System.Drawing.Point(49, 86);
            this.lblCine.Name = "lblCine";
            this.lblCine.Size = new System.Drawing.Size(65, 27);
            this.lblCine.TabIndex = 124;
            this.lblCine.Text = "Cine";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(443, 326);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(101, 33);
            this.btnFiltrar.TabIndex = 126;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cboCodigoIdioma
            // 
            this.cboCodigoIdioma.FormattingEnabled = true;
            this.cboCodigoIdioma.Location = new System.Drawing.Point(616, 326);
            this.cboCodigoIdioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCodigoIdioma.Name = "cboCodigoIdioma";
            this.cboCodigoIdioma.Size = new System.Drawing.Size(49, 24);
            this.cboCodigoIdioma.TabIndex = 129;
            this.cboCodigoIdioma.Visible = false;
            // 
            // cboCodigoFormato
            // 
            this.cboCodigoFormato.FormattingEnabled = true;
            this.cboCodigoFormato.Location = new System.Drawing.Point(616, 252);
            this.cboCodigoFormato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCodigoFormato.Name = "cboCodigoFormato";
            this.cboCodigoFormato.Size = new System.Drawing.Size(49, 24);
            this.cboCodigoFormato.TabIndex = 130;
            this.cboCodigoFormato.Visible = false;
            // 
            // cboFechaFunciones
            // 
            this.cboFechaFunciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFechaFunciones.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFechaFunciones.FormattingEnabled = true;
            this.cboFechaFunciones.Location = new System.Drawing.Point(267, 136);
            this.cboFechaFunciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFechaFunciones.Name = "cboFechaFunciones";
            this.cboFechaFunciones.Size = new System.Drawing.Size(280, 34);
            this.cboFechaFunciones.TabIndex = 131;
            this.cboFechaFunciones.SelectedIndexChanged += new System.EventHandler(this.cboFechaFunciones_SelectedIndexChanged);
            // 
            // cboFechasFun
            // 
            this.cboFechasFun.FormattingEnabled = true;
            this.cboFechasFun.Location = new System.Drawing.Point(616, 141);
            this.cboFechasFun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFechasFun.Name = "cboFechasFun";
            this.cboFechasFun.Size = new System.Drawing.Size(49, 24);
            this.cboFechasFun.TabIndex = 132;
            this.cboFechasFun.Visible = false;
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dgvFunciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFunciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFunciones.EnableHeadersVisualStyles = false;
            this.dgvFunciones.Location = new System.Drawing.Point(0, 0);
            this.dgvFunciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFunciones.MultiSelect = false;
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.RowHeadersVisible = false;
            this.dgvFunciones.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvFunciones.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFunciones.RowTemplate.Height = 24;
            this.dgvFunciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunciones.Size = new System.Drawing.Size(371, 124);
            this.dgvFunciones.TabIndex = 134;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sala";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hora";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "id";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "idsala";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 125;
            // 
            // pnlContenedorFunciones
            // 
            this.pnlContenedorFunciones.Controls.Add(this.dgvFunciones);
            this.pnlContenedorFunciones.Location = new System.Drawing.Point(251, 397);
            this.pnlContenedorFunciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContenedorFunciones.Name = "pnlContenedorFunciones";
            this.pnlContenedorFunciones.Size = new System.Drawing.Size(371, 124);
            this.pnlContenedorFunciones.TabIndex = 135;
            // 
            // cboHoraInicio
            // 
            this.cboHoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoraInicio.Enabled = false;
            this.cboHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoraInicio.FormattingEnabled = true;
            this.cboHoraInicio.Location = new System.Drawing.Point(249, 189);
            this.cboHoraInicio.Name = "cboHoraInicio";
            this.cboHoraInicio.Size = new System.Drawing.Size(155, 37);
            this.cboHoraInicio.TabIndex = 141;
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFinal.ForeColor = System.Drawing.Color.White;
            this.lblHoraFinal.Location = new System.Drawing.Point(443, 192);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(103, 29);
            this.lblHoraFinal.TabIndex = 140;
            this.lblHoraFinal.Text = "23:59:00";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(53, 194);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(97, 27);
            this.lblHora.TabIndex = 139;
            this.lblHora.Text = "Horario";
            // 
            // frmFuncionesCine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1036, 684);
            this.Controls.Add(this.cboHoraInicio);
            this.Controls.Add(this.lblHoraFinal);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pnlContenedorFunciones);
            this.Controls.Add(this.cboFechasFun);
            this.Controls.Add(this.cboFechaFunciones);
            this.Controls.Add(this.cboCodigoFormato);
            this.Controls.Add(this.cboCodigoIdioma);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblNombreCine);
            this.Controls.Add(this.lblCine);
            this.Controls.Add(this.lblNombrePelicula);
            this.Controls.Add(this.picPelicula);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSIguiente);
            this.Controls.Add(this.cboIdioma);
            this.Controls.Add(this.cboFormato);
            this.Controls.Add(this.lblFunciones);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.lblFuncciones);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFuncionesCine";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuncionesCine";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.pnlContenedorFunciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFuncciones;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblFunciones;
        private System.Windows.Forms.ComboBox cboFormato;
        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.Button btnSIguiente;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnClose;
        public System.Windows.Forms.Label lblNombreCine;
        private System.Windows.Forms.Label lblCine;
        public System.Windows.Forms.Label lblNombrePelicula;
        public System.Windows.Forms.PictureBox picPelicula;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cboCodigoIdioma;
        private System.Windows.Forms.ComboBox cboCodigoFormato;
        private System.Windows.Forms.ComboBox cboFechaFunciones;
        private System.Windows.Forms.ComboBox cboFechasFun;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.Panel pnlContenedorFunciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox picAyuda;
        private System.Windows.Forms.ComboBox cboHoraInicio;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.Label lblHora;
    }
}