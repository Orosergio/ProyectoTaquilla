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
    public partial class eliminarPelicula : Form
    {
        public eliminarPelicula()
        {
            InitializeComponent();
            funcCargar();
             cargar();
        }
        Conexion cn = new Conexion();
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
        void cargar()
        {
            try
            {
             string Sala = "SELECT * FROM PELICULA";
            OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
            OdbcDataReader mostrarC = comm.ExecuteReader();

            while (mostrarC.Read())
            {
                cboCodigoP.Items.Add(mostrarC.GetInt32(0));
                cboNombre.Items.Add(mostrarC.GetString(1));
            }
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
           

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cboNombre.SelectedItem == null)
            {
                MessageBox.Show("Si desea eliminar una pelicula, elija un nombre primero ");
            }
           else
            {
                try
                {
                    string Eliminar = "DELETE FROM PELICULA WHERE idPelicula = " + cboCodigoP.SelectedItem;
                    OdbcCommand comm = new OdbcCommand(Eliminar, cn.nuevaConexion());
                    OdbcDataReader mostrarC = comm.ExecuteReader();
                    MessageBox.Show("Los datos se eliminaron correctamente");
                    funcCargar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);

                }
            }


        }

        private void eliminarPelicula_Load(object sender, EventArgs e)
        {

        }

        private void dgtDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoP.SelectedIndex = cboNombre.SelectedIndex;
        }
    }
}
