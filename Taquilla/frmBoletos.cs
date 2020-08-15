using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taquilla
{
    public partial class frmBoletos : Form
    {
        int boletos,tiempo,idProyeccionPelicula,idSala,idCine;
        double totalCompra;
        List<clsBoletos> infoBoletosComprados = new List<clsBoletos>();
        List<clsBoletos> infoAsientosElegidos = new List<clsBoletos>();
        PictureBox[,] pcbAsientos = new PictureBox[10, 10];
        clsConexion cn = new clsConexion();
        public frmBoletos(double total, int cine, int sala, List<clsBoletos> infoBoletos, int proyeccion)
        {
            InitializeComponent();
            idSala = sala;
            idCine = cine;
            idProyeccionPelicula = proyeccion;
            totalCompra = total;
            infoBoletosComprados = infoBoletos;
            procAgregarImgAs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tiempo = funcObtenerTiempoCompra();
            tmrTiempo.Enabled = true;
            procAsientosOcupados();
            lblCantBoletosRes.Text = lblCantBoletos.Text.ToString();
            boletos = int.Parse(lblCantBoletosRes.Text.ToString());
        }

        private void procAsientosOcupados()
        {
            try
            {
                string consulta = "SELECT A.FILA, A.NUMERO FROM ASIENTOVENDIDO A, FACTURAENCABEZADO F WHERE F.IDFACTURAENCABEZADO=A.IDFACTURAENCABEZADO AND F.IDPROYECCIONPELICULA= " + idProyeccionPelicula;
                OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                OdbcDataReader asientosOcupados = comm.ExecuteReader();
                while (asientosOcupados.Read())
                {
                    pcbAsientos[asientosOcupados.GetInt32(1) - 1, asientosOcupados.GetInt32(0) - 1].Load("Imagenes/asientorojo.png");
                    pcbAsientos[asientosOcupados.GetInt32(1) - 1, asientosOcupados.GetInt32(0) - 1].Tag = "asientorojo.png";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                string consulta = "SELECT A.FILA, A.NUMERO FROM ASIENTORESERVADO A, RESERVACIONENCABEZADO F WHERE F.IDRESERVACIONENCABEZADO=A.IDRESERVACIONENCABEZADO AND F.IDPROYECCIONPELICULA= " + idProyeccionPelicula;
                OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                OdbcDataReader asientosOcupados = comm.ExecuteReader();
                while (asientosOcupados.Read())
                {
                    pcbAsientos[asientosOcupados.GetInt32(1) - 1, asientosOcupados.GetInt32(0) - 1].Load("Imagenes/asientorojo.png");
                    pcbAsientos[asientosOcupados.GetInt32(1) - 1, asientosOcupados.GetInt32(0) - 1].Tag = "asientorojo.png";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void procAgregarImgAs()
        {
            int tamano = funcObtenerTamano();
            tamano = tamano / 10;
            if (tamano == 5)
            {
                lblF.Visible = false;
                lblG.Visible = false;
                lblH.Visible = false;
                lblI.Visible = false;
                lblJ.Visible = false;
            }else if (tamano == 7)
            {
                lblH.Visible = false;
                lblI.Visible = false;
                lblJ.Visible = false;
            }
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < tamano; j++)
                {
                    pcbAsientos[i,j] = new PictureBox();
                    this.pnlAsientos.Controls.Add(pcbAsientos[i,j]);
                    pcbAsientos[i,j].Width = 45;
                    pcbAsientos[i,j].Height = 45;
                    pcbAsientos[i,j].Top = 450-(50 * j);
                    pcbAsientos[i,j].Left =  50 * i;
                    pcbAsientos[i, j].Load("Imagenes/asientoverde.png");
                    pcbAsientos[i,j].Tag= "asientoverde.png";
                    pcbAsientos[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    pcbAsientos[i, j].Name = "pcbAsiento," + i + "," + j;
                    pcbAsientos[i,j].Click += new System.EventHandler(this.imagePictureBox_Click);
                }
            }
        }

        private int funcObtenerTiempoCompra()
        {
            int tiempo = 0;
            try
            {
                MessageBox.Show(idCine.ToString());
                string consulta = "SELECT TIEMPOCOMPRA FROM CINE WHERE IDCINE= " + idCine;
                OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                OdbcDataReader tiempoCompra = comm.ExecuteReader();
                if (tiempoCompra.Read())
                {
                    tiempo = tiempoCompra.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return tiempo;
        }

        private int funcObtenerTamano()
        {
            int tamano=0;
            try
            {
                string consulta = "SELECT T.NOASIENTOS FROM TAMANOSALA T, SALA S WHERE S.IDTIPOSALA=T.IDTIPOSALA AND S.IDSALA= " + idSala;
                OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                OdbcDataReader tamanoSala = comm.ExecuteReader();

                if (tamanoSala.Read())
                {
                    tamano = tamanoSala.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return tamano;
        }

        private void imagePictureBox_Click(object sender, System.EventArgs e)
        {
            PictureBox pic = sender as PictureBox; 
            string nombre = Path.GetFileName(pic.Tag.ToString());
            if (Path.GetFileName(pic.Tag.ToString()) != "asientorojo.png")
            {
                string nombreImagen = pic.Name.ToString();
                string[] nombreDividido = nombreImagen.Split(',');
                int contador = 0, fila = 0, columna = 0;
                foreach (var campo in nombreDividido)
                {
                    if (contador == 1)
                    {
                        fila = int.Parse(campo.ToString())+1;
                    }
                    else if (contador == 2)
                    {
                        columna = int.Parse(campo.ToString())+1;
                    }
                    contador++;
                }
                if (Path.GetFileName(pic.Tag.ToString()) == "asientoazul.png")
                {
                    pic.Load("Imagenes/asientoverde.png");
                    pic.Tag = "asientoverde.png";
                    boletos++;
                    lblCantBoletosRes.Text = boletos.ToString();
                    //infoAsientosElegidos.Remove(new clsBoletos(fila,columna));
                    infoAsientosElegidos.Remove(infoAsientosElegidos.Single(x => x.idBoletos == fila && x.cantidadBoletos==columna));
                }
                else if (boletos > 0)
                {
                    if (Path.GetFileName(pic.Tag.ToString()) == "asientoverde.png")
                    {
                        foreach(var campo in nombreDividido)
                        {
                            if (contador == 1)
                            {
                                fila = int.Parse(campo.ToString());
                            }else if (contador == 2)
                            {
                                columna = int.Parse(campo.ToString());
                            }
                            contador++;
                        }
                        pic.Load("Imagenes/asientoazul.png");
                        pic.Tag = "asientoazul.png";
                        boletos--;
                        lblCantBoletosRes.Text = boletos.ToString();
                        infoAsientosElegidos.Add(new clsBoletos(fila, columna));
                    }
                }
                else
                {
                    MessageBox.Show("Ya no cuenta con boletos, desmarque alguno si quiere cambiar su elección o regrese para agregar más boletos.","ELECCIÓN NO VÁLIDA",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Este asiento no está disponible.","ELECCIÓN NO DISPONIBLE",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("\t           Cerrando...\n\n\tSeguro que desea cerrar?", "ADVERTENCIA", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblCantBoletosRes.Text.ToString()) == 0)
            {
                /*foreach (clsBoletos asiento in infoAsientosElegidos)
                {
                    MessageBox.Show(asiento.ToString());

                }*/
                frmFacturacion facturacion = new frmFacturacion(infoBoletosComprados, infoAsientosElegidos,idSala,idCine,idProyeccionPelicula);
                facturacion.lblNombrePelicula.Text = lblNombrePelicula.Text.ToString();
                facturacion.lblCineElegido.Text = lblCineElegido.Text.ToString();
                facturacion.lblNoSala.Text = lblNoSala.Text.ToString();
                facturacion.lblFormatoPelicula.Text = lblFormatoPelicula.Text.ToString();
                facturacion.lblIdiomaPelicula.Text = lblIdiomaPelicula.Text.ToString();
                facturacion.lblHoraFuncion.Text = lblHoraFuncion.Text.ToString();
                facturacion.lblDiaFuncion.Text = lblDiaFuncion.Text.ToString();
                facturacion.lblCantSubTotal.Text = totalCompra.ToString();
                facturacion.lblCantTotal.Text = totalCompra.ToString();
                facturacion.lblCantTiempoRestante.Text = lblCantTiempoRestante.Text.ToString();
                tiempo=tiempo+4;
                this.Hide();
                facturacion.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Aún cuenta con boletos disponibles por escoger.", "BOLETOS DISPONIBLES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
        }

        private void pnlAsientos_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            tiempo--;
            lblCantTiempoRestante.Text = tiempo.ToString();
            if (tiempo == 0)
            {
                tmrTiempo.Stop();
                
                if (MessageBox.Show("Se terminó el tiempo de compra establecido.", "TIEMPO FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    frmCartelera cartelera = new frmCartelera();
                    this.Hide();
                    cartelera.ShowDialog();
                    this.Show();
                }  
            }
        }
    }
}
