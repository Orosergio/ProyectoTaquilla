using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taquilla
{
    public partial class frmPagoTarjeta : Form
    {
        int tiempo;
        public frmPagoTarjeta()
        {
            InitializeComponent();
        }

        private void lblDatos_Click(object sender, EventArgs e)
        {

        }

        private void frmPagoTarjeta_Load(object sender, EventArgs e)
        {
            tiempo = int.Parse(lblCantTiempoRestante.Text.ToString());
            tmrTiempo.Enabled = true;
            cboMes.Items.Add("Mes...");
            
            for(int i = 1; i <= 12; i++)
            {
                cboMes.Items.Add(i.ToString());
            }

            cboAño.Items.Add("Año...");
            for (int i = 0; i <= 10; i++)
            {
                cboAño.Items.Add((2020+i).ToString());
            }
            
            cboAño.SelectedIndex = 0;
            cboMes.SelectedIndex = 0;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        private void txtCVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.ToString() == "")
            {
                MessageBox.Show("Falta ingresar el dato de nombre", "FALTA DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (txtNumero.Text.ToString() == "")
            {
                MessageBox.Show("Falta ingresar el número de la tarjeta", "FALTA DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtCVV.Text.ToString() == "")
            {
                MessageBox.Show("Falta ingresar el dato de CVV", "FALTA DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cboAño.SelectedIndex == 0)
            {
                MessageBox.Show("Falta seleccionar el año de vencimiento", "FALTA DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cboMes.SelectedIndex == 0)
            {
                MessageBox.Show("Falta seleccionar el mes de vencimiento", "FALTA DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtNumero.Text.Length != 16)
                {
                    MessageBox.Show("El número de la tarjeta debe contener 16 dígitos", "ERROR EN LONGITUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(txtCVV.Text.Length<3 || txtCVV.Text.Length > 4)
                    {
                        MessageBox.Show("El CVV debe contener 3 o 4 dígitos", "ERROR EN LONGITUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Los datos de la tarjeta fueron aceptados.", "TARJETA ACEPTADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.Close();
                        this.Dispose();
                    }
                }
            }
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            tiempo--;
            lblCantTiempoRestante.Text = tiempo.ToString();
            if (tiempo == 0)
            {
                tmrTiempo.Stop();
                //MessageBox.Show("Se terminó el tiempo de compra establecido.", "TIEMPO FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();
            }
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
