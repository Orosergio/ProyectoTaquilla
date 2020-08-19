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

namespace AdministrativoReportes
{
    public partial class frmModificarPelicula : Form
    {
        public frmModificarPelicula()
        {
            InitializeComponent();
            procBuscar();
            procCargar();
            procEstatus();
        }
       void procEstatus()
        {
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo ");

        }
        clsValidacion validar = new clsValidacion();
        clsConexion cn = new clsConexion();
        String Link;
        void procLimpiar()
        {
            //funcion para limpiar los elementos del form
            txtNuevo.Text = "";
            txtLink.Text = "";
            txtDuracion.Text = "";
            txtDescripcion.Text = "";
            txtMultimedia.Text = "";
            cboClasificacion.Items.Clear();
            cboPelicula.Items.Clear();
            pbImagen.BackgroundImage = null;
            cboEstado.Items.Clear();



        }

        void procCargarPeliculas()
        {
            //carga los datos de las peliculas en los txt dependiendo cual se seleccione
            try
            {
                string Pelicula = "SELECT * FROM PELICULA WHERE idPelicula = " + Int32.Parse(cboCodigoP.SelectedItem.ToString());
                OdbcCommand com5 = new OdbcCommand(Pelicula, cn.nuevaConexion());
                OdbcDataReader mostrarDatos = com5.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    txtNuevo.Text = mostrarDatos.GetString(1);
                    txtDescripcion.Text = mostrarDatos.GetString(2);
                    txtMultimedia.Text = mostrarDatos.GetString(6);
                    txtLink.Text = mostrarDatos.GetString(7);
                    txtDuracion.Text = mostrarDatos.GetString(8);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }
        void procCargar()
        {
            //funcion para cargar datos en el DataGridView
            try
            {
                string cadena = "SELECT * FROM PELICULA";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.nuevaConexion());
                DataTable dt = new DataTable();
                datos.Fill(dt);
                dgtDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }
        void procBuscar()
        {
           //funcion que busca los datos que se le solicitan y los muestra en los comboBox
            try
            {
                        string Sala = "SELECT * FROM CLASIFICACIONPELICULA";
                        OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                        OdbcDataReader mostrarC = comm.ExecuteReader();

                        while (mostrarC.Read())
                        {
                            cboCodigoC.Items.Add(mostrarC.GetInt32(0));
                            cboClasificacion.Items.Add(mostrarC.GetString(1));
                        }

                string Pelicula = "SELECT * FROM PELICULA";
                OdbcCommand comPelicula = new OdbcCommand(Pelicula, cn.nuevaConexion());
                OdbcDataReader mostrarPelicula = comPelicula.ExecuteReader();

                while (mostrarPelicula.Read())
                {
                    cboCodigoP.Items.Add(mostrarPelicula.GetInt32(0));
                    cboPelicula.Items.Add(mostrarPelicula.GetString(1));
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
            }
       
    private void ModificarPelicula_Load(object sender, EventArgs e)
        {

        }

        private void cboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoP.SelectedIndex = cboPelicula.SelectedIndex;
            procCargarPeliculas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void cboClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoC.SelectedIndex = cboClasificacion.SelectedIndex;
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboCodigoP_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcNumerosYpuntos(e);
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //boton para modificar los datos de la base de datos segun los datos que se seleccionaron
            if (txtLink.Text == "" || txtNuevo.Text == "" || txtDescripcion.Text == "" || txtDuracion.Text == "" || txtMultimedia.Text == "" ||
              cboClasificacion.SelectedItem == null || cboEstado.SelectedItem == null)
            {
                MessageBox.Show("No debe dejar campos vacios");
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
                if (dtpFecha.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha de inicio no puede ser menor a la de Hoy ");
                }
                else
                {

                    Fecha = dtpFecha.Value.ToString("yyyy-MM-dd hh:mm:ss");
                    try
                    {

                        string Modificar = "UPDATE PELICULA SET nombre = '" + txtNuevo.Text + "' , descripcion = '" + txtDescripcion.Text + "', idClasificacion = " + Int32.Parse(cboCodigoC.SelectedItem.ToString()) + ", fechaestreno = '" + Fecha + "', estatus = '" + Estatus + "', linkTrailer = '" + txtMultimedia.Text + "', imagen = '" + Link + "', duracion = '" + txtDuracion.Text + "'  WHERE idPelicula=" + Int32.Parse(cboCodigoP.SelectedItem.ToString());
                        OdbcCommand Consulta = new OdbcCommand(Modificar, cn.nuevaConexion());
                        OdbcDataReader leer = Consulta.ExecuteReader();
                        MessageBox.Show("Los datos fueron actualizados correctamente ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                    }
                    clsBitacora bitacora = new clsBitacora();
                    string proceso = "Modificación datos de película";
                    string tabla = "PELICULA";
                    bitacora.GuardarBitacora(proceso, tabla);
                    procLimpiar();
                    procBuscar();
                    procCargar();
                    procEstatus();
                }
            }

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
                            pbImagen.BackgroundImage = Bitmap.FromStream(str);
                            pbImagen.BackgroundImageLayout = ImageLayout.Stretch;
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
                MessageBox.Show("El link de la imagen ingresada no es valido, intenete con otro link");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procBuscar();
            procEstatus();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAdministracion/Ayuda.chm", "Modificar Peliculas.html");
        }
    }
}
