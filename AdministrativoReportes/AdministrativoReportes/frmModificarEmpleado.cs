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
    public partial class frmModificarEmpleado : Form
    {
        clsValidacion validar = new clsValidacion();
        public frmModificarEmpleado()
        {
            InitializeComponent();
            procPuesto();
            procEmpleado();
            procEstatus();
        }
        clsConexion cn = new clsConexion();
        void procPuesto()
        {
            //en esta funcion buscar se seleccionaran las clasificacions de las peliculas y se mostraran en el cboClaficicacion
            try
            {
                string Sala = "SELECT * FROM PUESTO";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();

                while (mostrarC.Read())
                {
                    cboCodigoPnuevo.Items.Add(mostrarC.GetInt32(0));
                    cboPuestoN.Items.Add(mostrarC.GetString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
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
                    Nombre = mostrarC.GetString(1);
                    Apellido = mostrarC.GetString(2);
                    nombreCompleto = Nombre+" "+Apellido;
                    cboCodigoE.Items.Add(mostrarC.GetInt32(0));
                    cboNombre.Items.Add(nombreCompleto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoE.SelectedIndex = cboNombre.SelectedIndex;
            dgtDatos.DataSource = null;
            try
            {
                string cadena = "select E.idEmpleado AS CODIGO ,E.nombre AS NOMBRE ,E.apellido AS APELLIDO ,P.nombre AS PUESTO,E.fechaContratacion AS CONTRATACION ,E.fechaNacimiento AS NACIMIENTO,E.estatus AS ESTATUS FROM  puesto P, empleado E WHERE P.idPuesto = E.idPuesto AND idEmpleado = " + Int32.Parse(cboCodigoE.SelectedItem.ToString());
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.nuevaConexion());
                DataTable dt = new DataTable();
                datos.Fill(dt);
                dgtDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Correo" + ex);
            }
        
       
    }

        private void cboPuestoN_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoPnuevo.SelectedIndex =  cboPuestoN.SelectedIndex ;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //boton que muestra que datos se quieren mostrar en el dataGridView
                if (cboNombre.SelectedItem == null)
                {
                    MessageBox.Show("Debe ingresar un Empleado");
                }
                else
                {
                lblA.Text = "";
                lblN.Text = "";
                lblP.Text = "";
                lblCa.Text = "";
                lblEs.Text = "";
                lblNA.Text = "";
                try
                    {
                        string cadena = "select E.idEmpleado AS CODIGO ,E.nombre AS NOMBRE ,E.apellido AS APELLIDO ,P.nombre AS PUESTO,E.fechaContratacion AS CONTRATACION ,E.fechaNacimiento AS NACIMIENTO,E.estatus AS ESTATUS FROM  puesto P, empleado E WHERE P.idPuesto = E.idPuesto AND idEmpleado = "+Int32.Parse(cboCodigoE.SelectedItem.ToString());
                        OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.nuevaConexion());
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

        void procLimpiar()
        {
            txtNombreN.Text = "";
            txtApellidoN.Text = "";
            txtCodigo.Text = "";
            cboNombre.Items.Clear();
            cboPuestoN.Items.Clear();
            lblA.Text = "";
            lblN.Text = "";
            lblP.Text = "";
            lblCa.Text = "";
            lblEs.Text = "";
            lblNA.Text = "";
            dgtDatos.DataSource = null;
            cboEstatus.Items.Clear();
        }

        private void dgtDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoA.Text = dgtDatos.CurrentRow.Cells[0].Value.ToString();
            lblN.Text = dgtDatos.CurrentRow.Cells[1].Value.ToString();
            lblA.Text = dgtDatos.CurrentRow.Cells[2].Value.ToString();
            lblP.Text = dgtDatos.CurrentRow.Cells[3].Value.ToString();
            lblCa.Text = dgtDatos.CurrentRow.Cells[4].Value.ToString();
            lblNA.Text = dgtDatos.CurrentRow.Cells[5].Value.ToString();
            lblEs.Text = dgtDatos.CurrentRow.Cells[6].Value.ToString();

        }

        void procEstatus()
        {
            cboEstatus.Items.Add("Activo");
            cboEstatus.Items.Add("Inactivo");
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lblCodigoA.Text == "" || txtNombreN.Text == "" || txtApellidoN.Text == "" || cboEstatus.SelectedItem == null || cboPuestoN.SelectedItem == null)
            {
                MessageBox.Show("No debe dejar campos vacios o debe seleccionar el dato que desea modificar");
            }
            else
            {
                String Estatus, Fecha1, Fecha2;
                Estatus = cboEstatus.SelectedItem.ToString();
                if (Estatus == "Activo")
                {
                    Estatus = "1";
                }
                else if (Estatus == "Inactivo")
                {
                    Estatus = "0";
                }
                if (dtpContratacionN.Value.Date > DateTime.Now.Date || dtpNacimientoN.Value.Date >= DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha de contratacion no puede ser mayor a la de hoy o la fecha de nacimiento no puede ser mayor a la de hoy");
                }
                else
                {
                  
                    Fecha1 = dtpContratacionN.Value.ToString("yyyy-MM-dd");
                    Fecha2 = dtpNacimientoN.Value.ToString("yyyy-MM-dd");
                    try
                    {
                        string Modificar = "UPDATE EMPLEADO SET nombre = '" + txtNombreN.Text + "' , apellido  = '" + txtApellidoN.Text + "', idPuesto = " + Int32.Parse(cboCodigoPnuevo.SelectedItem.ToString()) + ",fechaContratacion = '" + Fecha1 + "',fechaNacimiento = '" + Fecha2 + "',estatus = " + Estatus + "  WHERE idEmpleado= '"+ Int32.Parse(lblCodigoA.Text.ToString())+"' ";
                        OdbcCommand Consulta = new OdbcCommand(Modificar, cn.nuevaConexion());
                        OdbcDataReader leer = Consulta.ExecuteReader();
                        MessageBox.Show("Los Datos se guardaron correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                    }
                    //Adicion de bitacora
                    clsBitacora bitacora = new clsBitacora();
                    string proceso = "Modificación de empleados";
                    string tabla = "UPDATE EMPLEADO SET nombre = " + txtNombreN.Text.ToString() + ", apellido  = " + txtApellidoN.Text.ToString() + ", idPuesto = " + cboCodigoPnuevo.SelectedItem.ToString() + ",fechaContratacion = " + Fecha1.ToString() + ",fechaNacimiento = " + Fecha2.ToString() + ",estatus = " + Estatus.ToString() + " WHERE idEmpleado= " + lblCodigoA.Text.ToString() + "";
                    bitacora.GuardarBitacora(proceso, tabla);
                    //Limpieza
                    procLimpiar();
                    procPuesto();
                    procEmpleado();
                    procEstatus();
                }
            }
        }

        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreN_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSoloLetras(e);
        }

        private void txtApellidoN_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSoloLetras(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procPuesto();
            procEmpleado();
            procEstatus();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAdministracion/Ayuda.chm", "Modificar Empleado.html");
        }
    }
}
