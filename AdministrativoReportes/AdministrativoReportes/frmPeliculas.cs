using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
//using WindowsFormsApp1;

namespace AdministrativoReportes
{
    public partial class frmPeliculas : Form
    {
        clsValidacion validar = new clsValidacion(); //variable de la clase validar para ver que se cumplan las restricciones de campos
        clsConexion cn = new clsConexion(); //varible de la clase conexion para realizar la conexion a la base de datos
        String uno = "1";
        String Fecha;
        string Link ;
        int numero = 0;
        int codigoA = 0;
        public frmPeliculas()
        {
            InitializeComponent();
            procBuscar();
            procCargar();
            procCodigoA();
          
        }

      

        void funcEstatus()
        {

        }
       
        void procLimpiar()
        {
            //Esta funcion limpia todos los campos
            txtNombre.Text = "";
            txtDuracion.Text = "";
            txtDescripcion.Text = "";
            txtMultimedia.Text = "";
            cboClasificacion.Items.Clear();
            txtLink.Text = "";
            pbPelicula.BackgroundImage = null;               
        }
        void procCargar()
        {
            //Muestra los datos de la tabla pelicula en el dataGridView llamada dgtDatos
            try
            {
            string cadena = "SELECT * FROM PELICULA WHERE estatus = '" + uno + "' ";
            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.nuevaConexion());
            DataTable dt = new DataTable();
            datos.Fill(dt);
            dgtDatos.DataSource = dt;
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
          

        }
        void procBuscar()
        {
            //en esta funcion buscar se seleccionaran las clasificacions de las peliculas y se mostraran en el cboClaficicacion
                try
                {
                    string Sala = "SELECT * FROM CLASIFICACIONPELICULA";
                    OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                    OdbcDataReader mostrarC = comm.ExecuteReader();

                    while (mostrarC.Read())
                    {
                        cboCodigoCla.Items.Add(mostrarC.GetInt32(0));
                        cboClasificacion.Items.Add(mostrarC.GetString(1));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde"+ex);
                }
        }
        private void Producto_Load(object sender, EventArgs e)
        {
            combobox();
            combobox2();
            codigo();

        }
        public void combobox()
        {
           
        }
        public void combobox2()
        {
            
        }

      
      
        public void codigo()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
         
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procBuscar();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmEliminarPelicula eliminar = new frmEliminarPelicula();

            eliminar.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cboClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoCla.SelectedIndex = cboClasificacion.SelectedIndex;
         
        }

        private void cboFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
       
           
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            //en este boton funciona a manera de mostrar la imagen en un pictureBox, posteriormente esta el link es
            //guardado en una variable para ser enviado a la base de datos
            try
            {
                if (txtLink.Text != "")
                {
                    WebRequest request = WebRequest.Create(txtLink.Text);
                    using (var response = request.GetResponse())
                    {
                        using (var str = response.GetResponseStream())
                        {
                            pbPelicula.BackgroundImage = Bitmap.FromStream(str);
                            pbPelicula.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                    Link = txtLink.Text;
                }
                else
                {
                    MessageBox.Show("Debe ingresar un link para la imagen");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("El link no se logro encontrar, intente con otro link");
            }
            

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtDuracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcNumerosYpuntos(e);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void btnModificar_Click(object sender, EventArgs e)
        {
           
          
            //this.Hide();
            frmModificarPelicula modificarPelicula = new frmModificarPelicula();
            modificarPelicula.ShowDialog();
            //this.Show();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Este if verifica que no se deje ningun campo en blanco, si hay uno en blando muestra el mensaje de que se necesitan llenar los campos
            if (cboClasificacion.SelectedItem == null || cboClasificacion.SelectedItem == null
               || (txtDescripcion.Text == "") || (txtDuracion.Text == "") || (txtMultimedia.Text == "") || (txtNombre.Text == "") || (pbPelicula.BackgroundImage == null))
            {
                MessageBox.Show("Necesita llegar todos los campos");
            }
            else
            {
                if (dtpFecha.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha de estreno no puede ser menor a la de Hoy ");
                }
                else
                {
                   
                    //Fecha obtiene la fecha seleccionada en el dptFecha y le coloca un formato
                    Fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

                    try
                    {
                        //se realiza la consulta de insertar en tabla pelicula con sus respectivos campos
                        string Insertar = "INSERT INTO PELICULA (idPelicula,nombre,descripcion,idClasificacion,fechaestreno,estatus,linkTrailer,imagen,duracion) " +  "VALUES (" + codigoA + ",'" + txtNombre.Text + "','" + txtDescripcion.Text + "'," + Int32.Parse(cboCodigoCla.SelectedItem.ToString()) + ",'" + Fecha + "','" + uno + "','" + txtMultimedia.Text + "','" + Link + "','" + txtDuracion.Text + "');";
                        OdbcCommand comm = new OdbcCommand(Insertar, cn.nuevaConexion());
                        OdbcDataReader mostrarC = comm.ExecuteReader();
                        MessageBox.Show("Los datos se ingresaron correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);

                    }
                    clsBitacora bitacora = new clsBitacora();
                    string proceso = "Adición de películas";
                    string tabla = "INSERT INTO PELICULA (idPelicula,nombre,descripcion,idClasificacion,fechaestreno,estatus,linkTrailer,imagen,duracion) VALUES (" + codigoA.ToString() + "," + txtNombre.Text.ToString() + "," + txtDescripcion.Text.ToString() + "," + cboCodigoCla.SelectedItem.ToString() + "," + Fecha.ToString() + "," + uno.ToString() + "," + txtMultimedia.Text.ToString() + "," + Link.ToString() + "," + txtDuracion.Text.ToString() + ");";
                    bitacora.GuardarBitacora(proceso, tabla);
                    procLimpiar();
                    procCargar();
                    procBuscar();
                    procCodigoA();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
          procLimpiar();
           procBuscar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarPelicula eliminar = new frmEliminarPelicula();

            eliminar.Show();
        }

        private void seleccionarImagenes_FileOk(object sender, CancelEventArgs e)
        {

        }
        void procCodigoA()
        {
            try
                //esta funcion hace un conteo de los datos que se encuentran en la tabla pelicula y almacena ese valor en la variable numero
               
            {
                string contador = "SELECT count(idPelicula) FROM PELICULA ";
                OdbcCommand comando = new OdbcCommand(contador, cn.nuevaConexion());
                numero = Convert.ToInt32(comando.ExecuteScalar());
                //si numero = 0, no encuentra ningun registro convierte el cidigoA en 1 y envia ese codigo para guardado como ID
                if (numero == 0)
                {
                    codigoA = 1;
                }
                else
                {
                    //de lo contrario se ira incrementando + 1 codigoA
                    codigoA = numero + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dtpFecha.Value.Date < DateTime.Now.Date)
                MessageBox.Show("La fecha seleccionada es menor a la fecha actual");
            {
                //Fecha obtiene la fecha seleccionada en el dptFecha y le coloca un formato
                Fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
                MessageBox.Show("" + Fecha);
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,"AyudaAdministracion/Ayuda.chm","Peliculas.html");
        }
    }
}
