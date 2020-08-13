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

namespace taquillaAdministracion
{
    public partial class Peliculas : Form
    {
        Validacion validar = new Validacion();
        Conexion cn = new Conexion();
        String Prueba = "prueba";
        String UbicacionImagen;
        string Link ;
        int CodigoImagen;
        int numero = 0;
        int codigoA = 0;
        public Peliculas()
        {
            InitializeComponent();
            funcBuscar();
            funcCargar();
            funcCodigoA();
          
        }

      

        void funcEstatus()
        {

        }
       
        void funcLimpiar()
        {
            txtNombre.Text = "";
            txtDuracion.Text = "";
            txtDescripcion.Text = "";
            txtMultimedia.Text = "";
            cboClasificacion.Items.Clear();
            txtLink.Text = "";
            pbPelicula.BackgroundImage = null;               
        }
        void funcCargar()
        {
            try
            {
            string cadena = "SELECT * FROM PELICULA";
            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.nuevaConexion());
            DataTable dt = new DataTable();
            datos.Fill(dt);
            dgtDatos.DataSource = dt;
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
          

        }
        void funcBuscar()
        {
          
            try
            {
              
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
            catch (Exception ex)
            {

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
            funcLimpiar();
            funcBuscar();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            eliminarPelicula eliminar = new eliminarPelicula();

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
            if(txtLink.Text != "")
            {
            WebRequest request = WebRequest.Create(txtLink.Text);
            using (var  response = request.GetResponse())
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
            ModificarPelicula modificarPelicula = new ModificarPelicula();
            modificarPelicula.ShowDialog();
            //this.Show();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (cboClasificacion.SelectedItem == null || cboClasificacion.SelectedItem == null
               || (txtDescripcion.Text == "") || (txtDuracion.Text == "") || (txtMultimedia.Text == "") || (txtNombre.Text == ""))
            {
                MessageBox.Show("Necesita llegar todos los campos");
            }
            else
            {

                String Estatus, Fecha;
                Estatus = cboEstado.SelectedItem.ToString();
                if (Estatus == "Activo")
                {
                    Estatus = "1";
                }
                else if (Estatus == "Inactivo")
                {
                    Estatus = "0";
                }
                Fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
                //  MessageBox.Show("" + Estatus);
                try
                {
                    MessageBox.Show(""+codigoA);
                    //string Insertar = "INSERT INTO pelicula VALUES (@idPelicula,@nombre,@descripcion,@idClasificacion,@fechaestreno,@estatus,@linkTrailer,@imagen,@duracion)";
                    string Insertar = "INSERT INTO PELICULA (idPelicula,nombre,descripcion,idClasificacion,fechaestreno,estatus,linkTrailer,imagen,duracion) " +
                          "VALUES (" + codigoA + ",'" + txtNombre.Text + "','" + txtDescripcion.Text + "'," + Int32.Parse(cboCodigoCla.SelectedItem.ToString()) + ",'" + Fecha + "','" + Estatus + "','" + txtMultimedia.Text + "','" + Link + "','" + txtDuracion.Text + "')";
                    OdbcCommand comm = new OdbcCommand(Insertar, cn.nuevaConexion());
                    OdbcDataReader mostrarC = comm.ExecuteReader();
                    MessageBox.Show("Los datos se ingresaron correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
                funcLimpiar();
                funcCargar();
                funcBuscar();
                funcCodigoA();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           funcLimpiar();
            funcBuscar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarPelicula eliminar = new eliminarPelicula();

            eliminar.Show();
        }

        private void seleccionarImagenes_FileOk(object sender, CancelEventArgs e)
        {

        }
        void funcCodigoA()
        {
            try
            {

                string contador = "SELECT count(idPelicula) FROM PELICULA ";
                OdbcCommand comando = new OdbcCommand(contador, cn.nuevaConexion());
                numero = Convert.ToInt32(comando.ExecuteScalar());

                if (numero == 0)
                {
                    codigoA = 1;
                }
                else
                {
                    codigoA = numero + 1;
                }
                //   MessageBox.Show(""+codigoA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
