using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Collections;

namespace AdministrativoReportes
{
    public class clsBitacora
    {
       public string fecha;
       public static string idUsuario;
       public string ipAddress;
       public string proceso;
       public string tabla;

        clsConexion cn = new clsConexion();
        //Variable que lleva el control del registro automático
        int codigoA;
        void procCodigoUser()
        {
            int numero;
            try
            //esta funcion hace un conteo de los datos que se encuentran en la tabla pelicula y almacena ese valor en la variable numero

            {
                string contador = "SELECT count(idUsuario) FROM BITACORA ";
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


        //Esta función sirve para tomar la ip de la máquina
        public static string getLocalIPAddress()
        {           
            Stack miPila = new Stack();
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    
                    miPila.Push(ip.ToString());
                    //localIP = ip.ToString();
                    //MessageBox.Show("Tú IP Local Es: " + localIP + " " + ip.AddressFamily.ToString());
                }
            }
            string direccion = miPila.Pop().ToString();
           // MessageBox.Show("GUARDARÉ " + direccion);
            return direccion;
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        //Recibo parámetros para enviarlo a la tabla de Bitácora
        public void GuardarBitacora(string proceso, string tabla)
        {
            try
            {
                //agrego a la variable ipAddress el método
                ipAddress = getLocalIPAddress();
                string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                procCodigoUser();
                /*MessageBox.Show("idBitacora: " + codigoA);
                MessageBox.Show("fecha: " + fecha);
                MessageBox.Show("idUsuario: " + idUsuario);
                MessageBox.Show("ipAddress " + ipAddress);
                MessageBox.Show("Proceso: " + proceso);
                MessageBox.Show("tabla: " + tabla);*/
                string cadena = "INSERT INTO BITACORA (idBitacora, fecha, idUsuario,ipAddress,proceso,tabla) VALUES (" + codigoA + ",'" + fecha + "'," + int.Parse(idUsuario) + ",'" + ipAddress + "','" + proceso + "','" + tabla + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.nuevaConexion());
                consulta.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la bitácora: " + ex);
            }
            
        }

        public void obtenerIdUsuario(string id)
        {
           //Obtiene el id del usuario que inicie sesión
            idUsuario = id;            
        }

        public string retornoIdUsuario()
        {
            return idUsuario;
        }

    }
}
