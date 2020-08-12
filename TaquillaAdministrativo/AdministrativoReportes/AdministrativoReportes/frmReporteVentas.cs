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
            
            
        }
       

        void cargarDatos()
        {
            try
            {
                string cadena = "SELECT RESENC.idReservacionEncabezado,RESENC.fecha,C.nombreClienteTarjeta,C.apellidoClienteTarjeta,RESENC.total,RESENC.descuento FROM CLIENTE C,RESERVACIONENCABEZADO RESENC WHERE RESENC.nitCliente = C.nitCliente AND RESENC.estatus = true;";
                OdbcCommand cma = new OdbcCommand(cadena,cn.conexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while(reader.Read()){
                    dgvventas.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2) +" "+ reader.GetString(3), "Q."+reader.GetDouble(4).ToString(), "Q."+reader.GetDouble(5).ToString());
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
                Double gananciames = 0;
                lblGeneralData.Text = "REPORTE CORRESPONDIENTE AL MES DE " + texto;
                try
                {
                    string cadena = "SELECT RESENC.idReservacionEncabezado,RESENC.fecha,C.nombreClienteTarjeta,C.apellidoClienteTarjeta,RESENC.total,RESENC.descuento FROM CLIENTE C,RESERVACIONENCABEZADO RESENC WHERE RESENC.nitCliente = C.nitCliente AND MONTH(fecha) =  " + mes + " AND RESENC.estatus = true;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvventas.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2) + " " + reader.GetString(3), "Q." + reader.GetDouble(4).ToString(), "Q." + reader.GetDouble(5).ToString());
                        gananciames += reader.GetDouble(4);
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
                Double ganancia = 0;
                try
                {
                    string cadena = "SELECT RESENC.idReservacionEncabezado,RESENC.fecha,C.nombreClienteTarjeta,C.apellidoClienteTarjeta,RESENC.total,RESENC.descuento FROM CLIENTE C,RESERVACIONENCABEZADO RESENC WHERE RESENC.nitCliente = C.nitCliente AND fecha BETWEEN '"+ dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND RESENC.estatus = true;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvventas.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2) + " " + reader.GetString(3), "Q." + reader.GetDouble(4).ToString(), "Q." + reader.GetDouble(5).ToString());
                        ganancia += reader.GetDouble(4);
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
