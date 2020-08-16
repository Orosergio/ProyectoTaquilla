namespace Taquilla
{
    partial class frmPagoTarjeta
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
            this.lblCantTiempoRestante = new System.Windows.Forms.Label();
            this.lblTiempoRestante = new System.Windows.Forms.Label();
            this.pnlDatosTarjeta = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.pnlDatosTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCantTiempoRestante
            // 
            this.lblCantTiempoRestante.AutoSize = true;
            this.lblCantTiempoRestante.BackColor = System.Drawing.Color.Transparent;
            this.lblCantTiempoRestante.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTiempoRestante.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantTiempoRestante.Location = new System.Drawing.Point(460, 386);
            this.lblCantTiempoRestante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantTiempoRestante.Name = "lblCantTiempoRestante";
            this.lblCantTiempoRestante.Size = new System.Drawing.Size(0, 27);
            this.lblCantTiempoRestante.TabIndex = 64;
            // 
            // lblTiempoRestante
            // 
            this.lblTiempoRestante.AutoSize = true;
            this.lblTiempoRestante.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempoRestante.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRestante.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTiempoRestante.Location = new System.Drawing.Point(128, 386);
            this.lblTiempoRestante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoRestante.Name = "lblTiempoRestante";
            this.lblTiempoRestante.Size = new System.Drawing.Size(305, 27);
            this.lblTiempoRestante.TabIndex = 63;
            this.lblTiempoRestante.Text = "TIEMPO RESTANTE (seg): ";
            // 
            // pnlDatosTarjeta
            // 
            this.pnlDatosTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnlDatosTarjeta.Controls.Add(this.btnConfirmar);
            this.pnlDatosTarjeta.Controls.Add(this.txtNumero);
            this.pnlDatosTarjeta.Controls.Add(this.lblNumero);
            this.pnlDatosTarjeta.Controls.Add(this.lblCVV);
            this.pnlDatosTarjeta.Controls.Add(this.txtCVV);
            this.pnlDatosTarjeta.Controls.Add(this.cboAño);
            this.pnlDatosTarjeta.Controls.Add(this.cboMes);
            this.pnlDatosTarjeta.Controls.Add(this.lblFechaVencimiento);
            this.pnlDatosTarjeta.Controls.Add(this.lblDatos);
            this.pnlDatosTarjeta.Controls.Add(this.txtNombre);
            this.pnlDatosTarjeta.Controls.Add(this.lblNombre);
            this.pnlDatosTarjeta.Location = new System.Drawing.Point(16, 39);
            this.pnlDatosTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDatosTarjeta.Name = "pnlDatosTarjeta";
            this.pnlDatosTarjeta.Size = new System.Drawing.Size(769, 332);
            this.pnlDatosTarjeta.TabIndex = 65;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnConfirmar.Location = new System.Drawing.Point(504, 267);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(225, 48);
            this.btnConfirmar.TabIndex = 55;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(169, 135);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(559, 35);
            this.txtNumero.TabIndex = 54;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumero.Location = new System.Drawing.Point(33, 146);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(122, 27);
            this.lblNumero.TabIndex = 53;
            this.lblNumero.Text = "NÚMERO:";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.BackColor = System.Drawing.Color.Transparent;
            this.lblCVV.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVV.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCVV.Location = new System.Drawing.Point(33, 278);
            this.lblCVV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(71, 27);
            this.lblCVV.TabIndex = 52;
            this.lblCVV.Text = "CVV:";
            // 
            // txtCVV
            // 
            this.txtCVV.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVV.Location = new System.Drawing.Point(169, 274);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(132, 35);
            this.txtCVV.TabIndex = 51;
            this.txtCVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCVV_KeyPress);
            // 
            // cboAño
            // 
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(568, 202);
            this.cboAño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(160, 35);
            this.cboAño.TabIndex = 50;
            // 
            // cboMes
            // 
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(379, 202);
            this.cboMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(160, 35);
            this.cboMes.TabIndex = 49;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(33, 206);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(317, 27);
            this.lblFechaVencimiento.TabIndex = 48;
            this.lblFechaVencimiento.Text = "FECHA DE VENCIMIENTO: ";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDatos.Location = new System.Drawing.Point(220, 18);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(294, 35);
            this.lblDatos.TabIndex = 47;
            this.lblDatos.Text = "DATOS DE TARJETA";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(169, 74);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(559, 35);
            this.txtNombre.TabIndex = 46;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(33, 85);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 27);
            this.lblNombre.TabIndex = 45;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Interval = 1000;
            this.tmrTiempo.Tick += new System.EventHandler(this.tmrTiempo_Tick);
            // 
            // frmPagoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(820, 434);
            this.Controls.Add(this.pnlDatosTarjeta);
            this.Controls.Add(this.lblCantTiempoRestante);
            this.Controls.Add(this.lblTiempoRestante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPagoTarjeta";
            this.Opacity = 0.94D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPagoTarjeta";
            this.Load += new System.EventHandler(this.frmPagoTarjeta_Load);
            this.pnlDatosTarjeta.ResumeLayout(false);
            this.pnlDatosTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblCantTiempoRestante;
        private System.Windows.Forms.Label lblTiempoRestante;
        private System.Windows.Forms.Panel pnlDatosTarjeta;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Timer tmrTiempo;
    }
}