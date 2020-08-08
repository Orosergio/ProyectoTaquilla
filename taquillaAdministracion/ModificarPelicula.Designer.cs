namespace taquillaAdministracion
{
    partial class ModificarPelicula
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMultimedia = new System.Windows.Forms.TextBox();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboCodigoC = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblDescripion = new System.Windows.Forms.Label();
            this.lblMultimedia = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblEstreno = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboCodigoP = new System.Windows.Forms.ComboBox();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(8, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(173, 115);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(289, 157);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtMultimedia
            // 
            this.txtMultimedia.Location = new System.Drawing.Point(173, 289);
            this.txtMultimedia.Name = "txtMultimedia";
            this.txtMultimedia.Size = new System.Drawing.Size(289, 23);
            this.txtMultimedia.TabIndex = 4;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(173, 329);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(289, 24);
            this.cboClasificacion.TabIndex = 5;
            this.cboClasificacion.SelectedIndexChanged += new System.EventHandler(this.cboClasificacion_SelectedIndexChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(173, 412);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(289, 24);
            this.cboEstado.TabIndex = 7;
            // 
            // cboCodigoC
            // 
            this.cboCodigoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoC.FormattingEnabled = true;
            this.cboCodigoC.Location = new System.Drawing.Point(476, 329);
            this.cboCodigoC.Name = "cboCodigoC";
            this.cboCodigoC.Size = new System.Drawing.Size(66, 24);
            this.cboCodigoC.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(501, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(173, 371);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(289, 23);
            this.dtpFecha.TabIndex = 11;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(173, 457);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(286, 23);
            this.txtDuracion.TabIndex = 12;
            this.txtDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracion_KeyPress);
            // 
            // lblDescripion
            // 
            this.lblDescripion.AutoSize = true;
            this.lblDescripion.ForeColor = System.Drawing.Color.White;
            this.lblDescripion.Location = new System.Drawing.Point(8, 118);
            this.lblDescripion.Name = "lblDescripion";
            this.lblDescripion.Size = new System.Drawing.Size(85, 17);
            this.lblDescripion.TabIndex = 13;
            this.lblDescripion.Text = "Descripcion";
            // 
            // lblMultimedia
            // 
            this.lblMultimedia.AutoSize = true;
            this.lblMultimedia.ForeColor = System.Drawing.Color.White;
            this.lblMultimedia.Location = new System.Drawing.Point(8, 294);
            this.lblMultimedia.Name = "lblMultimedia";
            this.lblMultimedia.Size = new System.Drawing.Size(80, 17);
            this.lblMultimedia.TabIndex = 14;
            this.lblMultimedia.Text = "Multimedia";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.ForeColor = System.Drawing.Color.White;
            this.lblClasificacion.Location = new System.Drawing.Point(8, 336);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(89, 17);
            this.lblClasificacion.TabIndex = 15;
            this.lblClasificacion.Text = "Clasificacion";
            // 
            // lblEstreno
            // 
            this.lblEstreno.AutoSize = true;
            this.lblEstreno.ForeColor = System.Drawing.Color.White;
            this.lblEstreno.Location = new System.Drawing.Point(8, 376);
            this.lblEstreno.Name = "lblEstreno";
            this.lblEstreno.Size = new System.Drawing.Size(148, 17);
            this.lblEstreno.TabIndex = 17;
            this.lblEstreno.Text = "Estreno de la pelicula";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(14, 419);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(142, 17);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado de la pelicula";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.ForeColor = System.Drawing.Color.White;
            this.lblDuracion.Location = new System.Drawing.Point(8, 462);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(157, 17);
            this.lblDuracion.TabIndex = 19;
            this.lblDuracion.Text = "Duracion de la pelicula";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(501, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 62);
            this.button2.TabIndex = 20;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 503);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(647, 185);
            this.dataGridView1.TabIndex = 21;
            // 
            // cboCodigoP
            // 
            this.cboCodigoP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoP.FormattingEnabled = true;
            this.cboCodigoP.Location = new System.Drawing.Point(501, 38);
            this.cboCodigoP.Name = "cboCodigoP";
            this.cboCodigoP.Size = new System.Drawing.Size(149, 24);
            this.cboCodigoP.TabIndex = 2;
            this.cboCodigoP.SelectedIndexChanged += new System.EventHandler(this.cboCodigoP_SelectedIndexChanged);
            // 
            // cboPelicula
            // 
            this.cboPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(172, 37);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(290, 24);
            this.cboPelicula.TabIndex = 1;
            this.cboPelicula.SelectedIndexChanged += new System.EventHandler(this.cboPelicula_SelectedIndexChanged);
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.ForeColor = System.Drawing.Color.White;
            this.lblNuevo.Location = new System.Drawing.Point(8, 78);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(107, 17);
            this.lblNuevo.TabIndex = 23;
            this.lblNuevo.Text = "Nuevo Nombre";
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(172, 78);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(287, 23);
            this.txtNuevo.TabIndex = 24;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(195, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(172, 17);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Modificacion de peliculas";
            // 
            // ModificarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(759, 776);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblEstreno);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblMultimedia);
            this.Controls.Add(this.lblDescripion);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboCodigoC);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboClasificacion);
            this.Controls.Add(this.txtMultimedia);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cboCodigoP);
            this.Controls.Add(this.cboPelicula);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ModificarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarPelicula";
            this.Load += new System.EventHandler(this.ModificarPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMultimedia;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboCodigoC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblDescripion;
        private System.Windows.Forms.Label lblMultimedia;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblEstreno;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboCodigoP;
        private System.Windows.Forms.ComboBox cboPelicula;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.Label lblTitulo;
    }
}