using EmpleadoPrueba;
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
        Conexion cn = new Conexion();
        public frmReportePuntos()
        {
            InitializeComponent();
            funcCargarDatos();
        }

        void funcCargarDatos()
        {
            try
            {
                string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,T.puntos,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente; ";
                OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {
                    dgvCliente.Rows.Add(reader.GetString(0), reader.GetString(1)+" "+ reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetString(5));
                }

                
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + e);
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnPdf.Visible=true;
            if (cboTipoReporte.SelectedIndex == 0)
            {
                dgvCliente.Rows.Clear();
               
                try
                {
                    string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,T.puntos,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente ORDER BY puntos DESC; ";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvCliente.Rows.Add(reader.GetString(0), reader.GetString(1) + " " + reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetString(5));
                    }
                    clsBitacora bitacora = new clsBitacora();
                    string proceso = "Reporte de clientes con mayor cantidad de puntos";
                    string tabla = "CLIENTE,TARJETA,CORREOCLIENTE";
                    bitacora.GuardarBitacora(proceso, tabla);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }

            }
            else if (cboTipoReporte.SelectedIndex == 1)
            {
                dgvCliente.Rows.Clear();
                
                
                try
                {
                    string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,T.puntos,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente ORDER BY puntos ASC;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvCliente.Rows.Add(reader.GetString(0), reader.GetString(1) + " " + reader.GetString(2), reader.GetString(3), reader.GetDouble(4), reader.GetString(5));
                    }

                    clsBitacora bitacora = new clsBitacora();
                    string proceso = "Reporte de clientes con menos cantidad de puntos";
                    string tabla = "CLIENTE,TARJETA,CORREOCLIENTE";
                    bitacora.GuardarBitacora(proceso, tabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            funcCrearPdf();
        }

        private void funcCrearPdf()
        {
            //CREACION DEL DOCUMENTO
            string nameRepo = "";
            nameRepo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del archivo:", "Registro", "Orosergio", 500, 500);
            PdfWriter pdfWriter = new PdfWriter("C:/Users/Yavhé Orozco/Documents/GitHub/ProyectoTaquilla/TaquillaAdministrativo/AdministrativoReportes/ReportesPdf/prueba.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);
            documento.SetMargins(180, 20, 55, 20);
            //var parrafo = new Paragraph("Hello PDF World");
            //documento.Add(parrafo);
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            //CONTENIDO
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);

            string[] columnas = { "NitCliente", "Nombre", "Apellido", "No. Tarjeta","Puntos Cliente","Correo Cliente"};

            //crear tabla para mostrar los datos
            float[] tamanios = { 3, 4, 4, 3, 3, 4 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas))); //PARA ENCABEZADO DE TABLA
            }

            if (cboTipoReporte.SelectedIndex == 0)
            {
                clsBitacora bitacora = new clsBitacora();
                string proceso = "GENERACION REPORTE PDF MAYORÍA DE PUNTOS";
                string tablaEnvio = "CLIENTE, TARJETA, CORREOCLIENTE";
                bitacora.GuardarBitacora(proceso, tablaEnvio);
                try
                {
                    string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,T.puntos,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente ORDER BY puntos DESC; ";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[0].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[1].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[2].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[3].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[4].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[5].ToString()).SetFont(fontContenido)));

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL OBTENER DATOS PARA INGRESO" + ex);
                }
                documento.Add(tabla);
                documento.Close();

                var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/Yavhé Orozco/Documents/GitHub/ProyectoTaquilla/TaquillaAdministrativo/AdministrativoReportes/Images/logoCine.jpeg")).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);
                var titulo = new Paragraph("REPORTE DE PUNTOS");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(15);

                var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha de creación: " + dfecha + "\nHora de creación: " + dhora + "\n" + cboTipoReporte.Text.ToString());
                fecha.SetFontSize(12);

                PdfDocument pdfDoc = new PdfDocument(new PdfReader("C:/Users/Yavhé Orozco/Documents/GitHub/ProyectoTaquilla/TaquillaAdministrativo/AdministrativoReportes/ReportesPdf/prueba.pdf"), new PdfWriter("C:/Users/Yavhé Orozco/Documents/GitHub/ProyectoTaquilla/TaquillaAdministrativo/AdministrativoReportes/ReportesPdf/'" + nameRepo + "'.pdf"));
                Document doc = new Document(pdfDoc);

                int numeros = pdfDoc.GetNumberOfPages();

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
            else if (cboTipoReporte.SelectedIndex == 1)
            {
                clsBitacora bitacora = new clsBitacora();
                string proceso = "GENERACION REPORTE PDF MINORÍA DE PUNTOS";
                string tablaEnvio = "CLIENTE, TARJETA, CORREOCLIENTE";
                bitacora.GuardarBitacora(proceso, tablaEnvio);
                try
                {
                    string cadena = "SELECT C.nitCliente, C.nombreClienteTarjeta, C.apellidoClienteTarjeta,T.noTarjeta,T.puntos,CC.correo FROM CLIENTE C, TARJETA T, CORREOCLIENTE CC WHERE C.nitCliente = T.nitCliente AND C.nitCliente = CC.nitCliente ORDER BY puntos ASC;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[0].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[1].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[2].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[3].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[4].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[5].ToString()).SetFont(fontContenido)));

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL OBTENER DATOS PARA INGRESO" + ex);
                }
                documento.Add(tabla);
                documento.Close();

                var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/Yavhé Orozco/Documents/GitHub/ProyectoTaquilla/TaquillaAdministrativo/AdministrativoReportes/Images/logoCine.jpeg")).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);
                var titulo = new Paragraph("REPORTE");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(15);

                var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha de creación: " + dfecha + "\nHora de creación: " + dhora + "\n" + cboTipoReporte.Text.ToString() );
                fecha.SetFontSize(12);

                PdfDocument pdfDoc = new PdfDocument(new PdfReader("C:/Users/Yavhé Orozco/Documents/GitHub/ProyectoTaquilla/TaquillaAdministrativo/AdministrativoReportes/ReportesPdf/prueba.pdf"), new PdfWriter("C:/Users/Yavhé Orozco/Documents/GitHub/ProyectoTaquilla/TaquillaAdministrativo/AdministrativoReportes/ReportesPdf/'" + nameRepo + "'.pdf"));
                Document doc = new Document(pdfDoc);

                int numeros = pdfDoc.GetNumberOfPages();

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
    }
}
