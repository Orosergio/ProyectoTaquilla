using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Taquilla
{
    public partial class frmCartelera : Form
    {
        int lx, ly;
        int sw, sh;
        List<clsPelicula> listaPelicula = new List<clsPelicula>();
        int cantidadPeliculas;
        int restantePeliculas = 3, peliculasPasadas=0;
        int codigoPelicula1, codigoPelicula2, codigoPelicula3;
        clsConexion conn = new clsConexion();
        public frmCartelera()
        {
            InitializeComponent();
            procDepartamento();
            
        }
       
        public void procDepartamento()
        {
            try
            {
                string Query = "SELECT * FROM DEPARTAMENTO  WHERE ESTATUS=1";
                OdbcDataReader Datos;
                OdbcCommand Consulta= new OdbcCommand();
                Consulta.CommandText = Query;
                Consulta.Connection = conn.Conexion();
                Datos = Consulta.ExecuteReader();
                while (Datos.Read())
                {
                    cboCodigoDepartamento.Items.Add(Datos.GetString(0));
                    cboDepartamento.Items.Add(Datos.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cartelera_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listaPelicula.Clear();
              try
              {
                  string Query = "select distinct p.nombre, p.descripcion, p.linktrailer, p.imagen, p.idpelicula from pelicula p, proyeccionpelicula pp, sala s, cine c where p.idpelicula=pp.idpelicula and pp.idsala=s.idsala and s.idcine=c.idcine and c.idcine=" + Int32.Parse(cboCodigoCine.SelectedItem.ToString())+ " and p.estatus=1";
                  OdbcDataReader Datos;
                  OdbcCommand Consulta = new OdbcCommand();
                  Consulta.CommandText = Query;
                  Consulta.Connection = conn.Conexion();
                  Datos = Consulta.ExecuteReader();
                  while (Datos.Read())
                  {
                    listaPelicula.Add(new clsPelicula(Datos.GetString(0), Datos.GetString(1), Datos.GetString(2), Datos.GetString(3), Int32.Parse(Datos.GetString(4))));                  
                  }
                
                pnlCartelera.Visible = true;
                cantidadPeliculas = listaPelicula.Count();
                btnSubir.Visible = false;
                procMostrarCartelera();
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.ToString());
                  throw;
             }
        }

        public void procMostrarCartelera()
        {
            peliculasPasadas = 0;
            if (cantidadPeliculas>=3)
            {
                procPeliculasIniciales(3, 1);
                procDesbloquearObjetos(1);
                btnBajar.Visible = true;
                btnSubir.Visible = false;
                peliculasPasadas += 3;
            }
            else if (cantidadPeliculas == 2)
            {
                procPeliculasIniciales(2, 1);
                procDesbloquearObjetos(2);
                btnBajar.Visible = false;
                btnSubir.Visible = false;
                peliculasPasadas += 3;
            }
            else if (cantidadPeliculas == 1)
            {
                procPeliculasIniciales(1, 1);
                btnBajar.Visible = false;
                btnSubir.Visible = false;
                procDesbloquearObjetos(3);
                peliculasPasadas += 1;
            }
            else if (cantidadPeliculas==0)
            {
                procDesbloquearObjetos(4);
                btnBajar.Visible = false;
                btnSubir.Visible = false;
            }
        }
        public void procDesbloquearObjetos(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    picPelicula1.Visible = true;
                    picPelicula2.Visible = true;
                    picPelicula3.Visible = true;
                    lblPelicula1.Visible = true;
                    lblPelicula2.Visible = true;
                    lblPelicula3.Visible = true;
                    txtSinopsis1.Visible = true;
                    txtSinopsis2.Visible = true;
                    txtSinopsis3.Visible = true;
                    lblSinopsis1.Visible = true;
                    lblSinopsis2.Visible = true;
                    lblSinopsis3.Visible = true;
                    btnClasificacion1.Visible = true;
                    btnClasificacion2.Visible = true;
                    btnClasificacion3.Visible = true;
                    btnTrailer1.Visible = true;
                    btnTrailer2.Visible = true;
                    btnTrailer3.Visible = true;
                    btnFuncion1.Visible = true;
                    btnFuncion2.Visible = true;
                    btnFuncion3.Visible = true;
                    break;
                case 2:
                    picPelicula1.Visible = true;
                    picPelicula2.Visible = true;
                    picPelicula3.Visible = false;
                    lblPelicula1.Visible = true;
                    lblPelicula2.Visible = true;
                    lblPelicula3.Visible = false;
                    txtSinopsis1.Visible = true;
                    txtSinopsis2.Visible = true;
                    txtSinopsis3.Visible = false;
                    lblSinopsis1.Visible = true;
                    lblSinopsis2.Visible = true;
                    lblSinopsis3.Visible = false;
                    btnClasificacion1.Visible = true;
                    btnClasificacion2.Visible = true;
                    btnClasificacion3.Visible = false;
                    btnTrailer1.Visible = true;
                    btnTrailer2.Visible = true;
                    btnTrailer3.Visible = false;
                    btnFuncion1.Visible = true;
                    btnFuncion2.Visible = true;
                    btnFuncion3.Visible = false;
                    break;
                case 3:
                    picPelicula1.Visible = true;
                    picPelicula2.Visible = false;
                    picPelicula3.Visible = false;
                    lblPelicula1.Visible = true;
                    lblPelicula2.Visible = false;
                    lblPelicula3.Visible = false;
                    txtSinopsis1.Visible = true;
                    txtSinopsis2.Visible = false;
                    txtSinopsis3.Visible = false;
                    lblSinopsis1.Visible = true;
                    lblSinopsis2.Visible = false;
                    lblSinopsis3.Visible = false;
                    btnClasificacion1.Visible = true;
                    btnClasificacion2.Visible = false;
                    btnClasificacion3.Visible = false;
                    btnTrailer1.Visible = true;
                    btnTrailer2.Visible = false;
                    btnTrailer3.Visible = false;
                    btnFuncion1.Visible = true;
                    btnFuncion2.Visible = false;
                    btnFuncion3.Visible = false;
                    break;
                case 4:
                    picPelicula1.Visible = false;
                    picPelicula2.Visible = false;
                    picPelicula3.Visible = false;
                    lblPelicula1.Visible = false;
                    lblPelicula2.Visible = false;
                    lblPelicula3.Visible = false;
                    txtSinopsis1.Visible = false;
                    txtSinopsis2.Visible = false;
                    txtSinopsis3.Visible = false;
                    lblSinopsis1.Visible = false;
                    lblSinopsis2.Visible = false;
                    lblSinopsis3.Visible = false;
                    btnClasificacion1.Visible = false;
                    btnClasificacion2.Visible = false;
                    btnClasificacion3.Visible = false;
                    btnTrailer1.Visible = false;
                    btnTrailer2.Visible = false;
                    btnTrailer3.Visible = false;
                    btnFuncion1.Visible = false;
                    btnFuncion2.Visible = false;
                    btnFuncion3.Visible = false;
                    break;
                default:
                    break;
            }
        }
        public void procPeliculasIniciales(int cantidadPeliculas, int opcion)
        {
            int repeticiones = 1;
            switch (opcion)
            {
                case 1:
                    foreach (clsPelicula movie in listaPelicula)
                    {
                        if (repeticiones <= cantidadPeliculas)
                        {
                            string imagen = @movie.RutaImagen;
                            switch (repeticiones)
                            {
                                case 1:
                                    picPelicula1.Image = Image.FromFile(imagen);
                                    lblPelicula1.Text = movie.Nombre;
                                    txtSinopsis1.Text = movie.Descripcion;
                                    lblTrailer1.Text = movie.Trailer;
                                    codigoPelicula1 = movie.codigoPelicula;//
                                    break;
                                case 2:
                                    picPelicula2.Image = Image.FromFile(imagen);
                                    lblPelicula2.Text = movie.Nombre;
                                    txtSinopsis2.Text = movie.Descripcion;
                                    lblTrailer2.Text = movie.Trailer;
                                    codigoPelicula2 = movie.codigoPelicula;//
                                    break;
                                case 3:
                                    picPelicula3.Image = Image.FromFile(imagen);
                                    lblPelicula3.Text = movie.Nombre;
                                    txtSinopsis3.Text = movie.Descripcion;
                                    lblTrailer3.Text = movie.Trailer;
                                    codigoPelicula3 = movie.codigoPelicula;//
                                    break;
                                default:
                                    break;
                            }
                            repeticiones++;
                        }
                    }
                    break;
                case 2:
                    //MessageBox.Show(cantidadPeliculas.ToString() + " -+++--");
                    foreach (clsPelicula movie in listaPelicula)
                    {                       
                        if ((repeticiones > peliculasPasadas) && (repeticiones <= cantidadPeliculas))
                        {                            
                            string imagen = @movie.RutaImagen;

                            if (repeticiones==(peliculasPasadas+1))
                            {
                               // MessageBox.Show(repeticiones.ToString()+" ---" );
                                picPelicula1.Image = Image.FromFile(imagen);
                                lblPelicula1.Text = movie.Nombre;
                                txtSinopsis1.Text = movie.Descripcion;
                                lblTrailer1.Text = movie.Trailer;
                                codigoPelicula1 = movie.codigoPelicula;//
                            }
                            else if (repeticiones == (peliculasPasadas+2))
                            {
                                picPelicula2.Image = Image.FromFile(imagen);
                                lblPelicula2.Text = movie.Nombre;
                                txtSinopsis2.Text = movie.Descripcion;
                                lblTrailer2.Text = movie.Trailer;
                                codigoPelicula2 = movie.codigoPelicula;//
                            }
                            else if (repeticiones == (peliculasPasadas+3))
                            {
                                picPelicula3.Image = Image.FromFile(imagen);
                                lblPelicula3.Text = movie.Nombre;
                                txtSinopsis3.Text = movie.Descripcion;
                                lblTrailer3.Text = movie.Trailer;
                                codigoPelicula3 = movie.codigoPelicula;//
                            }                            
                            repeticiones++;
                        }
                        else
                        {
                            repeticiones++;
                        }
                    }
                    break;
                default:
                    break;
            }
        
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            cboCodigoDepartamento.SelectedIndex = cboDepartamento.SelectedIndex;
            cboMunicipio.Items.Clear();
            cboCodigoCine.Items.Clear();
            cboCodigoMunicipio.Items.Clear();
            cboCine.Items.Clear();
            cboMunicipio.Enabled = true;
            try
            {
                string Query = "SELECT * FROM MUNICIPIO WHERE IDDEPARTAMENTO="+Int32.Parse(cboCodigoDepartamento.SelectedItem.ToString())+" AND ESTATUS=1";
                OdbcDataReader Datos;
                OdbcCommand Consulta = new OdbcCommand();
                Consulta.CommandText = Query;
                Consulta.Connection = conn.Conexion();
                Datos = Consulta.ExecuteReader();
                while (Datos.Read())
                {
                    cboCodigoMunicipio.Items.Add(Datos.GetString(0));
                    cboMunicipio.Items.Add(Datos.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int peliculasPasadasArriba = peliculasPasadas;
            //MessageBox.Show(peliculasPasadas.ToString() + "----");
            peliculasPasadas -= 6;
            //MessageBox.Show(peliculasPasadas.ToString()+"----");
            if (peliculasPasadas > 3)
            {
                procPeliculasIniciales(cantidadPeliculas, 2);
                procDesbloquearObjetos(1);
                btnBajar.Visible = true;
                btnSubir.Visible = true;
                peliculasPasadas += 3;
            }else if(peliculasPasadas == 3)
            {
                procPeliculasIniciales(cantidadPeliculas, 2);
                procDesbloquearObjetos(1);
                btnBajar.Visible = true;
                btnSubir.Visible = true;
                peliculasPasadas = 3;
            }
            else if (peliculasPasadas < 3)
            {
                procPeliculasIniciales(3, 1);
                procDesbloquearObjetos(1);
                btnBajar.Visible = true;
                btnSubir.Visible = false;               
                peliculasPasadas = 3;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            restantePeliculas = cantidadPeliculas - peliculasPasadas;
           // MessageBox.Show(restantePeliculas.ToString()+"--"+peliculasPasadas.ToString());
            if (restantePeliculas >= 3)
            {
                procPeliculasIniciales(cantidadPeliculas, 2);
                procDesbloquearObjetos(1);
                btnSubir.Visible = true;
                if (restantePeliculas > 3)
                {
                    btnBajar.Visible = true;
                }
                else
                {
                    btnBajar.Visible = false;
                }                  
                peliculasPasadas += 3;
            }
            else if (restantePeliculas == 2)
            {                
                procPeliculasIniciales(cantidadPeliculas, 2);
                procDesbloquearObjetos(2);
                btnBajar.Visible = false;
                btnSubir.Visible = true;
                peliculasPasadas += 3;
            }
            else if (restantePeliculas == 1)
            {              
                procPeliculasIniciales(cantidadPeliculas, 2);
                procDesbloquearObjetos(3);
                btnBajar.Visible = false;
                btnSubir.Visible = true;
                peliculasPasadas += 3;
            }
          //  MessageBox.Show(restantePeliculas.ToString() + "--" + peliculasPasadas.ToString());
        }

        private void cboCine_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoCine.SelectedIndex = cboCine.SelectedIndex;
            btnBuscar.Enabled = true;
        }

        private void btnTrailer1_Click(object sender, EventArgs e)
        {
            
            frmTrailer formTrailer = new frmTrailer(lblTrailer1.Text);
            formTrailer.ShowDialog();
        }

        private void btnTrailer2_Click(object sender, EventArgs e)
        {
            frmTrailer formTrailer = new frmTrailer(lblTrailer2.Text);
            formTrailer.ShowDialog();
        }

        private void btnTrailer3_Click(object sender, EventArgs e)
        {
            frmTrailer formTrailer = new frmTrailer(lblTrailer3.Text);
            formTrailer.ShowDialog();
        }

        private void btnFuncion1_Click(object sender, EventArgs e)
        {
            frmFuncionesCine formFunciones = new frmFuncionesCine(Int32.Parse(cboCodigoCine.SelectedItem.ToString()), codigoPelicula1);
            formFunciones.lblNombreCine.Text = cboCine.SelectedItem.ToString();
            formFunciones.lblNombrePelicula.Text = lblPelicula1.Text;
            formFunciones.picPelicula.Image = picPelicula1.Image;
            this.Hide();
            formFunciones.ShowDialog();
            this.Show();
            
        }

        private void btnFuncion2_Click(object sender, EventArgs e)
        {
            frmFuncionesCine formFunciones = new frmFuncionesCine(Int32.Parse(cboCodigoCine.SelectedItem.ToString()),codigoPelicula2);
            formFunciones.lblNombreCine.Text = cboCine.SelectedItem.ToString();
            formFunciones.lblNombrePelicula.Text = lblPelicula2.Text;
            formFunciones.picPelicula.Image = picPelicula2.Image;
            this.Hide();
            formFunciones.ShowDialog();
            this.Show();
        }

        private void btnFuncion3_Click(object sender, EventArgs e)
        {
            frmFuncionesCine formFunciones = new frmFuncionesCine(Int32.Parse(cboCodigoCine.SelectedItem.ToString()),codigoPelicula3);
            formFunciones.lblNombreCine.Text = cboCine.SelectedItem.ToString();
            formFunciones.lblNombrePelicula.Text = lblPelicula3.Text;
            formFunciones.picPelicula.Image = picPelicula3.Image;
            this.Hide();
            formFunciones.ShowDialog();
            this.Show();
        }

        private void cboMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            cboCodigoMunicipio.SelectedIndex = cboMunicipio.SelectedIndex;
            cboCine.Items.Clear();
            cboCodigoCine.Items.Clear();
            cboCine.Enabled = true;
            try
            {
                string Query = "SELECT * FROM cine WHERE IDMUNICIPIO="+Int32.Parse(cboCodigoMunicipio.SelectedItem.ToString())+" AND ESTATUS=1";
                OdbcDataReader Datos;
                OdbcCommand Consulta = new OdbcCommand();
                Consulta.CommandText = Query;
                Consulta.Connection = conn.Conexion();
                Datos = Consulta.ExecuteReader();
                while (Datos.Read())
                {
                    cboCodigoCine.Items.Add(Datos.GetString(0));
                    cboCine.Items.Add(Datos.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("\t           Cerrando...\n\n\tSeguro que desea cerrar?", "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnRestaurar.Visible = false;
            btnMax.Visible = true;
        }
    }
}
