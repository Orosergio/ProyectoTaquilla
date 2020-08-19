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
    public partial class frmPromocion : Form
    {
        public frmPromocion()
        {
            InitializeComponent();
            procBoleto();
            procCodigoA();
        }
        int numero  = 0;
        int codigoA = 0;
        clsValidacion validar = new clsValidacion();
        clsConexion cn = new clsConexion();
        String fechaI, fechaF;

        void procLimpiar()
        {
            txtDescuento.Text = "";
            txtPromocion.Text = "";
            cboCodigoB.Items.Clear();
            cboBoleto.Items.Clear();
            cboCodigoF.Items.Clear();
            cboFormato.Items.Clear();
            lblCodigoBoleto.Text = "";
        }
        void procCodiBoleto()
        {
            try
            {
                string Sala = "SELECT b.idBoleto from boleto b,formato f,tipoboleto T where f.idFormato = b.idFormato and t.idTipoBoleto = b.idTipoBoleto and T.idTipoBoleto = " + Int32.Parse(cboCodigoB.SelectedItem.ToString())+" and f.idFormato = "+ Int32.Parse(cboCodigoF.SelectedItem.ToString());
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
                    cboCodigoB.Items.Add(mostrarC.GetInt32(0));
                    cboBoleto.Items.Add(mostrarC.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }

        void procCodigoA()
        {
            try
            //esta funcion hace un conteo de los datos que se encuentran en la tabla pelicula y almacena ese valor en la variable numero

            {
                string contador = "SELECT count(idPromocion) FROM PROMOCION ";
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

        private void cboBoleto_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procBoleto();
        }

        private void cboFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoF.SelectedIndex = cboFormato.SelectedIndex;
            procCodiBoleto();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificacionDescuentos descuento = new frmModificacionDescuentos();
            descuento.ShowDialog();
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSueldo(e);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,"AyudaAgregado/Ayuda.chm","IngresoDescuentos.html");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Este if verifica que no se deje ningun campo en blanco, si hay uno en blando muestra el mensaje de que se necesitan llenar los campos
            if (txtPromocion.Text == "" || txtDescuento.Text == "" || cboBoleto.SelectedItem == null ||  cboFormato.SelectedItem == null)
            {
                MessageBox.Show("Necesita llegar todos los campos");
            }
            else
            {
                //en el string estatus guardo el estatus seleccinado en el cboEstado 
                String Estatus = "1";
                if(dtpInicio.Value.Date < DateTime.Now.Date || dtpFinal.Value.Date < DateTime.Now.Date || dtpInicio.Value.Date >= dtpFinal.Value.Date )
                {
                    MessageBox.Show("Fechas no validas");
                }else
                {
                fechaI = dtpInicio.Value.ToString("yyyy-MM-dd HH:MM");
                fechaF = dtpFinal.Value.ToString("yyyy-MM-dd HH:MM");
                try
                {
                    //se realiza la consulta de insertar en tabla pelicula con sus respectivos campos
                    string Insertar = "INSERT INTO PROMOCION (idPromocion,NombrePromocion,CantidadDescuento,fechaInicio,fechaFinal,idBoleto,estatus) " +
                    "VALUES (" + codigoA + ",'" + txtPromocion.Text + "','"+txtDescuento.Text+"','" + fechaI + "','" + fechaF + "',"+Int32.Parse(lblCodigoBoleto.Text.ToString())+",'" + Estatus + "')";
                    OdbcCommand comm = new OdbcCommand(Insertar, cn.nuevaConexion());
                    OdbcDataReader mostrarC = comm.ExecuteReader();
                    MessageBox.Show("Los datos se ingresaron correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
                //Adicion de bitacora
               /* clsBitacora bitacora = new clsBitacora();
                string proceso = "Adición de teléfono a empleado";
                string tabla = "TELEFONO";
                bitacora.GuardarBitacora(proceso, tabla);*/
                //Limpieza
                procLimpiar();
                procCodigoA();
                procBoleto();

            }
                }
              
        }
    }
}
