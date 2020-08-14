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

namespace taquillaAdministracion
{
    public partial class eliminarFuncion : Form
    {
        Conexion cn = new Conexion();
        public eliminarFuncion()
        {
            InitializeComponent();
         
            cargarFuncion();
        }
        string estatus = "1";
        void cargarFuncion()
        {
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
        void funcCargar()
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
            cargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
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

                cboPelicula.Items.Clear();
                cboCodigoF.Items.Clear();
                funcCargar();
                cargar();
                cargarFuncion();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        { 
           
            funcCargar();
           
        }
        void cargar()
        {
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
    }
}
