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

namespace AdministrativoReportes
{
    public partial class frmReporteTaquillera : Form
    {
        Conexion cn = new Conexion();
        public frmReporteTaquillera()
        {
            InitializeComponent();
            funcCargarDatos();
        }

        void funcCargarDatos()
        {
            try
            {
                string cadena = "SELECT P.nombre, CLAS.nombre, P.duracion, SUM(ENC.total) AS Cantidad_Recaudada FROM FACTURA F, RESERVACIONENCABEZADO ENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE F.idReservacionEncabezado = ENC.idReservacionEncabezado AND ENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND F.estatus = true group by P.idPelicula ORDER BY Cantidad_Recaudada DESC; ";
                OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {
                    dgvPeliculaTaquillera.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2),"Q." + reader.GetDouble(3).ToString());
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + e);
            }

        }
        private void frmReporteTaquillera_Load(object sender, EventArgs e)
        {

        }

        private void cboTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoReporte.SelectedIndex == 0)
            {
                lblTexto.Visible = true;
                cboMes.Visible = true;
                lblDiaInicio.Visible = false;
                dtpInicio.Visible = false;
                lblDiaFin.Visible = false;
                dtpFin.Visible = false;

            }
            else if (cboTipoReporte.SelectedIndex == 1)
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
            if (cboTipoReporte.SelectedIndex == 0)
            {
                dgvPeliculaTaquillera.Rows.Clear();
                string texto = cboMes.Text;
             
                lblGeneralData.Text = "REPORTE CORRESPONDIENTE AL MES DE " + texto;
                try
                {
                    string cadena = "SELECT P.nombre, CLAS.nombre, P.duracion, SUM(ENC.total) AS Cantidad_Recaudada FROM FACTURA F, RESERVACIONENCABEZADO ENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE F.idReservacionEncabezado = ENC.idReservacionEncabezado AND ENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND F.estatus = true AND MONTH(F.fecha) = "+mes+" GROUP BY P.idPelicula ORDER BY Cantidad_Recaudada DESC; ";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvPeliculaTaquillera.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), "Q." + reader.GetDouble(3).ToString());

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }

            }
            else if (cboTipoReporte.SelectedIndex == 1)
            {
                dgvPeliculaTaquillera.Rows.Clear();
                string inicio = dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string fin = dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss");
                //MessageBox.Show("INICIO: "+inicio);
                //MessageBox.Show("FIN: "+fin);
               
                try
                {
                    string cadena = "SELECT P.nombre, CLAS.nombre, P.duracion, SUM(ENC.total) AS Cantidad_Recaudada FROM FACTURA F, RESERVACIONENCABEZADO ENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE F.idReservacionEncabezado = ENC.idReservacionEncabezado AND ENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND F.estatus = true AND F.fecha BETWEEN'" + dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' GROUP BY P.idPelicula ORDER BY Cantidad_Recaudada DESC;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvPeliculaTaquillera.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), "Q." + reader.GetDouble(3).ToString());

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }
            }
        }
    }
}
