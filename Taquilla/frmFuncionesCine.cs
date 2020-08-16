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

namespace Taquilla
{
    public partial class frmFuncionesCine : Form
    {
        clsConexion conn = new clsConexion();
        int codigoCine, codigoPelicula;
        public frmFuncionesCine(int idCine, int idPelicula)
        {
            InitializeComponent();
            codigoCine = idCine;
            codigoPelicula = idPelicula;
            procFormato();
            procIdioma();
            procFechaFunciones();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            
       
        }
        public void procFechaFunciones()
        /*Procedimiento para mostrar las fechas de las funciones disponibles desde la hora que esta consultando hasta los siguientes dias
      ,dias anteriores o horas anteriores no los consulta*/
        {
            try
            {
                string Query = "select distinct date_format(pp.fechahoraproyeccion, '%d - %m - %Y'),  date_format(pp.fechahoraproyeccion, '%Y-%m-%d') ";
                Query += "from pelicula p, proyeccionpelicula pp, sala s, cine c ";
                Query += "where p.idpelicula=pp.idpelicula and pp.idsala=s.idsala and s.idcine=c.idcine and c.idcine=" + codigoCine + "  and pp.estatus=1 and p.estatus=1 ";
                Query += "and s.estatus=1 and pp.fechahoraproyeccion >= sysdate() AND P.IDPELICULA=" + codigoPelicula;
                OdbcDataReader Datos;
                OdbcCommand Consulta = new OdbcCommand();
                Consulta.CommandText = Query;
                Consulta.Connection = conn.Conexion();
                Datos = Consulta.ExecuteReader();
                while (Datos.Read())
                {
                    cboFechaFunciones.Items.Add(Datos.GetString(0));
                    cboFechasFun.Items.Add(Datos.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public void procIdioma()
        /*Procedimiento para mostrar todos los idiomas*/
        {
            try
            {
                string Query = "SELECT * FROM IDIOMA";
                OdbcDataReader Datos;
                OdbcCommand Consulta = new OdbcCommand();
                Consulta.CommandText = Query;
                Consulta.Connection = conn.Conexion();
                Datos = Consulta.ExecuteReader();
                while (Datos.Read())
                {
                    cboCodigoIdioma.Items.Add(Datos.GetString(0));
                    cboIdioma.Items.Add(Datos.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public void procFormato()
        /*Procedimiento para mostrar todos los formatos en los combobox*/
        {
            try
            {
                string Query = "SELECT * FROM FORMATO";
                OdbcDataReader Datos;
                OdbcCommand Consulta = new OdbcCommand();
                Consulta.CommandText = Query;
                Consulta.Connection = conn.Conexion();
                Datos = Consulta.ExecuteReader();
                while (Datos.Read())
                {
                    cboCodigoFormato.Items.Add(Datos.GetString(0));
                    cboFormato.Items.Add(Datos.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        /*Boton que filtra las horas de las proyecciones y muestra las salas segun el formato, el idioma y la fecha de la
        proyeccion de la pelicula*/
        {
            if (cboFormato.Text=="")
            {
                MessageBox.Show("Debe elegir un formato para la pelicula");
            }
            else if (cboIdioma.Text=="")
            {
                MessageBox.Show("Debe elegir un idioma para la pelicula");
            }
            else if (cboFechaFunciones.Text=="")
            {
                MessageBox.Show("Debe elegir una fecha para la pelicula");
            }
            else
            {
                dgvFunciones.Rows.Clear();
                try
                {
                    string Query;
                    string horaactual = DateTime.Now.ToString("%h:%i %p");
                    string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");
                    if (cboFechasFun.SelectedItem.ToString()!=fechaActual)
                    {
                        Query = "select date_format(pp.fechahoraproyeccion, '%h:%i %p'), s.numero, pp.idproyeccionpelicula, s.idsala from proyeccionpelicula pp,";
                        Query += "idioma i, formato f, sala s, pelicula p, cine c where c.idcine=s.idcine and s.idsala=pp.idsala and pp.ididioma=i.ididioma ";
                        Query += "and pp.idformato=f.idformato and pp.idpelicula=p.idpelicula and i.ididioma=" + Int32.Parse(cboCodigoIdioma.SelectedItem.ToString()) + " ";
                        Query += "and f.idformato=" + Int32.Parse(cboCodigoFormato.SelectedItem.ToString()) + " and c.idcine=" + codigoCine + " and p.idpelicula=" + codigoPelicula + " ";
                        Query += "and cast(pp.fechahoraproyeccion as date) ='" + cboFechasFun.SelectedItem.ToString() + "' and pp.estatus=1 and p.estatus=1 and s.estatus=1 ";
                        Query += "and pp.fechahoraproyeccion >= sysdate()";
                    }
                    else
                    {
                        Query = "select date_format(pp.fechahoraproyeccion, '%h:%i %p'), s.numero, pp.idproyeccionpelicula, s.idsala from proyeccionpelicula pp,";
                        Query += "idioma i, formato f, sala s, pelicula p, cine c where c.idcine=s.idcine and s.idsala=pp.idsala and pp.ididioma=i.ididioma ";
                        Query += "and pp.idformato=f.idformato and pp.idpelicula=p.idpelicula and i.ididioma=" + Int32.Parse(cboCodigoIdioma.SelectedItem.ToString()) + " ";
                        Query += "and f.idformato=" + Int32.Parse(cboCodigoFormato.SelectedItem.ToString()) + " and c.idcine=" + codigoCine + " and p.idpelicula=" + codigoPelicula + " ";
                        Query += "and cast(pp.fechahoraproyeccion as date) ='" + cboFechasFun.SelectedItem.ToString() + "' and pp.estatus=1 and p.estatus=1 and s.estatus=1 ";
                        Query += "and cast(pp.fechahoraproyeccion as time) between curTime() and '23:59:59'";
                    }
                    
                    OdbcDataReader Datos;
                    OdbcCommand Consulta = new OdbcCommand();
                    Consulta.CommandText = Query;
                    Consulta.Connection = conn.Conexion();
                    Datos = Consulta.ExecuteReader();
                    if (Datos.Read())
                    {
                        dgvFunciones.Rows.Add(Datos.GetString(1), Datos.GetString(0), Datos.GetString(2), Datos.GetString(3));
                        while (Datos.Read())
                        {
                            dgvFunciones.Rows.Add(Datos.GetString(1), Datos.GetString(0), Datos.GetString(2), Datos.GetString(3));
                        }
                        btnSIguiente.Enabled = true;
                    }
                    else
                    {
                        btnSIguiente.Enabled = false;
                    }
                   
                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
           
           
        }

        private void cboFechaFunciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboFechasFun.SelectedIndex = cboFechaFunciones.SelectedIndex;
        }

        private void cboFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoFormato.SelectedIndex = cboFormato.SelectedIndex;

        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoIdioma.SelectedIndex = cboIdioma.SelectedIndex;
        }

        private void dgvFunciones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
    
        }

        private void btnSIguiente_Click(object sender, EventArgs e)
        /*Se obtienen los datos para lso parametros que necesita el siguiente frm y se cambia
       de form para continuar con la compra o la reservación*/
        {

            int fila, idSala, idProyeccion;
            fila = dgvFunciones.CurrentRow.Index;
            idSala = Int32.Parse(dgvFunciones.Rows[fila].Cells[3].Value.ToString());
            idProyeccion = Int32.Parse(dgvFunciones.Rows[fila].Cells[2].Value.ToString());
            frmCantidadBoletos cantidad = new frmCantidadBoletos(lblNombrePelicula.Text, lblNombreCine.Text, codigoCine, idSala, idProyeccion, cboFechaFunciones.SelectedItem.ToString(), Int32.Parse(cboCodigoFormato.SelectedItem.ToString()));
            cantidad.lblHora.Text = dgvFunciones.Rows[fila].Cells[1].Value.ToString();
            cantidad.lblIdioma.Text = cboIdioma.SelectedItem.ToString();
            cantidad.lblNombreFormato.Text = cboFormato.SelectedItem.ToString();
            cantidad.lblSala.Text = dgvFunciones.Rows[fila].Cells[0].Value.ToString();
            this.Hide();
            cantidad.ShowDialog();
            try
            {
                this.Show();
            }
            catch (Exception)
            {
                Application.Exit();

            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        /*Boton para cerrar la aplicación*/
        {
            if (MessageBox.Show("\t           Cerrando...\n\n\tSeguro que desea cerrar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmFuncionesCine_Load(object sender, EventArgs e)
        {

        }
    }
}
