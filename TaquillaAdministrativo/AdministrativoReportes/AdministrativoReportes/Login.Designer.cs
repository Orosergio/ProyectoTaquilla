namespace FinalProyecto
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.lcon = new System.Windows.Forms.Label();
            this.lus = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnminimize = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btning = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(111)))));
            this.lbl.Location = new System.Drawing.Point(429, 230);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(52, 19);
            this.lbl.TabIndex = 44;
            this.lbl.Text = "label3";
            this.lbl.Visible = false;
            // 
            // lcon
            // 
            this.lcon.AutoSize = true;
            this.lcon.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(111)))));
            this.lcon.Location = new System.Drawing.Point(330, 183);
            this.lcon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lcon.Name = "lcon";
            this.lcon.Size = new System.Drawing.Size(52, 19);
            this.lcon.TabIndex = 43;
            this.lcon.Text = "label3";
            this.lcon.Visible = false;
            // 
            // lus
            // 
            this.lus.AutoSize = true;
            this.lus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(111)))));
            this.lus.Location = new System.Drawing.Point(330, 96);
            this.lus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lus.Name = "lus";
            this.lus.Size = new System.Drawing.Size(52, 19);
            this.lus.TabIndex = 42;
            this.lus.Text = "label3";
            this.lus.Visible = false;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.Black;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtuser.Location = new System.Drawing.Point(332, 71);
            this.txtuser.Margin = new System.Windows.Forms.Padding(2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(243, 24);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "USUARIO";
            this.txtuser.Enter += new System.EventHandler(this.Txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.Txtuser_Leave);
            // 
            // btnminimize
            // 
            this.btnminimize.Image = ((System.Drawing.Image)(resources.GetObject("btnminimize.Image")));
            this.btnminimize.Location = new System.Drawing.Point(703, 3);
            this.btnminimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(30, 28);
            this.btnminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimize.TabIndex = 40;
            this.btnminimize.TabStop = false;
            this.btnminimize.Click += new System.EventHandler(this.Btnminimize_Click);
            // 
            // btnclose
            // 
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(737, 2);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 29);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 39;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(475, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 33);
            this.label5.TabIndex = 38;
            this.label5.Text = "LOGIN";
            // 
            // btning
            // 
            this.btning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btning.FlatAppearance.BorderSize = 0;
            this.btning.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btning.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btning.ForeColor = System.Drawing.Color.LightGray;
            this.btning.Location = new System.Drawing.Point(391, 250);
            this.btning.Margin = new System.Windows.Forms.Padding(2);
            this.btning.Name = "btning";
            this.btning.Size = new System.Drawing.Size(288, 39);
            this.btning.TabIndex = 3;
            this.btning.Text = "ACCEDER";
            this.btning.UseVisualStyleBackColor = false;
            this.btning.Click += new System.EventHandler(this.Btning_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Black;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtpassword.Location = new System.Drawing.Point(332, 155);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(243, 24);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Text = "CONTRASEÑA";
            this.txtpassword.Enter += new System.EventHandler(this.Txtpassword_Enter);
            this.txtpassword.Leave += new System.EventHandler(this.Txtpassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(329, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "__________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(329, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "__________________________________________";
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.linkpass.AutoSize = true;
            this.linkpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.LinkColor = System.Drawing.Color.DimGray;
            this.linkpass.Location = new System.Drawing.Point(430, 304);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(204, 17);
            this.linkpass.TabIndex = 0;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "¿Has olvidado tu contraseña?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lcon);
            this.Controls.Add(this.lus);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btning);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lcon;
        private System.Windows.Forms.Label lus;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.PictureBox btnminimize;
        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btning;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkpass;
    }
}