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
    public partial class frmModificarCine : Form
    {
        public frmModificarCine()
        {
            InitializeComponent();
            procDepartamento();
            procCine();
            procEstatus();
        }

        clsConexion cn = new clsConexion();
        clsValidacion validar = new clsValidacion();

        void procCine()
        {
            try
            {
                string Sala = "SELECT * FROM CINE";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                while (mostrarC.Read())
                {
                    cboCodigoCine.Items.Add(mostrarC.GetInt32(0));
                    cboCine.Items.Add(mostrarC.GetString(1));

                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }
        void procCargarCine()
        {
            try
            {
                string Sala = "SELECT * FROM CINE WHERE idCine ="+Int32.Parse(cboCodigoCine.SelectedItem.ToString());
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                while (mostrarC.Read())
                {
                    txtCine.Text = mostrarC.GetString(1);
                    txtDireccion.Text = mostrarC.GetString(3);
                    txtTiempo.Text = mostrarC.GetString(4);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

       void  procEstatus()
        {
            cboEstatus.Items.Add("Activo");
            cboEstatus.Items.Add("Inactivo");
        }

        void procDepartamento()
        {
            //en esta funcion buscar se seleccionaran las clasificacions de las peliculas y se mostraran en el cboClaficicacion
            try
            {
                string Sala = "SELECT * FROM DEPARTAMENTO";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                while (mostrarC.Read())
                {
                    cboCodigoD.Items.Add(mostrarC.GetInt32(0));
                    cboDepartamento.Items.Add(mostrarC.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        void procMunicipio()
        {

            try
            {
                string Municipio = "SELECT * FROM MUNICIPIO  WHERE idDepartamento= " + Int32.Parse(cboCodigoD.SelectedItem.ToString());
                OdbcCommand comm1 = new OdbcCommand(Municipio, cn.nuevaConexion());
                OdbcDataReader mostrarMun = comm1.ExecuteReader();
                while (mostrarMun.Read())
                {
                    cboCodigoM.Items.Add(mostrarMun.GetInt32(0));
                    cboMunicipio.Items.Add(mostrarMun.GetString(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);

            }
        }

       void procLimpiar()
        {
            cboCine.Items.Clear();
            cboCodigoCine.Items.Clear();
            cboMunicipio.Items.Clear();
            cboCodigoM.Items.Clear();
            cboCodigoD.Items.Clear();
            cboDepartamento.Items.Clear();
            txtCine.Text = "";
            txtDireccion.Text = "";
            txtTiempo.Text = "";
            cboEstatus.Items.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cboEstatus.SelectedItem == null || cboDepartamento.SelectedItem == null || cboMunicipio.SelectedItem == null || cboCine.SelectedItem == null || txtCine.Text == "" || txtDireccion.Text == "" || txtTiempo.Text == "")
            {
                MessageBox.Show("No debe dejar campos vacios o debe seleccionar el dato que desea modificar");
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

                    string Modificar = "UPDATE Cine SET  nombre = '" + txtCine.Text + "' ,idMunicipio = " + Int32.Parse(cboCodigoM.SelectedItem.ToString()) + " ,Direccion = '" + txtDireccion.Text + "',tiempoCompra = " + Int32.Parse(txtTiempo.Text.ToString()) + ",estatus = '" + Estatus + "'  WHERE idCine= " + Int32.Parse(cboCodigoCine.SelectedItem.ToString());
                    OdbcCommand Consulta = new OdbcCommand(Modificar, cn.nuevaConexion());
                    OdbcDataReader leer = Consulta.ExecuteReader();
                    MessageBox.Show("Los Datos se actualizaron correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                }
                procLimpiar();
                procDepartamento();
                procCine();
                procEstatus();
            }
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoM.Items.Clear();
            cboMunicipio.Items.Clear();
            cboCodigoD.SelectedIndex = cboDepartamento.SelectedIndex;
            procMunicipio();
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSoloNumeros(e);
        }

        private void cboCine_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoCine.SelectedIndex = cboCine.SelectedIndex;
            procCargarCine();
        }

        private void cboMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoM.SelectedIndex = cboMunicipio.SelectedIndex;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procDepartamento();
            procEstatus();
            procCine();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAgregado/Ayuda.chm", "ModificacionCines.html");
        }
    }
}
