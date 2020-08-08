using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taquillaAdministracion
{
    class Validacion
    {
        public void funcSoloLetras(KeyPressEventArgs validar)
        {

            try
            {
                if(Char.IsLetter(validar.KeyChar))
                {
                    validar.Handled = false;
                }else if(Char.IsControl(validar.KeyChar))
                {
                    validar.Handled = false;
                }else if(Char.IsSeparator(validar.KeyChar))
                {
                    validar.Handled = false;
                }
                else
                {
                    validar.Handled = true;
                    MessageBox.Show(" ingrese solo letras");
                }
            }catch(Exception ex)
            {

            }
        }

        public void funcSoloNumeros(KeyPressEventArgs validar)
        {

            try
            {
                if (Char.IsNumber(validar.KeyChar))
                {
                    validar.Handled = false;
                }
                else if (Char.IsControl(validar.KeyChar))
                {
                    validar.Handled = false;
                }
                else if (Char.IsSeparator(validar.KeyChar))
                {
                    validar.Handled = false;
                }
                else if (Char.IsUpper(validar.KeyChar))
                {
                    validar.Handled = false;
                }
                else
                {
                    validar.Handled = true;
                    MessageBox.Show("Ingrese solo numeros");
                }
            }
            catch (Exception ex)
            {

            }
        }

            public void funcNumerosYpuntos(KeyPressEventArgs validar)
            {
            if((validar.KeyChar >= 32 && validar.KeyChar <= 47)  || (validar.KeyChar >= 59 && validar.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo Numeros");
                validar.Handled = true;
                return;
            }


            }
        }

    }
