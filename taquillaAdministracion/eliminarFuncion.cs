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
            //funcCargar();
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
            try
            {
                string Eliminar = "DELET * FROM PROYECCIONPELICULA WHERE idProyeccionPelicula = " + cboCodigoPro.SelectedItem;
                OdbcCommand comm = new OdbcCommand(Eliminar, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                MessageBox.Show("Los datos se eliminaron correctamente");
                //funcCargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);

            }
            //funcCargar();
        }
    }
}
