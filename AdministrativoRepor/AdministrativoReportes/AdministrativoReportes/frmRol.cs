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
    public partial class frmRol : Form
    {
        clsConexion cn = new clsConexion();
        int numero = 0;
        int codigoA = 0;
        String uno = "1";
        public frmRol()
        {
            InitializeComponent();
            procCodigoA();
            procCargarRol();
         
        }
        void procCodigoA()
        {
            try
            //esta funcion hace un conteo de los datos que se encuentran en la tabla pelicula y almacena ese valor en la variable numero

            {
                string contador = "SELECT count(idRol) FROM ROL ";
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmRol_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Este if verifica que no se deje ningun campo en blanco, si hay uno en blando muestra el mensaje de que se necesitan llenar los campos
            if(txtRol.Text == "" || cboEstatus.SelectedItem == null)
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
                    string Insertar = "INSERT INTO ROL (idRol,nombre,estatus) " +
                          "VALUES (" + codigoA + ",'" + txtRol.Text + "', '"+Estatus+"')";
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
                string proceso = "Adición de rol";
                string tabla = "ROL";
                bitacora.GuardarBitacora(proceso, tabla);
                //Limpieaza
                txtRol.Text = "";
                procCargarRol();
                procCodigoA();
            }
        }

        void procCargarRol()
        {
            //Muestra los datos de la tabla pelicula en el dataGridView llamada dgtDatos
            try
            {
                string cadena = "SELECT * FROM ROL WHERE estatus = '" + uno + "' ";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtRol.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarRol rol = new frmModificarRol();
            rol.ShowDialog();
        }
    }
}
