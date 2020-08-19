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
    public partial class frmModificarCorreo : Form
    {
        public frmModificarCorreo()
        {
            InitializeComponent();
            procEstatus();
            procEmpleado();
            
        }
        clsConexion cn = new clsConexion();
        void procLimpiar()
        {
            txtCorreo.Text = "";
            txtCorreoN.Text = "";
            cboEstatus.Items.Clear();
            cboEmpleadoN.Items.Clear();
            lblT.Text = "";
            lblE.Text = "";
            lblEs.Text = "";

        }
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
                    cboCodigoN.Items.Add(mostrarC.GetInt32(0));
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
        void procEstatus()
        {
            cboEstatus.Items.Add("Activo");
            cboEstatus.Items.Add("Inactivo");
        }

        void procEmpleados()
        {

        }
        void procDatosEmpleado()
        {
            //boton que modificara el correo del usuario segun el correo que este guardado en la base de datos
            if(txtCorreo.Text == "")
            {
                MessageBox.Show("Debe ingresar un correo");
            }else
            {
                try
                 {
                    String Correo = txtCorreo.Text.ToString();
                    String Cadena = "select * from correo c where c.correo ='"+txtCorreo.Text.ToString();
                string cadena = "select C.idCorreo, E.nombre,C.correo,C.estatus from empleado E, correo C where E.idEmpleado = C.idEmpleado and C.correo = "+txtCorreo.Text.ToString();
                OdbcDataAdapter datos = new OdbcDataAdapter(Cadena, cn.nuevaConexion());
                DataTable dt = new DataTable();
                datos.Fill(dt);
                dgtDatos.DataSource = dt;
                }
                catch (Exception ex)
                {
                MessageBox.Show("Correo" + ex);
                 }
            }
           
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            procDatosEmpleado();
        }

        private void dgtDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //boton para copiar los datos del dataGridView en labels correspondientes
            lblCodigoCorreo.Text = dgtDatos.CurrentRow.Cells[0].Value.ToString();
            lblT.Text = dgtDatos.CurrentRow.Cells[1].Value.ToString();
            lblE.Text = dgtDatos.CurrentRow.Cells[2].Value.ToString();
           
            lblEs.Text = dgtDatos.CurrentRow.Cells[3].Value.ToString();
        }

        private void cboCodigoN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //boton que modifica los Correos de la base de datos
            if (cboEstatus.SelectedItem == null || cboEmpleadoN.SelectedItem == null ||txtCorreoN.Text == "" || lblCodigoCorreo.Text == "")
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

                    string Modificar = "UPDATE CORREO SET  correo = '" + txtCorreo.Text + "' ,idEmpleado = " + cboCodigoN.SelectedItem + " ,estatus = '" + Estatus + "'  WHERE idTelefono= " + lblC.Text.ToString();
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
                procEstatus();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAdministracion/Ayuda.chm", "Modificar Correo.html");
        }
    }
}
