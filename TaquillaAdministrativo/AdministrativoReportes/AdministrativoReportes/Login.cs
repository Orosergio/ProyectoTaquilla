using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace FinalProyecto
{
    public partial class Login : Form
    {
        int codigo, codigo2;
       /* MySqlCommand Query = new MySqlCommand();
        MySqlCommand Query2 = new MySqlCommand();
        MySqlConnection Conexion;
        MySqlDataReader consultar, consultar2;
        public string sql = "datasource=127.0.0.1;port=3306;username=root;password=;database=SUPERMERCADO";*/
        public Login()
        {
            InitializeComponent();
          
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        int iCodigo = 0;
      
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text=="USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;

            }
        }

        private void Txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text=="")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void Txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "CONTRASEÑA")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.LightGray;
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void Txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "CONTRASEÑA";
                txtpassword.ForeColor = Color.DimGray;
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void Btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btning_Click(object sender, EventArgs e)
        {
            int error = 1;
            int ver = 1;
            if (txtuser.Text== "USUARIO" || txtuser.Text == "")
            {
                error = 0;
                lus.Text = "Ingrese su usuario";
                lus.Visible = true;
            }
            else
            {
                lus.Visible = false;
            }
            if (txtpassword.Text== "CONTRASEÑA" || txtpassword.Text == "")
            {
                error = 0;
                lcon.Text = "Ingrese su contraseña ";
                lcon.Visible = true;
            }
            else
            {
                lcon.Visible = false;
            }
            if (error != 0)
            {
            /*    try
                {
                    Conexion = new MySqlConnection();
                    Conexion.ConnectionString = sql;
                    Conexion.Open();
                    Query.CommandText = "SELECT * FROM USUARIOS";
                    Query.Connection = Conexion;
                    consultar = Query.ExecuteReader();
                    while (consultar.Read())
                    {
                        if (txtuser.Text==(Convert.ToString(consultar[1])) && txtpassword.Text == (Convert.ToString(consultar[2])))
                        {
                            ver = 3;                            
                            FormPrincipal frm = new FormPrincipal();
                            frm.Show();
                            this.Hide();
                        }

                    }
                    Conexion.Close();

                }
                catch (MySqlException er)
                {
                    MessageBox.Show(er.Message);
                }
            */
               }
            if (ver == 3)
            {
                lbl.Visible = false;
                txtpassword.Text = "";
                txtuser.Text = "";
            }
            else
            {
                lbl.Text = "Usuario/Contraseña son incorrectas";
					lbl.Visible = true;
            }







        }
    }
}
