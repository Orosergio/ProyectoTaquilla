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
    public partial class modificarFunciones : Form
    {
        Validacion validar = new Validacion();
        public modificarFunciones()
        {
            InitializeComponent();
            funcBuscar();
            funcCargar();
        }
        Conexion cn = new Conexion();
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
        void funcLimpiar()
        {

            cboCine.Items.Clear();
            cboDepartamento.Items.Clear();
            cboMunicipio.Items.Clear();
            cboSala.Items.Clear();
            cboPelicula.Items.Clear();
            cboIdioma.Items.Clear();
            cboFormato.Items.Clear();
            txtCodigoF.Text = "";
            lblDatoSala.Text = "";
            lblDatoPelicula.Text = "";
            lblDatoIdioma.Text = "";
            lblDatoFormato.Text = "";
            lblDatoHorario.Text = "";
           
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
        private void modificarFunciones_Load(object sender, EventArgs e)
        {

        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigoF.Text== "")
            {
                MessageBox.Show("Escriba un codigo de funcion");
            }
            else
            {
                try
                {
                    string Pelicula = "SELECT * FROM PROYECCIONPELICULA WHERE idProyeccionPelicula = " + Int32.Parse(txtCodigoF.Text) ;
                   
                    OdbcCommand com5 = new OdbcCommand(Pelicula, cn.nuevaConexion());
                    OdbcDataReader mostrarDatos = com5.ExecuteReader();
                    while (mostrarDatos.Read())
                    {   
                        lblDatoPelicula.Text = mostrarDatos.GetString(1);
                        lblDatoSala.Text = mostrarDatos.GetString(2);
                        lblDatoIdioma.Text = mostrarDatos.GetString(3);
                        lblDatoFormato.Text = mostrarDatos.GetString(4);
                        lblDatoHorario.Text = mostrarDatos.GetString(5);
                    }
                   /* string NombrePelicula = "SELECT nombre FROM PELICULA WHERE idPelicula =" + lblDatoPelicula.Text;
                    OdbcCommand com7= new OdbcCommand(NombrePelicula, cn.nuevaConexion());
                    OdbcDataReader mostrarNombre = com7.ExecuteReader();
                    while (mostrarDatos.Read())
                    {
                        lblNombrePelicula.Text = mostrarDatos.GetString(1);
                        
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                }
               // funcLimpiar();
            }
        }

        private void txtCodigoF_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSoloNumeros(e);
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
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoI.SelectedIndex = cboIdioma.SelectedIndex;
        }

        private void cboFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoF.SelectedIndex = cboFormato.SelectedIndex;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cboCine.SelectedItem == null || cboDepartamento.SelectedItem == null || cboFormato.SelectedItem == null
              || cboIdioma.SelectedItem == null || cboMunicipio.SelectedItem == null || cboSala.SelectedItem == null ||
              cboPelicula.SelectedItem == null)
            {
                MessageBox.Show("No debe dejar campos vacios");
            }
            else
            {
                String Fecha = dtpFecha.Value.ToString("yyyy-MM-dd hh:mm:ss");
                try
                {
                    string Insertar = "UPDATE  PROYECCIONPELICULA SET idPelicula = "+cboCodigoP.SelectedItem+",idSala = "+cboCodigoS.SelectedItem+",idIdioma = "+cboCodigoI.SelectedItem+",idFormato = "+cboCodigoF.SelectedItem+",fechaHoraProyeccion ='"+Fecha+"'WHERE idProyeccionPelicula="+txtCodigoF.Text;
                    OdbcCommand comm = new OdbcCommand(Insertar, cn.nuevaConexion());
                    OdbcDataReader mostrarC = comm.ExecuteReader(); 
                    MessageBox.Show("Los datos se modificaron correctamente");
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
    }
    
}
