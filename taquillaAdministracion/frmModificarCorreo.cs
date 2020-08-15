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

namespace taquillaAdministracion
{
    public partial class frmModificarCorreo : Form
    {
        public frmModificarCorreo()
        {
            InitializeComponent();
        }
        clsConexion cn = new clsConexion();

        void procDatosEmpleado()
        {
            //boton que modificara el correo del usuario segun el correo que este guardado en la base de datos
            if(txtCorreo.Text == "")
            {
                MessageBox.Show("Debe ingresar un correo");
            }else
            {
                try
                 {
                string cadena = "select C.idCorreo, E.nombre,C.correo,C.estatus from empleado E, correo C WHERE E.idEmpleado = C.idEmpleado and correo = "+ txtCorreo.Text;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.nuevaConexion());
                DataTable dt = new DataTable();
                datos.Fill(dt);
                dgtDatos.DataSource = dt;
                }
                catch (Exception ex)
                {
                MessageBox.Show("Correo" + ex);
                 }
            }
           
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            procDatosEmpleado();
        }

        private void dgtDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //boton para copiar los datos del dataGridView en labels correspondientes
            lblC.Text = dgtDatos.CurrentRow.Cells[0].Value.ToString();
            lblE.Text = dgtDatos.CurrentRow.Cells[1].Value.ToString();
            lblT.Text = dgtDatos.CurrentRow.Cells[2].Value.ToString();
            lblEs.Text = dgtDatos.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
