using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taquilla
{
    public partial class frmTrailer : Form
    {


       
        public frmTrailer(string url)
            /*Se asigna que solo muestre el video en lugar de todo el contenedor*/
        {
            
            InitializeComponent();
              string html = " <html><head>";
              html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible' />";
              html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='600' height='400' </iframe>";
              html += "</body></html>";
              this.webBrowser1.DocumentText = string.Format(html, url.Split('=')[1]);
        }

        private void frmTrailer_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayuda/AyudaTaquilla.chm", "Trailer.html");
        }
    }
}
