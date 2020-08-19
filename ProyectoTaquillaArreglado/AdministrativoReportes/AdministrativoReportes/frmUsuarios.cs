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
    public partial class frmUsuarios : Form
    {
        int numero = 0;
        int codigoA = 0;
        clsConexion cn = new clsConexion();
        public frmUsuarios()
        {
            InitializeComponent();
            procCodigoA();
            procEmpleado();
            procRol();
        }
        void procCodigoA()
        {
            try
            //esta funcion hace un conteo de los datos que se encuentran en la tabla pelicula y almacena ese valor en la variable numero

            {
                string contador = "SELECT count(idUsuario) FROM Usuario ";
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
                String nombre, apellido, nombreCompleto;
                while (mostrarC.Read())
                {
                    nombre = mostrarC.GetString(1);
                    apellido = mostrarC.GetString(2);
                    nombreCompleto = nombre + " " + apellido;
                    cboCodigoE.Items.Add(mostrarC.GetInt32(0));
                    cboEmpleado.Items.Add(nombreCompleto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        void procRol()
        {
            //en esta funcion buscar se seleccionaran las clasificacions de las peliculas y se mostraran en el cboClaficicacion
            try
            {
                string Sala = "SELECT * FROM ROL";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();

                while (mostrarC.Read())
                {
                    cboCodigoR.Items.Add(mostrarC.GetInt32(0));
                    cboRol.Items.Add(mostrarC.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        void procLimpiar()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtConfirmar.Text = "";
            cboEmpleado.Items.Clear();
            cboRol.Items.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Este if verifica que no se deje ningun campo en blanco, si hay uno en blando muestra el mensaje de que se necesitan llenar los campos
            if (txtUsuario.Text == "" || txtContraseña.Text == "" || txtConfirmar.Text == "" || cboEmpleado.SelectedItem == null || cboRol.SelectedItem == null )
            {
                MessageBox.Show("Necesita llegar todos los campos");
            }
            else
            {
                if (txtContraseña.Text == txtConfirmar.Text)

                {
                    //en el string estatus guardo el estatus seleccinado en el cboEstado 
                    String Estatus = "1";
                    
                    try
                    {
                        //se realiza la consulta de insertar en tabla pelicula con sus respectivos campos
                        string Insertar = "INSERT INTO USUARIO (idUsuario,idEmpleado,idRol,contrasenia,nombreUsuario,estatus) " +
                              "VALUES (" + codigoA + ","+Int32.Parse(cboCodigoE.SelectedItem.ToString())+ ", "+Int32.Parse(cboCodigoR.SelectedItem.ToString()) + " ,'"+txtConfirmar.Text+"','"+txtUsuario.Text+"','" + Estatus + "')";
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
                    string proceso = "Ingreso de usuarios";
                    string tabla = "USUARIO";
                    bitacora.GuardarBitacora(proceso, tabla);
                    //Limpieza
                    /*  txtRol.Text = "";
                      procCargarRol();*/
                    procLimpiar();
                    procRol();
                    procEmpleado();
                    procCodigoA();
                }else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            

            }
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoE.SelectedIndex = cboEmpleado.SelectedIndex;

        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoR.SelectedIndex = cboRol.SelectedIndex;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procRol();
            procEmpleado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarUsuario usuario = new frmModificarUsuario();
            usuario.ShowDialog();
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {

        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            frmRol rol = new frmRol();
            rol.ShowDialog();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAdministracion/Ayuda.chm", "Ingreso Usuario.html");
        }
    }
}
