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
    public partial class frmTelefono : Form
    {
        int numero = 0;
        int codigoA = 0;
        clsConexion cn = new clsConexion();
        public frmTelefono()
        {
            InitializeComponent();
            procCodigoA();
            procEmpleado();
        }

        void procCodigoA()
        {
            try
            //esta funcion hace un conteo de los datos que se encuentran en la tabla pelicula y almacena ese valor en la variable numero

            {
                string contador = "SELECT count(idTelefono) FROM TELEFONO ";
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

        void procEmpleado()
        {
            //en esta funcion buscar se seleccionaran las clasificacions de las peliculas y se mostraran en el cboClaficicacion
            try
            {
                string Sala = "SELECT * FROM EMPLEADO";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();

                while (mostrarC.Read())
                {
                    cboCodigoE.Items.Add(mostrarC.GetInt32(0));
                    cboEmpleado.Items.Add(mostrarC.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }
        void procLimpiar()
        {
            txtTelefono.Text = "";
            cboEmpleado.Items.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Este if verifica que no se deje ningun campo en blanco, si hay uno en blando muestra el mensaje de que se necesitan llenar los campos
            if (txtTelefono.Text == "" || cboEmpleado.SelectedItem == null || cboEstatus.SelectedItem == null)
            {
                MessageBox.Show("Necesita llegar todos los campos");
            }
            else
            {
                //en el string estatus guardo el estatus seleccinado en el cboEstado 
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
                    //se realiza la consulta de insertar en tabla pelicula con sus respectivos campos
                    string Insertar = "INSERT INTO telefono (idTelefono,telefono,idEmpleado,estatus) " +
                    "VALUES (" + codigoA + ",'" + txtTelefono.Text + "'," + Int32.Parse(cboCodigoE.SelectedItem.ToString()) + ",'" + Estatus + "')";
                    OdbcCommand comm = new OdbcCommand(Insertar, cn.nuevaConexion());
                    OdbcDataReader mostrarC = comm.ExecuteReader();
                    MessageBox.Show("Los datos se ingresaron correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
                //Adicion de bitacora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "Adición de teléfono a empleado";
                string tabla = "TELEFONO";
                bitacora.GuardarBitacora(proceso, tabla);
                //Limpieza
                procLimpiar();
                procCodigoA();
                procEmpleado();
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procEmpleado();
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoE.SelectedIndex = cboEmpleado.SelectedIndex;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarTelefono modificar = new frmModificarTelefono();
            modificar.ShowDialog();
        }
    }
}
