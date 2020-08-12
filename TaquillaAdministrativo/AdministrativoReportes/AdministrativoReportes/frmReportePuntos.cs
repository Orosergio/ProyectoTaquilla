using EmpleadoPrueba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrativoReportes
{
    public partial class frmReportePuntos : Form
    {
        Conexion cn = new Conexion();
        public frmReportePuntos()
        {
            InitializeComponent();
            funcCargarDatos();
        }

        void funcCargarDatos()
        {
            try
            {
                string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,T.puntos,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente; ";
                OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {
                    dgvCliente.Rows.Add(reader.GetString(0), reader.GetString(1)+" "+ reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetString(5));
                }

                
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + e);
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            if (cboTipoReporte.SelectedIndex == 0)
            {
                dgvCliente.Rows.Clear();
               
                try
                {
                    string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,T.puntos,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente ORDER BY puntos DESC; ";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvCliente.Rows.Add(reader.GetString(0), reader.GetString(1) + " " + reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetString(5));
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }

            }
            else if (cboTipoReporte.SelectedIndex == 1)
            {
                dgvCliente.Rows.Clear();
                
                
                try
                {
                    string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,T.puntos,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente ORDER BY puntos ASC;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvCliente.Rows.Add(reader.GetString(0), reader.GetString(1) + " " + reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetString(5));
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
