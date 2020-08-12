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
        int boletos,tiempo=80,idProyeccionPelicula=1,idSala=1;
        conexion cn = new conexion();
        public frmBoletos()
        {
            InitializeComponent();
            boletos = int.Parse(lblCantBoletos.Text.ToString());
            procAgregarImgAs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrTiempo.Enabled = true;
            procAsientosOcupados();
        }
        
        private void procAsientosOcupados()
        {
            try
            {
                string consulta = "SELECT FILA,NUMERO FROM ASIENTO WHERE IDPROYECCIONPELICULA= " + idProyeccionPelicula;
                OdbcCommand comm = new OdbcCommand(consulta, cn.Conexion());
                OdbcDataReader asientosOcupados = comm.ExecuteReader();
                while (asientosOcupados.Read())
                {
                    pcbAsientos[asientosOcupados.GetInt32(1) - 1, asientosOcupados.GetInt32(0) - 1].Load("Imagenes/asientorojo.png");
                    pcbAsientos[asientosOcupados.GetInt32(1) - 1, asientosOcupados.GetInt32(0) - 1].Tag = "asientorojo.png";
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        PictureBox[,] pcbAsientos = new PictureBox[10, 10];
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
                if (Path.GetFileName(pic.Tag.ToString()) == "asientoazul.png")
                {
                    pic.Load("Imagenes/asientoverde.png");
                    pic.Tag = "asientoverde.png";
                    boletos++;
                    lblCantBoletosRes.Text = boletos.ToString();
                }
                else if (boletos > 0)
                {
                    if (Path.GetFileName(pic.Tag.ToString()) == "asientoverde.png")
                    {
                        pic.Load("Imagenes/asientoazul.png");
                        pic.Tag = "asientoazul.png";
                        boletos--;
                        lblCantBoletosRes.Text = boletos.ToString();
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

        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFacturacion fac = new frmFacturacion();
            this.Hide();
            fac.Show();
        }

        private void pnlAsientos_MouseClick(object sender, MouseEventArgs e)
        {
            /*int x = MousePosition.X;
            int y = MousePosition.Y;
            MessageBox.Show("x: " + x + " y: " + y); */
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            tiempo--;
            lblCantTiempoRestante.Text = tiempo.ToString() + " Segundo(s)";
            if (tiempo == 0)
            {
                this.Close();
            }
        }
    }
}
