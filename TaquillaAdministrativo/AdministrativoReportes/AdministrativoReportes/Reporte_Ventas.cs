using EmpleadoPrueba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace WindowsFormsApp1
{
    public partial class Reporte_Ventas : Form
    {
        Conexion cn = new Conexion();
        public Reporte_Ventas()
        {
            InitializeComponent();
            cargarDatos();
            /* try
             {
                 Conexion = new MySqlConnection();
                 Conexion.ConnectionString = sql;
                 Conexion.Open();
                 Query.CommandText = "SELECT v.fecha,c.nombre,c.apellido,prod.nombre,dv.cantidad from ventas v," +
                     "detalleventas dv, producto prod, cliente c where v.nitcliente=c.nit" +
                     " and dv.idproducto=prod.idproducto order by v.fecha desc";
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
        /*public void connection()
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

        void cargarDatos()
        {
            try
            {
                string cadena = "SELECT * FROM RESERVACIONENCABEZADO;";
                OdbcCommand cma = new OdbcCommand(cadena,cn.conexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while(reader.Read()){
                    dgvventas.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(6).ToString(), reader.GetInt32(7).ToString(), reader.GetInt32(10).ToString());
                }
               

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + e);
            }           

        }
        private void Reporte_Ventas_Load(object sender, EventArgs e)
        {

        }
        
        private void Dgvventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            
        }
    }
}
