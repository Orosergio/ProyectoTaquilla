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
    public partial class frmVerEmpleados : Form
    {
        String uno = "1";
        clsConexion cn = new clsConexion();
        public frmVerEmpleados()
        {
            InitializeComponent();
            procCargarEmpleados();
        }
        void procCargarEmpleados()
        {
            //Muestra los datos de la tabla pelicula en el dataGridView llamada dgtDatos
            try
            {
                string cadena = "select E.idEmpleado AS CODIGO ,E.nombre AS NOMBRE ,E.apellido AS APELLIDO ,P.nombre AS PUESTO,E.fechaContratacion AS CONTRATACION ,E.fechaNacimiento AS NACIMIENTO,E.estatus AS ESTATUS FROM  puesto P, empleado E WHERE P.idPuesto = E.idPuesto AND E.estatus = '" + uno + "' ";
                //string cadena = "SELECT * FROM EMPLEADO WHERE estatus = '" + uno + "' ";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.nuevaConexion());
                DataTable dt = new DataTable();
                datos.Fill(dt);
                dgtDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }


        }
        private void frmVerEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            procCargarEmpleados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            procCargarEmpleados();
        }
    }
}
