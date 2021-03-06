﻿using System;
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
using AdministrativoReportes;
using System.Data.Odbc;
using AdministrativoReportes;
using System.Net;

namespace FinalProyecto
{
    public partial class FormPrincipal : Form
    {
        
        
        public FormPrincipal()
        {
            InitializeComponent();
            estadoRol();
                                    
        }
        clsConexion cn = new clsConexion();
        public void estadoRol()
        {
            clsBitacora bitacora = new clsBitacora();
            string idUser = bitacora.retornoIdUsuario();
            try
            {
                string cadena = " SELECT R.idRol, R.nombre FROM ROL R, USUARIO U WHERE U.idRol = R.idRol AND U.idUsuario = '"+int.Parse(idUser)+"';";
                OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString()=="1")//Superusuario
                    {
                        //TIENE TODO PERMITIDO
                        btnPeliculas.Visible = true;
                        btnFunciones.Visible = true;
                        btnEmpleado.Visible = true;
                        btnUsuario.Visible = true;
                        btnReportes.Visible = true;
                        btnMostrarBitacora.Visible = true;
                        btnCine.Visible = true;
                        btnBoleto.Visible = true;
                        btnDescuentos.Visible = true;
                    }
                    if (reader[0].ToString() == "2") //admin
                    {
                        //ADMINISTRA PELICULAS Y FUNCIONES
                        btnPeliculas.Visible = true;
                        btnFunciones.Visible = true;
                        btnEmpleado.Visible = false;
                        btnUsuario.Visible = false;
                        btnReportes.Visible = false;
                        panel8.Visible = false;
                        panel5.Visible = false;
                        panel1.Visible = false;
                        panel9.Visible = false;
                        btnMostrarBitacora.Visible = false;
                        btnCine.Visible = true;
                        btnBoleto.Visible = false;
                        btnDescuentos.Visible = false;
                        panel11.Visible = false;
                        panel14.Visible = false;

                    }
                    if (reader[0].ToString() == "3") //recursos humanos
                    {
                        //PUESTOS, ROLES Y USUARIOS
                        btnPeliculas.Visible = false;
                        btnFunciones.Visible = false;
                        btnEmpleado.Visible = true;
                        btnUsuario.Visible = true;
                        btnReportes.Visible = false;
                        panel10.Visible = false;
                        panel3.Visible = false;
                        panel5.Visible = false;
                        panel9.Visible = false;
                        btnMostrarBitacora.Visible = false;
                        btnCine.Visible = false;
                        panel12.Visible = false;
                        btnBoleto.Visible = false;
                        panel11.Visible = false;
                        btnDescuentos.Visible = false;
                        panel14.Visible = false;
                    }
                   
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ENCONTRAR ROL" + ex);
            }

           
        }

        #region FormularioFuncion
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        //Obtencion de coordenadas
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
        //Librerias para las coordenadas

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
            panel7.Visible = false;
            panel2.Visible = false;
            frmReporteVentas fm = new frmReporteVentas();
            AbrirFormEnPanel(fm);
            

        }

        private void Btnreportcompra_Click(object sender, EventArgs e)
        {
            Submenurepor.Visible = false;
            panel7.Visible = false;
            panel2.Visible = false;
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
            frmEmpleado fm = new frmEmpleado();
            AbrirFormEnPanel(fm);
        }

       
        //Activación del slide
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
        //Contracción del slide
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
            frmUsuarios fm = new frmUsuarios();
            AbrirFormEnPanel(fm);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {         
        }

        private void Submenurepor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPeliculas fm = new frmPeliculas();
            AbrirFormEnPanel(fm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFunciones fm = new frmFunciones();
            AbrirFormEnPanel(fm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            frmPeliculas fm = new frmPeliculas();
            AbrirFormEnPanel(fm);
        }

       
        private void btnFunciones_Click(object sender, EventArgs e)
        {
            frmFunciones fm = new frmFunciones();
            AbrirFormEnPanel(fm);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmUsuarios fm = new frmUsuarios();
            AbrirFormEnPanel(fm);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Submenurepor.Visible = true;
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            Submenurepor.Visible = true;
            panel7.Visible = true;
            panel2.Visible = true;
        }

        private void btnReportePuntos_Click(object sender, EventArgs e)
        {
            Submenurepor.Visible = false;
            panel7.Visible = false;
            panel2.Visible = false;
            frmReportePuntos fm = new frmReportePuntos();
            AbrirFormEnPanel(fm);
        }

        private void btnMostrarBitacora_Click(object sender, EventArgs e)
        {
            frmMostrarBitacora frm = new frmMostrarBitacora();
            AbrirFormEnPanel(frm);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCine_Click(object sender, EventArgs e)
        {
            frmCine frm = new frmCine();
            AbrirFormEnPanel(frm);
        }

        private void btnBoleto_Click(object sender, EventArgs e)
        {
            frmModificacionBoleto frm = new frmModificacionBoleto();
            AbrirFormEnPanel(frm);
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            frmPromocion frm = new frmPromocion();
            AbrirFormEnPanel(frm);
        }


        //Utilizar la hora del sistema en el programa
        private void TmFechaHora_Tick_1(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        //Abrir los diferentes forms dentro del panel
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
