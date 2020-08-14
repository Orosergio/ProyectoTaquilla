using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectomercado
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            string sConsulta;
            if (txtnombre.Text!="" && txtapellido.Text!="")
            {               
               /* try
                {
                    string s = "datasource=127.0.0.1;port=3306;username=root;password=;database=SUPERMERCADO";
                    MySqlConnection database = new MySqlConnection(s);
                    database.Open();
                    sConsulta = "insert into cliente values ("+Convert.ToInt32(txtnit.Text)+",'"+txtnombre.Text+"','"+txtapellido.Text+"'); ";
                    MySqlCommand command = new MySqlCommand(sConsulta, database);
                    MySqlDataReader myReader = command.ExecuteReader();
                    database.Close();
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Mal");
                    throw;
                }*/
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
