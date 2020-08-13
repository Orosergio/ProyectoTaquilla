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

namespace taquillaAdministracion
{
    public partial class ModFunciones : Form
    {
        Conexion cn = new Conexion();
        public ModFunciones()
        {
            InitializeComponent();
            funcBuscar();
        }
        void funcCargar()
        {
           try
            {
               /* int codigoDepartamento = Int32.Parse(cboCodigoD.SelectedItem.ToString());
                int codigoCine = Int32.Parse(cboCodigoC.SelectedItem.ToString());
                int codigoMunicipio = Int32.Parse(cboCodigoM.SelectedItem.ToString());*/
                int codigoPelicula = Int32.Parse(cboCodigoP.SelectedItem.ToString());
                int codigoSala = Int32.Parse(cboCodigoS.SelectedItem.ToString());
                string cadena = "SELECT PRO.idProyeccionPelicula, PE.nombre, S.numero, PRO.fechaHoraProyeccion, I.nombre, F.nombre FROM proyeccionpelicula PRO, pelicula PE,sala S, cine C, idioma I, formato F , departamento D, municipio M WHERE D.idDepartamento = M.idDepartamento AND M.idMunicipio = C.idMunicipio AND C.idCine = S.idCine AND S.idSala = "+codigoSala+" AND PE.idPelicula = "+codigoPelicula+ " AND I.idIdioma = PRO.idIdioma AND F.idFormato = PRO.idFormato  ORDER BY idProyeccionPelicula ASC";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.nuevaConexion());
                DataTable dt = new DataTable();
                datos.Fill(dt);
                dgtDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" +ex);
            }
        }
        void funcBuscar()
        {
            try
            {
                string Departamento = "SELECT * FROM DEPARTAMENTO ";
                OdbcCommand comm = new OdbcCommand(Departamento, cn.nuevaConexion());
                OdbcDataReader mostrarDep = comm.ExecuteReader();

                while (mostrarDep.Read())
                {
                    cboCodigoD.Items.Add(mostrarDep.GetInt32(0));
                    cboDepartamento.Items.Add(mostrarDep.GetString(1));
                }

                string Pelicula = "SELECT * FROM PELICULA ";
                OdbcCommand comm1 = new OdbcCommand(Pelicula, cn.nuevaConexion());
                OdbcDataReader mostrarP = comm1.ExecuteReader();

                while (mostrarP.Read())
                {
                    cboCodigoP.Items.Add(mostrarP.GetInt32(0));
                    cboPelicula.Items.Add(mostrarP.GetString(1));
                }

                string PeliculaNueva = "SELECT * FROM PELICULA ";
                OdbcCommand C = new OdbcCommand(PeliculaNueva, cn.nuevaConexion());
                OdbcDataReader mostrarPelicula = C.ExecuteReader();

                while (mostrarPelicula.Read())
                {
                    cboCodigoPN.Items.Add(mostrarPelicula.GetInt32(0));
                    cboPeliculaNueva.Items.Add(mostrarPelicula.GetString(1));
                }

                string Formato = "SELECT * FROM FORMATO ";
                OdbcCommand comm2 = new OdbcCommand(Formato, cn.nuevaConexion());
                OdbcDataReader mostrarF = comm2.ExecuteReader();

                while (mostrarF.Read())
                {
                    cboCodigoF.Items.Add(mostrarF.GetInt32(0));
                    cboFormato.Items.Add(mostrarF.GetString(1));
                }

                string Idioma = "SELECT * FROM IDIOMA ";
                OdbcCommand comm3 = new OdbcCommand(Idioma, cn.nuevaConexion());
                OdbcDataReader mostrarI = comm3.ExecuteReader();

                while (mostrarI.Read())
                {
                    cboCodigoI.Items.Add(mostrarI.GetInt32(0));
                    cboIdioma.Items.Add(mostrarI.GetString(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde" + ex);

            }


        }
        private void ModFunciones_Load(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoF.SelectedIndex = cboFormato.SelectedIndex;
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoD.SelectedIndex =  cboDepartamento.SelectedIndex ;

            cboMunicipio.Items.Clear();
            try
            {

                string Municipio = "SELECT * FROM MUNICIPIO  WHERE idDepartamento= " + Int32.Parse(cboCodigoD.SelectedItem.ToString());
                OdbcCommand comm1 = new OdbcCommand(Municipio, cn.nuevaConexion());
                OdbcDataReader mostrarMun = comm1.ExecuteReader();
                while (mostrarMun.Read())
                {
                    cboCodigoM.Items.Add(mostrarMun.GetInt32(0));
                    cboMunicipio.Items.Add(mostrarMun.GetString(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde");

            }

        }

        private void cboMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodigoM.SelectedIndex = cboMunicipio.SelectedIndex ;

            cboCine.Items.Clear();
            try
            {
                string Cine = "SELECT * FROM CINE WHERE idMunicipio =" + Int32.Parse(cboCodigoM.SelectedItem.ToString());
                OdbcCommand comm2 = new OdbcCommand(Cine, cn.nuevaConexion());
                OdbcDataReader mostrarCine = comm2.ExecuteReader();

                while (mostrarCine.Read())
                {
                    cboCodigoC.Items.Add(mostrarCine.GetInt32(0));
                    cboCine.Items.Add(mostrarCine.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde");

            }

        }

        private void cboCine_SelectedIndexChanged(object sender, EventArgs e)
        {
          cboCodigoC.SelectedIndex  = cboCine.SelectedIndex ;
            cboSala.Items.Clear();
            try
            {
                string Sala = "SELECT * FROM SALA WHERE idCine = " + Int32.Parse(cboCodigoC.SelectedItem.ToString());
                OdbcCommand comm3 = new OdbcCommand(Sala, cn.nuevaConexion());
                OdbcDataReader mostrarSala = comm3.ExecuteReader();

                while (mostrarSala.Read())
                {
                    cboCodigoS.Items.Add(mostrarSala.GetInt32(0));
                    cboSala.Items.Add(mostrarSala.GetString(1));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los registros en este momento intente mas tarde");

            }
        }

        private void cboSala_SelectedIndexChanged(object sender, EventArgs e)
        {
          cboCodigoS.SelectedIndex = cboSala.SelectedIndex  ;
        }

        private void cboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
        cboCodigoP.SelectedIndex   = cboPelicula.SelectedIndex ;
        }

        private void cboPeliculaNueva_SelectedIndexChanged(object sender, EventArgs e)
        {
          cboCodigoPN.SelectedIndex  = cboPeliculaNueva.SelectedIndex ;
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
          cboCodigoI.SelectedIndex = cboIdioma.SelectedIndex ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcCargar();
        }
    }
}
