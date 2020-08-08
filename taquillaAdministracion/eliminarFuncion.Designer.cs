namespace taquillaAdministracion
{
    partial class eliminarFuncion
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgtDatos = new System.Windows.Forms.DataGridView();
            this.cboCodigoPro = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(72, 385);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(233, 86);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgtDatos
            // 
            this.dgtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDatos.Location = new System.Drawing.Point(72, 210);
            this.dgtDatos.Name = "dgtDatos";
            this.dgtDatos.RowHeadersWidth = 51;
            this.dgtDatos.RowTemplate.Height = 24;
            this.dgtDatos.Size = new System.Drawing.Size(660, 150);
            this.dgtDatos.TabIndex = 1;
            // 
            // cboCodigoPro
            // 
            this.cboCodigoPro.FormattingEnabled = true;
            this.cboCodigoPro.Location = new System.Drawing.Point(237, 55);
            this.cboCodigoPro.Name = "cboCodigoPro";
            this.cboCodigoPro.Size = new System.Drawing.Size(151, 24);
            this.cboCodigoPro.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(454, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(69, 58);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(126, 17);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo Proyeccion";
            // 
            // eliminarFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 553);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cboCodigoPro);
            this.Controls.Add(this.dgtDatos);
            this.Controls.Add(this.btnEliminar);
            this.Name = "eliminarFuncion";
            this.Text = "eliminarFuncion";
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgtDatos;
        private System.Windows.Forms.ComboBox cboCodigoPro;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblCodigo;
    }
}