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
    public partial class frmModificacionDescuentos : Form
    {
        public frmModificacionDescuentos()
        {
            InitializeComponent();
            procCargarDescuentos();
            procBoleto();
            procEstatus();
        }
        clsConexion cn = new clsConexion();
        String fechaI, fechaF;
        clsValidacion validar = new clsValidacion();
        void procEstatus()
        {
            cboEstatus.Items.Add("Activo");
            cboEstatus.Items.Add("Inactivo");
        }
        void procLimpiar()
        {
            lblCantidadA.Text = "";
            lblD.Text = "";
            lblC.Text = "";
            lblFI.Text = "";
            lblFF.Text = "";
            lblE.Text = "";
            lblNBoleto.Text = "";
            lblCodigoA.Text = "";
            lblCodigoBoleto.Text = "";
            txtDescuento.Text = "";
            txtPromocion.Text = "";
            cboCodigoB.Items.Clear();
            cboBoleto.Items.Clear();
            cboCodigoBN.Items.Clear();
            cboNombreB.Items.Clear();
            cboFormato.Items.Clear();
            cboCodigoF.Items.Clear();
            cboEstatus.Items.Clear();
            dgtDatos.DataSource = null;
             
                
        }
        void procCodiBoleto()
        {
            try
            {
                string Sala = "SELECT b.idBoleto from boleto b,formato f,tipoboleto T where f.idFormato = b.idFormato and t.idTipoBoleto = b.idTipoBoleto and T.idTipoBoleto = " + Int32.Parse(cboCodigoBN.SelectedItem.ToString()) + " and f.idFormato = " + Int32.Parse(cboCodigoF.SelectedItem.ToString());
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
                    cboCodigoBN.Items.Add(mostrarC.GetInt32(0));
                    cboNombreB.Items.Add(mostrarC.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }
        void procCargarDescuentos()
        {
            try
            {
                string Sala = "SELECT * FROM PROMOCION";
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
        void procCargardgtDatos()
        {
            
            dgtDatos.DataSource = null;
            lblD.Text = "";
            lblC.Text = "";
            lblFI.Text = "";
            lblFF.Text = "";
            lblE.Text = "";
            lblCodigoA.Text = "";
            
            try
            {

                string cadena = "  select p.idPromocion AS CODIGO,p.NombrePromocion AS PROMOCION,p.CantidadDescuento AS CANTIDAD ,p.fechaInicio AS INICIO,p.fechaFinal AS FINAL,t.nombre AS BOLETO,p.estatus AS ESTATUS from boleto b,promocion p, tipoboleto t where b.idBoleto = p.idBoleto and t.idTipoBoleto = b.idTipoBoleto and p.idPromocion = " + Int32.Parse(cboCodigoB.SelectedItem.ToString()) + " ";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.nuevaConexion());
                DataTable dt = new DataTable();
                datos.Fill(dt);
                dgtDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }
        private void cboBoleto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoB.SelectedIndex = cboBoleto.SelectedIndex;
            procCargardgtDatos();
        }

        private void dgtDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoA.Text = dgtDatos.CurrentRow.Cells[0].Value.ToString();
            lblD.Text = dgtDatos.CurrentRow.Cells[1].Value.ToString();
            lblC.Text = dgtDatos.CurrentRow.Cells[2].Value.ToString();
            lblFI.Text = dgtDatos.CurrentRow.Cells[3].Value.ToString();
            lblFF.Text = dgtDatos.CurrentRow.Cells[4].Value.ToString();
            lblNBoleto.Text = dgtDatos.CurrentRow.Cells[5].Value.ToString();
            lblE.Text = dgtDatos.CurrentRow.Cells[6].Value.ToString();
            
            txtPromocion.Text = dgtDatos.CurrentRow.Cells[1].Value.ToString();
            txtDescuento.Text = dgtDatos.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboNombreB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboFormato.Items.Clear();
            cboCodigoF.Items.Clear();
            lblCodigoBoleto.Text = "";
            cboCodigoBN.SelectedIndex = cboNombreB.SelectedIndex;
            try
            {
                string Sala = "SELECT f.idFormato,f.nombre from boleto b,formato f,tipoboleto T where f.idFormato = b.idFormato and t.idTipoBoleto = b.idTipoBoleto and T.idTipoBoleto = " + Int32.Parse(cboCodigoBN.SelectedItem.ToString());
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
            cboCodigoF.SelectedIndex = cboFormato.SelectedIndex ;
            procCodiBoleto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procBoleto();
            procEstatus();
            procCargarDescuentos();
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSueldo(e);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAgregado/AyudaAgregado.chm", "ModificarDescuentos.html");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Este if verifica que no se deje ningun campo en blanco, si hay uno en blando muestra el mensaje de que se necesitan llenar los campos
            if (lblCodigoA.Text == "" || txtPromocion.Text == "" || txtDescuento.Text == "" || cboBoleto.SelectedItem == null || cboFormato.SelectedItem == null || cboEstatus.SelectedItem == null)
            {
                MessageBox.Show("Necesita llegar todos los campos o necesita seleccionar un dato de la tabla");
            }
            else
            {
                //en el string estatus guardo el estatus seleccinado en el cboEstado 
                String Estatus = cboEstatus.SelectedItem.ToString();
                if (Estatus == "Activo")
                {
                    Estatus = "1";
                }
                else if (Estatus == "Inactivo")
                {
                    Estatus = "0";
                }
                if (dtpInicio.Value.Date < DateTime.Now.Date || dtpFinal.Value.Date < DateTime.Now.Date || dtpInicio.Value.Date >= dtpFinal.Value.Date )
                {
                    MessageBox.Show("La fecha de inicio no puede ser menor a la de Hoy o la fecha de finalizacion no puede se menor a la de hoy");
                }
                else
                {
                    fechaI = dtpInicio.Value.ToString("yyyy-MM-dd HH:MM");
                    fechaF = dtpFinal.Value.ToString("yyyy-MM-dd HH:MM");
                    try
                    {
                        //se realiza la consulta de insertar en tabla pelicula con sus respectivos campos
                        string Insertar = "UPDATE PROMOCION SET NombrePromocion = '" +txtPromocion.Text + "' , CantidadDescuento = " + double.Parse(txtDescuento.Text.ToString())+", fechaInicio = '"+fechaI+"', fechaFinal = '" + fechaF + "', idBoleto = " + Int32.Parse(lblCodigoBoleto.Text.ToString())+ ", estatus = '" + Estatus + "'  WHERE idPromocion = " + Int32.Parse(lblCodigoA.Text.ToString())+" "; 
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
                     string proceso = "Modificación de descuentos";
                     string tabla = "UPDATE PROMOCION SET NombrePromocion = " + txtPromocion.Text.ToString() + ", CantidadDescuento = " + txtDescuento.Text.ToString() + ", fechaInicio = " + fechaI.ToString() + ", fechaFinal = " + fechaF.ToString() + ", idBoleto = " + lblCodigoBoleto.Text.ToString() + ", estatus = " + Estatus.ToString() + "  WHERE idPromocion = " + lblCodigoA.Text.ToString() + " ";
                    bitacora.GuardarBitacora(proceso, tabla);
                    //Limpieza
                    procLimpiar();
                    procEstatus();
                    procBoleto();
                    procCargarDescuentos();

                }
            }
        }
    }
}
