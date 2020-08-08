using System;
//using MySql.Data.MySqlClient;
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
    public partial class funciones : Form
    {
        int codigo;
        Conexion cn = new Conexion();
        public funciones()
        {
            InitializeComponent();
           funcBuscar();
           funcCargar();
           
        }
        void funcCargar()
        {
            try
            {
                string cadena = "SELECT * FROM PROYECCIONPELICULA";
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
            public void connection()
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbidprod.SelectedIndex = cmbprod.SelectedIndex;
        }

        private void cmbprov_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbidemp.SelectedIndex = cmbemp.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
          
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funcLimpiar();


        }
        void funcLimpiar()
        {
            
            cboCine.Items.Clear();
            cboDepartamento.Items.Clear();
            cboMunicipio.Items.Clear();
            cboSala.Items.Clear();
            cboPelicula.Items.Clear();
            cboIdioma.Items.Clear();
            cboFormato.Items.Clear();
            cboCodigoC.Items.Clear();
            cboCodigoD.Items.Clear();
            cboCodigoF.Items.Clear();
            cboCodigoI.Items.Clear();
            cboCodigoM.Items.Clear();
            cboCodigoP.Items.Clear();
            cboCodigoS.Items.Clear();
        }
        void funcBuscar()
        {
            try
            {
                string Departamento = "SELECT * FROM DEPARTAMENTO ";
                OdbcCommand comm = new OdbcCommand(Departamento, cn.nuevaConexion());
                OdbcDataReader mostrarDep = comm.ExecuteReader();

                while (mostrarDep.Read())
                {
                    cboCodigoD.Items.Add(mostrarDep.GetInt32(0));
                    cboDepartamento.Items.Add(mostrarDep.GetString(1));
                }

                string Pelicula = "SELECT * FROM PELICULA ";
                OdbcCommand comm1 = new OdbcCommand(Pelicula, cn.nuevaConexion());
                OdbcDataReader mostrarP = comm1.ExecuteReader();

                while (mostrarP.Read())
                {
                    cboCodigoP.Items.Add(mostrarP.GetInt32(0));
                    cboPelicula.Items.Add(mostrarP.GetString(1));
                }

                string Formato = "SELECT * FROM FORMATO ";
                OdbcCommand comm2 = new OdbcCommand(Formato, cn.nuevaConexion());
                OdbcDataReader mostrarF = comm2.ExecuteReader();

                while (mostrarF.Read())
                {
                    cboCodigoF.Items.Add(mostrarF.GetInt32(0));
                    cboFormato.Items.Add(mostrarF.GetString(1));
                }

                string Idioma = "SELECT * FROM IDIOMA ";
                OdbcCommand comm3 = new OdbcCommand(Idioma, cn.nuevaConexion());
                OdbcDataReader mostrarI = comm3.ExecuteReader();

                while (mostrarI.Read())
                {
                    cboCodigoI.Items.Add(mostrarI.GetInt32(0));
                    cboIdioma.Items.Add(mostrarI.GetString(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);

            }


        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoD.SelectedIndex = cboDepartamento.SelectedIndex;
            cboMunicipio.Items.Clear();
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
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde");

            }
        }        

        private void cboMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoM.SelectedIndex = cboMunicipio.SelectedIndex;
            cboCine.Items.Clear();
            try
            {
                string Cine = "SELECT * FROM CINE WHERE idMunicipio =" + Int32.Parse(cboCodigoM.SelectedItem.ToString());
                OdbcCommand comm2 = new OdbcCommand(Cine, cn.nuevaConexion());
                OdbcDataReader mostrarCine = comm2.ExecuteReader();

                while (mostrarCine.Read())
                {
                    cboCodigoC.Items.Add(mostrarCine.GetInt32(0));
                    cboCine.Items.Add(mostrarCine.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde");

            }

        }

        private void cboCine_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoC.SelectedIndex = cboCine.SelectedIndex;
            cboSala.Items.Clear();
            try
            {
                string Sala = "SELECT * FROM SALA WHERE idCine = " + Int32.Parse(cboCodigoC.SelectedItem.ToString());
                OdbcCommand comm3 = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarSala = comm3.ExecuteReader();

                while (mostrarSala.Read())
                {
                    cboCodigoS.Items.Add(mostrarSala.GetInt32(0));
                    cboSala.Items.Add(mostrarSala.GetString(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde");

            }

        }

        private void cboSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoS.SelectedIndex = cboSala.SelectedIndex;
        }

        private void cboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoP.SelectedIndex = cboPelicula.SelectedIndex;
            try
            {
                string Idioma = "SELECT * FROM IDIOMA WHERE idPelicula = " + Int32.Parse(cboCodigoP.SelectedItem.ToString());
                OdbcCommand comm5 = new OdbcCommand(Idioma, cn.nuevaConexion());
                OdbcDataReader mostrarIdi = comm5.ExecuteReader();

                while (mostrarIdi.Read())
                {
                    cboCodigoI.Items.Add(mostrarIdi.GetInt32(0));
                    cboIdioma.Items.Add(mostrarIdi.GetString(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde");

            }

        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoI.SelectedIndex = cboIdioma.SelectedIndex;
           
        }

        private void cboFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
           cboCodigoF.SelectedIndex =  cboFormato.SelectedIndex;
          
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if( cboCine.SelectedItem == null || cboDepartamento.SelectedItem == null || cboFormato.SelectedItem == null
               || cboIdioma.SelectedItem == null || cboMunicipio.SelectedItem == null || cboSala.SelectedItem == null  ||
               cboPelicula.SelectedItem == null)
            {
                MessageBox.Show("No debe dejar campos vacios");
            }
                else
                    {
                        try
                        {
                            string Insertar = "INSERT INTO PROYECCIONPELICULA (idProyeccionPelicula,idPelicula,idSala,idIdioma,idFormato,fechaHoraProyeccion) " +
                                "VALUES (" + cboCodigoP + "," + cboCodigoS + "," + cboCodigoI + "," + cboFormato + "," + dtpFecha2.Value + ")";
                            OdbcCommand comm = new OdbcCommand(Insertar, cn.nuevaConexion());
                            OdbcDataReader mostrarC = comm.ExecuteReader();
                            MessageBox.Show("Los datos se ingresaron correctamente");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);

                        }
                        funcLimpiar();
                    }
        }
           
    }
}
