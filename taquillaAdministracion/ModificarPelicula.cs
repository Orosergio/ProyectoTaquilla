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
    public partial class ModificarPelicula : Form
    {
        public ModificarPelicula()
        {
            InitializeComponent();
            funcBuscar();
            funcCargar();
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
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }
        void funcBuscar()
        {
           
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                    txtDuracion.Text = mostrarDatos.GetString(8);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
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
            try
            {
                string Modificar = "SELECT * FROM PELICULA WHERE idPelicula = " + Int32.Parse(cboCodigoP.SelectedItem.ToString());
                OdbcCommand Consulta = new OdbcCommand(Modificar, cn.nuevaConexion());
                OdbcDataReader Ingresar = Consulta.ExecuteReader()

               /* while (Ingresar.Read())
                {
                    txtNuevo.Text = mostrarDatos.GetString(1);
                    txtDescripcion.Text = mostrarDatos.GetString(2);
                    txtMultimedia.Text = mostrarDatos.GetString(6);
                    txtDuracion.Text = mostrarDatos.GetString(8);
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }
    }
}
