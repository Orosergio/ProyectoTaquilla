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
        int boletos, tiempo, idProyeccionPelicula, idSala, idCine;
        double totalCompra;
        List<clsBoletos> infoBoletosComprados = new List<clsBoletos>();
        List<clsBoletos> infoAsientosElegidos = new List<clsBoletos>();
        PictureBox[,] pcbAsientos = new PictureBox[10, 10];
        clsConexion cn = new clsConexion();

        //lo siguiente es para que el form pueda obtener datos que serán enviados desde el form de cantidad de boletos  
        public frmBoletos(double total, int cine, int sala, List<clsBoletos> infoBoletos, int proyeccion)
        {
            InitializeComponent();
            //aquí se igualan las variables recibidas a las variables propias globales de este form
            idSala = sala;
            idCine = cine;
            idProyeccionPelicula = proyeccion;
            totalCompra = total;
            infoBoletosComprados = infoBoletos;
            //se llama el procedimiento para agregar todas las imágenes de los asientos de acuerdo al tamaño que tiene la sala que fue elegida.
            procAgregarImgAs();
        }

        private void frmBoletos_Load(object sender, EventArgs e)
        {
            //cuando el form cargue manda a llamar la funcion de obtener tiempo para saber cuánto tiempo tiene el cliente para hacer su compra o reservación.
            tiempo = funcObtenerTiempoCompra();
            //empieza a contar el timer
            tmrTiempo.Enabled = true;
            //se llama el procedimiento para marcar en rojo los asientos ocupados.
            procAsientosOcupados();
            lblCantBoletosRes.Text = lblCantBoletos.Text.ToString();
            boletos = int.Parse(lblCantBoletosRes.Text.ToString());
        }

        //procedimiento para marcar en rojo los asientos ocupados.
        private void procAsientosOcupados()
        {
            try
            {
                //consulta para obtener los asientos que están ocupados de la sala escogida de la tabla de asientos comprados
                string consulta = "SELECT A.FILA, A.NUMERO FROM ASIENTOVENDIDO A, FACTURAENCABEZADO F WHERE F.IDFACTURAENCABEZADO=A.IDFACTURAENCABEZADO AND F.IDPROYECCIONPELICULA= " + idProyeccionPelicula;
                OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                OdbcDataReader asientosOcupados = comm.ExecuteReader();
                while (asientosOcupados.Read())
                {
                    //todos los encontrados se marcan en color rojo.
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
                //consulta para obtener los asientos que están ocupados de la sala escogida de la tabla de asientos reservados
                string consulta = "SELECT A.FILA, A.NUMERO FROM ASIENTORESERVADO A, RESERVACIONENCABEZADO F WHERE F.IDRESERVACIONENCABEZADO=A.IDRESERVACIONENCABEZADO AND F.IDPROYECCIONPELICULA= " + idProyeccionPelicula;
                OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                OdbcDataReader asientosOcupados = comm.ExecuteReader();
                while (asientosOcupados.Read())
                {
                    //todos los encontrados se marcan en color rojo.
                    pcbAsientos[asientosOcupados.GetInt32(1) - 1, asientosOcupados.GetInt32(0) - 1].Load("Imagenes/asientorojo.png");
                    pcbAsientos[asientosOcupados.GetInt32(1) - 1, asientosOcupados.GetInt32(0) - 1].Tag = "asientorojo.png";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //procedimiento para agregar todas las imágenes de los asientos de acuerdo al tamaño que tiene la sala que fue elegida.
        public void procAgregarImgAs()
        {
            //se llama la función de obtener el tamaño de la sala para guardarlo en la variable
            int tamano = funcObtenerTamano();
            //se divide el tamaño entre 10 porque la fila siempre va a tener 10 asientos
            tamano = tamano / 10;
            if (tamano == 5)
            {
                lblF.Visible = false;
                lblG.Visible = false;
                lblH.Visible = false;
                lblI.Visible = false;
                lblJ.Visible = false;
            }
            else if (tamano == 7)
            {
                lblH.Visible = false;
                lblI.Visible = false;
                lblJ.Visible = false;
            }
            //ciclos para llenar de imágenes la matriz de asientos.
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < tamano; j++)
                {
                    //se asigna a la posición de la matriz un nuevo pictureBox
                    pcbAsientos[i, j] = new PictureBox();
                    //se agrega al panel el pictureBox creado
                    this.pnlAsientos.Controls.Add(pcbAsientos[i, j]);
                    //se asigna el alto y ancho de la imagen
                    pcbAsientos[i, j].Width = 45;
                    pcbAsientos[i, j].Height = 45;
                    //se asignan las posiciones donde se van a mostrar
                    pcbAsientos[i, j].Top = 450 - (50 * j);
                    pcbAsientos[i, j].Left = 50 * i;
                    //se asigna la imagen de color verde 
                    pcbAsientos[i, j].Load("Imagenes/asientoverde.png");
                    pcbAsientos[i, j].Tag = "asientoverde.png";
                    pcbAsientos[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    //se asigna un nombre único a cada imagen
                    pcbAsientos[i, j].Name = "pcbAsiento," + i + "," + j;
                    //se crea un evento de click para las imágenes de los asientos
                    pcbAsientos[i, j].Click += new System.EventHandler(this.imagePictureBox_Click);
                }
            }
        }

        //cuando el form cargue manda a llamar la funcion de obtener tiempo para saber cuánto tiempo tiene el cliente para hacer su compra o reservación.
        private int funcObtenerTiempoCompra()
        {
            int tiempo = 0;
            try
            {
                //consulta para obtener el tiempo de compra o reserva del cine elegido
                string consulta = "SELECT TIEMPOCOMPRA FROM CINE WHERE IDCINE= " + idCine;
                OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                OdbcDataReader tiempoCompra = comm.ExecuteReader();
                if (tiempoCompra.Read())
                {
                    //se guarda en la variable
                    tiempo = tiempoCompra.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //devuelve el tiempo
            return tiempo;
        }

        //función de obtener el tamaño de la sala para guardarlo en la variable
        private int funcObtenerTamano()
        {
            int tamano = 0;
            try
            {
                //consulta para obtener el tamaño de la sala elegida
                string consulta = "SELECT T.NOASIENTOS FROM TAMANOSALA T, SALA S WHERE S.IDTIPOSALA=T.IDTIPOSALA AND S.IDSALA= " + idSala;
                OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                OdbcDataReader tamanoSala = comm.ExecuteReader();

                if (tamanoSala.Read())
                {
                    //se guarda en la variable
                    tamano = tamanoSala.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //devuelve el tamaño
            return tamano;
        }

        //método click para cuando elija un asiento
        private void imagePictureBox_Click(object sender, System.EventArgs e)
        {
            //se obtiene que imagen fue seleccionada
            PictureBox pic = sender as PictureBox;
            //se guarda el nombre de la imagen seleccionada
            string nombre = Path.GetFileName(pic.Tag.ToString());
            if (Path.GetFileName(pic.Tag.ToString()) != "asientorojo.png")
            {
                string nombreImagen = pic.Name.ToString();
                string[] nombreDividido = nombreImagen.Split(',');
                int contador = 0, fila = 0, columna = 0;
                //se divide el nombre para tener la fila y columna seleccionada
                foreach (var campo in nombreDividido)
                {
                    if (contador == 1)
                    {
                        fila = int.Parse(campo.ToString()) + 1;
                    }
                    else if (contador == 2)
                    {
                        columna = int.Parse(campo.ToString()) + 1;
                    }
                    contador++;
                }
                //si el asiento está en azul al darle clik cambia el color a verde y suma la cantidad de boletos que tiene disponible
                if (Path.GetFileName(pic.Tag.ToString()) == "asientoazul.png")
                {
                    pic.Load("Imagenes/asientoverde.png");
                    pic.Tag = "asientoverde.png";
                    boletos++;
                    //muestra la cantidad de boletos actualmente
                    lblCantBoletosRes.Text = boletos.ToString();
                    //elimina de la lista de asientos el asiento que acaba de seleccionar
                    infoAsientosElegidos.Remove(infoAsientosElegidos.Single(x => x.idBoletos == columna && x.cantidadBoletos == fila));
                }
                //si aún cuenta con boletos
                else if (boletos > 0)
                {
                    //si el asiento está en verde al darle clik cambia el color a azul y suma la cantidad de boletos que tiene disponible
                    if (Path.GetFileName(pic.Tag.ToString()) == "asientoverde.png")
                    {
                        //se divide el nombre para tener la fila y columna seleccionada
                        foreach (var campo in nombreDividido)
                        {
                            if (contador == 1)
                            {
                                fila = int.Parse(campo.ToString());
                            }
                            else if (contador == 2)
                            {
                                columna = int.Parse(campo.ToString());
                            }
                            contador++;
                        }
                        pic.Load("Imagenes/asientoazul.png");
                        pic.Tag = "asientoazul.png";
                        boletos--;
                        lblCantBoletosRes.Text = boletos.ToString();
                        //agrega a la lista el asiento seleccionado
                        infoAsientosElegidos.Add(new clsBoletos(columna, fila));
                    }
                }
                else
                {
                    MessageBox.Show("Ya no cuenta con boletos, desmarque alguno si quiere cambiar su elección o regrese para agregar más boletos.", "ELECCIÓN NO VÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Este asiento no está disponible.", "ELECCIÓN NO DISPONIBLE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayuda/AyudaTaquilla.chm", "Asientos.html");
        }






        //pregunta al usuario si esta seguro de cerrar cuando presione la x
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("\t           Cerrando...\n\n\tSeguro que desea cerrar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //regresa al form anterior
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            //revisa si ya terminó de elegir sus boletos
            if (int.Parse(lblCantBoletosRes.Text.ToString()) == 0)
            {
                //manda los parametros al form de facturación
                frmDatosCliente facturacion = new frmDatosCliente(infoBoletosComprados, infoAsientosElegidos, idSala, idCine, idProyeccionPelicula);
                //copia información esencial a labels del form de facturación.
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
                tiempo = tiempo + 4;
                //oculta este form y muestra el otro
                this.Hide();
                facturacion.ShowDialog();
                try
                {
                    this.Show();
                }
                catch (Exception)
                {

                    Application.Exit();
                }
                
            }
            else
            {
                MessageBox.Show("Aún cuenta con boletos disponibles por escoger.", "BOLETOS DISPONIBLES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            //cada segundo que pasa se resta el tiempo y se muestra en pantalla
            tiempo--;
            lblCantTiempoRestante.Text = tiempo.ToString();
            //si el tiempo llega a 0 muestra un mensaje y lo regresa hasta a cartelera
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
