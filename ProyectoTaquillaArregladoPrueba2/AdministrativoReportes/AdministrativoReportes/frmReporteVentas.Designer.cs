namespace WindowsFormsApp1
{
    partial class frmReporteVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvventas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblType = new System.Windows.Forms.Label();
            this.cboEleccion = new System.Windows.Forms.ComboBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblGeneralData = new System.Windows.Forms.Label();
            this.lblDiaInicio = new System.Windows.Forms.Label();
            this.lblDiaFin = new System.Windows.Forms.Label();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(411, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(224, 27);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Reporte Ganancias";
            // 
            // dgvventas
            // 
            this.dgvventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column4,
            this.Descuento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvventas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvventas.EnableHeadersVisualStyles = false;
            this.dgvventas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvventas.Location = new System.Drawing.Point(62, 277);
            this.dgvventas.Name = "dgvventas";
            this.dgvventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvventas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvventas.Size = new System.Drawing.Size(1021, 428);
            this.dgvventas.TabIndex = 2;
            this.dgvventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvventas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "idReservación";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha y Hora";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Completo";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(58, 83);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(247, 21);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Seleccione tipo de reporte";
            // 
            // cboEleccion
            // 
            this.cboEleccion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEleccion.FormattingEnabled = true;
            this.cboEleccion.Items.AddRange(new object[] {
            "Reporte por Mes",
            "Reporte por Semana"});
            this.cboEleccion.Location = new System.Drawing.Point(312, 82);
            this.cboEleccion.Name = "cboEleccion";
            this.cboEleccion.Size = new System.Drawing.Size(176, 27);
            this.cboEleccion.TabIndex = 5;
            this.cboEleccion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(58, 126);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(170, 21);
            this.lblTexto.TabIndex = 6;
            this.lblTexto.Text = "Seleccione el mes";
            this.lblTexto.Visible = false;
            // 
            // cboMes
            // 
            this.cboMes.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cboMes.Location = new System.Drawing.Point(244, 125);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(121, 27);
            this.cboMes.TabIndex = 7;
            this.cboMes.Visible = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(547, 101);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(239, 73);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblGeneralData
            // 
            this.lblGeneralData.AutoSize = true;
            this.lblGeneralData.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralData.ForeColor = System.Drawing.Color.White;
            this.lblGeneralData.Location = new System.Drawing.Point(58, 253);
            this.lblGeneralData.Name = "lblGeneralData";
            this.lblGeneralData.Size = new System.Drawing.Size(187, 21);
            this.lblGeneralData.TabIndex = 9;
            this.lblGeneralData.Text = "DATOS GENERALES";
            // 
            // lblDiaInicio
            // 
            this.lblDiaInicio.AutoSize = true;
            this.lblDiaInicio.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaInicio.ForeColor = System.Drawing.Color.White;
            this.lblDiaInicio.Location = new System.Drawing.Point(58, 126);
            this.lblDiaInicio.Name = "lblDiaInicio";
            this.lblDiaInicio.Size = new System.Drawing.Size(123, 21);
            this.lblDiaInicio.TabIndex = 10;
            this.lblDiaInicio.Text = "Dia de Inicio";
            this.lblDiaInicio.Visible = false;
            // 
            // lblDiaFin
            // 
            this.lblDiaFin.AutoSize = true;
            this.lblDiaFin.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaFin.ForeColor = System.Drawing.Color.White;
            this.lblDiaFin.Location = new System.Drawing.Point(58, 161);
            this.lblDiaFin.Name = "lblDiaFin";
            this.lblDiaFin.Size = new System.Drawing.Size(88, 21);
            this.lblDiaFin.TabIndex = 11;
            this.lblDiaFin.Text = "Dia Final";
            this.lblDiaFin.Visible = false;
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.ForeColor = System.Drawing.Color.White;
            this.lblGanancia.Location = new System.Drawing.Point(543, 253);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(223, 21);
            this.lblGanancia.TabIndex = 15;
            this.lblGanancia.Text = "TOTAL DE GANANCIAS ";
            this.lblGanancia.Visible = false;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(187, 127);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(301, 25);
            this.dtpInicio.TabIndex = 16;
            this.dtpInicio.Visible = false;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(187, 158);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(301, 25);
            this.dtpFin.TabIndex = 17;
            this.dtpFin.Visible = false;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.Location = new System.Drawing.Point(844, 101);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(188, 73);
            this.btnPdf.TabIndex = 18;
            this.btnPdf.Text = "Generar PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Visible = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1156, 747);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblGanancia);
            this.Controls.Add(this.lblDiaFin);
            this.Controls.Add(this.lblDiaInicio);
            this.Controls.Add(this.lblGeneralData);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cboMes);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.cboEleccion);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvventas);
            this.Name = "frmReporteVentas";
            this.Text = "Reporte_Ventas";
            this.Load += new System.EventHandler(this.Reporte_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvventas;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboEleccion;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblGeneralData;
        private System.Windows.Forms.Label lblDiaInicio;
        private System.Windows.Forms.Label lblDiaFin;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.Button btnPdf;
    }
}