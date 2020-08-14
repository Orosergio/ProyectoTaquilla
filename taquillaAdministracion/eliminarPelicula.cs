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
        String uno = "1";
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
             
                string cadena = "SELECT * FROM PELICULA WHERE estatus = '"+uno+"' ";
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
             
                string Sala = "SELECT * FROM PELICULA WHERE estatus = '" + uno + "' ";
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboNombre.SelectedItem == null)
            {
                MessageBox.Show("Si desea eliminar una pelicula, elija un nombre primero ");
            }
            else
            {
                try
                {
                    string Estatus = "0";
                    string Modificar = "UPDATE PELICULA SET estatus = '"+Estatus+"' WHERE idPelicula=" + cboCodigoP.SelectedItem;
                    OdbcCommand Consulta = new OdbcCommand(Modificar, cn.nuevaConexion());
                    OdbcDataReader leer = Consulta.ExecuteReader();
                    MessageBox.Show("El estatus de la pelicula fue modificado a inactivo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                }
               
                cboNombre.Items.Clear();
                cargar(); 
                funcCargar();
            }
        }
        }
    }

