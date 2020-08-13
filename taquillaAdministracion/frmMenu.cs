using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taquillaAdministracion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pnlMenuOpciones.Width == 250)
            {
                pnlMenuOpciones.Width = 65;
            }
            else 
            
                pnlMenuOpciones.Width = 250;
            
        }
    }
}
