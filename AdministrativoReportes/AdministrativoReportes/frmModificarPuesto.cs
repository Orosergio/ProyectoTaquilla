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
    public partial class frmModificarPuesto : Form
    {
        clsConexion cn = new clsConexion();
        public frmModificarPuesto()
        {
            InitializeComponent();
            procBuscarPuesto();
            procCargarPuesto();
        }
        void procBuscarPuesto()
        {
            //funcion para buscar los puestos guardados en la base de datos
            try
            {
                string Sala = "SELECT * FROM PUESTO";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();

                while (mostrarC.Read())
                {
                    cboCodigoPuesto.Items.Add(mostrarC.GetInt32(0));
                    cboPuesto.Items.Add(mostrarC.GetString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        void procCargarPuesto()
        {
            //Muestra los datos de la tabla pelicula en el dataGridView llamada dgtDatos
            try
            {
                string cadena = "SELECT * FROM PUESTO  ";
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //en este boton me muestra el sueldo y el puesto en los txt que se le solicitan
            if (cboPuesto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un puesto primero");
            }
            else
            {
                try
                {
                    string Pelicula = "SELECT * FROM PUESTO WHERE idPuesto = " + Int32.Parse(cboCodigoPuesto.SelectedItem.ToString());
                    OdbcCommand com5 = new OdbcCommand(Pelicula, cn.nuevaConexion());
                    OdbcDataReader mostrarDatos = com5.ExecuteReader();

                    while (mostrarDatos.Read())
                    {
                        txtSueldo.Text = mostrarDatos.GetString(1);
                        txtPuesto.Text = mostrarDatos.GetString(2);
                       
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                }
            }
        }

        private void cboPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoPuesto.SelectedIndex = cboPuesto.SelectedIndex;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //boton para modificar los datos de la base de datos, o para modificar los puestos
            if(txtPuesto.Text == "" || txtSueldo.Text == "" || cboEstatus.SelectedItem == null)
            { 
                MessageBox.Show("No debe dejar campos vacios");
            }
            else
            {
                String Estatus;
                Estatus = cboEstatus.SelectedItem.ToString();
                if (Estatus == "Activo")
                {
                    Estatus = "1";
                }
                else if (Estatus == "Inactivo")
                {
                    Estatus = "0";
                }
 
                try
                {
                    string Modificar = "UPDATE PUESTO SET nombre = '" + txtPuesto.Text + "' , sueldo  = '" + txtSueldo.Text + "', estatus = " + Estatus + "  WHERE idPuesto=" + cboCodigoPuesto.SelectedItem;
                    OdbcCommand Consulta = new OdbcCommand(Modificar, cn.nuevaConexion());
                    OdbcDataReader leer = Consulta.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                }
                //Adición de bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "Modificación de puesto";
                string tabla = "PUESTO";
                bitacora.GuardarBitacora(proceso, tabla);
                //Limpieaza
                procLimpiar();
                procCargarPuesto();
            }
        }

        void procLimpiar()
        {  
            cboPuesto.Items.Clear();
            txtPuesto.Text = "";
            txtSueldo.Text = "";
         
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procBuscarPuesto();
        }

        private void frmModificarPuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
