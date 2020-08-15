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
    public partial class frmEmpleado : Form
    {
        clsConexion cn = new clsConexion();
        int numero = 0;
        int codigoA =  0;
        public frmEmpleado()
        {
            InitializeComponent();
            procCodigoA();
            procPuesto();
        }
        void procCodigoA()
        {
            try
            //esta funcion hace un conteo de los datos que se encuentran en la tabla pelicula y almacena ese valor en la variable numero

            {
                string contador = "SELECT count(idEmpleado) FROM EMPLEADO ";
                OdbcCommand comando = new OdbcCommand(contador, cn.nuevaConexion());
                numero = Convert.ToInt32(comando.ExecuteScalar());
                //si numero = 0, no encuentra ningun registro convierte el cidigoA en 1 y envia ese codigo para guardado como ID
                if (numero == 0)
                {
                    codigoA = 1;
                }
                else
                {
                    //de lo contrario se ira incrementando + 1 codigoA
                    codigoA = numero + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

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
                    cboCodigoPuesto.Items.Add(mostrarC.GetInt32(0));
                    cboPuesto.Items.Add(mostrarC.GetString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        void procLimpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cboPuesto.Items.Clear();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Este if verifica que no se deje ningun campo en blanco, si hay uno en blando muestra el mensaje de que se necesitan llenar los campos
            if(txtNombre.Text == "" || txtApellido.Text == "" || cboPuesto.SelectedItem ==  null || cboEstatus.SelectedItem == null)
            { 
                MessageBox.Show("Necesita llegar todos los campos");
            }
            else
            {
                //en el string estatus guardo el estatus seleccinado en el cboEstado 
                String Estatus, fechaContratacion,fechaNacimiento;
                Estatus = cboEstatus.SelectedItem.ToString();
                if (Estatus == "Activo")
                {
                    Estatus = "1";
                }
                else if (Estatus == "Inactivo")
                {
                    Estatus = "0";
                }
                //Fecha obtiene la fecha seleccionada en el dptFecha y le coloca un formato
                fechaContratacion = dtpContratacion.Value.ToString("yyyy-MM-dd");
                fechaNacimiento = dtpNacimiento.Value.ToString("yyyy-MM-dd");

                try
                {
                    //se realiza la consulta de insertar en tabla pelicula con sus respectivos campos
                    string Insertar = "INSERT INTO EMPLEADO (idEmpleado,nombre,apellido,idPuesto,fechaContratacion,fechaNacimiento,estatus) " +
                    "VALUES (" + codigoA + ",'" + txtNombre.Text + "','" + txtApellido.Text + "'," + Int32.Parse(cboCodigoPuesto.SelectedItem.ToString()) + ",'" + fechaContratacion + "','" + fechaNacimiento + "','" + Estatus + "')";
                    OdbcCommand comm = new OdbcCommand(Insertar, cn.nuevaConexion());
                    OdbcDataReader mostrarC = comm.ExecuteReader();
                    MessageBox.Show("Los datos se ingresaron correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
                procLimpiar();
                procPuesto();
                procCodigoA();
                /*funcCargar();
                funcBuscar();
                funcCodigoA();*/
            }
        }

        private void cboPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoPuesto.SelectedIndex = cboPuesto.SelectedIndex;
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            frmCorreo correo = new frmCorreo();
            correo.ShowDialog();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            frmVerEmpleados empleados = new frmVerEmpleados();
            empleados.ShowDialog();
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            frmTelefono empleados = new frmTelefono();
            empleados.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarEmpleado empleados = new frmModificarEmpleado();
            empleados.ShowDialog();
        }
    }
}
