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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPelicula));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMultimedia = new System.Windows.Forms.TextBox();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboCodigoC = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblDescripion = new System.Windows.Forms.Label();
            this.lblMultimedia = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblEstreno = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.dgtDatos = new System.Windows.Forms.DataGridView();
            this.cboCodigoP = new System.Windows.Forms.ComboBox();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(8, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(250, 117);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(289, 157);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtMultimedia
            // 
            this.txtMultimedia.Location = new System.Drawing.Point(250, 291);
            this.txtMultimedia.Name = "txtMultimedia";
            this.txtMultimedia.Size = new System.Drawing.Size(289, 23);
            this.txtMultimedia.TabIndex = 4;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(250, 331);
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
            this.cboEstado.Location = new System.Drawing.Point(250, 414);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(289, 24);
            this.cboEstado.TabIndex = 7;
            // 
            // cboCodigoC
            // 
            this.cboCodigoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoC.FormattingEnabled = true;
            this.cboCodigoC.Location = new System.Drawing.Point(816, 331);
            this.cboCodigoC.Name = "cboCodigoC";
            this.cboCodigoC.Size = new System.Drawing.Size(60, 24);
            this.cboCodigoC.TabIndex = 8;
            this.cboCodigoC.Visible = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(250, 373);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(289, 23);
            this.dtpFecha.TabIndex = 11;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(250, 459);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(286, 23);
            this.txtDuracion.TabIndex = 12;
            this.txtDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracion_KeyPress);
            // 
            // lblDescripion
            // 
            this.lblDescripion.AutoSize = true;
            this.lblDescripion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripion.ForeColor = System.Drawing.Color.White;
            this.lblDescripion.Location = new System.Drawing.Point(8, 118);
            this.lblDescripion.Name = "lblDescripion";
            this.lblDescripion.Size = new System.Drawing.Size(120, 22);
            this.lblDescripion.TabIndex = 13;
            this.lblDescripion.Text = "Descripcion";
            // 
            // lblMultimedia
            // 
            this.lblMultimedia.AutoSize = true;
            this.lblMultimedia.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultimedia.ForeColor = System.Drawing.Color.White;
            this.lblMultimedia.Location = new System.Drawing.Point(12, 289);
            this.lblMultimedia.Name = "lblMultimedia";
            this.lblMultimedia.Size = new System.Drawing.Size(115, 22);
            this.lblMultimedia.TabIndex = 14;
            this.lblMultimedia.Text = "Multimedia";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion.ForeColor = System.Drawing.Color.White;
            this.lblClasificacion.Location = new System.Drawing.Point(14, 333);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(128, 22);
            this.lblClasificacion.TabIndex = 15;
            this.lblClasificacion.Text = "Clasificacion";
            // 
            // lblEstreno
            // 
            this.lblEstreno.AutoSize = true;
            this.lblEstreno.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstreno.ForeColor = System.Drawing.Color.White;
            this.lblEstreno.Location = new System.Drawing.Point(14, 373);
            this.lblEstreno.Name = "lblEstreno";
            this.lblEstreno.Size = new System.Drawing.Size(209, 22);
            this.lblEstreno.TabIndex = 17;
            this.lblEstreno.Text = "Estreno de la pelicula";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(14, 416);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(203, 22);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado de la pelicula";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.ForeColor = System.Drawing.Color.White;
            this.lblDuracion.Location = new System.Drawing.Point(12, 460);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(223, 22);
            this.lblDuracion.TabIndex = 19;
            this.lblDuracion.Text = "Duracion de la pelicula";
            // 
            // dgtDatos
            // 
            this.dgtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDatos.Location = new System.Drawing.Point(11, 503);
            this.dgtDatos.Name = "dgtDatos";
            this.dgtDatos.ReadOnly = true;
            this.dgtDatos.RowHeadersWidth = 51;
            this.dgtDatos.RowTemplate.Height = 24;
            this.dgtDatos.Size = new System.Drawing.Size(733, 185);
            this.dgtDatos.TabIndex = 21;
            // 
            // cboCodigoP
            // 
            this.cboCodigoP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoP.FormattingEnabled = true;
            this.cboCodigoP.Location = new System.Drawing.Point(816, 39);
            this.cboCodigoP.Name = "cboCodigoP";
            this.cboCodigoP.Size = new System.Drawing.Size(60, 24);
            this.cboCodigoP.TabIndex = 2;
            this.cboCodigoP.Visible = false;
            this.cboCodigoP.SelectedIndexChanged += new System.EventHandler(this.cboCodigoP_SelectedIndexChanged);
            // 
            // cboPelicula
            // 
            this.cboPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(249, 39);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(290, 24);
            this.cboPelicula.TabIndex = 1;
            this.cboPelicula.SelectedIndexChanged += new System.EventHandler(this.cboPelicula_SelectedIndexChanged);
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevo.ForeColor = System.Drawing.Color.White;
            this.lblNuevo.Location = new System.Drawing.Point(8, 78);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(147, 22);
            this.lblNuevo.TabIndex = 23;
            this.lblNuevo.Text = "Nuevo Nombre";
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(249, 80);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(287, 23);
            this.txtNuevo.TabIndex = 24;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(246, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 22);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Modificacion de peliculas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(763, 503);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(165, 61);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(763, 584);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 62);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(569, 39);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(228, 237);
            this.pbImagen.TabIndex = 28;
            this.pbImagen.TabStop = false;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(569, 333);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(241, 23);
            this.txtLink.TabIndex = 30;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.ForeColor = System.Drawing.Color.White;
            this.lblLink.Location = new System.Drawing.Point(597, 291);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(173, 22);
            this.lblLink.TabIndex = 31;
            this.lblLink.Text = "Link de la imagen";
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImagen.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.ForeColor = System.Drawing.Color.White;
            this.btnImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnImagen.Image")));
            this.btnImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImagen.Location = new System.Drawing.Point(569, 377);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(241, 61);
            this.btnImagen.TabIndex = 32;
            this.btnImagen.Text = "Ver imagen";
            this.btnImagen.UseVisualStyleBackColor = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // ModificarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(940, 705);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.dgtDatos);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblEstreno);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblMultimedia);
            this.Controls.Add(this.lblDescripion);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.dtpFecha);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblDescripion;
        private System.Windows.Forms.Label lblMultimedia;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblEstreno;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.DataGridView dgtDatos;
        private System.Windows.Forms.ComboBox cboCodigoP;
        private System.Windows.Forms.ComboBox cboPelicula;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Button btnImagen;
    }
}