using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taquillaAdministracion
{
    class clsConexion
    {
        public OdbcConnection nuevaConexion()
        {
            /* OdbcConnection conectar = new OdbcConnection("Dsn=SistemaTaquilla");
             conectar.Open();
             return conectar;*/

            OdbcConnection con = new OdbcConnection("Dsn=Taquilla");
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine("No conecto"+ex);
            }
            return con;
        }
    }
}
