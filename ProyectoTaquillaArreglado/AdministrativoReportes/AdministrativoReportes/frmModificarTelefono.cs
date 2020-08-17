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
    public partial class frmModificarTelefono : Form
    {
        public frmModificarTelefono()
        {
            InitializeComponent();
            procEmpleado();
        }
        clsConexion cn = new clsConexion();
        clsValidacion telefono = new clsValidacion();
        void procEmpleado()
        {
            //en esta funcion buscar se seleccionaran las clasificacions de las peliculas y se mostraran en el cboClaficicacion
            try
            {
                string Sala = "SELECT * FROM EMPLEADO";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                string Nombre, Apellido, nombreCompleto;
               
                while (mostrarC.Read())
                {
                    cboCodigoE.Items.Add(mostrarC.GetInt32(0));
                    Nombre = mostrarC.GetString(1);
                    Apellido = mostrarC.GetString(2);
                    nombreCompleto = Nombre + " " + Apellido;
                    cboEmpleadoN.Items.Add(nombreCompleto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        void procDatosEmpleado()
        {
            lblC.Text = "";
            lblT.Text = "";
            lblE.Text = "";
            lblEs.Text = "";
            //funcion que busca los los datos del empleado segun e telefono lo que se solicita en la consulta
            try
                {
                    string cadena = "select t.idTelefono, E.nombre,T.telefono,T.estatus from empleado E, telefono T WHERE E.idEmpleado = T.idEmpleado and telefono = " + txtTelefono.Text;
                    OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.nuevaConexion());
                    DataTable dt = new DataTable();
                    datos.Fill(dt);
                    dgtDatos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //se llama a la funcion que busca los datos y verifica que el txt no este vacio 
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe escribir un numero de telefono");
            }
            else
            {

                procDatosEmpleado();
            }
        }

        private void dgtDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //copia los datos del DataGridView en los labels
            lblC.Text = dgtDatos.CurrentRow.Cells[0].Value.ToString();
            lblE.Text = dgtDatos.CurrentRow.Cells[1].Value.ToString();
            lblT.Text = dgtDatos.CurrentRow.Cells[2].Value.ToString();
            lblEs.Text = dgtDatos.CurrentRow.Cells[3].Value.ToString();
          
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //boton que modifica los telefonos de la base de datos
            if (cboEstatus.SelectedItem == null || cboEmpleadoN.SelectedItem ==  null || txtTelefonoN.Text == "" || lblC.Text == "")
            {
                MessageBox.Show("No debe dejar campos vacios o debe seleccionar un el dato que desea modificar");
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

                    string Modificar = "UPDATE TELEFONO SET  telefono = '" + txtTelefonoN.Text + "' ,idEmpleado = " + cboCodigoE.SelectedItem + " ,estatus = '" + Estatus + "'  WHERE idTelefono=" + lblC.Text;
                    OdbcCommand Consulta = new OdbcCommand(Modificar, cn.nuevaConexion());
                    OdbcDataReader leer = Consulta.ExecuteReader();
                    MessageBox.Show("Los Datos se actualizaron correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                }
               procLimpiar();
               procEmpleado();
            }
        }
        //funcion para limpiar los elementos de la base de datos
        void procLimpiar()
        {
            lblC.Text = "";
            lblT.Text = "";
            lblE.Text = "";
            lblEs.Text = "";
            txtTelefonoN.Text = "";
            txtTelefono.Text = "";
            cboEmpleadoN.Items.Clear();
            dgtDatos.DataSource = null;
        }

        private void cboEmpleadoN_SelectedIndexChanged(object sender, EventArgs e)
        {
           cboCodigoE.SelectedIndex =  cboEmpleadoN.SelectedIndex;
        }

        private void frmModificarTelefono_Load(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            telefono.funcTelefono(e);
        }

        private void txtTelefonoN_KeyPress(object sender, KeyPressEventArgs e)
        {
            telefono.funcTelefono(e);
        }
    }
}
