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
using System.Data.Odbc;
using System.Reflection;
using AdministrativoReportes;
using System.Net;
using System.Net.Sockets;
using iText.Layout.Element;

namespace FinalProyecto
{
    public partial class Login : Form
    {
        //Variable para controlar si ha olvidado la contraseña
        int olvidarPassword=0;
        clsConexion cn = new clsConexion();
        public Login()
        {
            InitializeComponent();
          
        }
        //Librerías para controlar el posicionamiento
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        
      
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Control del textBox
        private void Txtuser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text=="")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.White;
            }
        }

        private void Txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
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

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }
        //Esta funcion se realiza al olvidar las credenciales, activa una bandera
        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            olvidarPassword = 1;
            btnIngreso.Text = "Enviar Correo";
            lblOlvidar.Text = "";
            
            if (txtUser.Text != "")
            {
                lblUser.Visible = true;
                lblUser.Text = "INGRESE SU CORREO PARA RECIBIR CONTRASEÑA";
                txtUser.Text = "";
                txtPassword.Text = "";
                lblPassword.Text = "";
            }
            else
            {
              
            }               
        }

        

        private void Btning_Click(object sender, EventArgs e)
        {
            //Si la bandera de olvidar credenciales no se ha activado
            if (olvidarPassword==0)
            {
                //Verificacion del llenado de los textBox
                int error = 1;
                int ver = 1;
                if (txtUser.Text == "USUARIO" || txtUser.Text == "")
                {
                    error = 0;
                    lblUser.Text = "Ingrese su usuario";
                    lblUser.Visible = true;
                }else{
                    lblUser.Visible = false;
                }
                if (txtPassword.Text == "CONTRASEÑA" || txtPassword.Text == "")
                {
                    error = 0;
                    lblPassword.Text = "Ingrese su contraseña ";
                    lblPassword.Visible = true;
                }else{
                    lblPassword.Visible = false;
                }
                //Si los datos no son vacios en los textBox
                if (error != 0)
                {
                    //Realiza la consulta para verificar las credenciale y si son correctas se procede con el sistema
                    try
                    {
                        string cadena = "SELECT * FROM USUARIO";
                        OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                        OdbcDataReader reader = cma.ExecuteReader();
                        while (reader.Read())
                        {
                            if (txtUser.Text == (Convert.ToString(reader[4])) && txtPassword.Text == (Convert.ToString(reader[3])))
                            {
                                clsBitacora bitacora = new clsBitacora();
                                
                                bitacora.obtenerIdUsuario(reader[0].ToString());
                                string proceso = "LOGIN";
                                string tabla = "USUARIO";
                                bitacora.GuardarBitacora(proceso,tabla);
                                ver = 3;
                                FormPrincipal frm = new FormPrincipal();
                                frm.Show();
                                this.Hide();
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR AL OBTENER DATOS PARA INGRESO" + ex);
                    }
                }
                if (ver == 3)
                {
                    lblOlvidar.Visible = false;
                    txtPassword.Text = "";
                    txtUser.Text = "";
                }
                //Si se ha fallado en las credenciales
                else
                {
                    lblOlvidar.Text = "Usuario/Contraseña son incorrectas";
                    lblOlvidar.Visible = true;
                }


            }//Si la bandera de olvidar credenciales se ha activado
            else if (olvidarPassword==1){
                int controlEncuento = 0;
                
                //Realiza la consulta para verificar si el correo para restaurar credenciales es válido
                try
                {
                    string cadena = "SELECT * FROM CORREO";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {//Si el correo es válido
                        if (txtUser.Text == (Convert.ToString(reader[1])))
                        {
                            controlEncuento = 1;
                            MessageBox.Show("TU CONTRASEÑA HA SIDO ENVIADA");
                            //Se envian las credenciales al correo válido
                            
                            try
                            {
                                string correoCliente = txtUser.Text;
                                MessageBox.Show("correoCliente: " +correoCliente);
                                string cadenaCorreo = "SELECT U.nombreUsuario,U.contrasenia FROM USUARIO U, EMPLEADO E, CORREO C WHERE U.idEmpleado = E.idEmpleado AND E.idEmpleado = C.idEmpleado  AND C.correo = '"+txtUser.Text+"'; ";
                                OdbcCommand cmaCorreo = new OdbcCommand(cadenaCorreo, cn.nuevaConexion());
                                OdbcDataReader readerCorreo = cmaCorreo.ExecuteReader();
                                while (readerCorreo.Read())
                                {
                                    System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                                    msg.To.Add(txtUser.Text);
                                    msg.Subject = "CREDENCIALES ZINEPPOLIS";
                                    msg.SubjectEncoding = System.Text.Encoding.UTF8;
                                    msg.Bcc.Add("yavhe._.orozco@hotmail.es"); //copia del correo
                                    msg.Body = "Ha recibido este correo para restaurar credenciales  <br/> USUARIO: " + (readerCorreo.GetString(0)) + " <br/> CONTRASEÑA: "
                                        + readerCorreo.GetString(1) + ". <br/> Sea cuidadoso con sus credenciales";
                                    msg.BodyEncoding = System.Text.Encoding.UTF8;
                                    msg.IsBodyHtml = true;
                                    msg.From = new System.Net.Mail.MailAddress("grupo3sistemaso1@gmail.com");

                                    //CREACION DEL CLIENTE DE CORREO
                                    System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                                    cliente.Credentials = new System.Net.NetworkCredential("grupo3sistemaso1@gmail.com", "s1stema$2");
                                    cliente.Port = 587;
                                    cliente.EnableSsl = true;
                                    cliente.Host = "smtp.gmail.com"; //Servidor de salida de GMAIL
                                    try
                                    {
                                        cliente.Send(msg);
                                        MessageBox.Show("Se han enviado las credenciales,sea cuidadoso");
                                    }
                                    catch (Exception error)
                                    {

                                        MessageBox.Show("ERROR AL ENVIAR" + error);
                                    }

                                }
                               
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR AL OBTENER DATOS PARA EL CORREO DE RECUPERACION " + ex);
                            }
                            olvidarPassword = 0;
                            lblPassword.Visible = true;
                            txtUser.Text = "USUARIO";
                            txtPassword.Text = "CONTRASEÑA";
                            lblUser.Text = "Ingrese su usuario";
                            lblPassword.Text = "Ingrese su contraseña ";
                            btnIngreso.Text = "ACCEDER";
                        }
                    }
                    if (controlEncuento!=1)
                    {
                        MessageBox.Show("CORREO INVÁLIDO");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR DENTRO DEL FORGET" + ex);
                }

                               
            }
        }
    }
}
