using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
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
    public partial class frmReportePuntos : Form
    {
        clsConexion cn = new clsConexion();
        public frmReportePuntos()
        {
            InitializeComponent();
            funcCargarDatos();
        }
        //Carga todos los datos al inicio sin filtro
        void funcCargarDatos()
        {
            try
            {
                string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,FACENC.puntos,CC.correo, P.nombre, FACENC.fecha FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC, FACTURAENCABEZADO FACENC, PELICULA P, PROYECCIONPELICULA PP WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente AND C.nitCliente = FACENC.nitCliente AND FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula ORDER BY C.nitCliente ASC; ";
                OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {
                    dgvCliente.Rows.Add(reader.GetString(0), reader.GetString(1)+" "+ reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                }

                
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + e);
            }
            //CARGAR PELICULAS
            try
            {
                string cadena = "SELECT * FROM PELICULA; ";
                OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {
                    cboPeliculas.Items.Add(reader.GetString(1));
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + e);
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            //Si se selecciona un reporte por mes
            if (cboTipoReporte.SelectedIndex == 0)
            {
                btnPdf.Visible = true;
                dgvCliente.Rows.Clear();
               //realiza la consulta y agrega datos al datagridview
                try
                {
                    string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta, SUM(FACENC.puntos) AS Puntos_Totales,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC, FACTURAENCABEZADO FACENC, PELICULA P, PROYECCIONPELICULA PP WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente AND C.nitCliente = FACENC.nitCliente AND FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula group by C.nitCliente ORDER BY Puntos_Totales DESC;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvCliente.Rows.Add(reader.GetString(0), reader.GetString(1) + " " + reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetString(5),"VARIOS","VARIOS");
                    }
                    //Agrega los datos a la bitácora
                    clsBitacora bitacora = new clsBitacora();
                    string proceso = "Reporte de clientes con mayor cantidad de puntos";
                    string tabla = cadena;
                    bitacora.GuardarBitacora(proceso, tabla);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }

            }//Si se selecciona el filtro de semana
            else if (cboTipoReporte.SelectedIndex == 1)
            {
                btnPdf.Visible = true;
                dgvCliente.Rows.Clear();
                
                //Realiza la consulta y agrega datos al DataGridView
                try
                {
                    string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta, SUM(FACENC.puntos) AS Puntos_Totales,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC, FACTURAENCABEZADO FACENC, PELICULA P, PROYECCIONPELICULA PP WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente AND C.nitCliente = FACENC.nitCliente AND FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula group by C.nitCliente ORDER BY Puntos_Totales ASC;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvCliente.Rows.Add(reader.GetString(0), reader.GetString(1) + " " + reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetString(5),"VARIOS","VARIOS");
                    }
                    //Agrega los datos a la bitácora
                    clsBitacora bitacora = new clsBitacora();
                    string proceso = "Reporte de clientes con menos cantidad de puntos";
                    string tabla = cadena;
                    bitacora.GuardarBitacora(proceso, tabla);
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }
            }
            else if (cboTipoReporte.SelectedIndex == 2)
            {
                btnPdf.Visible = true;
                dgvCliente.Rows.Clear();

                //Realiza la consulta y agrega datos al DataGridView
                try
                {
                    string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,SUM(FACENC.puntos) AS Puntos_Totales,CC.correo, P.nombre, FACENC.fecha FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC, FACTURAENCABEZADO FACENC, PELICULA P, PROYECCIONPELICULA PP WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente AND C.nitCliente = FACENC.nitCliente AND FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.nombre = '"+cboPeliculas.SelectedItem.ToString()+ "' GROUP BY C.nitCliente ORDER BY FACENC.fecha DESC; ";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvCliente.Rows.Add(reader.GetString(0), reader.GetString(1) + " " + reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetString(5), reader.GetString(6), "VARIOS");
                    }
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }
                //Agrega los datos a la bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "Reporte de clientes con menos cantidad de puntos";
                string tabla = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,SUM(FACENC.puntos) AS Puntos_Totales,CC.correo, P.nombre, FACENC.fecha FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC, FACTURAENCABEZADO FACENC, PELICULA P, PROYECCIONPELICULA PP WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente AND C.nitCliente = FACENC.nitCliente AND FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.nombre = pelicula GROUP BY C.nitCliente ORDER BY FACENC.fecha DESC; ";
                bitacora.GuardarBitacora(proceso, tabla);
            }
            else
            {
                MessageBox.Show("SELECCIONE UN TIPO DE REPORTE");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            //Llama a la funcion
            funcCrearPdf();
        }

        private void funcCrearPdf()
        {
            //CREACION DEL DOCUMENTO
            string nameRepo = "";
            nameRepo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del archivo:", "Registro", "Orosergio", 500, 500);
            PdfWriter pdfWriter = new PdfWriter("ReportesPdf/prueba.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);
            documento.SetMargins(180, 10, 55, 10);
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            //CONTENIDO
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
            //Encabezados del DataGridView
            string[] columnas = { "NitCliente", "Nombre", "Apellido", "No. Tarjeta","Puntos Cliente","Correo", "Película","Fecha"};
            string texto = "VARIOS";
            //crear tabla para mostrar los datos
            float[] tamanios = { 3, 4, 4, 3, 3, 4,3,3};
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas))); //PARA ENCABEZADO DE TABLA
            }
            //Si los reportes son por mayoria de puntos
            if (cboTipoReporte.SelectedIndex == 0)
            {
                //Agrega los datos a la bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "GENERACION REPORTE PDF DE LOS CLIENTES CON LA MAYORÍA DE PUNTOS";
                string tablaEnvio = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta, SUM(FACENC.puntos) AS Puntos_Totales,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC, FACTURAENCABEZADO FACENC, PELICULA P, PROYECCIONPELICULA PP WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente AND C.nitCliente = FACENC.nitCliente AND FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula group by C.nitCliente ORDER BY Puntos_Totales DESC;";
                bitacora.GuardarBitacora(proceso, tablaEnvio);
                //Realiza la consulta y llena el DataGridView
                try
                {
                    string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta, SUM(FACENC.puntos) AS Puntos_Totales,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC, FACTURAENCABEZADO FACENC, PELICULA P, PROYECCIONPELICULA PP WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente AND C.nitCliente = FACENC.nitCliente AND FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula group by C.nitCliente ORDER BY Puntos_Totales DESC;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[0].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[1].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[2].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[3].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[4].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[5].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(texto.ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(texto.ToString()).SetFont(fontContenido)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL OBTENER DATOS PARA INGRESO" + ex);
                }
                documento.Add(tabla);
                documento.Close();
                //Adición de diseño al PDF
                var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("logoCine.jpeg")).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);
                var titulo = new Paragraph("REPORTE DE PUNTOS");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(15);

                var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha de creación: " + dfecha + "\nHora de creación: " + dhora + "\n" + cboTipoReporte.Text.ToString());
                fecha.SetFontSize(12);

                PdfDocument pdfDoc = new PdfDocument(new PdfReader("ReportesPdf/prueba.pdf"), new PdfWriter("ReportesPdf/'" + nameRepo + "'.pdf"));
                Document doc = new Document(pdfDoc);

                int numeros = pdfDoc.GetNumberOfPages();
                //Posicionamiento de los elementos
                for (int i = 1; i <= numeros; i++)
                {
                    PdfPage pagina = pdfDoc.GetPage(i);
                    float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                    doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(titulo, 300, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(fecha, 25, y - 70, i, TextAlignment.LEFT, VerticalAlignment.TOP, 0);

                    doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() / 2 - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                }
                doc.Close();
            }//Si los reportes son por minoria de puntos
            else if (cboTipoReporte.SelectedIndex == 1)
            {
                //Agrega la bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "GENERACION REPORTE PDF MINORÍA DE PUNTOS";
                string tablaEnvio = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta, SUM(FACENC.puntos) AS Puntos_Totales,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC, FACTURAENCABEZADO FACENC, PELICULA P, PROYECCIONPELICULA PP WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente AND C.nitCliente = FACENC.nitCliente AND FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula group by C.nitCliente ORDER BY Puntos_Totales ASC;";
                bitacora.GuardarBitacora(proceso, tablaEnvio);
                //Realiza consulta y agrega al DataGridView
                try
                {
                    string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta, SUM(FACENC.puntos) AS Puntos_Totales,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC, FACTURAENCABEZADO FACENC, PELICULA P, PROYECCIONPELICULA PP WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente AND C.nitCliente = FACENC.nitCliente AND FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula group by C.nitCliente ORDER BY Puntos_Totales ASC;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[0].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[1].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[2].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[3].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[4].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[5].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(texto.ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(texto.ToString()).SetFont(fontContenido)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL OBTENER DATOS PARA INGRESO" + ex);
                }
                documento.Add(tabla);
                documento.Close();
                //Adición del diseño
                var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("logoCine.jpeg")).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);
                var titulo = new Paragraph("REPORTE");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(15);

                var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha de creación: " + dfecha + "\nHora de creación: " + dhora + "\n" + cboTipoReporte.Text.ToString() );
                fecha.SetFontSize(12);

                PdfDocument pdfDoc = new PdfDocument(new PdfReader("ReportesPdf/prueba.pdf"), new PdfWriter("ReportesPdf/'" + nameRepo + "'.pdf"));
                Document doc = new Document(pdfDoc);

                int numeros = pdfDoc.GetNumberOfPages();
                //Adicion de posicionamiento
                for (int i = 1; i <= numeros; i++)
                {
                    PdfPage pagina = pdfDoc.GetPage(i);
                    float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                    doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(titulo, 300, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(fecha, 25, y - 70, i, TextAlignment.LEFT, VerticalAlignment.TOP, 0);

                    doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() / 2 - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                }
                doc.Close();
            }
            else if (cboTipoReporte.SelectedIndex == 2)
            {
                //Agrega la bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "GENERACION REPORTE PDF POR PELÍCULA";
                string tablaEnvio = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,SUM(FACENC.puntos) AS Puntos_Totales,CC.correo, P.nombre, FACENC.fecha FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC, FACTURAENCABEZADO FACENC, PELICULA P, PROYECCIONPELICULA PP WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente AND C.nitCliente = FACENC.nitCliente AND FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.nombre = " + cboPeliculas.SelectedItem.ToString() + " GROUP BY C.nitCliente ORDER BY FACENC.fecha DESC; ";
                bitacora.GuardarBitacora(proceso, tablaEnvio);
                //Realiza consulta y agrega al DataGridView
                try
                {
                    string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,SUM(FACENC.puntos) AS Puntos_Totales,CC.correo, P.nombre, FACENC.fecha FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC, FACTURAENCABEZADO FACENC, PELICULA P, PROYECCIONPELICULA PP WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente AND C.nitCliente = FACENC.nitCliente AND FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.nombre = '" + cboPeliculas.SelectedItem.ToString() + "' GROUP BY C.nitCliente ORDER BY FACENC.fecha DESC; ";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[0].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[1].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[2].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[3].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[4].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[5].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[6].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(texto.ToString()).SetFont(fontContenido)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL OBTENER DATOS PARA INGRESO" + ex);
                }
                documento.Add(tabla);
                documento.Close();
                //Adición del diseño
                var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("logoCine.jpeg")).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);
                var titulo = new Paragraph("REPORTE");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(15);

                var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha de creación: " + dfecha + "\nHora de creación: " + dhora + "\n" + cboTipoReporte.Text.ToString());
                fecha.SetFontSize(12);

                PdfDocument pdfDoc = new PdfDocument(new PdfReader("ReportesPdf/prueba.pdf"), new PdfWriter("ReportesPdf/'" + nameRepo + "'.pdf"));
                Document doc = new Document(pdfDoc);

                int numeros = pdfDoc.GetNumberOfPages();
                //Adicion de posicionamiento
                for (int i = 1; i <= numeros; i++)
                {
                    PdfPage pagina = pdfDoc.GetPage(i);
                    float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                    doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(titulo, 300, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(fecha, 25, y - 70, i, TextAlignment.LEFT, VerticalAlignment.TOP, 0);

                    doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() / 2 - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                }
                doc.Close();
            }


        }

        private void frmReportePuntos_Load(object sender, EventArgs e)
        {

        }

        private void cboTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoReporte.SelectedIndex != 2)
            {
                lblPelicula.Visible = false;
                cboPeliculas.Visible = false;
            }
            else
            {
                lblPelicula.Visible = true;
                cboPeliculas.Visible = true;
            }
        }
    }
}
