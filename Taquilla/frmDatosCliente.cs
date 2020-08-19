using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Windows.Forms;

namespace Taquilla
{
    public partial class frmDatosCliente : Form
    {
        int tiempo, idProyeccionPelicula, idSala, idCine;
        List<clsBoletos> infoBoletosComprados = new List<clsBoletos>();
        List<clsBoletos> infoAsientosElegidos = new List<clsBoletos>();
        clsConexion cn = new clsConexion();
        //esto sirve para que el form de facturación pueda recibir los datos enviados por el form de boletos.
        public frmDatosCliente(List<clsBoletos> infoBoletos, List<clsBoletos> infoAsientos, int sala, int cine, int proyeccion)
        {
            InitializeComponent();
            //se copian las variables recibidas a variables globales
            idSala = sala;
            idCine = cine;
            idProyeccionPelicula = proyeccion;
            infoBoletosComprados = infoBoletos;
            infoAsientosElegidos = infoAsientos;
        }



        private void btnPagar_Click(object sender, EventArgs e)
        {
            //si hay datos del cliente
            if (lblApellidoCliente.Text != "")
            {
                //si el pago esta elegido
                if (chkPago.Checked)
                {
                    int codigoEnc = 1;
                    try
                    {
                        //consulta para obtener el codigo máximo en la tabla de factura encabezado
                        string consulta = "SELECT MAX(IDFACTURAENCABEZADO) FROM FACTURAENCABEZADO ";
                        OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                        OdbcDataReader codFacturaEnc = comm.ExecuteReader();
                        if (codFacturaEnc.Read())
                        {
                            //se suma 1 al código obtenido
                            codigoEnc = codFacturaEnc.GetInt32(0) + 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    //se obtiene la fecha y hora actual del sistema
                    DateTime fechaActual = DateTime.Now;
                    try
                    {
                        //consulta para insertar los datos en la tabla de factura encabezado
                        string insertarEncabezado = "INSERT INTO FACTURAENCABEZADO (IDFACTURAENCABEZADO,SERIE,FECHA,NITCLIENTE,TOTAL,DESCUENTO,IDPROYECCIONPELICULA,ESTATUS) " +
                            "VALUES(" + codigoEnc + ",'" + "BGCLC-" + codigoEnc + "',?," + txtNit.Text.ToString() + "," + decimal.Parse(lblCantTotal.Text.ToString()) + "," + decimal.Parse(lblCantDescuento.Text.ToString()) + "," + idProyeccionPelicula + "," + 1 + ")";
                        OdbcCommand comm = new OdbcCommand(insertarEncabezado, cn.Conexion());
                        comm.Parameters.Add("@FECHA", OdbcType.DateTime).Value = fechaActual;
                        comm.ExecuteNonQuery();
                        //se recorre la lista de boletos para que se guarden
                        for (int i = 0; i < infoBoletosComprados.Count; i++)
                        {
                            try
                            {
                                //consulta para guardar los detalles en factura detalle
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
                        //se recorre la lista de asientos para que se guarden
                        for (int i = 0; i < infoAsientosElegidos.Count; i++)
                        {
                            try
                            {
                                //consulta para guardar los asientos en factura asientovendido
                                string insertarAsiento = "INSERT INTO ASIENTOVENDIDO (FILA,NUMERO,IDFACTURAENCABEZADO) " +
                                    "VALUES ( " + infoAsientosElegidos.ElementAt(i).idBoletos + ", " + infoAsientosElegidos.ElementAt(i).cantidadBoletos + "," + codigoEnc + ")";
                                OdbcCommand comm2 = new OdbcCommand(insertarAsiento, cn.Conexion());
                                comm2.ExecuteNonQuery();
                            }
                            catch (Exception ex3)
                            {
                                MessageBox.Show(ex3.ToString());
                            }
                        }
                        //se llama el proceso de enviar correo y se manda como parámetro que es una compra.
                        procCorreoConfirmacion("Compra");
                        if ((MessageBox.Show("Compra exitosa, recibirá un correo de confirmación.", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)) == DialogResult.OK)
                        {
                            Application.Restart();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    int codigoEnc = 1;
                    try
                    {
                        //consulta para obtener el codigo máximo en la tabla de reservación encabezado
                        string consulta = "SELECT MAX(IDRESERVACIONENCABEZADO) FROM RESERVACIONENCABEZADO ";
                        OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                        OdbcDataReader codResEnc = comm.ExecuteReader();
                        if (codResEnc.Read())
                        {
                            codigoEnc = codResEnc.GetInt32(0) + 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    //se obtiene la fecha y hora actual del sistema
                    DateTime fechaActual = DateTime.Now;
                    try
                    {
                        //consulta para insertar los datos en la tabla de reservación encabezado
                        string insertarEncabezado = "INSERT INTO RESERVACIONENCABEZADO (IDRESERVACIONENCABEZADO,FECHA,NITCLIENTE,TOTAL,DESCUENTO,IDPROYECCIONPELICULA,ESTATUS) " +
                            "VALUES(" + codigoEnc + ",?," + txtNit.Text.ToString() + "," + decimal.Parse(lblCantTotal.Text.ToString()) + "," + decimal.Parse(lblCantDescuento.Text.ToString()) + "," + idProyeccionPelicula + "," + 1 + ")";
                        OdbcCommand comm = new OdbcCommand(insertarEncabezado, cn.Conexion());
                        comm.Parameters.Add("@FECHA", OdbcType.DateTime).Value = fechaActual;
                        comm.ExecuteNonQuery();
                        //se recorre la lista de boletos para que se guarden
                        for (int i = 0; i < infoBoletosComprados.Count; i++)
                        {
                            try
                            {
                                //consulta para guardar los detalles en reservación detalle
                                string insertarDetalle = "INSERT INTO RESERVACIONDETALLE (IDBOLETO,IDRESERVACIONENCABEZADO,CANTIDAD) " +
                                   "VALUES ( " + infoBoletosComprados.ElementAt(i).idBoletos + ", " + codigoEnc + "," + infoBoletosComprados.ElementAt(i).cantidadBoletos + ")";
                                OdbcCommand comm2 = new OdbcCommand(insertarDetalle, cn.Conexion());
                                comm2.ExecuteReader();
                            }
                            catch (Exception ex2)
                            {
                                MessageBox.Show(ex2.ToString());
                            }
                        }
                        //se recorre la lista de asientos para que se guarden
                        for (int i = 0; i < infoAsientosElegidos.Count; i++)
                        {
                            try
                            {
                                //consulta para guardar los asientos en factura asientoreservado
                                string insertarAsiento = "INSERT INTO ASIENTORESERVADO (FILA,NUMERO,IDRESERVACIONENCABEZADO) " +
                                   "VALUES ( " + infoAsientosElegidos.ElementAt(i).idBoletos + ", " + infoAsientosElegidos.ElementAt(i).cantidadBoletos + "," + codigoEnc + ")";
                                OdbcCommand comm2 = new OdbcCommand(insertarAsiento, cn.Conexion());
                                comm2.ExecuteReader();
                            }
                            catch (Exception ex3)
                            {
                                MessageBox.Show(ex3.ToString());
                            }
                        }
                        //se llama el proceso de enviar correo y se manda como parámetro que es una reserva.
                        procCorreoConfirmacion("Reserva");
                        if ((MessageBox.Show("Reservación exitosa, recibirá un correo de confirmación.", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information)) == DialogResult.OK)
                        {
                            Application.Restart();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe de ingresar un cliente", "FALTA DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //proceso de enviar correo al cliente
        public void procCorreoConfirmacion(string tipo)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            //se agrega el destinatario
            msg.To.Add(lblCorreoCliente.Text.ToString());
            //se agrega el asunto del mensaje
            msg.Subject = "Confirmación de " + tipo;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            //copia del correo
            msg.Bcc.Add("bryanorlando-98@hotmail.com");
            string asientos = "Asientos: <br/>";
            //recorre la lista de asientos elegidos y los concatena en un string
            for (int i = 0; i < infoAsientosElegidos.Count; i++)
            {
                asientos += "       Fila: " + infoAsientosElegidos.ElementAt(i).idBoletos.ToString() + " Columna:" + infoAsientosElegidos.ElementAt(i).cantidadBoletos.ToString() + " <br/>";
            }
            //se guarda en un mensaje todos los datos que se van a enviar al cliente
            msg.Body = "Sus datos de " + tipo + " son: <br/><br/> DATOS PERSONALES <br/><br/> Nombre: " + lblNombreCliente.Text.ToString() + " <br/>" +
                "Apellido: " + lblApellidoCliente.Text.ToString() + "<br/><br/> DATOS ELEGIDOS <br/><br/> Pelicula: " + lblNombrePelicula.Text.ToString() + "<br/> Día:" +
                " " + lblDiaFuncion.Text.ToString() + "<br/> Hora: " + lblHoraFuncion.Text.ToString() + "<br/> Sala: " + lblNoSala.Text.ToString() + "<br/> " + asientos + "<br/> " +
                "Descuento Realizado: " + lblCantDescuento.Text.ToString() + "<br/> " +
                "Total: " + lblCantTotal.Text.ToString() + "<br/> Puntos Obtenidos: " + lblCantPuntos.Text.ToString();
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
                //se envía el correo
                cliente.Send(msg);
            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR AL ENVIAR CORREO" + error.ToString());
            }
        }


        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //si presiona la tecla enter busca el nit ingresado
            if (e.KeyChar == 13)
            {
                try
                {
                    //consulta para buscar los datos del nit ingresado 
                    string consulta = "SELECT C.NOMBRECLIENTETARJETA, C.APELLIDOCLIENTETARJETA, CO.CORREO, T.NOTARJETA FROM CLIENTE C, CORREOCLIENTE CO, TARJETA T WHERE C.NITCLIENTE= '" + txtNit.Text.ToString() + "'";
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
                        //no encontro el nit ingresado
                        MessageBox.Show("El NIT ingresado no fue encontrado", "NIT NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //regresa al form anterior
            this.Close();
            this.Dispose();
        }

        private void chkPago_CheckedChanged(object sender, EventArgs e)
        {
            //si se marca el pago
            if (chkPago.Checked)
            {
                //muestra el form de tarjeta para ingresar datos   
                frmPagoTarjeta tarjeta = new frmPagoTarjeta();
                tarjeta.lblCantTiempoRestante.Text = lblCantTiempoRestante.Text.ToString();
                btnPagar.Text = "Facturar";
                tiempo = tiempo + 2;
                this.Hide();
                tarjeta.ShowDialog();
                this.Show();
            }
        }

        //pregunta al usuario si quiere cerrar cuando se presione la x, si si se cierra, de lo contrario no
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("\t           Cerrando...\n\n\tSeguro que desea cerrar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void btnDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {

        }

        private void picAgregarCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente agregar = new frmAgregarCliente();
            agregar.lblCantTiempoRestante.Text = lblCantTiempoRestante.Text.ToString();
            tiempo = tiempo + 2;
            this.Hide();
            agregar.ShowDialog();
            this.Show();
        }

        private void picAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayuda/AyudaTaquilla.chm", "DatosCliente.html");
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            tiempo = int.Parse(lblCantTiempoRestante.Text.ToString());
            //se activa la cuenta de tiempo
            tmrTiempo.Enabled = true;
            //se llama el procediemiento de obtener el decuento
            procObtenerDescuento();
            //se muestran los puntos obtenidos
            lblCantPuntos.Text = (double.Parse(lblCantTotal.Text.ToString()) * 0.30).ToString();
        }

        //procedimiento para obtener el descuento
        private void procObtenerDescuento()
        {
            //se obtiene la fecha y tiemmpo actual
            DateTime fechaActual = DateTime.Now;
            //ciclo para buscar las promociones de los distintos tipos de boletos
            for (int i = 0; i < infoBoletosComprados.Count; i++)
            {
                try
                {
                    //se obtienen los datos para calcular el descuento si tiene
                    string consulta = "SELECT P.CANTIDADDESCUENTO,P.FECHAINICIO, P.FECHAFINAL, B.PRECIO FROM PROMOCION P, BOLETO B WHERE B.IDBOLETO=P.IDBOLETO AND B.IDBOLETO= " + infoBoletosComprados.ElementAt(i).idBoletos.ToString();
                    OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                    OdbcDataReader asientosOcupados = comm.ExecuteReader();
                    if (asientosOcupados.Read())
                    {
                        //si se encuentra se busca que la fecha actual esté entre el rango de la promoción
                        if (DateTime.Compare(fechaActual, asientosOcupados.GetDateTime(1)) > 0 && DateTime.Compare(fechaActual, asientosOcupados.GetDateTime(2)) < 0)
                        {
                            //si si está dentro del rango se calcula el descuento
                            double total = asientosOcupados.GetDouble(3) * infoBoletosComprados.ElementAt(i).cantidadBoletos;
                            lblCantDescuento.Text = (total * asientosOcupados.GetDouble(0)).ToString();
                            lblCantTotal.Text = (double.Parse(lblCantSubTotal.Text.ToString()) - double.Parse(lblCantDescuento.Text.ToString())).ToString();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //por cada segundo que pase se resta el tiempo y se muestra
        private void tmrTiempoCompra_Tick(object sender, EventArgs e)
        {
            tiempo--;
            lblCantTiempoRestante.Text = tiempo.ToString();
            //si el tiempo es 0 este form se cierra
            if (tiempo == 0)
            {
                tmrTiempo.Stop();
                this.Close();
                this.Dispose();
            }

        }
    }
}
