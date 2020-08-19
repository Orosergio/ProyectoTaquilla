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
    public partial class frmEliminarPelicula : Form
    {
        String uno = "1";
        public frmEliminarPelicula()
        {
            InitializeComponent();
             procCargarDatos();
             procCargar();
        }
        clsConexion cn = new clsConexion();

        //funcion para cargar los datos de la pelicula en el dataGridView segun el estatus
        void procCargarDatos()
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
        void procCargar()
        {
            //funcion que carga datos de la tabla pelicula en comboBox
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
            //funcion para actualizar datos en la base de datos
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
                clsBitacora bitacora = new clsBitacora();
                string proceso = "Inactivación de película";
                string tabla = "PELICULA";
                bitacora.GuardarBitacora(proceso, tabla);
                cboNombre.Items.Clear();
                procCargar(); 
                procCargarDatos();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAdministracion/Ayuda.chm", "Eliminacion Pelicula.html");
        }
    }
    }

