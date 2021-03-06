﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrativoReportes
{
    public partial class frmCorreo : Form
    {
        clsConexion cn = new clsConexion();
        int numero = 0;
        int codigoA = 0;
        public frmCorreo()
        {
            InitializeComponent();
            procCodigoA();
            procEmpleado();
        }
        //funcion que limpiar los campos indicados
       void procLimpiar()
        {
            txtCorreo.Text = "";
            cboEmpleado.Items.Clear();
        }
        void procCodigoA()
        {
            try
            //esta funcion hace un conteo de los datos que se encuentran en la tabla pelicula y almacena ese valor en la variable numero

            {
                string contador = "SELECT count(idCorreo) FROM CORREO ";
                OdbcCommand comando = new OdbcCommand(contador, cn.nuevaConexion());
                numero = Convert.ToInt32(comando.ExecuteScalar());
                //si numero = 0, no encuentra ningun registro convierte el cidigoA en 1 y envia ese codigo para guardado como ID
                if (numero == 0)
                {
                    codigoA = 1;
                }
                else
                {
                    //de lo contrario se ira incrementando + 1 codigoA
                    codigoA = numero + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        void procEmpleado()
        {
            //en esta funcion buscar se seleccionaran las clasificacions de las peliculas y se mostraran en el cboClaficicacion
            try
            {
                string Sala = "SELECT * FROM EMPLEADO";
                OdbcCommand comm = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();

                String nombre, apellido, nombreCompleto;
               
                while (mostrarC.Read())
                {
                    cboCodigoE.Items.Add(mostrarC.GetInt32(0));
                    nombre = mostrarC.GetString(1);
                    apellido = mostrarC.GetString(2);
                    nombreCompleto = nombre + " " + apellido;
                    cboEmpleado.Items.Add(nombreCompleto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Este if verifica que no se deje ningun campo en blanco, si hay uno en blando muestra el mensaje de que se necesitan llenar los campos
            if (txtCorreo.Text == "" || cboEmpleado.SelectedItem == null )
            {
                MessageBox.Show("Necesita llegar todos los campos");
            }
            else
            {
                //en el string estatus guardo el estatus seleccinado en el cboEstado 
                String Estatus = "1";
               
                try
                {
                    //se realiza la consulta de insertar en tabla pelicula con sus respectivos campos
                    string Insertar = "INSERT INTO CORREO (idCorreo,correo,idEmpleado,estatus) " +
                    "VALUES (" + codigoA + ",'" + txtCorreo.Text + "'," + Int32.Parse(cboCodigoE.SelectedItem.ToString()) + ",'" + Estatus + "')";
                    OdbcCommand comm = new OdbcCommand(Insertar, cn.nuevaConexion());
                    OdbcDataReader mostrarC = comm.ExecuteReader();
                    MessageBox.Show("Los datos se ingresaron correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
                //Adicion de bitacora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "Ingreso de correos a empleados";
                string tabla = "INSERT INTO CORREO (idCorreo,correo,idEmpleado,estatus) VALUES (" + codigoA.ToString() + "," + txtCorreo.Text.ToString() + "," + cboCodigoE.SelectedItem.ToString() + "," + Estatus.ToString() + ")";
                bitacora.GuardarBitacora(proceso, tabla);
                //Limpieza
                procLimpiar();
                procCodigoA();
                procEmpleado();
               
            }
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aqui vuelve el index de los comboBox iguales
            cboCodigoE.SelectedIndex = cboEmpleado.SelectedIndex;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //boton que limpia los campos si se quiere cancelar
            procLimpiar();
            procEmpleado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //boton para abrir otro form
            frmModificarCorreo correo = new frmModificarCorreo();
            correo.ShowDialog();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaAdministracion/Ayuda.chm", "Ingreso de Correos.html");
        }
    }
   
}
