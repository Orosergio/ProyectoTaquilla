using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taquillaAdministracion
{
    class Conexion
    {
        public OdbcConnection nuevaConexion()
        {
            /* OdbcConnection conectar = new OdbcConnection("Dsn=SistemaTaquilla");
             conectar.Open();
             return conectar;*/

            OdbcConnection con = new OdbcConnection("Dsn=SistemaTaquilla");
            try
            {
                con.Open();
            }
            catch
            {
                Console.WriteLine("No conecto");
            }
            return con;
        }
    }
}
