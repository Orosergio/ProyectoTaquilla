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

namespace Taquilla
{
    public partial class frmAgregarCliente : Form
    {
        clsConexion cn = new clsConexion();
        int tiempo = 0;
        public frmAgregarCliente()
        {
            InitializeComponent();
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //cerrar esta ventana
            tmrTiempo.Stop();
            this.Close();
            this.Dispose();
        }

        private void picAyuda_Click(object sender, EventArgs e)
        {
            //mostrar la ayuda de la ventana
            Help.ShowHelp(this, "Ayuda/AyudaTaquilla.chm", "AgregarCliente.html");
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //llama al procedimiento de solo letras
            procSoloLetras(e);
        }

        //procedimiento que permite solo escribir letras
        private void procSoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Space) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //llama al procedimiento de solo letras
            procSoloLetras(e);
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //revisa que puede ingresar numeros y k o K
            if (Char.IsDigit(e.KeyChar) || e.KeyChar==(char)Keys.K || e.KeyChar==107)
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void picTarjeta_Click(object sender, EventArgs e)
        {
            //manda a la llamar la funcion booleana para saber si el nit ingresado es valido
            if (funcRevisarNit())
            {
                //revisa que no hayan campos vacios
                if (txtNombre.Text.ToString() == "")
                {
                    MessageBox.Show("Falta ingresar el campo de nombre", "LLENAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtApellido.Text.ToString() == "")
                {
                    MessageBox.Show("Falta ingresar el campo de apellido", "LLENAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtCorreo.Text.ToString() == "")
                {
                    MessageBox.Show("Falta ingresar el campo de correo", "LLENAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        //consulta para buscar los datos del nit ingresado 
                        string consulta = "SELECT NITCLIENTE FROM CLIENTE WHERE NITCLIENTE= '" + txtNit.Text.ToString() + "'";
                        OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                        OdbcDataReader datosCliente = comm.ExecuteReader();
                        if (datosCliente.Read())
                        {
                            MessageBox.Show("El NIT ingresado ya existe", "NIT ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            
                            // si no encontro el nit en los guardados, se genera un numero de tarjeta para el cliente
                            if (procEsEmailValido(txtCorreo.Text.ToString()))
                            {
                                lblTarjetaOriginada.Text =(char)txtNombre.Text.ToString()[0] + (char)txtApellido.Text.ToString()[0] + txtNit.Text.Substring(2,2)+ txtNit.Text.Substring(4,2)+ txtNit.Text.Substring(0, 2);
                            }
                            else
                            {
                                MessageBox.Show("El correo ingresado no es válido", "CORREO NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            
        }

        private bool funcRevisarNit()
        {
            //revisa que el nit tenga 7 digitos
            string nit = txtNit.Text.ToString();
            bool bueno=false;
            if (nit.Length == 7)
            {
                //revisa que los 6 caracteres sean digitos pero el ultimo puede ser digito o k o K
                for (int i = 0; i < 7; i++)
                {
                    if (i == 6 && Char.IsLetterOrDigit(nit[i]))
                    {
                        bueno = true;
                    }
                    else
                    {
                        if (!Char.IsDigit(nit[i]))
                        {
                            MessageBox.Show("El NIT ingresado no es válido ya que la letra solo puede ir al final", "NIT INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            bueno = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El NIT ingresado debe contener 7 caracteres", "NIT INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bueno = false;
            }
            return bueno;
        }
        //funcion para revisar si el email es valido
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

        private void tmrTiempo_Tick(object sender, EventArgs e)
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

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //revisa que el nit este valido
            if (funcRevisarNit())
            {
                //revisa que no hayan campos vacios
                if (txtNombre.Text.ToString() == "")
                {
                    MessageBox.Show("Falta ingresar el campo de nombre", "LLENAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtApellido.Text.ToString() == "")
                {
                    MessageBox.Show("Falta ingresar el campo de apellido", "LLENAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtCorreo.Text.ToString() == "")
                {
                    MessageBox.Show("Falta ingresar el campo de correo", "LLENAR DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lblTarjetaOriginada.Text.ToString() == "")
                {
                    MessageBox.Show("Debe de genear su número de tarjeta presionando el botón", "TARJETA INVÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (lblTarjetaOriginada.Text.ToString() != (char)txtNombre.Text.ToString()[0] + (char)txtApellido.Text.ToString()[0] + txtNit.Text.Substring(2, 2) + txtNit.Text.Substring(4, 2) + txtNit.Text.Substring(0, 2))
                {
                    MessageBox.Show("Al modificar algún campo de texto debe presionar de nuevo el botón de tarjeta para actualizar su tarjeta con los datos actuales.", "DATOS DE TARJETA DESACTUALIZADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        //consulta para guardar el cliente
                        string insertarCliente = "INSERT INTO CLIENTE (NITCLIENTE,NOMBRECLIENTETARJETA,APELLIDOCLIENTETARJETA) " +
                           "VALUES (?,?,? )";
                        OdbcCommand comm2 = new OdbcCommand(insertarCliente, cn.Conexion());
                        comm2.Parameters.Add("@NITCLIENTE", OdbcType.VarChar).Value = txtNit.Text.ToString();
                        comm2.Parameters.Add("@NOMBRECLIENTETARJETA", OdbcType.VarChar).Value = txtNombre.Text.ToString();
                        comm2.Parameters.Add("@APELLIDOCLIENTETARJETA", OdbcType.VarChar).Value = txtApellido.Text.ToString();
                        comm2.ExecuteNonQuery();
                        try
                        {
                            //consulta para guardar la tarjeta del cliente
                            string insertarTarjeta = "INSERT INTO TARJETA (NOTARJETA,NITCLIENTE,PUNTOS,ESTATUS) " +
                               "VALUES ("+int.Parse(lblTarjetaOriginada.Text.ToString())+",?,0.0,1)";
                            OdbcCommand comm3 = new OdbcCommand(insertarTarjeta, cn.Conexion());
                            comm3.Parameters.Add("@NITCLIENTE", OdbcType.VarChar).Value = txtNit.Text.ToString();
                            comm3.ExecuteNonQuery();
                            if (MessageBox.Show("Datos del cliente agregados correctamente.", "DATOS AGREGADOS", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                tmrTiempo.Stop();
                                this.Close();
                                this.Dispose();
                            }
                        }
                        catch (Exception ex3)
                        {
                            MessageBox.Show(ex3.ToString());
                        }
                        
                    }
                    catch (Exception ex3)
                    {
                        MessageBox.Show(ex3.ToString());
                    }
                }
            }
            
           
                
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            //habilita el tmer para contar el tiempo
            tmrTiempo.Enabled = true;
            tiempo = int.Parse(lblCantTiempoRestante.Text.ToString());
        }
    }
}
