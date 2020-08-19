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
    public partial class frmModFunciones : Form
    {
        clsConexion cn = new clsConexion();
        public frmModFunciones()
        {
            InitializeComponent();
            procBuscar();
            procEstatus();
        }

        void procEstatus()
        {
            cboEstatus.Items.Add("Activo");
            cboEstatus.Items.Add("Inactivo");
        }
        void procCargarFunciones()
        {
            if (cboDepartamento.SelectedItem == null || cboMunicipio.SelectedItem == null || cboCine.SelectedItem == null || cboPelicula.SelectedItem == null || cboSala.SelectedItem == null)
            {
                MessageBox.Show("No debe dejar campos vacios");
            }
            else
            {
                lblC.Text = "";
                lblP.Text = "";
                lblS.Text = "";
                lblH.Text = "";
                lblI.Text = "";
                lblF.Text = "";
                try
                {
                  
                    string cadena = "SELECT PRO.idProyeccionPelicula AS CODIGO, PE.nombre AS PELICULA,C.nombre AS CINE,S.numero AS SALA, PRO.fechaHoraProyeccion AS HORARIO, I.nombre AS IDIOMA, F.nombre AS FORMATO FROM proyeccionpelicula PRO, pelicula PE,sala S, cine C, idioma I, formato F , departamento D, municipio M WHERE D.idDepartamento = M.idDepartamento AND M.idMunicipio = C.idMunicipio AND C.idCine = S.idCine AND S.idSala = PRO.idSala AND PE.idPelicula = PRO.idPelicula AND I.idIdioma = PRO.idIdioma AND F.idFormato = PRO.idFormato and PE.idPelicula = " + Int32.Parse(cboCodigoP.SelectedItem.ToString()) + " and S.idSala = " + Int32.Parse(cboCodigoS.SelectedItem.ToString()) + " ";
                    OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.nuevaConexion());
                    DataTable dt = new DataTable();
                    datos.Fill(dt);
                    dgtDatos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        //funcion que busca elementos de la base de datos y los coloca en sus respectivo comboBox
        void procBuscar()
        {
           procLimpiar();
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

            

                string PeliculaNueva = "SELECT * FROM PELICULA ";
                OdbcCommand C = new OdbcCommand(PeliculaNueva, cn.nuevaConexion());
                OdbcDataReader mostrarPelicula = C.ExecuteReader();

                while (mostrarPelicula.Read())
                {
                    cboCodigoPN.Items.Add(mostrarPelicula.GetInt32(0));
                    cboPeliculaNueva.Items.Add(mostrarPelicula.GetString(1));
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
        private void ModFunciones_Load(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoF.SelectedIndex = cboFormato.SelectedIndex;
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //en este comboBox permitira que municipios se veran en el siguiente comboBox
            cboMunicipio.Items.Clear();
            cboCodigoM.Items.Clear();
            cboCodigoD.SelectedIndex =  cboDepartamento.SelectedIndex ;
           
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
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde"+ex);

            }

        }

        private void cboMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //en este comboBox permitira que cines se veran en el siguiente comboBox
            cboCine.Items.Clear();
            cboCodigoC.Items.Clear();
            cboCodigoM.SelectedIndex = cboMunicipio.SelectedIndex ;
           
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
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde"+ex);

            }

        }

        private void cboCine_SelectedIndexChanged(object sender, EventArgs e)
        {
            //en este comboBox permitira que salas se veran en el siguiente comboBox
            cboPelicula.Items.Clear();
            cboCodigoP.Items.Clear();
            cboSala.Items.Clear();
            cboCodigoS.Items.Clear();
            cboSalaN.Items.Clear();
            cboCodigoN.Items.Clear();
            cboCodigoC.SelectedIndex = cboCine.SelectedIndex;
                
            try
                {
                    string Sala = "SELECT * FROM SALA WHERE idCine = " + Int32.Parse(cboCodigoC.SelectedItem.ToString());
                    OdbcCommand comm3 = new OdbcCommand(Sala, cn.nuevaConexion());
                    OdbcDataReader mostrarSala = comm3.ExecuteReader();

                    while (mostrarSala.Read())
                    {
                        cboCodigoS.Items.Add(mostrarSala.GetInt32(0));
                        cboSala.Items.Add(mostrarSala.GetString(1));

                        cboCodigoN.Items.Add(mostrarSala.GetInt32(0));
                        cboSalaN.Items.Add(mostrarSala.GetString(1));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde"+ex);
                }
            dgtDatos.DataSource = null;
 
        }

        private void cboSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPelicula.Items.Clear();
            cboCodigoP.Items.Clear();
            cboCodigoS.SelectedIndex = cboSala.SelectedIndex  ;
           
            try
            {
                string cadena = "select DISTINCT P.nombre,P.idPelicula from pelicula P, proyeccionpelicula PRO , sala S  where P.idPelicula = PRO.idPelicula AND PRO.idSala = S.idSala AND PRO.idSala = " + Int32.Parse(cboCodigoS.SelectedItem.ToString()) + " ";
                OdbcCommand comm3 = new OdbcCommand(cadena, cn.nuevaConexion());
                OdbcDataReader mostrarSala = comm3.ExecuteReader();

                while (mostrarSala.Read())
                {
                    cboCodigoP.Items.Add(mostrarSala.GetInt32(1));
                    cboPelicula.Items.Add(mostrarSala.GetString(0));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
            dgtDatos.DataSource = null;

        }

        private void cboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
        cboCodigoP.SelectedIndex   = cboPelicula.SelectedIndex ;
            procCargarFunciones();
        }

        private void cboPeliculaNueva_SelectedIndexChanged(object sender, EventArgs e)
        {
          cboCodigoPN.SelectedIndex  = cboPeliculaNueva.SelectedIndex ;
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
          cboCodigoI.SelectedIndex = cboIdioma.SelectedIndex ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dgtDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgtDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //en este boton se realizara segun el click en el dato del dataGridView, los datos se mostraran en label respectivos
            lblC.Text = dgtDatos.CurrentRow.Cells[0].Value.ToString();
            lblP.Text = dgtDatos.CurrentRow.Cells[1].Value.ToString();
            lblS.Text = dgtDatos.CurrentRow.Cells[2].Value.ToString();
            lblH.Text = dgtDatos.CurrentRow.Cells[3].Value.ToString();
            lblI.Text = dgtDatos.CurrentRow.Cells[4].Value.ToString();
            lblF.Text = dgtDatos.CurrentRow.Cells[5].Value.ToString();
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboSalaN_SelectedIndexChanged(object sender, EventArgs e)
        {
            //en este comboBox permitira que formatos se veran en el siguiente comboBox
            cboFormato.Items.Clear();
            cboCodigoF.Items.Clear();
            cboCodigoN.SelectedIndex  = cboSalaN.SelectedIndex  ;
         
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
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde"+ex);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
           
                
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //en este boton se modificaran los datos que se hallan seleccionados
            if (cboCodigoPN.SelectedItem == null || cboCodigoI.SelectedItem == null || cboCodigoF.SelectedItem == null ||
             cboCodigoN.SelectedItem == null || cboEstatus.SelectedItem == null || lblC.Text == "")
            {
                MessageBox.Show("No debe dejar campos vacios o debe seleccionar una funcion para modificar");
            }
            else
            {
                String Estatus, Fecha;
                Estatus = cboEstatus.SelectedItem.ToString();
                if (Estatus == "Activo")
                {
                    Estatus = "1";
                }
                else if (Estatus == "Inactivo")
                {
                    Estatus = "0";
                }
                if (dtpHorario.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha  no puede ser menor a la de Hoy ");
                }
                else
                {

                    Fecha = dtpHorario.Value.ToString("yyyy-MM-dd HH:MM");
                    try
                    {

                        string Modificar = "UPDATE PROYECCIONPELICULA SET idPelicula = '" + cboCodigoPN.SelectedItem + "' , idSala = '" + cboCodigoN.SelectedItem + "', idIdioma= " + cboCodigoI.SelectedItem + ", idFormato = '" + cboCodigoF.SelectedItem + "', fechaHoraProyeccion = '" + Fecha + "', estatus = '" + Estatus + "'  WHERE idProyeccionPelicula=" + lblC.Text;
                        OdbcCommand Consulta = new OdbcCommand(Modificar, cn.nuevaConexion());
                        OdbcDataReader leer = Consulta.ExecuteReader();
                        MessageBox.Show("Los Datos se actualizaron correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
                    }
                    clsBitacora bitacora = new clsBitacora();
                    string proceso = "Modificar funciones";
                    string tabla = "PROYECCIONPELICULA";
                    bitacora.GuardarBitacora(proceso, tabla);
                    procLimpiar();
                    procBuscar();
                    procEstatus();
                }
            }
        }
        void procLimpiar()
        {
            //funcion que limpia los elementos del form
            cboCodigoD.Items.Clear();
            cboCodigoP.Items.Clear();
            cboCodigoPN.Items.Clear();
            cboCodigoF.Items.Clear();
            cboCodigoI.Items.Clear();
            cboCodigoM.Items.Clear();
            cboCodigoN.Items.Clear();
            cboCodigoC.Items.Clear();
            cboCodigoS.Items.Clear();

            cboDepartamento.Items.Clear();
            cboMunicipio.Items.Clear();
            cboPelicula.Items.Clear();
            cboCine.Items.Clear();
            cboSala.Items.Clear();
            cboSalaN.Items.Clear();
            cboPeliculaNueva.Items.Clear();
            cboIdioma.Items.Clear();
            cboFormato.Items.Clear();
            lblC.Text="";
            lblP.Text = "";
            lblS.Text = "";
            lblH.Text = "";
            lblI.Text = "";
            lblF.Text = "";
            dgtDatos.DataSource = null;
            cboEstatus.Items.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procLimpiar();
            procBuscar();
            procEstatus();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAdministracion/Ayuda.chm", "Modificar Funciones.html");
        }
    }
}
