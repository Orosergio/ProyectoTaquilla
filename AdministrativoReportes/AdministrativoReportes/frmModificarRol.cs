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
    public partial class frmModificarRol : Form
    {
        clsConexion cn = new clsConexion();
      
        public frmModificarRol()
        {
            InitializeComponent();
            procBuscarRoles();
            procCargarRol();
            procEstatus();
        }
        void procEstatus()
        {
            cboEstatus.Items.Add("Activo");
            cboEstatus.Items.Add("Inactivo");
        }
        void procBuscarRoles()
        {
            //en esta funcion buscar se seleccionaran las clasificacions de las peliculas y se mostraran en el cboClaficicacion
            try
            {
                string Sala = "SELECT * FROM ROL";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();

                while (mostrarC.Read())
                {
                    cboCodigoRol.Items.Add(mostrarC.GetInt32(0));
                    cboRol.Items.Add(mostrarC.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }
        void procCargarRol()
        {
            //Muestra los datos de la tabla pelicula en el dataGridView llamada dgtDatos
            try
            {
                string cadena = "SELECT * FROM ROL  ";
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
        private void frmModificarRol_Load(object sender, EventArgs e)
        {

        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoRol.SelectedIndex = cboRol.SelectedIndex;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //boton que modifica los roles que hay en la base de datos
           if(cboRol.SelectedItem == null || cboEstatus.SelectedItem == null || txtRol.Text == "")
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
                  
                    string Modificar = "UPDATE ROL SET nombre = '" + txtRol.Text + "' , estatus = '" + Estatus + "'  WHERE idRol=" + Int32.Parse(cboCodigoRol.SelectedItem.ToString());
                    OdbcCommand Consulta = new OdbcCommand(Modificar, cn.nuevaConexion());
                    OdbcDataReader leer = Consulta.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                }
                //Adición de bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "Modificación de rol";
                string tabla = "UPDATE ROL SET nombre = " + txtRol.Text.ToString() + ", estatus = " + Estatus.ToString() + " WHERE idRol =" + cboCodigoRol.SelectedItem.ToString();
                bitacora.GuardarBitacora(proceso, tabla);
                //Limpieaza
                procLimpiar();
                procBuscarRoles();
                procCargarRol();
                procEstatus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procBuscarRoles();
            procEstatus();
        }

        void procLimpiar()
        {
            cboRol.Items.Clear();
            txtRol.Text = "";
            cboEstatus.Items.Clear();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAdministracion/Ayuda.chm", "Modificar Rol.html");
        }
    }
}
