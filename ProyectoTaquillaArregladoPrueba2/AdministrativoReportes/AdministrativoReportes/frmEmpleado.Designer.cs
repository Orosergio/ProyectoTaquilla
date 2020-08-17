namespace AdministrativoReportes
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblContratacion = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.dtpContratacion = new System.Windows.Forms.DateTimePicker();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cboCodigoPuesto = new System.Windows.Forms.ComboBox();
            this.btnTelefono = new System.Windows.Forms.Button();
            this.btnCorreo = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnPuesto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(779, 142);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(365, 49);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(779, 84);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(365, 49);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cboEstatus
            // 
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstatus.Location = new System.Drawing.Point(296, 357);
            this.cboEstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(263, 35);
            this.cboEstatus.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(296, 86);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(388, 35);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(779, 25);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(365, 49);
            this.btnIngresar.TabIndex = 25;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(144, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 31);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Ingreso de Empleado";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(47, 361);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(90, 27);
            this.lblEstatus.TabIndex = 23;
            this.lblEstatus.Text = "Estatus";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(45, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 27);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(297, 133);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(388, 35);
            this.txtApellido.TabIndex = 34;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(47, 135);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(108, 27);
            this.lblApellido.TabIndex = 33;
            this.lblApellido.Text = "Apellido";
            // 
            // cboPuesto
            // 
            this.cboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuesto.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Location = new System.Drawing.Point(296, 180);
            this.cboPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(319, 35);
            this.cboPuesto.TabIndex = 36;
            this.cboPuesto.SelectedIndexChanged += new System.EventHandler(this.cboPuesto_SelectedIndexChanged);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(45, 182);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(86, 27);
            this.lblPuesto.TabIndex = 35;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblContratacion
            // 
            this.lblContratacion.AutoSize = true;
            this.lblContratacion.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratacion.ForeColor = System.Drawing.Color.White;
            this.lblContratacion.Location = new System.Drawing.Point(45, 236);
            this.lblContratacion.Name = "lblContratacion";
            this.lblContratacion.Size = new System.Drawing.Size(224, 27);
            this.lblContratacion.TabIndex = 37;
            this.lblContratacion.Text = "Fecha contratacion";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblNacimiento.Location = new System.Drawing.Point(45, 298);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(209, 27);
            this.lblNacimiento.TabIndex = 38;
            this.lblNacimiento.Text = "Fecha nacimiento";
            // 
            // dtpContratacion
            // 
            this.dtpContratacion.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpContratacion.Location = new System.Drawing.Point(296, 236);
            this.dtpContratacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpContratacion.Name = "dtpContratacion";
            this.dtpContratacion.Size = new System.Drawing.Size(340, 35);
            this.dtpContratacion.TabIndex = 39;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Location = new System.Drawing.Point(296, 289);
            this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(340, 35);
            this.dtpNacimiento.TabIndex = 40;
            // 
            // cboCodigoPuesto
            // 
            this.cboCodigoPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoPuesto.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoPuesto.FormattingEnabled = true;
            this.cboCodigoPuesto.Location = new System.Drawing.Point(620, 179);
            this.cboCodigoPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCodigoPuesto.Name = "cboCodigoPuesto";
            this.cboCodigoPuesto.Size = new System.Drawing.Size(64, 35);
            this.cboCodigoPuesto.TabIndex = 41;
            this.cboCodigoPuesto.Visible = false;
            // 
            // btnTelefono
            // 
            this.btnTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelefono.FlatAppearance.BorderSize = 0;
            this.btnTelefono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelefono.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelefono.ForeColor = System.Drawing.Color.White;
            this.btnTelefono.Image = ((System.Drawing.Image)(resources.GetObject("btnTelefono.Image")));
            this.btnTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelefono.Location = new System.Drawing.Point(779, 258);
            this.btnTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(365, 49);
            this.btnTelefono.TabIndex = 46;
            this.btnTelefono.Text = "Agregar Telefono";
            this.btnTelefono.UseVisualStyleBackColor = false;
            this.btnTelefono.Click += new System.EventHandler(this.btnTelefono_Click);
            // 
            // btnCorreo
            // 
            this.btnCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorreo.FlatAppearance.BorderSize = 0;
            this.btnCorreo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorreo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorreo.ForeColor = System.Drawing.Color.White;
            this.btnCorreo.Image = ((System.Drawing.Image)(resources.GetObject("btnCorreo.Image")));
            this.btnCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorreo.Location = new System.Drawing.Point(779, 199);
            this.btnCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(365, 49);
            this.btnCorreo.TabIndex = 45;
            this.btnCorreo.Text = "Agregar Correo";
            this.btnCorreo.UseVisualStyleBackColor = false;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(779, 325);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(365, 49);
            this.btnEmpleado.TabIndex = 44;
            this.btnEmpleado.Text = "Ver Empleados";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnPuesto
            // 
            this.btnPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnPuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPuesto.FlatAppearance.BorderSize = 0;
            this.btnPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(251)))), ((int)(((byte)(25)))));
            this.btnPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuesto.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuesto.ForeColor = System.Drawing.Color.White;
            this.btnPuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnPuesto.Image")));
            this.btnPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuesto.Location = new System.Drawing.Point(779, 391);
            this.btnPuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPuesto.Name = "btnPuesto";
            this.btnPuesto.Size = new System.Drawing.Size(365, 49);
            this.btnPuesto.TabIndex = 47;
            this.btnPuesto.Text = "Puesto";
            this.btnPuesto.UseVisualStyleBackColor = false;
            this.btnPuesto.Click += new System.EventHandler(this.btnPuesto_Click);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1175, 475);
            this.Controls.Add(this.btnPuesto);
            this.Controls.Add(this.btnTelefono);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.cboCodigoPuesto);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.dtpContratacion);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblContratacion);
            this.Controls.Add(this.cboPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblContratacion;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.DateTimePicker dtpContratacion;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.ComboBox cboCodigoPuesto;
        private System.Windows.Forms.Button btnTelefono;
        private System.Windows.Forms.Button btnCorreo;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnPuesto;
    }
}