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

namespace AdministrativoReportes
{
    public partial class frmEliminarFuncion : Form
    {
        clsConexion cn = new clsConexion();
        public frmEliminarFuncion()
        {
            InitializeComponent();
            procCargarPelicula();
        }
        string estatus = "1";
        void procCargarPelicula()
        {
            //funcion para buscar las peliculas segun el estatus
            try
            {
                string Sala = "SELECT * FROM PELICULA WHERE estatus = '"+estatus+"'";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                while (mostrarC.Read())
                {
                    cboCodigoP.Items.Add(mostrarC.GetInt32(0));
                    cboPelicula.Items.Add(mostrarC.GetString(1));
                }
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }


        }
        //funcion que busca las proyecciones de las peliculas segun el codigo indicado
        void procCargarFunciones()
        {
            if (cboPelicula.SelectedItem  == null)
            {
                MessageBox.Show("Debe seleccionar una pelicula");
            }else
            {
                try
                {
                    string cadena = "SELECT * FROM PROYECCIONPELICULA WHERE idPelicula =" + Int32.Parse(cboCodigoP.SelectedItem.ToString());
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
           
            
        }
            private void btnEliminar_Click(object sender, EventArgs e)
        {
         
        }

        private void eliminarFuncion_Load(object sender, EventArgs e)
        {

        }

        private void cboCodigoPro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoP.SelectedIndex = cboPelicula.SelectedIndex;
            procCargarCodigoProyecciones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //funcion para actualizar campos en la base de datos
            if (cboPelicula.SelectedItem == null)
            {
                MessageBox.Show("Si desea eliminar una funcion, seleccione una pelicula primero");
            }
            else
            {
                try
                {
                    string Estatus = "0";
                    string Modificar = "UPDATE PROYECCIONPELICULA SET estatus = '" + Estatus + "' WHERE idPelicula=" + cboCodigoP.SelectedItem;
                    OdbcCommand Consulta = new OdbcCommand(Modificar, cn.nuevaConexion());
                    OdbcDataReader leer = Consulta.ExecuteReader();
                    MessageBox.Show("El estatus de la pelicula fue modificado a inactivo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                }
                //Adición de bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "Eliminar funciones de peliculas";
                string tabla = "PROYECCIONPELICULA";
                bitacora.GuardarBitacora(proceso, tabla);
                //Limpieza de items
                cboPelicula.Items.Clear();
                cboCodigoF.Items.Clear();
                procCargarFunciones();
                procCargarCodigoProyecciones();
                procCargarPelicula();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            procCargarFunciones();


        }
        void procCargarCodigoProyecciones()
        {
            cboCodigoF.Items.Clear();
            //funcion para buscar las proyecciones segun el codigo que se indica
            try
            {
                string cadena = "SELECT * FROM PROYECCIONPELICULA WHERE idPelicula =" + Int32.Parse(cboCodigoP.SelectedItem.ToString());
                OdbcCommand comm1 = new OdbcCommand(cadena, cn.nuevaConexion());
                OdbcDataReader mostrarMun = comm1.ExecuteReader();
                while (mostrarMun.Read())
                {
                    cboCodigoF.Items.Add(mostrarMun.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        private void cboCodigoF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboPelicula.Items.Clear();
            cboCodigoF.Items.Clear();
            dgtDatos.DataSource = null;
            procCargarPelicula();

        }
    }
}
