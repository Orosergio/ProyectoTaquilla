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
    public partial class frmModificarUsuario : Form
    {
        public frmModificarUsuario()
        {
            InitializeComponent();
            procEmpleado();
            procRol();
            procUsuario();
        }
        clsConexion cn = new clsConexion();

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
                    nombreCompleto = nombre +" "+apellido;
                    cboCoEmp.Items.Add(mostrarC.GetInt32(0));
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
        void procUsuario()
        {
            //en esta funcion buscar se seleccionaran las clasificacions de las peliculas y se mostraran en el cboClaficicacion
            try
            {
                string Sala = "SELECT * FROM USUARIO";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();

                while (mostrarC.Read())
                {
                    cboCodigoU.Items.Add(mostrarC.GetInt32(0));
                    cboUsuario.Items.Add(mostrarC.GetString(4));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //busca los datos del usuario y los muestra en los DataGridView
            if (cboUsuario.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un correo");
            }
            else
            {
                try
                {
                    string cadena = "select  U.idUsuario AS CODIGO,U.nombreUsuario AS USUARIO ,R.nombre AS ROL,E.nombre AS NOMBRE,E.apellido AS APELLIDO,U.estatus AS ESTATUS FROM USUARIO U,EMPLEADO E,ROL R WHERE E.idEmpleado = U.idEmpleado AND R.idRol = U.idRol AND idUsuario = " + Int32.Parse(cboCodigoU.SelectedItem.ToString());
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
        //funcion para limpiar los elementos del form
        void procLimpiar()
        {
            lblE.Text = "";
            lblR.Text = "";
            lblU.Text = "";
            lblC.Text = "";
            lblEstatusC.Text = "";
            lblCodigoA.Text = "";
            txtContraseñaCon.Text = "";
            txtContraseña.Text = "";
            txtUsuario.Text = "";
            cboEmpleado.Items.Clear();
            cboRol.Items.Clear();
            cboUsuario.Items.Clear();
            dgtDatos.DataSource = null;
        }

        private void dgtDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //funcion que copia los elementos del dataGridView en los labels
            lblCodigoA.Text = dgtDatos.CurrentRow.Cells[0].Value.ToString();
            String nombre, apellido, nombreCompleto;
            nombre = dgtDatos.CurrentRow.Cells[3].Value.ToString();
            apellido = dgtDatos.CurrentRow.Cells[4].Value.ToString(); ;
            nombreCompleto = nombre + " " + apellido;
            lblE.Text = nombreCompleto;
            lblR.Text = dgtDatos.CurrentRow.Cells[2].Value.ToString();
            lblU.Text = dgtDatos.CurrentRow.Cells[1].Value.ToString();
          //  lblC.Text = dgtDatos.CurrentRow.Cells[3].Value.ToString();
            lblEstatusC.Text = dgtDatos.CurrentRow.Cells[5].Value.ToString();
           
        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoU.SelectedIndex = cboUsuario.SelectedIndex;
            dgtDatos.DataSource = "";
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCoEmp.SelectedIndex = cboEmpleado.SelectedIndex;
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoR.SelectedIndex = cboRol.SelectedIndex;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //boton que modifica los datos de usuario
            if (txtUsuario.Text == "" || txtContraseña.Text == "" || txtContraseñaCon.Text == "" || cboEstatus.SelectedItem == null || cboRol.SelectedItem == null || cboEmpleado.SelectedItem == null || lblCodigoA.Text == "")
            {
                MessageBox.Show("No debe dejar campos vacios o debe seleccionar un dato el cual desea modificar");
            }
            else
            {
                if(txtContraseña.Text == txtContraseñaCon.Text)
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
                        string Modificar = "UPDATE USUARIO SET idEmpleado = '" + cboCoEmp.SelectedItem + "' , idRol  = '" + cboCodigoR.SelectedItem + "', contrasenia = '" + txtContraseñaCon.Text + "', nombreUsuario = '" + txtUsuario.Text + "',estatus = " + Estatus + "  WHERE idUsuario=" +Int32.Parse(cboCodigoU.SelectedItem.ToString()); ;
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
                    string proceso = "Modificación de usuarios";
                    string tabla = "USUARIO";
                    bitacora.GuardarBitacora(proceso, tabla);
                    //Limpieza
                    procLimpiar();
                    procRol();
                    procEmpleado();
                    procUsuario();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                
            }
        }

        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
