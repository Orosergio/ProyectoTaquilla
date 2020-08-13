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
        conexion conn = new conexion();
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
        {
            try
            {
                string Query = "select distinct date_format(pp.fechahoraproyeccion, '%d - %m - %Y'),  date_format(pp.fechahoraproyeccion, '%Y-%m-%d') from pelicula p, proyeccionpelicula pp, sala s, cine c where p.idpelicula=pp.idpelicula and pp.idsala=s.idsala and s.idcine=c.idcine and c.idcine=" + codigoCine+"  AND P.IDPELICULA="+codigoPelicula;
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
        {
           
            try
            {
                string Query = "select date_format(pp.fechahoraproyeccion, '%h:%i %p'), s.numero, pp.idproyeccionpelicula, s.idsala from proyeccionpelicula pp, idioma i, formato f, sala s, pelicula p where s.idsala=pp.idsala and pp.ididioma=i.ididioma and pp.idformato=f.idformato and pp.idpelicula=p.idpelicula and i.ididioma="+Int32.Parse(cboCodigoIdioma.SelectedItem.ToString())+" and f.idformato="+Int32.Parse(cboCodigoFormato.SelectedItem.ToString())+ " and p.idpelicula="+codigoPelicula+ " and cast(pp.fechahoraproyeccion as date) ='" + cboFechasFun.SelectedItem.ToString()+"'";
                OdbcDataReader Datos;
                OdbcCommand Consulta = new OdbcCommand();
                Consulta.CommandText = Query;
                Consulta.Connection = conn.Conexion();
                Datos = Consulta.ExecuteReader();                
                while (Datos.Read()){
                    dgvFunciones.Rows.Add(Datos.GetString(1), Datos.GetString(0), Datos.GetString(2), Datos.GetString(3));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
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
        {
            int fila, idSala, idProyeccion;
            fila = dgvFunciones.CurrentRow.Index;
            idSala = Int32.Parse(dgvFunciones.Rows[fila].Cells[3].Value.ToString());
            idProyeccion = Int32.Parse(dgvFunciones.Rows[fila].Cells[2].Value.ToString());
            MessageBox.Show(idSala.ToString());
            frmCantidadBoletos cantidad = new frmCantidadBoletos(lblNombrePelicula.Text, lblNombreCine.Text, codigoCine, idSala, idProyeccion, cboFechaFunciones.SelectedItem.ToString(), Int32.Parse(cboCodigoFormato.SelectedItem.ToString()));
            cantidad.lblHora.Text = dgvFunciones.Rows[fila].Cells[1].Value.ToString();
            cantidad.lblIdioma.Text = cboIdioma.SelectedItem.ToString();
            cantidad.lblNombreFormato.Text = cboFormato.SelectedItem.ToString();
            cantidad.lblSala.Text = dgvFunciones.Rows[fila].Cells[0].Value.ToString();
            this.Hide();
            cantidad.ShowDialog();
            this.Show();
            ;
        }

        private void frmFuncionesCine_Load(object sender, EventArgs e)
        {

        }
    }
}
