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
using WindowsFormsApp1;
using EmpleadoPrueba;
using AdministrativoReportes;

namespace FinalProyecto
{
    public partial class FormPrincipal : Form
    {
        int codigo;
        
        public FormPrincipal()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
                        
        }

        #region FormularioFuncion
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
  
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.PanelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("\t           Cerrando...\n\n\tSeguro que desea cerrar?","ADVERTENCIA",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        int lx, ly;
        int sw, sh;
        private void BtnMax_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMax.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnRestaurar.Visible = false;
            btnMax.Visible = true;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd,int wMsg, int wParam,int lParam);

        private void TituloBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
        #endregion

        private void Button4_Click(object sender, EventArgs e)
        {
            Submenurepor.Visible = true;

        }

   
        private void Btnreportventa_Click(object sender, EventArgs e)
        {
            Submenurepor.Visible = false;
            frmReporteVentas fm = new frmReporteVentas();
            AbrirFormEnPanel(fm);
            

        }

        private void Btnreportcompra_Click(object sender, EventArgs e)
        {
            Submenurepor.Visible = false;
            frmReporteTaquillera fm = new frmReporteTaquillera();
            AbrirFormEnPanel(fm);
            
        }

        private void TituloBarra_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

       

        private void BtnSLIDE_Click(object sender, EventArgs e)
        {
               if (Menu.Width==250)
               {
                   Menu.Width = 60;
               }
               else if(Menu.Width==60)  
               {
                   Menu.Width = 250;
               }
        }

        private void TmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (Menu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                Menu.Width = Menu.Width - 5;
        }

      

        private void Principal_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

      

      

        private void Button6_Click(object sender, EventArgs e)
        {
           /* Usuario fm = new Usuario();
            AbrirFormEnPanel(fm);*/
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Submenurepor.Visible = false;
            frmReporteTaquillera fm = new frmReporteTaquillera();
            AbrirFormEnPanel(fm);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            string fecha = "";
           /* try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT fechainventario FROM inventario order by fechainventario";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                while (consultar.Read())
                {
                    fecha = consultar.GetString(0);

                }
                Conexion.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT id.cantidad, prod.nombre, prov.nombre,i.fechainventario from inventariodetalle id, inventario i," +
                    "producto prod, proveedor prov where prod.idproveedor=prov.idproveedor and id.idproducto=prod.idproducto" +
                    " and i.idinventario=id.idinventario";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                while (consultar.Read())
                {
                    if (consultar.GetString(3) == fecha)
                    {
                        if (consultar.GetInt32(0) <= 20)
                        {
                            MessageBox.Show("Se debe de tomar en cuenta que de el producto " + consultar.GetString(1) +
                           " solo se cuenta con " + consultar.GetInt32(0) + ", y está debajo del límite establecido. LLamar" +
                           " al proveedor " + consultar.GetString(2));
                            if (consultar.GetInt32(0) <= 5)
                            {
                                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                                msg.To.Add("bryanorlando-98@hotmail.com");
                                msg.Subject = "Pedido de producto URGENTE";
                                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                                msg.Bcc.Add("grupo3sistemaso1@gmail.com");
                                msg.Body = "Necesitamos " + (100 - consultar.GetInt32(0)).ToString() + " unidades de "
                                    + consultar.GetString(1) + " urgentemente";
                                msg.BodyEncoding = System.Text.Encoding.UTF8;
                                msg.IsBodyHtml = true;
                                msg.From = new System.Net.Mail.MailAddress("grupo3sistemaso1@gmail.com");
                                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                                cliente.Credentials = new System.Net.NetworkCredential("grupo3sistemaso1@gmail.com", "s1stema$2");
                                cliente.Port = 587;
                                cliente.EnableSsl = true;
                                cliente.Host = "smtp.gmail.com";
                                try
                                {
                                    cliente.Send(msg);
                                    MessageBox.Show("Se contacto al proveedor " + consultar.GetString(2) + " debido a la escasez del producto " +
                                        consultar.GetString(1));
                                }
                                catch (Exception error)
                                {

                                    MessageBox.Show(error.ToString());
                                }
                            }
                        }
                    }
                }
                Conexion.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }*/
            
        }

        private void Submenurepor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TmFechaHora_Tick_1(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.Principal.Controls.Count > 0)
                this.Principal.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.Principal.Controls.Add(fh);
            this.Principal.Tag = fh;
            fh.Show();
        }

       
    }
}
