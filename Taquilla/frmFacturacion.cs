using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Windows.Forms;

namespace Taquilla
{
    public partial class frmFacturacion : Form
    {
        int tiempo, idProyeccionPelicula, idSala, idCine;
        List<clsBoletos> infoBoletosComprados = new List<clsBoletos>();
        List<clsBoletos> infoAsientosElegidos = new List<clsBoletos>();
        clsConexion cn = new clsConexion();
        public frmFacturacion(List<clsBoletos>infoBoletos, List<clsBoletos> infoAsientos, int sala, int cine, int proyeccion)
        {
            InitializeComponent();
            idSala = sala;
            idCine = cine;
            idProyeccionPelicula = proyeccion;
            infoBoletosComprados = infoBoletos;
            infoAsientosElegidos = infoAsientos;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtNoTarjeta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(procEsEmailValido(txtCorreo.Text).ToString());
            if (lblApellidoCliente.Text != "")
            {
                if (chkPago.Checked)
                {
                    int codigoEnc = 1;
                    try
                    {
                        string consulta = "SELECT MAX(IDFACTURAENCABEZADO) FROM FACTURAENCABEZADO ";
                        OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                        OdbcDataReader codFacturaEnc = comm.ExecuteReader();
                        if (codFacturaEnc.Read())
                        {
                            codigoEnc = codFacturaEnc.GetInt32(0) + 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    DateTime fechaActual = DateTime.Now;
                    try
                    {
                        string insertarEncabezado = "INSERT INTO FACTURAENCABEZADO (IDFACTURAENCABEZADO,SERIE,FECHA,NITCLIENTE,TOTAL,DESCUENTO,IDPROYECCIONPELICULA,ESTATUS) " +
                            "VALUES(" + codigoEnc + ",'" + "BGCLC-"+codigoEnc + "',?," + int.Parse(txtNit.Text.ToString()) + "," + decimal.Parse(lblCantTotal.Text.ToString()) + "," + decimal.Parse(lblCantDescuento.Text.ToString()) + "," + idProyeccionPelicula + "," + 1 + ")";
                        OdbcCommand comm = new OdbcCommand(insertarEncabezado, cn.Conexion());
                        comm.Parameters.Add("@FECHA", OdbcType.DateTime).Value = fechaActual;
                        comm.ExecuteNonQuery();
                        for (int i = 0; i < infoBoletosComprados.Count; i++)
                        {
                            try
                            {
                                string insertarDetalle = "INSERT INTO FACTURADETALLE (IDBOLETO,IDFACTURAENCABEZADO,CANTIDAD) " +
                                    "VALUES ( " + infoBoletosComprados.ElementAt(i).idBoletos + ", " + codigoEnc + "," + infoBoletosComprados.ElementAt(i).cantidadBoletos + ")";
                                OdbcCommand comm2 = new OdbcCommand(insertarDetalle, cn.Conexion());
                                comm2.ExecuteNonQuery();
                            }
                            catch (Exception ex2)
                            {
                                MessageBox.Show(ex2.ToString());
                            }
                        }
                        for (int i = 0; i < infoAsientosElegidos.Count; i++)
                        {
                            try
                            {
                                string insertarAsiento = "INSERT INTO ASIENTOVENDIDO (FILA,NUMERO,IDFACTURAENCABEZADO) " +
                                    "VALUES ( " + infoAsientosElegidos.ElementAt(i).cantidadBoletos + ", " + infoAsientosElegidos.ElementAt(i).idBoletos + "," + codigoEnc + ")";
                                OdbcCommand comm2 = new OdbcCommand(insertarAsiento, cn.Conexion());
                                comm2.ExecuteNonQuery();
                            }
                            catch (Exception ex3)
                            {
                                MessageBox.Show(ex3.ToString());
                            }
                        }
                        procCorreoConfirmacion("Compra");
                        MessageBox.Show("Compra exitosa, recibirá un correo de confirmación.", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    int codigoEnc=1;
                    try
                    {
                        string consulta = "SELECT MAX(IDRESERVACIONENCABEZADO) FROM RESERVACIONENCABEZADO ";
                        OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                        OdbcDataReader codResEnc = comm.ExecuteReader();
                        if (codResEnc.Read())
                        {
                            codigoEnc = codResEnc.GetInt32(0)+1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    DateTime fechaActual = DateTime.Now;
                    try
                    {
                        string insertarEncabezado = "INSERT INTO RESERVACIONENCABEZADO (IDRESERVACIONENCABEZADO,FECHA,NITCLIENTE,TOTAL,DESCUENTO,IDPROYECCIONPELICULA,ESTATUS) " +
                            "VALUES(?,?,?,?,?,?,?)";
                        OdbcCommand comm = new OdbcCommand(insertarEncabezado, cn.Conexion());
                        comm.Parameters.Add("@IDRESERVACIONENCABEZADO", OdbcType.Int).Value = codigoEnc;
                        comm.Parameters.Add("@FECHA", OdbcType.DateTime).Value = fechaActual;
                        comm.Parameters.Add("@NITCLIENTE", OdbcType.Int).Value = int.Parse(txtNit.Text.ToString());
                        comm.Parameters.Add("@TOTAL", OdbcType.Decimal).Value = decimal.Parse(lblCantTotal.Text.ToString());
                        comm.Parameters.Add("@DESCUENTO", OdbcType.Decimal).Value = decimal.Parse(lblCantDescuento.Text.ToString());
                        comm.Parameters.Add("@IDPROYECCIONPELICULA", OdbcType.Int).Value = idProyeccionPelicula;
                        comm.Parameters.Add("@ESTATUS", OdbcType.TinyInt).Value = 1;
                        OdbcDataReader insEnc = comm.ExecuteReader();
                        for (int i = 0; i < infoBoletosComprados.Count; i++)
                        {
                            try
                            {
                                string insertarDetalle = "INSERT INTO RESERVACIONDETALLE (IDBOLETO,IDRESERVACIONENCABEZADO,CANTIDAD) " +
                                   "VALUES ( " + infoBoletosComprados.ElementAt(i).idBoletos + ", " + codigoEnc + "," + infoBoletosComprados.ElementAt(i).cantidadBoletos + ")";
                                OdbcCommand comm2 = new OdbcCommand(insertarDetalle, cn.Conexion());
                                insEnc = comm2.ExecuteReader();
                            }
                            catch (Exception ex2)
                            {
                                MessageBox.Show(ex2.ToString());
                            }
                        }
                        for (int i = 0; i < infoAsientosElegidos.Count; i++)
                        {
                            try
                            {
                                string insertarAsiento = "INSERT INTO ASIENTORESERVADO (FILA,NUMERO,IDRESERVACIONENCABEZADO) " +
                                   "VALUES ( " + infoAsientosElegidos.ElementAt(i).cantidadBoletos + ", " + infoAsientosElegidos.ElementAt(i).idBoletos + "," + codigoEnc + ")";
                                OdbcCommand comm2 = new OdbcCommand(insertarAsiento, cn.Conexion());
                                insEnc = comm2.ExecuteReader();
                            }
                            catch (Exception ex3)
                            {
                                MessageBox.Show(ex3.ToString());
                            }
                        }
                        procCorreoConfirmacion("Reserva");
                        MessageBox.Show("Reservación exitosa, recibirá un correo de confirmación.","ÉXITO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe de ingresar un cliente para los datos de facturación","FALTA DE DATOS",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void procCorreoConfirmacion(string tipo)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(lblCorreoCliente.Text.ToString());
            msg.Subject = "Confirmación de " + tipo;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Bcc.Add("bryanorlando-98@hotmail.com"); //copia del correo
            string asientos="Asientos: <br/>";
            for (int i = 0; i < infoBoletosComprados.Count; i++)
            {
                asientos += "       Fila: " + infoAsientosElegidos.ElementAt(i).idBoletos.ToString() + " Columna:" + infoAsientosElegidos.ElementAt(i).cantidadBoletos.ToString() + " <br/>";
            }
            msg.Body = "Sus datos de " + tipo + " son: <br/><br/> DATOS PERSONALES <br/><br/> Nombre: " + lblNombreCliente.Text.ToString() + " <br/>" +
                "Apellido: " + lblApellidoCliente.Text.ToString()+ "<br/><br/> DATOS ELEGIDOS <br/><br/> Pelicula: "+ lblNombrePelicula.Text.ToString()+ "<br/> Día:" +
                " "+lblDiaFuncion.Text.ToString() + "<br/> Hora: "+lblHoraFuncion.Text.ToString()+ "<br/> Sala: "+lblNoSala.Text.ToString()+ "<br/> " + asientos+ "<br/> " +
                "Descuento Realizado: " + lblCantDescuento.Text.ToString()+ "<br/> " +
                "Total: "+lblCantTotal.Text.ToString()+ "<br/> Puntos Obtenidos: " + lblCantPuntos.Text.ToString();
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("grupo3sistemaso1@gmail.com");

            //CREACION DEL CLIENTE DE CORREO
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("grupo3sistemaso1@gmail.com", "s1stema$2");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com"; //Servidor de salida de GMAIL
            try
            {
                cliente.Send(msg);
            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR AL ENVIAR CORREO" + error.ToString());
            }
        }

        bool procEsEmailValido(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void txtNoTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
                
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    string consulta = "SELECT C.NOMBRECLIENTETARJETA, C.APELLIDOCLIENTETARJETA, CO.CORREO, T.NOTARJETA FROM CLIENTE C, CORREOCLIENTE CO, TARJETA T WHERE C.NITCLIENTE= " + int.Parse(txtNit.Text.ToString());
                    OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                    OdbcDataReader datosCliente = comm.ExecuteReader();
                    if (datosCliente.Read())
                    {
                        lblNombreCliente.Text = datosCliente.GetString(0);
                        lblApellidoCliente.Text = datosCliente.GetString(1);
                        lblCorreoCliente.Text = datosCliente.GetString(2);
                        lblTarjetaCliente.Text = datosCliente.GetString(3);

                    }
                    else
                    {
                        MessageBox.Show("El NIT ingresado no fue encontrado", "NIT NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void pnlDatosDetalles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkPago_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPago.Checked)
            {
                
                frmPagoTarjeta tarjeta = new frmPagoTarjeta();
                tarjeta.lblCantTiempoRestante.Text = lblCantTiempoRestante.Text.ToString();
                tiempo=tiempo+2;
                this.Hide();
                tarjeta.ShowDialog();
                this.Show();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("\t           Cerrando...\n\n\tSeguro que desea cerrar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            tiempo = int.Parse(lblCantTiempoRestante.Text.ToString());
            tmrTiempo.Enabled = true;
            procObtenerDescuento();
            lblCantPuntos.Text = (double.Parse(lblCantTotal.Text.ToString()) * 0.30).ToString();
        }

        private void procObtenerDescuento()
        {
            DateTime fechaActual = DateTime.Today;
            for(int i=0; i<infoBoletosComprados.Count; i++)
            {
                try
                {
                    string consulta = "SELECT P.CANTIDADDESCUENTO,P.FECHAINICIO, P.FECHAFINAL, B.PRECIO FROM PROMOCION P, BOLETO B WHERE B.IDBOLETO=P.IDBOLETO AND B.IDBOLETO= " + infoBoletosComprados.ElementAt(i).idBoletos.ToString();
                    OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                    OdbcDataReader asientosOcupados = comm.ExecuteReader();
                    if (asientosOcupados.Read())
                    {
                        
                        if (DateTime.Compare(fechaActual, asientosOcupados.GetDateTime(1)) > 0 && DateTime.Compare(fechaActual, asientosOcupados.GetDateTime(2)) < 0)
                        {
                            double total = asientosOcupados.GetDouble(3) * infoBoletosComprados.ElementAt(i).cantidadBoletos;
                            lblCantDescuento.Text = (total * asientosOcupados.GetDouble(0)).ToString();
                            lblCantTotal.Text = (double.Parse(lblCantSubTotal.Text.ToString())- double.Parse(lblCantDescuento.Text.ToString())).ToString();
                        }
                        
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void tmrTiempoCompra_Tick(object sender, EventArgs e)
        {
            tiempo--;
            lblCantTiempoRestante.Text = tiempo.ToString();
            frmPagoTarjeta tarjeta = new frmPagoTarjeta();
            
            if (tiempo == 0)
            {
                tmrTiempo.Stop();
                this.Close();
                this.Dispose();
            }
            
        }
    }
}
