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
    public partial class frmPuesto : Form
    {
        int numero = 0;
        int codigoA = 0;
        String uno = "1";
        clsConexion cn = new clsConexion();
        clsValidacion validar = new clsValidacion();
        public frmPuesto()
        {
            InitializeComponent();
            procCodigoA();
            procCargarPuesto();
        }
        void procCodigoA()
        {
            try
            //esta funcion hace un conteo de los datos que se encuentran en la tabla pelicula y almacena ese valor en la variable numero

            {
                string contador = "SELECT count(idPuesto) FROM PUESTO ";
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
        void procCargarPuesto()
        {
            //Muestra los datos de la tabla pelicula en el dataGridView llamada dgtDatos
            try
            {
                string cadena = "SELECT * FROM PUESTO WHERE estatus = '" + uno + "' ";
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
        private void frmPuesto_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Este if verifica que no se deje ningun campo en blanco, si hay uno en blando muestra el mensaje de que se necesitan llenar los campos
            if (txtPuesto.Text == ""  || txtSueldo.Text == "")
            {
                MessageBox.Show("Necesita llegar todos los campos");
            }
            else
            {
                //en el string estatus guardo el estatus seleccinado en el cboEstado 
                String Estatus = "1";
                
                try
                {
                    //se realiza la consulta de insertar en tabla pelicula con sus respectivos campos
                    string Insertar = "INSERT INTO Puesto (idPuesto,nombre,sueldo,estatus) " +
                          "VALUES (" + codigoA + ",'" + txtPuesto.Text + "', " + double.Parse(txtSueldo.Text.ToString()) + ",'" + Estatus + "')";
                    OdbcCommand comm = new OdbcCommand(Insertar, cn.nuevaConexion());
                    OdbcDataReader mostrarC = comm.ExecuteReader();
                    MessageBox.Show("Los datos se ingresaron correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
                //Adición de bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "Ingreso de puesto";
                string tabla = "INSERT INTO Puesto (idPuesto,nombre,sueldo,estatus) VALUES (" + codigoA.ToString() + "," + txtPuesto.Text.ToString() + ", " + txtSueldo.Text.ToString() + "," + Estatus.ToString() + ")";
                bitacora.GuardarBitacora(proceso, tabla);
                //Limpieaza
                procLimpiar();
                procCodigoA();
                procCargarPuesto();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procCargarPuesto();
        }

       void procLimpiar()
        {
            txtPuesto.Text = "";
            txtSueldo.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarPuesto puesto = new frmModificarPuesto();
            puesto.ShowDialog();
        }

        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSoloLetras(e);
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSueldo(e);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAdministracion/Ayuda.chm", "Ingreso Puesto.html");
        }
    }
}
