using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyectomercado;

namespace FinalProyecto
{
    public partial class Empleado : Form
    {
        int codigo, codigo2;
        /*MySqlCommand Query = new MySqlCommand();
        MySqlCommand Query2 = new MySqlCommand();
        MySqlConnection Conexion;
        MySqlDataReader consultar,consultar2;
        public string sql = "datasource=127.0.0.1;port=3306;username=root;password=;database=SUPERMERCADO";*/
        public Empleado()
        {
            InitializeComponent();
            connection();
            codigoTelefono();
            codigoaument();
            codigoCorreo();
            codigo = 0;
           /* try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT * FROM puesto";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                while (consultar.Read())
                {
                    cmbidpuesto.Items.Add(consultar.GetInt32(0));
                    cmbpuesto.Items.Add(consultar.GetString(1));
                }
                Conexion.Close();

                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query2.CommandText = "SELECT * FROM jornada";
                Query2.Connection = Conexion;
                consultar2 = Query2.ExecuteReader();
                while (consultar2.Read())
                {
                    cmbidjornada.Items.Add(consultar2.GetInt32(0));
                    cmbjornada.Items.Add(consultar2.GetString(1));
                }
                Conexion.Close();



            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }*/

        }
        int iCodTelefono=0, iCodCorreo=0;
        public void codigoTelefono()
        {
            {
               /* try
                {
                    string s = "datasource=127.0.0.1;port=3306;username=root;password=;database=SUPERMERCADO";
                    MySqlConnection database = new MySqlConnection(s);
                    database.Open();
                    string sConsulta = "select count(idtelefono) from telefonoempleado";
                    MySqlCommand command = new MySqlCommand(sConsulta, database);
                    int numero;
                    numero = Convert.ToInt32(command.ExecuteScalar());
                    database.Close();
                    if (numero == 0)
                    {
                        iCodTelefono = 1;
                    }
                    else
                    {
                        iCodTelefono = numero + 1;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                    throw;
                }*/
            }
        }

        public void codigoCorreo()
        {
            {
               /* try
                {
                    string s = "datasource=127.0.0.1;port=3306;username=root;password=;database=SUPERMERCADO";
                    MySqlConnection database = new MySqlConnection(s);
                    database.Open();
                    string sConsulta = "select count(idcorreo) from correoempleado";
                    MySqlCommand command = new MySqlCommand(sConsulta, database);
                    int numero;
                    numero = Convert.ToInt32(command.ExecuteScalar());
                    database.Close();
                    if (numero == 0)
                    {
                        iCodCorreo = 1;
                    }
                    else
                    {
                        iCodCorreo = numero + 1;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                    throw;
                }*/
            }
        }

        public void connection()
        {
          /*  try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
              //  MessageBox.Show("Conectado con éxito");
                Conexion.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }*/
        }
        int iCodigo = 0;
        public void codigoaument()
        {
            {
               /* try
                {
                    string s = "datasource=127.0.0.1;port=3306;username=root;password=;database=SUPERMERCADO";
                    MySqlConnection database = new MySqlConnection(s);
                    database.Open();
                    string sConsulta = "select count(idempleado) from empleado";
                   
                   
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





        private void Btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            /*conexionbd conexion = new conexionbd();
            conexion.abrir();*/
            
        }

        private void Cmbjornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbidjornada.SelectedIndex = cmbjornada.SelectedIndex;
        }
        
        private void Lookemp_Click(object sender, EventArgs e)
        {
            this.Hide();
               /* INGRESOEMPLEADO frm = new INGRESOEMPLEADO();*/
           // frm.Show();
        }

        private void Addemail_Click(object sender, EventArgs e)
        {
            /*CorreoEmpleado frm = new CorreoEmpleado();*/
            //frm.Show();
        }

        private void Addphone_Click(object sender, EventArgs e)
        {
          //  TelefonoEmpleado frm = new TelefonoEmpleado();
           // frm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
          /*  if (cmbjornada.SelectedIndex != -1&& cmbpuesto.SelectedIndex != -1)
            {
                

                string consulta = "INSERT INTO empleado VALUES (@idempleado,@nombre,@apellido,@idpuesto,@fechanac,@direccion,@salario,@fechacontra,@idjornada)";
                string fechanaci = dtpnacimiento.Value.ToString("yyyy-MM-dd");
                string fechacontra = dtpcontratacion.Value.ToString("yyyy-MM-dd");
               
                Conexion.Open();
                MySqlCommand comando = new MySqlCommand(consulta, Conexion);
                comando.Parameters.AddWithValue("@idempleado", iCodigo);
                comando.Parameters.AddWithValue("@nombre", txtnombre.Text.ToString());
                comando.Parameters.AddWithValue("@apellido", txtapellido.Text.ToString());
                comando.Parameters.AddWithValue("@idpuesto", Int32.Parse(cmbidpuesto.SelectedItem.ToString()));
                comando.Parameters.AddWithValue("@fechanac", fechanaci);
                comando.Parameters.AddWithValue("@direccion", txtdireccion.Text.ToString());
                comando.Parameters.AddWithValue("@salario", Double.Parse(txtsalario.Text.ToString()));
                comando.Parameters.AddWithValue("@fechacontra", fechacontra);
                comando.Parameters.AddWithValue("@idjornada", Int32.Parse(cmbidjornada.SelectedItem.ToString()));
                comando.ExecuteNonQuery();
                Conexion.Close();
                this.Close();
               // MessageBox.Show("Datos Guardados con exito");

                insertarTelefono();
                insertarCorreo();
            }*/
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        }

        private void Btnpuesto_Click(object sender, EventArgs e)
        {
           // Puesto frm = new Puesto();
            //frm.Show();

        }

        private void Btnjornada_Click(object sender, EventArgs e)
        {
           // Jornada frm = new Jornada();
           // frm.Show();
        }

        public void insertarTelefono()
        {
            /*                
                try
                {
                    string consulta2 = "INSERT INTO telefonoempleado VALUES (@idtelefono,@idempleado,@telefono)";
                    Conexion.Open();
                    MySqlCommand comando2 = new MySqlCommand(consulta2, Conexion);
                    comando2.Parameters.AddWithValue("@idtelefono", iCodTelefono);
                    comando2.Parameters.AddWithValue("@idempleado", iCodigo);
                    comando2.Parameters.AddWithValue("@telefono", txttel.Text.ToString());
                    comando2.ExecuteNonQuery();
                    Conexion.Close();
                    this.Close();
                 //   MessageBox.Show("Datos telefono Guardados con exito");
                }
                catch (Exception)
                {
                    MessageBox.Show("telefono no se pudo");
                    throw;
                }*/
            
        }


        public void insertarCorreo()
        {
            /*
                try
                {
                    string consulta3 = "INSERT INTO correoempleado VALUES (@idcorreo,@idempleado,@correo)";
                    Conexion.Open();
                    MySqlCommand comando3 = new MySqlCommand(consulta3, Conexion);
                    comando3.Parameters.AddWithValue("@idcorreo", iCodCorreo);
                    comando3.Parameters.AddWithValue("@idempleado", iCodigo);
                    comando3.Parameters.AddWithValue("@correo", txtemail.Text.ToString());
                    comando3.ExecuteNonQuery();
                    Conexion.Close();
                    this.Close();
                   // MessageBox.Show("Datos correo Guardados con exito");
                }
                catch (Exception)
                {
                    MessageBox.Show("correo no se pudo");
                    throw;
                }*/
            
        }
        private void Cmbpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {


            cmbidpuesto.SelectedIndex = cmbpuesto.SelectedIndex;
           /* if (cmbpuesto.SelectedIndex != -1&& cmbjornada.SelectedIndex != -1)
            {
                try
                {
                    Conexion = new MySqlConnection();
                    Conexion.ConnectionString = sql;
                    Conexion.Open();
                    Query.CommandText = "SELECT * FROM puesto Where idpuesto=" + Int32.Parse(cmbidpuesto.SelectedItem.ToString());
                    Query.Connection = Conexion;
                    consultar = Query.ExecuteReader();
                    while (consultar.Read())
                    {
                        cmbidpuesto.Items.Add(consultar.GetInt32(0));
                        cmbpuesto.Items.Add(consultar.GetString(1));
                    }
                    Conexion.Close();

                    Conexion = new MySqlConnection();
                    Conexion.ConnectionString = sql;
                    Conexion.Open();
                    Query2.CommandText = "SELECT * FROM jornada Where idjornada=" + Int32.Parse(cmbidjornada.SelectedItem.ToString());
                    Query2.Connection = Conexion;
                    consultar2 = Query2.ExecuteReader();
                    while (consultar2.Read())
                    {
                        cmbidjornada.Items.Add(consultar2.GetInt32(0));
                        cmbjornada.Items.Add(consultar2.GetString(1));
                    }
                    Conexion.Close();




                }
                catch (MySqlException er)
                {
                    MessageBox.Show(er.Message);
                }
            }*/




        }
    }
}
