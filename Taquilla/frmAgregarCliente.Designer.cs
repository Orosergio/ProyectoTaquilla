namespace Taquilla
{
    partial class frmAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCliente));
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.picAyuda = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlDatosDetalles = new System.Windows.Forms.Panel();
            this.lblCantTiempoRestante = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblTiempoRestante = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.picTarjeta = new System.Windows.Forms.PictureBox();
            this.lblTarjetaOriginada = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNoTarjeta = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlDatosDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.pnlBarraSuperior.Controls.Add(this.picAyuda);
            this.pnlBarraSuperior.Controls.Add(this.btnMin);
            this.pnlBarraSuperior.Controls.Add(this.btnCerrar);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(635, 41);
            this.pnlBarraSuperior.TabIndex = 1;
            // 
            // picAyuda
            // 
            this.picAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAyuda.Image = global::Taquilla.Properties.Resources.pregunta;
            this.picAyuda.Location = new System.Drawing.Point(12, 6);
            this.picAyuda.Name = "picAyuda";
            this.picAyuda.Size = new System.Drawing.Size(32, 32);
            this.picAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAyuda.TabIndex = 124;
            this.picAyuda.TabStop = false;
            this.picAyuda.Click += new System.EventHandler(this.picAyuda_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(557, 6);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(32, 32);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 6;
            this.btnMin.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(595, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            // 
            // pnlDatosDetalles
            // 
            this.pnlDatosDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnlDatosDetalles.Controls.Add(this.lblCantTiempoRestante);
            this.pnlDatosDetalles.Controls.Add(this.btnPagar);
            this.pnlDatosDetalles.Controls.Add(this.lblTiempoRestante);
            this.pnlDatosDetalles.Controls.Add(this.btnAtras);
            this.pnlDatosDetalles.Controls.Add(this.picTarjeta);
            this.pnlDatosDetalles.Controls.Add(this.lblTarjetaOriginada);
            this.pnlDatosDetalles.Controls.Add(this.txtCorreo);
            this.pnlDatosDetalles.Controls.Add(this.txtApellido);
            this.pnlDatosDetalles.Controls.Add(this.txtNombre);
            this.pnlDatosDetalles.Controls.Add(this.lblCorreo);
            this.pnlDatosDetalles.Controls.Add(this.txtNit);
            this.pnlDatosDetalles.Controls.Add(this.lblApellido);
            this.pnlDatosDetalles.Controls.Add(this.lblDatosCliente);
            this.pnlDatosDetalles.Controls.Add(this.lblNombre);
            this.pnlDatosDetalles.Controls.Add(this.lblNoTarjeta);
            this.pnlDatosDetalles.Controls.Add(this.lblNit);
            this.pnlDatosDetalles.Location = new System.Drawing.Point(27, 82);
            this.pnlDatosDetalles.Name = "pnlDatosDetalles";
            this.pnlDatosDetalles.Size = new System.Drawing.Size(578, 398);
            this.pnlDatosDetalles.TabIndex = 27;
            // 
            // lblCantTiempoRestante
            // 
            this.lblCantTiempoRestante.AutoSize = true;
            this.lblCantTiempoRestante.BackColor = System.Drawing.Color.Transparent;
            this.lblCantTiempoRestante.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTiempoRestante.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantTiempoRestante.Location = new System.Drawing.Point(260, 288);
            this.lblCantTiempoRestante.Name = "lblCantTiempoRestante";
            this.lblCantTiempoRestante.Size = new System.Drawing.Size(0, 21);
            this.lblCantTiempoRestante.TabIndex = 64;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPagar.Location = new System.Drawing.Point(286, 331);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(121, 39);
            this.btnPagar.TabIndex = 127;
            this.btnPagar.Text = "AGREGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblTiempoRestante
            // 
            this.lblTiempoRestante.AutoSize = true;
            this.lblTiempoRestante.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempoRestante.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRestante.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTiempoRestante.Location = new System.Drawing.Point(17, 288);
            this.lblTiempoRestante.Name = "lblTiempoRestante";
            this.lblTiempoRestante.Size = new System.Drawing.Size(243, 21);
            this.lblTiempoRestante.TabIndex = 63;
            this.lblTiempoRestante.Text = "TIEMPO RESTANTE (seg): ";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAtras.Location = new System.Drawing.Point(167, 331);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(98, 39);
            this.btnAtras.TabIndex = 126;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // picTarjeta
            // 
            this.picTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTarjeta.Image = global::Taquilla.Properties.Resources.tarjeta;
            this.picTarjeta.Location = new System.Drawing.Point(524, 193);
            this.picTarjeta.Name = "picTarjeta";
            this.picTarjeta.Size = new System.Drawing.Size(32, 32);
            this.picTarjeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTarjeta.TabIndex = 125;
            this.picTarjeta.TabStop = false;
            this.picTarjeta.Click += new System.EventHandler(this.picTarjeta_Click);
            // 
            // lblTarjetaOriginada
            // 
            this.lblTarjetaOriginada.AutoSize = true;
            this.lblTarjetaOriginada.BackColor = System.Drawing.Color.Transparent;
            this.lblTarjetaOriginada.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjetaOriginada.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTarjetaOriginada.Location = new System.Drawing.Point(180, 250);
            this.lblTarjetaOriginada.Name = "lblTarjetaOriginada";
            this.lblTarjetaOriginada.Size = new System.Drawing.Size(0, 21);
            this.lblTarjetaOriginada.TabIndex = 56;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(184, 195);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(323, 30);
            this.txtCorreo.TabIndex = 55;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(184, 153);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(323, 30);
            this.txtApellido.TabIndex = 54;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(184, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(323, 30);
            this.txtNombre.TabIndex = 53;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCorreo.Location = new System.Drawing.Point(17, 204);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(94, 21);
            this.lblCorreo.TabIndex = 52;
            this.lblCorreo.Text = "CORREO:";
            // 
            // txtNit
            // 
            this.txtNit.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNit.Location = new System.Drawing.Point(184, 69);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(223, 30);
            this.txtNit.TabIndex = 33;
            this.txtNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellido.Location = new System.Drawing.Point(17, 162);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(107, 21);
            this.lblApellido.TabIndex = 31;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosCliente.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDatosCliente.Location = new System.Drawing.Point(47, 22);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(237, 27);
            this.lblDatosCliente.TabIndex = 30;
            this.lblDatosCliente.Text = "DATOS DE CLIENTE";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(17, 122);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 21);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblNoTarjeta
            // 
            this.lblNoTarjeta.AutoSize = true;
            this.lblNoTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblNoTarjeta.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTarjeta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNoTarjeta.Location = new System.Drawing.Point(17, 250);
            this.lblNoTarjeta.Name = "lblNoTarjeta";
            this.lblNoTarjeta.Size = new System.Drawing.Size(133, 21);
            this.lblNoTarjeta.TabIndex = 26;
            this.lblNoTarjeta.Text = "NO. TARJETA:";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.BackColor = System.Drawing.Color.Transparent;
            this.lblNit.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNit.Location = new System.Drawing.Point(17, 78);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(47, 21);
            this.lblNit.TabIndex = 25;
            this.lblNit.Text = "NIT:";
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Interval = 1000;
            this.tmrTiempo.Tick += new System.EventHandler(this.tmrTiempo_Tick);
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(635, 504);
            this.Controls.Add(this.pnlDatosDetalles);
            this.Controls.Add(this.pnlBarraSuperior);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarCliente";
            this.Load += new System.EventHandler(this.frmAgregarCliente_Load);
            this.pnlBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlDatosDetalles.ResumeLayout(false);
            this.pnlDatosDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTarjeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.PictureBox picAyuda;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlDatosDetalles;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNoTarjeta;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.PictureBox picTarjeta;
        private System.Windows.Forms.Label lblTarjetaOriginada;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnAtras;
        public System.Windows.Forms.Label lblCantTiempoRestante;
        private System.Windows.Forms.Label lblTiempoRestante;
        private System.Windows.Forms.Timer tmrTiempo;
    }
}