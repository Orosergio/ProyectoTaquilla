using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.Odbc;

namespace Taquilla
{
    public partial class frmCantidadBoletos : Form
    {
        string nombrePeliculas, nombreCines, fechas;
        int idCines, idSalas, idProyeccions, idFormatos, cantidadBoletos=0;
        int idTipo1, idTipo2, idTipo3;
        clsConexion conn = new clsConexion();
        public frmCantidadBoletos(string nombrePelicula, string nombreCine, int idCine, int idSala, int idProyeccion, string fecha, int idFormato)
        {
            InitializeComponent();
            nombrePeliculas = nombrePelicula;
            nombreCines = nombreCine;
            idCines = idCine;
            idSalas = idSala;
            idProyeccions = idProyeccion;
            fechas = fecha;
            idFormatos = idFormato;
            procPrecios(1);
            procPrecios(2);
            procPrecios(3);
            MessageBox.Show(nombrePeliculas+nombreCines+idCines.ToString()+idSalas.ToString()+idProyeccions.ToString()+fechas+idFormatos.ToString());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            
        }

        private void btnMas1_Click(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(lblCantidadTercera.Text);
            double precio = double.Parse(lblPrecioTerceraEdad.Text);
            double total,totales;
            cantidad++;
            cantidadBoletos++;
            lblCantidadTercera.Text = cantidad.ToString();
            total = cantidad * precio;
            lblSubTercera.Text = total.ToString();
            totales =0;
            totales = (double.Parse(lblSubTercera.Text)) + (double.Parse(lblSubAdulto.Text)) + (double.Parse(lblSubNinos.Text));
            lblCantidadTotal.Text = totales.ToString();
            if (cantidad>0)
            {
                btnMenos1.Enabled = true;
            }
           

        }

        private void btnMas2_Click(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(lblCantidadAdulto.Text);
            double precio = double.Parse(lblPrecioAdulto.Text);
            double total,totales;
            cantidad++;
            cantidadBoletos++;
            lblCantidadAdulto.Text = cantidad.ToString();
            total = cantidad * precio;
            lblSubAdulto.Text = total.ToString();
            totales = 0;
            totales = (double.Parse(lblSubTercera.Text)) + (double.Parse(lblSubAdulto.Text)) + (double.Parse(lblSubNinos.Text));
            lblCantidadTotal.Text = totales.ToString();
            if (cantidad > 0)
            {
                btnMenos2.Enabled = true;
            }
        }

        private void btnMas3_Click(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(lblCantidadNinos.Text);
            double precio = double.Parse(lblPrecioNino.Text);
            double total,totales;
            cantidad++;
            cantidadBoletos++;
            lblCantidadNinos.Text = cantidad.ToString();
            total = cantidad * precio;
            lblSubNinos.Text = total.ToString();
            totales = 0;
            totales = (double.Parse(lblSubTercera.Text)) + (double.Parse(lblSubAdulto.Text)) + (double.Parse(lblSubNinos.Text));
            lblCantidadTotal.Text = totales.ToString();
            if (cantidad > 0)
            {
                btnMenos3.Enabled = true;
            }
        }

        private void btnMenos1_Click(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(lblCantidadTercera.Text);
            double precio = double.Parse(lblPrecioTerceraEdad.Text);
            double total,totales;
            if (cantidad==0)
            {
                btnMenos1.Enabled = false;
            }
            else
            {
                cantidad--;
                cantidadBoletos--;
                lblCantidadTercera.Text = cantidad.ToString();
            }
            total = cantidad * precio;
            lblSubTercera.Text = total.ToString();
            totales = 0;
            totales = (double.Parse(lblSubTercera.Text)) + (double.Parse(lblSubAdulto.Text)) + (double.Parse(lblSubNinos.Text));
            lblCantidadTotal.Text = totales.ToString();
        }

        private void btnMenos2_Click(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(lblCantidadAdulto.Text);
            double precio = double.Parse(lblPrecioAdulto.Text);
            double total,totales;
            if (cantidad == 0)
            {
                btnMenos2.Enabled = false;
            }
            else
            {
                cantidad--;
                cantidadBoletos--;
                lblCantidadAdulto.Text = cantidad.ToString();
            }
            total = cantidad * precio;
            lblSubAdulto.Text = total.ToString();
            totales = 0;
            totales = (double.Parse(lblSubTercera.Text)) + (double.Parse(lblSubAdulto.Text)) + (double.Parse(lblSubNinos.Text));
            lblCantidadTotal.Text = totales.ToString();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            List<clsBoletos> infoBoletos = new List<clsBoletos>();
            if (Int32.Parse(lblCantidadTercera.Text)!=0)
            {
                infoBoletos.Add(new clsBoletos(idTipo1, Int32.Parse(lblCantidadTercera.Text)));
            }
            if (Int32.Parse(lblCantidadAdulto.Text) != 0)
            {
                infoBoletos.Add(new clsBoletos(idTipo2, Int32.Parse(lblCantidadAdulto.Text)));
            }
            if (Int32.Parse(lblCantidadNinos.Text) != 0)
            {
                infoBoletos.Add(new clsBoletos(idTipo3, Int32.Parse(lblCantidadNinos.Text)));
            }
            frmBoletos boletos = new frmBoletos(double.Parse(lblCantidadTotal.Text),idCines,idSalas, infoBoletos,idProyeccions);
            boletos.lblNombrePelicula.Text = nombrePeliculas;
            boletos.lblCineElegido.Text = nombreCines;
            boletos.lblNoSala.Text = lblSala.Text;
            boletos.lblCantBoletos.Text = cantidadBoletos.ToString();
            boletos.lblFormatoPelicula.Text = lblFormato.Text;
            boletos.lblIdiomaPelicula.Text = lblIdioma.Text;
            boletos.lblHoraFuncion.Text = lblHora.Text;
            boletos.lblDiaFuncion.Text = fechas;
            this.Hide();
            boletos.ShowDialog();
            this.Show();
        }

        private void lblFormato_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(lblCantidadNinos.Text);
            double precio = double.Parse(lblPrecioNino.Text);
            double total,totales;
            if (cantidad == 0)
            {
                btnMenos3.Enabled = false;
            }
            else
            {
                cantidad--;
                cantidadBoletos--;
                lblCantidadNinos.Text = cantidad.ToString();
            }
            total = cantidad * precio;
            lblSubNinos.Text = total.ToString();
            totales = 0;
            totales = (double.Parse(lblSubTercera.Text)) + (double.Parse(lblSubAdulto.Text)) + (double.Parse(lblSubNinos.Text));
            lblCantidadTotal.Text = totales.ToString();
        }

        private void Boletos_Load(object sender, EventArgs e)
        {

        }
        public void procPrecios(int opcion)
        {
            try
            {
                string Query = "select b.precio , b.idboleto from boleto b, formato f, tipoboleto tp where b.idformato=f.idformato and tp.idtipoboleto=b.idtipoboleto and f.idformato=" + idFormatos+" and tp.idtipoboleto="+opcion;
                OdbcDataReader Datos;
                OdbcCommand Consulta = new OdbcCommand();
                Consulta.CommandText = Query;
                Consulta.Connection = conn.Conexion();
                Datos = Consulta.ExecuteReader();
                while (Datos.Read())
                {
                    switch (opcion)
                    {
                        case 1:
                            lblPrecioTerceraEdad.Text = Datos.GetString(0);
                            idTipo1 = Int32.Parse(Datos.GetString(1));
                            break;
                        case 2:
                            lblPrecioAdulto.Text = Datos.GetString(0);
                            idTipo2 = Int32.Parse(Datos.GetString(1));
                            break;
                        case 3:
                            lblPrecioNino.Text = Datos.GetString(0);
                            idTipo3 = Int32.Parse(Datos.GetString(1));
                            break;  
                        default:
                            break;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
