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
    public partial class Usuario : Form
    {
        int iCodigo;
        bool bandera = false;
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            combobox();
            codigo();
        }
        public void combobox()
        {
            string sConsulta;
          /*  try
            {
                string s = "datasource=127.0.0.1;port=3306;username=root;password=;database=SUPERMERCADO";
                MySqlConnection database = new MySqlConnection(s);
                database.Open();
                sConsulta = "select * from tipousuario";
                MySqlCommand command = new MySqlCommand(sConsulta, database);
                MySqlDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    combotipo.Items.Add(Convert.ToString(myReader["TipoUsuario"]));
                    comboid.Items.Add(Convert.ToString(myReader["IdTipoUser"]));
                }          
                database.Close();
            }
            catch (Exception)
            {

                throw;
            }*/
        }

        private void combotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboid.SelectedIndex = combotipo.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComprobarAdministrador();
            if (bandera==true)
            {
                if (txtcontran.Text!="" && txtusuarion.Text!="" && comboid.Text!="")
                {
                    string sConsulta, sUsuario, sContra, sTipo;
                    sUsuario = txtusuarion.Text;
                    sContra = txtcontran.Text;
                    sTipo = comboid.Text;
                 /*   try
                    {
                        string s = "datasource=127.0.0.1;port=3306;username=root;password=;database=SUPERMERCADO";
                        MySqlConnection database = new MySqlConnection(s);
                        database.Open();
                        sConsulta = "insert into usuarios values("+iCodigo+",'"+sUsuario+"','"+sContra+"',"+Convert.ToInt32(sTipo)+");";
                        MySqlCommand command = new MySqlCommand(sConsulta, database);
                        MySqlDataReader myReader = command.ExecuteReader();
                        txtusuarion.Clear();
                        txtusuarioadmin.Clear();
                        txtcontradmin.Clear();
                        txtcontran.Clear();                        
                        iCodigo += 1;
                        database.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error");
                        throw;
                    }*/
                }
            }
        }

       
        public void codigo()
        {
            {
              /*  try
                {
                    string s = "datasource=127.0.0.1;port=3306;username=root;password=;database=SUPERMERCADO";
                    MySqlConnection database = new MySqlConnection(s);
                    database.Open();
                    string sConsulta = "select count(iduser) from usuarios";
                    MySqlCommand command = new MySqlCommand(sConsulta, database);
                    int numero;
                    numero = Convert.ToInt32(command.ExecuteScalar());
                    database.Close();
                    if (numero == 0)
                    {
                        iCodigo = 1;
                    }
                    else
                    {
                        iCodigo = numero + 1;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                    throw;
                }*/
            }
        }
        public void ComprobarAdministrador()
        {
            string sCuenta,sConsulta;
            string sContra;

          /*  try
            {
                string s = "datasource=127.0.0.1;port=3306;username=root;password=;database=SUPERMERCADO";
                MySqlConnection database = new MySqlConnection(s);
                database.Open();
                sConsulta = "select nombreusuario,contraseña from usuarios where nombreusuario='"+Convert.ToString(txtusuarioadmin.Text)+"' and contraseña='"+Convert.ToString(txtcontradmin.Text)+"' and tipo_usuario = 1";
                MySqlCommand command = new MySqlCommand(sConsulta, database);
                MySqlDataReader myReader = command.ExecuteReader();

                myReader.Read();
                sCuenta = myReader[0].ToString();
                sContra = myReader[1].ToString();
               
                database.Close();
                if (sCuenta != "" && sContra != "")
                {
                    bandera = true;
                }

            }
            catch (Exception)
            {
                bandera = false;
            }*/
        }
    }
}
