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
using Microsoft.SqlServer.Server;

namespace WindowsFormsApp1
{
    public partial class frmReporteVentas : Form
    {
        Conexion cn = new Conexion();
        public frmReporteVentas()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEleccion.SelectedIndex == 0)
            {                
                lblTexto.Visible = true;
                cboMes.Visible = true;
                lblDiaInicio.Visible = false;
                dtpInicio.Visible = false;
                lblDiaFin.Visible = false;
                dtpFin.Visible = false;
                
            }else if (cboEleccion.SelectedIndex==1)
            {                
                lblTexto.Visible = false;
                cboMes.Visible = false;
                lblDiaInicio.Visible = true;
                dtpInicio.Visible = true;
                lblDiaFin.Visible = true;
                dtpFin.Visible = true;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int mes = Int32.Parse(cboMes.SelectedIndex.ToString()) + 1;
            if (cboEleccion.SelectedIndex == 0)
            {
                dgvventas.Rows.Clear();
                string texto = cboMes.Text;
                int gananciames = 0;
                lblGeneralData.Text = "REPORTE CORRESPONDIENTE AL MES DE " + texto;
                try
                {
                    string cadena = "SELECT * FROM RESERVACIONENCABEZADO WHERE  MONTH(fecha) = " + mes + ";";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvventas.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(6).ToString(), reader.GetInt32(7).ToString(), reader.GetInt32(10).ToString());
                        gananciames += reader.GetInt32(6);
                        lblGanancia.Text = "TOTAL DE GANANCIAS: " + gananciames;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }

            }
            else if (cboEleccion.SelectedIndex == 1)
            {
                dgvventas.Rows.Clear();
                string inicio = dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string fin = dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss");
                //MessageBox.Show("INICIO: "+inicio);
                //MessageBox.Show("FIN: "+fin);
                int ganancia = 0;
                try
                {
                    string cadena = "SELECT * FROM RESERVACIONENCABEZADO WHERE fecha BETWEEN '"+ dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss") + "';";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvventas.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(6).ToString(), reader.GetInt32(7).ToString(), reader.GetInt32(10).ToString());
                        ganancia += reader.GetInt32(6);
                        lblGanancia.Text="TOTAL DE GANANCIAS: " +ganancia ;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }
            }

            
           
        }
       

      
        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
