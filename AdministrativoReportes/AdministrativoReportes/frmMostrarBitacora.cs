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
    public partial class frmMostrarBitacora : Form
    {
        clsConexion cn = new clsConexion();
        public frmMostrarBitacora()
        {
            InitializeComponent();
            funcCargarDatos();
        }

        void funcCargarDatos()
        {
            try
            {
                string cadena = "SELECT B.idBitacora, B.fecha, U.nombreUsuario, E.nombre, E.apellido, B.ipAddress, B.proceso, B.tabla FROM BITACORA B, USUARIO U, EMPLEADO E WHERE B.idUsuario = U.idUsuario AND U.idEmpleado = E.idEmpleado ORDER BY B.fecha DESC; ";
                OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {
                    dgvDatosBitacora.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) + " " + reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + e);
            }

        }

        private void frmMostrarBitacora_Load(object sender, EventArgs e)
        {

        }

        private void chkFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltro.Checked==true)
            {
                lblInicio.Visible = true;
                lblFin.Visible = true;
                dtpInicio.Visible = true;
                dtpFin.Visible = true;
                btnBuscar.Visible=true;
            }
            else
            {
                dgvDatosBitacora.Rows.Clear();
                lblInicio.Visible = false;
                lblFin.Visible = false;
                dtpInicio.Visible = false;
                dtpFin.Visible = false;
                btnBuscar.Visible = false;
                funcCargarDatos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String FechaInicio = dtpInicio.Value.ToString("yyyy-MM-dd HH:mm:ss");
            String FechaFin = dtpFin.Value.ToString("yyyy-MM-dd HH:mm:ss");
            dgvDatosBitacora.Rows.Clear();
            try
            {
                string cadena = "SELECT B.idBitacora, B.fecha, U.nombreUsuario, E.nombre, E.apellido, B.ipAddress, B.proceso, B.tabla FROM BITACORA B, USUARIO U, EMPLEADO E WHERE B.idUsuario = U.idUsuario AND U.idEmpleado = E.idEmpleado AND B.fecha BETWEEN '" + FechaInicio + "' AND '" + FechaFin + "' ;";
                OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {
                    dgvDatosBitacora.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) + " " + reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));

                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
            }
        }
    }
}
