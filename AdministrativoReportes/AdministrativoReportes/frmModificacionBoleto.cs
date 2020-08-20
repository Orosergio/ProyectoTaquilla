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
    public partial class frmModificacionBoleto : Form
    {
        public frmModificacionBoleto()
        {
            InitializeComponent();
            procBoleto();
        }
        clsConexion cn = new clsConexion();
        clsValidacion validacion = new clsValidacion();

        void procLimpiar()
        {
            cboCodigoB.Items.Clear();
            cboBoleto.Items.Clear();
            cboCodigoF.Items.Clear();
            cboFormato.Items.Clear();
            txtPrecio.Text = "";
            lblCodigoBoleto.Text = "";
        }

        void procCodiBoleto()
        {
            try
            {
                string Sala = "SELECT b.idBoleto from boleto b,formato f,tipoboleto T where f.idFormato = b.idFormato and t.idTipoBoleto = b.idTipoBoleto and T.idTipoBoleto = " + Int32.Parse(cboCodigoB.SelectedItem.ToString()) + " and f.idFormato = " + Int32.Parse(cboCodigoF.SelectedItem.ToString());
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();

                while (mostrarC.Read())
                {
                    lblCodigoBoleto.Text = mostrarC.GetString(0);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        void procPrecio()
        {
            try
            {
                string Sala = "SELECT precio FROM BOLETO WHERE idBoleto="+Int32.Parse(lblCodigoBoleto.Text.ToString());
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();

                while (mostrarC.Read())
                {
                    txtPrecio.Text = (mostrarC.GetString(0));
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }


        void procBoleto()
        {

            //en esta funcion buscar se seleccionaran los boletos
            try
            {
                string Sala = "SELECT * FROM TIPOBOLETO";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();

                while (mostrarC.Read())
                {
                    cboCodigoB.Items.Add(mostrarC.GetInt32(0));
                    cboBoleto.Items.Add(mostrarC.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cboBoleto.SelectedItem == null || cboFormato.SelectedItem == null || txtPrecio.Text == "" || lblCodigoBoleto.Text == "")
            {
                MessageBox.Show("No debe dejar campos vacios o debe seleccionar un el dato que desea modificar");
            }
            else
            {   
                try
                {

                    string Modificar = "UPDATE BOLETO SET  idTipoBoleto = " + Int32.Parse(cboCodigoB.SelectedItem.ToString()) + " ,precio = " + Int32.Parse(txtPrecio.Text.ToString()) + ",idFormato = " + Int32.Parse(cboCodigoF.SelectedItem.ToString()) + "   WHERE idBoleto= " + Int32.Parse(lblCodigoBoleto.Text.ToString());
                    OdbcCommand Consulta = new OdbcCommand(Modificar, cn.nuevaConexion());
                    OdbcDataReader leer = Consulta.ExecuteReader();
                    MessageBox.Show("Los Datos se actualizaron correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                }
                //IMPLEMENTACIÓN DE BITÁCORA
                clsBitacora bitacora = new clsBitacora();
                string proceso = "Modificación de boletos";
                string tabla = "UPDATE BOLETO SET idTipoBoleto = " + cboCodigoB.SelectedItem.ToString() + ",precio = " + txtPrecio.Text.ToString() + ",idFormato = " + cboCodigoF.SelectedItem.ToString() + " WHERE idBoleto= " + lblCodigoBoleto.Text.ToString()+"";
                bitacora.GuardarBitacora(proceso, tabla);
                //LIMPIEZA
                procLimpiar();
                procBoleto();
             ///   procEstatus();
            }
        }

        private void cboBoleto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecio.Text = "";
            cboFormato.Items.Clear();
            cboCodigoF.Items.Clear();
            lblCodigoBoleto.Text = "";
            cboCodigoB.SelectedIndex = cboBoleto.SelectedIndex;
            try
            {
                string Sala = "SELECT f.idFormato,f.nombre from boleto b,formato f,tipoboleto T where f.idFormato = b.idFormato and t.idTipoBoleto = b.idTipoBoleto and T.idTipoBoleto = " + Int32.Parse(cboCodigoB.SelectedItem.ToString());
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();

                while (mostrarC.Read())
                {
                    cboCodigoF.Items.Add(mostrarC.GetInt32(0));
                    cboFormato.Items.Add(mostrarC.GetString(1));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        private void cboFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoF.SelectedIndex = cboFormato.SelectedIndex;
            procCodiBoleto();
            procPrecio();

        }

        private void frmModificacionBoleto_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procBoleto();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.funcSueldo(e);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAgregado/AyudaAgregado.chm", "Boleto.html");
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
