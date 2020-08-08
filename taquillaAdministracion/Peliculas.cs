using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
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
        public Peliculas()
        {
            InitializeComponent();
            funcBuscar();
            funcCargar();
          funcCodigoA();
        }
        
        int codigoA = 0;

        void funcEstatus()
        {

        }
        void funcCodigoA()
        {
            try
            {
               
                string contador = "SELECT MAX(idPelicula) FROM PELICULA ORDER BY idPelicula ASC";
                OdbcCommand comando = new OdbcCommand(contador , cn.nuevaConexion());
                int numero = 0 ;
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
                MessageBox.Show("Error"+ex);
            }
        }
        void funcLimpiar()
        {
            txtNombre.Text = "";
            txtDuracion.Text = "";
            txtDescripcion.Text = "";
            txtMultimedia.Text = "";
          //  cboClasificacion.Items.Clear();
         //   cboEstado.Items.Clear();
          ///  cboIdioma.Items.Clear();
         //   cboCodigoCla.Items.Clear();
          //  cboCodigoEstado.Items.Clear();
         //   cboCodigoIdio.Items.Clear();
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
            
            if(cboClasificacion.SelectedItem == null  ||cboClasificacion.SelectedItem == null 
               || (txtDescripcion.Text == "") || (txtDuracion.Text == "") || (txtMultimedia.Text == "") || (txtNombre.Text == ""))
            {
                MessageBox.Show("Necesita llegar todos los campos");
            }
             else
            {
                funcCodigoA();
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
                Fecha = dtpFecha.Value.ToString("yyyy-MM-dd hh:mm:ss");
                //  MessageBox.Show("" + Estatus);
                try
                {
                    string Insertar = "INSERT INTO PELICULA (idPelicula,nombre,descripcion,idClasificacion,fechaEstreno,estatus,linkTrailer,imagen,duracion) " +
                          "VALUES (" + codigoA + ",'" + txtNombre.Text + "','" + txtDescripcion.Text + "'," + cboCodigoCla.SelectedItem + ",'" + Fecha + "','" + Estatus + "','" + txtMultimedia.Text + "','" + Prueba + "','" + txtDuracion.Text + "')";
                    OdbcCommand comm = new OdbcCommand(Insertar, cn.nuevaConexion());
                    OdbcDataReader mostrarC = comm.ExecuteReader();
                    MessageBox.Show("Los datos se ingresaron correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);

                }
                funcLimpiar();
                funcCargar();
            }
         
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            funcLimpiar();

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
           // cboCodigoForm.SelectedIndex = cboFormato.SelectedIndex;
        
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
         //  cboCodigoIdio.SelectedIndex = cboIdioma.SelectedIndex;
           
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
          seleccionarImagenes.ShowDialog();
            pbPelicula.Image = Image.FromFile(seleccionarImagenes.FileName);

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
            ModificarPelicula modificarPelicula = new ModificarPelicula();
            modificarPelicula.Show();
        }
    }
}
