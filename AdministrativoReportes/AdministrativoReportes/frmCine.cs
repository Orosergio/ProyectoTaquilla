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
    public partial class frmCine : Form
    {
        public frmCine()
        {
            InitializeComponent();
            procDepartamento();
            procCodigoA();
        }
        clsConexion cn = new clsConexion();
        clsValidacion validar = new clsValidacion();
        int numero = 0;
        int codigoA = 0;
        void procDepartamento()
        {
            //en esta funcion busca los Departamentos 
            try
            {
                string Sala = "SELECT * FROM DEPARTAMENTO";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                while (mostrarC.Read())
                {
                    cboCodigoD.Items.Add(mostrarC.GetInt32(0));
                    cboDepartamento.Items.Add(mostrarC.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }
        void procMunicipio()
        {
          
            try
            { 
                string Municipio = "SELECT * FROM MUNICIPIO  WHERE idDepartamento= " + Int32.Parse(cboCodigoD.SelectedItem.ToString());
                OdbcCommand comm1 = new OdbcCommand(Municipio, cn.nuevaConexion());
                OdbcDataReader mostrarMun = comm1.ExecuteReader();
                while (mostrarMun.Read())
                {
                    cboCodigoM.Items.Add(mostrarMun.GetInt32(0));
                    cboMunicipio.Items.Add(mostrarMun.GetString(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);

            }
        }
        void procCodigoA()
        {
            try
            //esta funcion hace un conteo de los datos que se encuentran en la tabla pelicula y almacena ese valor en la variable numero

            {
                string contador = "SELECT count(idCine) FROM CINE ";
                OdbcCommand comando = new OdbcCommand(contador, cn.nuevaConexion());
                numero = Convert.ToInt32(comando.ExecuteScalar());
                //si numero = 0, no encuentra ningun registro convierte el cidigoA en 1 y envia ese codigo para guardado como ID
                if (numero == 0)
                {
                    codigoA = 1;
                }
                else
                {
                    //de lo contrario se ira incrementando + 1 codigoA
                    codigoA = numero + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        void procLimpiar()
        {
            txtCine.Text = "";
            txtDireccion.Text = "";
            
            duwTiempo.SelectedIndex = 299;
            cboMunicipio.Items.Clear();
            cboCodigoM.Items.Clear();
            cboCodigoD.Items.Clear();
            cboDepartamento.Items.Clear();
        }
    
        private void frmCine_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.duwTiempo.Items;
            for (int i=300; i>0;i--)
            {
                collection.Add(i);
            }
            this.duwTiempo.SelectedIndex = 299;
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoM.Items.Clear();
            cboMunicipio.Items.Clear();
            cboCodigoD.SelectedIndex = cboDepartamento.SelectedIndex;
            procMunicipio();
           
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSoloNumeros(e);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtCine.Text == "" || txtDireccion.Text == "" || duwTiempo.Text == "" || cboDepartamento.SelectedItem == null || cboMunicipio.SelectedItem == null)
            {
                MessageBox.Show("No debe dejar campos vacios");
            }else
            {
                String estatus = "1";
                try
            {
                string Insertar = "INSERT INTO CINE (idCine,nombre,idMunicipio,direccion,tiempoCompra,estatus) " +
                "VALUES ( " + codigoA + ",'" + txtCine.Text + "'," + Int32.Parse(cboCodigoM.SelectedItem.ToString()) + ",'" + txtDireccion.Text.ToString() + "'," + Int32.Parse(duwTiempo.Text) + ",'" + estatus + "')";
                OdbcCommand comm = new OdbcCommand(Insertar, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                MessageBox.Show("La funcion se guardo correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
                clsBitacora bitacora = new clsBitacora();
                string proceso = "INGRESO DE CINE";
                string tabla = "INSERT INTO CINE (idCine,nombre,idMunicipio,direccion,tiempoCompra,estatus) VALUES ( " + codigoA.ToString() + "," + txtCine.Text.ToString() + "," +cboCodigoM.SelectedItem.ToString() + "," + txtDireccion.Text.ToString() + "," + duwTiempo.Text.ToString() + "," + estatus.ToString()+")"; 
                bitacora.GuardarBitacora(proceso, tabla);
            }
            procLimpiar();
            procDepartamento();
            procCodigoA();
            
        }

        private void cboMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoM.SelectedIndex = cboMunicipio.SelectedIndex;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procDepartamento();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarCine CINE = new frmModificarCine();
            CINE.ShowDialog();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAgregado/AyudaAgregado.chm", "IngresoCine.html");
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void duwTiempo_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
