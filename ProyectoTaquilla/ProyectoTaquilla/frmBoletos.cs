using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaquilla
{
    public partial class frmBoletos : Form
    {
        public frmBoletos()
        {
            InitializeComponent();
            procAgregarImgAs();
            pcbAsientos[2, 2].Image = System.Drawing.Image.FromFile("D:/U/4 AÑO 2 SEM/ANALISIS 2/PRIMER PARCIAL/PROYECTO/ProyectoTaquilla/ProyectoTaquilla/ProyectoTaquilla/Imagenes/asientorojo.png");
            pcbAsientos[3, 2].Image = System.Drawing.Image.FromFile("D:/U/4 AÑO 2 SEM/ANALISIS 2/PRIMER PARCIAL/PROYECTO/ProyectoTaquilla/ProyectoTaquilla/ProyectoTaquilla/Imagenes/asientorojo.png");
            pcbAsientos[4, 2].Image = System.Drawing.Image.FromFile("D:/U/4 AÑO 2 SEM/ANALISIS 2/PRIMER PARCIAL/PROYECTO/ProyectoTaquilla/ProyectoTaquilla/ProyectoTaquilla/Imagenes/asientorojo.png");
            pcbAsientos[2, 4].Image = System.Drawing.Image.FromFile("D:/U/4 AÑO 2 SEM/ANALISIS 2/PRIMER PARCIAL/PROYECTO/ProyectoTaquilla/ProyectoTaquilla/ProyectoTaquilla/Imagenes/asientorojo.png");
            pcbAsientos[3, 4].Image = System.Drawing.Image.FromFile("D:/U/4 AÑO 2 SEM/ANALISIS 2/PRIMER PARCIAL/PROYECTO/ProyectoTaquilla/ProyectoTaquilla/ProyectoTaquilla/Imagenes/asientorojo.png");
            pcbAsientos[5, 3].Image = System.Drawing.Image.FromFile("D:/U/4 AÑO 2 SEM/ANALISIS 2/PRIMER PARCIAL/PROYECTO/ProyectoTaquilla/ProyectoTaquilla/ProyectoTaquilla/Imagenes/asientoazul.png");
            pcbAsientos[6, 3].Image = System.Drawing.Image.FromFile("D:/U/4 AÑO 2 SEM/ANALISIS 2/PRIMER PARCIAL/PROYECTO/ProyectoTaquilla/ProyectoTaquilla/ProyectoTaquilla/Imagenes/asientoazul.png");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        PictureBox[,] pcbAsientos = new PictureBox[10, 5];
        public void procAgregarImgAs()
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    pcbAsientos[i,j] = new PictureBox();
                    this.panel2.Controls.Add(pcbAsientos[i,j]);
                    pcbAsientos[i,j].Width = 50;
                    pcbAsientos[i,j].Height = 50;
                    pcbAsientos[i,j].Top = 60 * j;
                    pcbAsientos[i,j].Left = 60 * i;
                    //pcbAsientos[i, j].BackColor = Color.Red;
                    pcbAsientos[i, j].Image = System.Drawing.Image.FromFile("D:/U/4 AÑO 2 SEM/ANALISIS 2/PRIMER PARCIAL/PROYECTO/ProyectoTaquilla/ProyectoTaquilla/ProyectoTaquilla/Imagenes/asientoverde.png");
                    pcbAsientos[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                }
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFacturacion fac = new frmFacturacion();
            this.Hide();
            fac.Show();
        }
    }
}
