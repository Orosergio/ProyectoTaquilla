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
using System.Net;

namespace Taquilla
{
    public partial class frmCartelera : Form
    {
        List<clsPelicula> listaPelicula = new List<clsPelicula>();  //se declara una lista de cla clase de clsPelicula
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
            /*Este procedimientomuestra todos los departamentos en el combobox cuando el estatus sea 1*/
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
                    cboCodigoDepartamento.Items.Add(Datos.GetString(0)); //Agregamos los codigos de los departamentos en el combo escondido
                    cboDepartamento.Items.Add(Datos.GetString(1));//Agregamos el nombre de los departamentos en el combo del departamento visible
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

    
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        public void procMostrarCartelera()
            /*Procedimiento que muestra las primeras peliculas en la cartelera dependiendo de su cantidad*/
        {
            peliculasPasadas = 0;
            if (cantidadPeliculas>=3)/*Si la cantidad de peliculas es mayor a 3 o igual a 3 vuelve visibles 
                todos los obsjetos y desbloquea ambas flechas para moverse atreves de la cartelera y a la variable
                le suma 3 para indicar que ya pasaron las primeras 3 peliculas*/
            {
                procPeliculasIniciales(3, 1);
                procDesbloquearObjetos(1);
                btnBajar.Visible = true;
                btnSubir.Visible = false;
                peliculasPasadas += 3;
            }
            else if (cantidadPeliculas == 2)/*Si la cantidad de peliculas es igual 2 vuelve visibles 
                los primeros dos objetos y bloquea ambas flechas */
            {
                procPeliculasIniciales(2, 1);
                procDesbloquearObjetos(2);
                btnBajar.Visible = false;
                btnSubir.Visible = false;
                peliculasPasadas += 3;
            }
            else if (cantidadPeliculas == 1)/*Si la cantidad de peliculas es igual 1 vuelve visible 
                los primeros objetos y bloquea ambas flechas */
            {
                procPeliculasIniciales(1, 1);
                btnBajar.Visible = false;
                btnSubir.Visible = false;
                procDesbloquearObjetos(3);
                peliculasPasadas += 1;
            }
            else if (cantidadPeliculas==0)/*Si la cantidad de peliculas es igual 0 vuelve invivisble 
                todos los objetos objetos y bloquea ambas flechas */
            {
                procDesbloquearObjetos(4);
                btnBajar.Visible = false;
                btnSubir.Visible = false;
            }
        }
        public void procDesbloquearObjetos(int opcion)
            /*Prodecimiento que se utiliza para mostrar los objetos de la cartelera segun la opcion que este se envie
             dependiendo de la cantidad de peliculas existentes*/
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
        public void procImagenenesInternet(string linkImagen, int opcion)
            /*Muestra las imagenes guardadas de la lista utilizando un link de internet 
             que en este caso es de nuestro reporsitorio de github donde almacenamos las imagenes*/
        {
            WebRequest request = WebRequest.Create(linkImagen);
            using (var respone = request.GetResponse())
            {
                using (var str=respone.GetResponseStream())
                {
                    switch (opcion)
                    {
                        case 1:
                            picPelicula1.BackgroundImage = null;
                            picPelicula1.BackgroundImage = Bitmap.FromStream(str);
                            picPelicula1.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case 2:
                            picPelicula2.BackgroundImage = null;
                            picPelicula2.BackgroundImage = Bitmap.FromStream(str);
                            picPelicula2.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case 3:
                            picPelicula3.BackgroundImage = null;
                            picPelicula3.BackgroundImage = Bitmap.FromStream(str);
                            picPelicula3.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void procPeliculasIniciales(int cantidadPeliculas, int opcion)
        /*Dependiendo de la cantidad de peliculas que ya se mostraron se mostraran las siguientes 3 si es que existen gaurdadas en la lista*/
        {
            int repeticiones = 1;
            switch (opcion)
            {
                case 1:
                    foreach (clsPelicula movie in listaPelicula)
                    {
                        /*Muestras la primeras peliculas en la cartelera*/
                        if (repeticiones <= cantidadPeliculas)
                        {
                            string imagen = movie.RutaImagen;
                            switch (repeticiones)
                            {
                                case 1:
                                    procImagenenesInternet(imagen, 1);                                    
                                    lblPelicula1.Text = movie.Nombre;
                                    txtSinopsis1.Text = movie.Descripcion;
                                    lblTrailer1.Text = movie.Trailer;
                                    codigoPelicula1 = movie.codigoPelicula;//
                                    this.ttpClasificacion.SetToolTip(btnClasificacion1, movie.Clasificacion +"-"+movie.DescripcionClasificacion);
                                    break;
                                case 2:
                                    procImagenenesInternet(imagen, 2);
                                    lblPelicula2.Text = movie.Nombre;
                                    txtSinopsis2.Text = movie.Descripcion;
                                    lblTrailer2.Text = movie.Trailer;
                                    codigoPelicula2 = movie.codigoPelicula;//
                                    this.ttpClasificacion.SetToolTip(btnClasificacion2, movie.Clasificacion + "-" + movie.DescripcionClasificacion);
                                    break;
                                case 3:
                                    procImagenenesInternet(imagen, 3);
                                    lblPelicula3.Text = movie.Nombre;
                                    txtSinopsis3.Text = movie.Descripcion;
                                    lblTrailer3.Text = movie.Trailer;
                                    codigoPelicula3 = movie.codigoPelicula;//
                                    this.ttpClasificacion.SetToolTip(btnClasificacion3, movie.Clasificacion + "-" + movie.DescripcionClasificacion);
                                    break;
                                default:
                                    break;
                            }
                            repeticiones++;
                        }
                    }
                    break;
                case 2:                 
                    foreach (clsPelicula movie in listaPelicula)
                    {                       
                        if ((repeticiones > peliculasPasadas) && (repeticiones <= cantidadPeliculas))
                        {                            
                            string imagen = movie.RutaImagen;
                            /*Segun el numero de la repetición y las peliculas que paso muestra las peliculas en los objetos*/
                            if (repeticiones==(peliculasPasadas+1))
                            {
                              
                                procImagenenesInternet(imagen, 1);
                                lblPelicula1.Text = movie.Nombre;
                                txtSinopsis1.Text = movie.Descripcion;
                                lblTrailer1.Text = movie.Trailer;
                                codigoPelicula1 = movie.codigoPelicula;//
                                this.ttpClasificacion.SetToolTip(btnClasificacion1, movie.Clasificacion + "-" + movie.DescripcionClasificacion);
                            }
                            else if (repeticiones == (peliculasPasadas+2))
                            {
                                procImagenenesInternet(imagen, 2);
                                lblPelicula2.Text = movie.Nombre;
                                txtSinopsis2.Text = movie.Descripcion;
                                lblTrailer2.Text = movie.Trailer;
                                codigoPelicula2 = movie.codigoPelicula;//
                                this.ttpClasificacion.SetToolTip(btnClasificacion2, movie.Clasificacion + "-" + movie.DescripcionClasificacion);
                            }
                            else if (repeticiones == (peliculasPasadas+3))
                            {
                                procImagenenesInternet(imagen, 3);
                                lblPelicula3.Text = movie.Nombre;
                                txtSinopsis3.Text = movie.Descripcion;
                                lblTrailer3.Text = movie.Trailer;
                                codigoPelicula3 = movie.codigoPelicula;//
                                this.ttpClasificacion.SetToolTip(btnClasificacion3, movie.Clasificacion + "-" + movie.DescripcionClasificacion);
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
        /*Este procedimiento que muestra los municipios dependiendo del codigo y el estatus del departamento*/
        {
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
        /*Boton para regresar a las 3 peliculas anteriores si es que ya se bajo una o mas veces en la cartelera*/
        {
            int peliculasPasadasArriba = peliculasPasadas;
            peliculasPasadas -= 6;
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
        /*Boton para  desplazarnos por la cartelera hacia abajo si es que existen mas peliculas*/
        {
            restantePeliculas = cantidadPeliculas - peliculasPasadas;
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
        }

        private void cboCine_SelectedIndexChanged(object sender, EventArgs e)
            /*Evento del combobox que cuando seleccione el cine se ejecute la consulta y obtenga los datos de la pelicula incluyendo su
             imagen y su trailer ademas de la clasificación de esta, obtendra estos datos unicamente si el estatus de la pelicula es 1 y por
             el codigo del cine*/
        {
            cboCodigoCine.SelectedIndex = cboCine.SelectedIndex;
            wmpLogo.Visible = false;//Oculta el logo de cinepolis
            listaPelicula.Clear();//limpiamos la lista donde se almacenan las peliculas del cine
            try
            {
                string Query = "select distinct p.nombre, p.descripcion, p.linktrailer, p.imagen, p.idpelicula, cl.nombre,cl.descripcion " +
                    "from pelicula p, proyeccionpelicula pp, sala s, cine c, clasificacionpelicula cl " +
                    "where cl.idclasificacionpelicula=p.idclasificacion and p.idpelicula=pp.idpelicula and pp.idsala=s.idsala and s.idcine=c.idcine " +
                    "and c.idcine=" + Int32.Parse(cboCodigoCine.SelectedItem.ToString()) + " and p.estatus=1";
                OdbcDataReader Datos;
                OdbcCommand Consulta = new OdbcCommand();
                Consulta.CommandText = Query;
                Consulta.Connection = conn.Conexion();
                Datos = Consulta.ExecuteReader();
                while (Datos.Read())
                {
                    //Se agregan todos los datos obtenidos por la consulta a la lista
                    listaPelicula.Add(new clsPelicula(Datos.GetString(0), Datos.GetString(1), Datos.GetString(2), Datos.GetString(3), Int32.Parse(Datos.GetString(4)), Datos.GetString(5), Datos.GetString(6)));
                }
  
                pnlCartelera.Visible = true; //Muestra el panel
                cantidadPeliculas = listaPelicula.Count(); //Se obtienen cuantas peliculas se obtuvieron de la consulta
                btnSubir.Visible = false; //El boton de subir se vuelve invisible
                procMostrarCartelera(); // Se llama al procedimiento para mostrar la cartelera
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void btnTrailer1_Click(object sender, EventArgs e)
            /*Abre el form para mostrar el trailer del video de la pelicula*/
        {
            
            frmTrailer formTrailer = new frmTrailer(lblTrailer1.Text);
            formTrailer.ShowDialog();
        }

        private void btnTrailer2_Click(object sender, EventArgs e)
        /*Abre el form para mostrar el trailer del video de la pelicula*/
        {
            frmTrailer formTrailer = new frmTrailer(lblTrailer2.Text);
            formTrailer.ShowDialog();
        }

        private void btnTrailer3_Click(object sender, EventArgs e)
        /*Abre el form para mostrar el trailer del video de la pelicula*/
        {
            frmTrailer formTrailer = new frmTrailer(lblTrailer3.Text);
            formTrailer.ShowDialog();
        }

        private void btnFuncion1_Click(object sender, EventArgs e)
            /*Se abre el form para ver las funciones que existen en el cine de esa pelicula enviandole algunos parametros y otros datos
             a los objetos del otro form para que muestre la información de la pelicula*/
        {
            frmFuncionesCine formFunciones = new frmFuncionesCine(Int32.Parse(cboCodigoCine.SelectedItem.ToString()), codigoPelicula1);
            formFunciones.lblNombreCine.Text = cboCine.SelectedItem.ToString();
            formFunciones.lblNombrePelicula.Text = lblPelicula1.Text;
            formFunciones.picPelicula.BackgroundImage = picPelicula1.BackgroundImage;
            formFunciones.picPelicula.BackgroundImageLayout = ImageLayout.Stretch;
            this.Hide();
            formFunciones.ShowDialog();
            try
            {
                this.Show();
            }
            catch (Exception)
            {
                Application.Exit();

            }

        }

        private void btnFuncion2_Click(object sender, EventArgs e)
        /*Se abre el form para ver las funciones que existen en el cine de esa pelicula enviandole algunos parametros y otros datos
         a los objetos del otro form para que muestre la información de la pelicula*/
        {
            frmFuncionesCine formFunciones = new frmFuncionesCine(Int32.Parse(cboCodigoCine.SelectedItem.ToString()),codigoPelicula2);
            formFunciones.lblNombreCine.Text = cboCine.SelectedItem.ToString();
            formFunciones.lblNombrePelicula.Text = lblPelicula2.Text;
            formFunciones.picPelicula.BackgroundImage = picPelicula2.BackgroundImage;
            formFunciones.picPelicula.BackgroundImageLayout = ImageLayout.Stretch;
            this.Hide();
            formFunciones.ShowDialog();
            try
            {
                this.Show();
            }
            catch (Exception)
            {
                Application.Exit();

            }
        }

        private void btnFuncion3_Click(object sender, EventArgs e)
        /*Se abre el form para ver las funciones que existen en el cine de esa pelicula enviandole algunos parametros y otros datos
         a los objetos del otro form para que muestre la información de la pelicula*/
        {
            frmFuncionesCine formFunciones = new frmFuncionesCine(Int32.Parse(cboCodigoCine.SelectedItem.ToString()),codigoPelicula3);
            formFunciones.lblNombreCine.Text = cboCine.SelectedItem.ToString();
            formFunciones.lblNombrePelicula.Text = lblPelicula3.Text;
            formFunciones.picPelicula.BackgroundImage = picPelicula3.BackgroundImage;
            formFunciones.picPelicula.BackgroundImageLayout = ImageLayout.Stretch;
            this.Hide();
            formFunciones.ShowDialog();
            try
            {
                this.Show();
            }
            catch (Exception)
            {
                Application.Exit();

            }
            
        }

        private void cboMunicipio_SelectedIndexChanged(object sender, EventArgs e)
            /*¨Procedimiento que muestra los cines dependiendo del codigo y el estatus del municipio*/
        {
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
            //Evento para cerrar un form cuando presiona la x
        {
            if (MessageBox.Show("\t           Cerrando...\n\n\tSeguro que desea cerrar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }
    }
}
