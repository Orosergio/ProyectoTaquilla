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
     //   private const string Format = "dd-MM-yyyy hh:mm";
        int codigo;
        Conexion cn = new Conexion();
        public funciones()
        {
            InitializeComponent();
            funcBuscar();
            funcCargar();
            funcCodigoA();
        }
        String Estatus = "1";
        int codigoA;
        void funcCodigoA()
        {
            try
            {
                
                string contador = "SELECT count(idProyeccionPelicula) FROM PROYECCIONPELICULA ";
                OdbcCommand comando = new OdbcCommand(contador, cn.nuevaConexion());
                int numero = 0;
                numero = Convert.ToInt32(comando.ExecuteScalar());

                if (numero == 0)
                {
                    codigoA = 1;
                }
                else
                {
                    codigoA = numero + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        void funcCargar()
        {
            try
            {
                string cadena = "SELECT * FROM PROYECCIONPELICULA WHERE estatus = '"+Estatus+"' ";
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
            funcCargar();
            funcBuscar();


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

                string Pelicula = "SELECT * FROM PELICULA WHERE estatus = '"+Estatus+"' ";
                OdbcCommand comm1 = new OdbcCommand(Pelicula, cn.nuevaConexion());
                OdbcDataReader mostrarP = comm1.ExecuteReader();

                while (mostrarP.Read())
                {
                    cboCodigoP.Items.Add(mostrarP.GetInt32(0));
                    cboPelicula.Items.Add(mostrarP.GetString(1));
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
            cboFormato.Items.Clear();
            try
            {
                string Sala1 = "SELECT F.idFormato,F.nombre FROM formato F, formatosala FS, sala S WHERE S.idSala = FS.idSala AND F.idFormato = FS.idFormato AND S.idSala = " + Int32.Parse(cboCodigoS.SelectedItem.ToString());
                OdbcCommand comm33 = new OdbcCommand(Sala1, cn.nuevaConexion());
                OdbcDataReader mostrarSala1 = comm33.ExecuteReader();

                while (mostrarSala1.Read())
                {
                   cboCodigoF.Items.Add(mostrarSala1.GetInt32(0));
                   cboFormato.Items.Add(mostrarSala1.GetString(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde");

            }
        }

        private void cboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoP.SelectedIndex = cboPelicula.SelectedIndex;

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
                funcCodigoA();
                String Fecha = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:MM");
                try
                        {
                            string Insertar = "INSERT INTO PROYECCIONPELICULA (idProyeccionPelicula,idPelicula,idSala,idIdioma,idFormato,fechaHoraProyeccion,estatus) " +
                            "VALUES ( "+codigoA+"," + cboCodigoP.SelectedItem + "," + cboCodigoS.SelectedItem + "," + cboCodigoI.SelectedItem + "," + cboCodigoF.SelectedItem + ",'" + Fecha + "','"+Estatus+"')";
                            OdbcCommand comm = new OdbcCommand(Insertar, cn.nuevaConexion());
                            OdbcDataReader mostrarC = comm.ExecuteReader();
                            MessageBox.Show("La funcion se guardo correctamente");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                        }
                funcLimpiar();
                funcCargar();
                funcBuscar();
           
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarFuncion eliminar = new eliminarFuncion();
            eliminar.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           ModFunciones eliminar = new ModFunciones();
            eliminar.Show();
        }

        private void dtpFecha2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
