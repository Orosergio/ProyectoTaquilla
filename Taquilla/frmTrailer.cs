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
        {
            
            InitializeComponent();

            string html = " <html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='600' height='400' </iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = string.Format(html, url.Split('=')[1]);
        }

        private void frmTrailer_Load(object sender, EventArgs e)
        {

        }
    }
}
