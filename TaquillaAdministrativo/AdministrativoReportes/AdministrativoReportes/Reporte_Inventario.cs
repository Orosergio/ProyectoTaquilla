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
    public partial class Reporte_Inventario : Form
    {
       /* MySqlCommand Query = new MySqlCommand();
        MySqlConnection Conexion;
        MySqlDataReader consultar;
        public string sql = "datasource=127.0.0.1;port=3306;username=root;password=;database=SUPERMERCADO";*/
        public Reporte_Inventario()
        {
            InitializeComponent();
          /*  try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT i.fechainventario,e.nombre,e.apellido,prod.nombre,id.cantidad from inventario i," +
                    "inventariodetalle id, producto prod, empleado e where i.idempleado=e.idempleado" +
                    " and id.idproducto=id.idproducto order by i.fechainventario desc";
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
              //  MessageBox.Show("Conectado con éxito");
                Conexion.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        */
        private void Reporte_Inventario_Load(object sender, EventArgs e)
        {

        }
    }
}
