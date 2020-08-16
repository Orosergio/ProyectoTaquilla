namespace AdministrativoReportes
{
    partial class frmModificarTelefono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarTelefono));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.dgtDatos = new System.Windows.Forms.DataGridView();
            this.lblEmpleadoA = new System.Windows.Forms.Label();
            this.lblEstatusA = new System.Windows.Forms.Label();
            this.lblTelefonoA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmpleadoN = new System.Windows.Forms.Label();
            this.lblEstatusN = new System.Windows.Forms.Label();
            this.lblTelefonoN = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblEs = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.txtTelefonoN = new System.Windows.Forms.TextBox();
            this.cboEmpleadoN = new System.Windows.Forms.ComboBox();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.cboCodigoE = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(123, 55);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(226, 30);
            this.txtTelefono.TabIndex = 72;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(383, 49);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 38);
            this.btnBuscar.TabIndex = 71;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(244, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(253, 23);
            this.lblTitulo.TabIndex = 70;
            this.lblTitulo.Text = "Modificacion de Telefono";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(31, 58);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(88, 21);
            this.lblTelefono.TabIndex = 69;
            this.lblTelefono.Text = "Telefono";
            // 
            // dgtDatos
            // 
            this.dgtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDatos.Location = new System.Drawing.Point(29, 105);
            this.dgtDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgtDatos.Name = "dgtDatos";
            this.dgtDatos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtDatos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgtDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgtDatos.RowTemplate.Height = 24;
            this.dgtDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtDatos.Size = new System.Drawing.Size(468, 184);
            this.dgtDatos.TabIndex = 73;
            this.dgtDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtDatos_CellContentClick);
            // 
            // lblEmpleadoA
            // 
            this.lblEmpleadoA.AutoSize = true;
            this.lblEmpleadoA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoA.ForeColor = System.Drawing.Color.White;
            this.lblEmpleadoA.Location = new System.Drawing.Point(24, 397);
            this.lblEmpleadoA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleadoA.Name = "lblEmpleadoA";
            this.lblEmpleadoA.Size = new System.Drawing.Size(100, 21);
            this.lblEmpleadoA.TabIndex = 76;
            this.lblEmpleadoA.Text = "Empleado";
            // 
            // lblEstatusA
            // 
            this.lblEstatusA.AutoSize = true;
            this.lblEstatusA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusA.ForeColor = System.Drawing.Color.White;
            this.lblEstatusA.Location = new System.Drawing.Point(24, 434);
            this.lblEstatusA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstatusA.Name = "lblEstatusA";
            this.lblEstatusA.Size = new System.Drawing.Size(73, 21);
            this.lblEstatusA.TabIndex = 75;
            this.lblEstatusA.Text = "Estatus";
            // 
            // lblTelefonoA
            // 
            this.lblTelefonoA.AutoSize = true;
            this.lblTelefonoA.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoA.ForeColor = System.Drawing.Color.White;
            this.lblTelefonoA.Location = new System.Drawing.Point(24, 367);
            this.lblTelefonoA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoA.Name = "lblTelefonoA";
            this.lblTelefonoA.Size = new System.Drawing.Size(88, 21);
            this.lblTelefonoA.TabIndex = 74;
            this.lblTelefonoA.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 77;
            this.label2.Text = "Datos anteriores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(446, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 81;
            this.label3.Text = "Datos Nuevos";
            // 
            // lblEmpleadoN
            // 
            this.lblEmpleadoN.AutoSize = true;
            this.lblEmpleadoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoN.ForeColor = System.Drawing.Color.White;
            this.lblEmpleadoN.Location = new System.Drawing.Point(332, 403);
            this.lblEmpleadoN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleadoN.Name = "lblEmpleadoN";
            this.lblEmpleadoN.Size = new System.Drawing.Size(100, 21);
            this.lblEmpleadoN.TabIndex = 80;
            this.lblEmpleadoN.Text = "Empleado";
            // 
            // lblEstatusN
            // 
            this.lblEstatusN.AutoSize = true;
            this.lblEstatusN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusN.ForeColor = System.Drawing.Color.White;
            this.lblEstatusN.Location = new System.Drawing.Point(332, 440);
            this.lblEstatusN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstatusN.Name = "lblEstatusN";
            this.lblEstatusN.Size = new System.Drawing.Size(73, 21);
            this.lblEstatusN.TabIndex = 79;
            this.lblEstatusN.Text = "Estatus";
            // 
            // lblTelefonoN
            // 
            this.lblTelefonoN.AutoSize = true;
            this.lblTelefonoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoN.ForeColor = System.Drawing.Color.White;
            this.lblTelefonoN.Location = new System.Drawing.Point(332, 373);
            this.lblTelefonoN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoN.Name = "lblTelefonoN";
            this.lblTelefonoN.Size = new System.Drawing.Size(88, 21);
            this.lblTelefonoN.TabIndex = 78;
            this.lblTelefonoN.Text = "Telefono";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.ForeColor = System.Drawing.Color.White;
            this.lblE.Location = new System.Drawing.Point(125, 399);
            this.lblE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(0, 21);
            this.lblE.TabIndex = 84;
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEs.ForeColor = System.Drawing.Color.White;
            this.lblEs.Location = new System.Drawing.Point(125, 436);
            this.lblEs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(0, 21);
            this.lblEs.TabIndex = 83;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.ForeColor = System.Drawing.Color.White;
            this.lblT.Location = new System.Drawing.Point(125, 369);
            this.lblT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(0, 21);
            this.lblT.TabIndex = 82;
            // 
            // txtTelefonoN
            // 
            this.txtTelefonoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoN.Location = new System.Drawing.Point(426, 366);
            this.txtTelefonoN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefonoN.Name = "txtTelefonoN";
            this.txtTelefonoN.Size = new System.Drawing.Size(226, 30);
            this.txtTelefonoN.TabIndex = 85;
            // 
            // cboEmpleadoN
            // 
            this.cboEmpleadoN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleadoN.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpleadoN.FormattingEnabled = true;
            this.cboEmpleadoN.Location = new System.Drawing.Point(426, 405);
            this.cboEmpleadoN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEmpleadoN.Name = "cboEmpleadoN";
            this.cboEmpleadoN.Size = new System.Drawing.Size(226, 29);
            this.cboEmpleadoN.TabIndex = 86;
            this.cboEmpleadoN.SelectedIndexChanged += new System.EventHandler(this.cboEmpleadoN_SelectedIndexChanged);
            // 
            // cboEstatus
            // 
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstatus.Location = new System.Drawing.Point(426, 438);
            this.cboEstatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(226, 29);
            this.cboEstatus.TabIndex = 87;
            // 
            // cboCodigoE
            // 
            this.cboCodigoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoE.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoE.FormattingEnabled = true;
            this.cboCodigoE.Location = new System.Drawing.Point(656, 405);
            this.cboCodigoE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCodigoE.Name = "cboCodigoE";
            this.cboCodigoE.Size = new System.Drawing.Size(51, 29);
            this.cboCodigoE.TabIndex = 88;
            this.cboCodigoE.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(450, 512);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(170, 38);
            this.btnModificar.TabIndex = 89;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(518, 220);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 21);
            this.txtCodigo.TabIndex = 90;
            this.txtCodigo.Text = "Codigo";
            this.txtCodigo.Visible = false;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(607, 220);
            this.lblC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(0, 21);
            this.lblC.TabIndex = 91;
            this.lblC.Visible = false;
            // 
            // frmModificarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(735, 595);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cboCodigoE);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.cboEmpleadoN);
            this.Controls.Add(this.txtTelefonoN);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblEs);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmpleadoN);
            this.Controls.Add(this.lblEstatusN);
            this.Controls.Add(this.lblTelefonoN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmpleadoA);
            this.Controls.Add(this.lblEstatusA);
            this.Controls.Add(this.lblTelefonoA);
            this.Controls.Add(this.dgtDatos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTelefono);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmModificarTelefono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarTelefono";
            this.Load += new System.EventHandler(this.frmModificarTelefono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.DataGridView dgtDatos;
        private System.Windows.Forms.Label lblEmpleadoA;
        private System.Windows.Forms.Label lblEstatusA;
        private System.Windows.Forms.Label lblTelefonoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmpleadoN;
        private System.Windows.Forms.Label lblEstatusN;
        private System.Windows.Forms.Label lblTelefonoN;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblEs;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.TextBox txtTelefonoN;
        private System.Windows.Forms.ComboBox cboEmpleadoN;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.ComboBox cboCodigoE;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Label lblC;
    }
}