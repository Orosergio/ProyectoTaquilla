using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Reporte_Compras : Form
    {
       /* MySqlCommand Query = new MySqlCommand();
        MySqlConnection Conexion;
        MySqlDataReader consultar;
        public string sql = "datasource=127.0.0.1;port=3306;username=root;password=;database=SUPERMERCADO";*/
        public Reporte_Compras()
        {
            InitializeComponent();
           /* try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT c.fecha,p.nombre,p.apellido,prod.nombre,cd.cantidad from compras c," +
                    "detallecompras cd, producto prod, proveedor p where c.idproveedor=p.idproveedor" +
                    " and cd.idproducto=prod.idproducto order by c.fecha desc";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                while (consultar.Read())
                {
                    dgvventas.Rows.Add(consultar.GetString(0), consultar.GetString(1) + consultar.GetString(2), consultar.GetString(3), consultar.GetInt32(4).ToString());
                }
                Conexion.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }*/
        }
       /* public void connection()
        {
            try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
               // MessageBox.Show("Conectado con éxito");
                Conexion.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }*/
        private void Reporte_Ventas_Load(object sender, EventArgs e)
        {

        }
    }
}
