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
            funcCargar();
            cargarFuncion();
        }
        
        void cargarFuncion()
        {
            try
            {
                string Sala = "SELECT * FROM PROYECCIONPELICULA";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                while (mostrarC.Read())
                {
                    cboCodigoPro.Items.Add(mostrarC.GetInt32(0));
                   // cboNombre.Items.Add(mostrarC.GetString(1));
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
                string cadena = "SELECT * FROM PROYECCIONPELICULA";
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
            if (cboCodigoPro.SelectedItem == null)
            {
                MessageBox.Show("Si desea eliminar una Funcion, elija un Codigo primero ");
            }else
            {
                try
                {
                    string Eliminar = "DELETE  FROM PROYECCIONPELICULA WHERE idProyeccionPelicula = " + cboCodigoPro.SelectedItem;
                    OdbcCommand comm = new OdbcCommand(Eliminar, cn.nuevaConexion());
                    OdbcDataReader mostrarC = comm.ExecuteReader();
                    MessageBox.Show("Los datos se eliminaron correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);

                }
                cboCodigoPro.Items.Clear();
                funcCargar();
                cargarFuncion();
            }
           
        }

        private void eliminarFuncion_Load(object sender, EventArgs e)
        {

        }
    }
}
