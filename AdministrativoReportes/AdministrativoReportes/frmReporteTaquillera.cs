using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Font;
using iText.Layout.Element;
using iText.Kernel.Geom;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using iText.IO.Image;

namespace AdministrativoReportes
{
    public partial class frmReporteTaquillera : Form
    {
        clsConexion cn = new clsConexion();
        public frmReporteTaquillera()
        {
            InitializeComponent();
            funcCargarDatos();
        }
        //Realiza la consulta y carga datos sin filtros
        void funcCargarDatos()
        {
            try
            {
                string cadena = "SELECT P.nombre, CLAS.nombre, P.duracion, SUM(FACENC.total) AS Cantidad_Recaudada FROM FACTURAENCABEZADO FACENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND FACENC.estatus = true GROUP BY P.idPelicula ORDER BY Cantidad_Recaudada DESC; ";
                OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {
                    dgvPeliculaTaquillera.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2),"Q." + reader.GetDouble(3).ToString());
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + e);
            }

        }
        private void frmReporteTaquillera_Load(object sender, EventArgs e)
        {

        }

        private void cboTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Administración de objetos
            if (cboTipoReporte.SelectedIndex == 0)
            {
                lblTexto.Visible = true;
                cboMes.Visible = true;
                lblDiaInicio.Visible = false;
                dtpInicio.Visible = false;
                lblDiaFin.Visible = false;
                dtpFin.Visible = false;
               
            }
            else if (cboTipoReporte.SelectedIndex == 1)
            {
                lblTexto.Visible = false;
                cboMes.Visible = false;
                lblDiaInicio.Visible = true;
                dtpInicio.Visible = true;
                lblDiaFin.Visible = true;
                dtpFin.Visible = true;
                
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Si selecciona la opcion de por mes
            if (cboTipoReporte.SelectedIndex == 0)
            {
                int mes = Int32.Parse(cboMes.SelectedIndex.ToString()) + 1;
                btnPdf.Visible = true;
                dgvPeliculaTaquillera.Rows.Clear();
                string texto = cboMes.Text;
                //Adición de la bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "Reporte de película más taquillera por mes";
                string tabla = "SELECT P.nombre, CLAS.nombre, P.duracion, SUM(FACENC.total) AS Cantidad_Recaudada FROM FACTURAENCABEZADO FACENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND FACENC.estatus = true AND MONTH(FACENC.fecha) = " + mes + " GROUP BY P.idPelicula ORDER BY Cantidad_Recaudada DESC; ";
                bitacora.GuardarBitacora(proceso, tabla);
                lblGeneralData.Text = "REPORTE CORRESPONDIENTE AL MES DE " + texto;
                //Realiza la consulta y lo agrega al DataGridView
                try
                {
                    
                    string cadena = "SELECT P.nombre, CLAS.nombre, P.duracion, SUM(FACENC.total) AS Cantidad_Recaudada FROM FACTURAENCABEZADO FACENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND FACENC.estatus = true AND MONTH(FACENC.fecha) = "+mes+ " GROUP BY P.idPelicula ORDER BY Cantidad_Recaudada DESC; ";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvPeliculaTaquillera.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), "Q." + reader.GetDouble(3).ToString());

                    }
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }

            }//Si selecciona la opcion de reporte por semana
            else if (cboTipoReporte.SelectedIndex == 1)
            {
                //Adición de la bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "Reporte de película más taquillera por semana";
                string tabla = "SELECT P.nombre, CLAS.nombre, P.duracion, SUM(FACENC.total) AS Cantidad_Recaudada FROM FACTURAENCABEZADO FACENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND FACENC.estatus = true AND FACENC.fecha BETWEEN " + dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") + " AND " + dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss") + " GROUP BY P.idPelicula ORDER BY Cantidad_Recaudada DESC;";
                bitacora.GuardarBitacora(proceso, tabla);
                btnPdf.Visible = true;
                dgvPeliculaTaquillera.Rows.Clear();
                lblGeneralData.Text = "REPORTE DE SEMANA";
                //Realiza la consulta y actualiza el DataGridView
                try
                {
                    string cadena = "SELECT P.nombre, CLAS.nombre, P.duracion, SUM(FACENC.total) AS Cantidad_Recaudada FROM FACTURAENCABEZADO FACENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND FACENC.estatus = true AND FACENC.fecha BETWEEN'" + dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' GROUP BY P.idPelicula ORDER BY Cantidad_Recaudada DESC;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvPeliculaTaquillera.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), "Q." + reader.GetDouble(3).ToString());

                    }
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN TIPO DE REPORTE");
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
            PdfWriter pdfWriter = new PdfWriter("ReportesPdf/prueba.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);
            documento.SetMargins(200, 20, 55, 20);     
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            //CONTENIDO
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
            //Especificación de encabezados en el DataGridView
            string[] columnas = { "Nombre", "Clasificación", "Duración", "Cantidad Recaudada" };

            //crear tabla para mostrar los datos
            float[] tamanios = { 5, 2, 2, 3 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas))); //PARA ENCABEZADO DE TABLA
            }
            //Si el reporte será por mes
            if (cboTipoReporte.SelectedIndex == 0)
            {
                int mes = Int32.Parse(cboMes.SelectedIndex.ToString()) + 1;
                //Adición de la bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "GENERACION REPORTE PDF MÁS TAQUILLERA POR MES";
                string tablaEnvio = "SELECT P.nombre, CLAS.nombre, P.duracion, SUM(FACENC.total) AS Cantidad_Recaudada FROM FACTURAENCABEZADO FACENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND FACENC.estatus = true AND MONTH(FACENC.fecha) = " + mes + " GROUP BY P.idPelicula ORDER BY Cantidad_Recaudada DESC; ";
                bitacora.GuardarBitacora(proceso, tablaEnvio);
                //Realiza la consulta y actualiza el DataGridView
                try
                {
                    
                    string cadena = "SELECT P.nombre, CLAS.nombre, P.duracion, SUM(FACENC.total) AS Cantidad_Recaudada FROM FACTURAENCABEZADO FACENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND FACENC.estatus = true AND MONTH(FACENC.fecha) = " + mes + " GROUP BY P.idPelicula ORDER BY Cantidad_Recaudada DESC; ";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[0].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[1].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[2].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph("Q. "+reader[3].ToString()).SetFont(fontContenido)));

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL OBTENER DATOS PARA INGRESO" + ex);
                }
                documento.Add(tabla);
                documento.Close();
                //Adicion de diseño al PDF
                var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("logoCine.jpeg")).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);
                var titulo = new Paragraph("REPORTE");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(12);

                var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha de creación: " + dfecha + "\nHora de creación: " + dhora + "\n"+lblGeneralData.Text);
                fecha.SetFontSize(12);

                PdfDocument pdfDoc = new PdfDocument(new PdfReader("ReportesPdf/prueba.pdf"), new PdfWriter("ReportesPdf/'" + nameRepo + "'.pdf"));
                Document doc = new Document(pdfDoc);

                int numeros = pdfDoc.GetNumberOfPages();
                //Adicion de posicionamiento al diseño
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
            }//Si se selecciona por semana
            else if (cboTipoReporte.SelectedIndex == 1)
            {
                //Adición de la bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "GENERACION REPORTE PDF MÁS TAQUILLERA POR SEMANA";
                string tablaEnvio = "SELECT P.nombre, CLAS.nombre, P.duracion, SUM(FACENC.total) AS Cantidad_Recaudada FROM FACTURAENCABEZADO FACENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND FACENC.estatus = true AND FACENC.fecha BETWEEN " + dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") + " AND " + dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss") + " GROUP BY P.idPelicula ORDER BY Cantidad_Recaudada DESC;";
                bitacora.GuardarBitacora(proceso, tablaEnvio);
                //Realiza la consulta y lo agrega al DataGridView
                try
                {
                    string cadena = "SELECT P.nombre, CLAS.nombre, P.duracion, SUM(FACENC.total) AS Cantidad_Recaudada FROM FACTURAENCABEZADO FACENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND FACENC.estatus = true AND FACENC.fecha BETWEEN'" + dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' GROUP BY P.idPelicula ORDER BY Cantidad_Recaudada DESC;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[0].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[1].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[2].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph("Q. "+reader[3].ToString()).SetFont(fontContenido)));

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL OBTENER DATOS PARA INGRESO" + ex);
                }
                documento.Add(tabla);
                documento.Close();
                //Adición de diseño
                var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("logoCine.jpeg")).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);
                var titulo = new Paragraph("REPORTE");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(15);

                var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha de creación: " + dfecha + "\nHora de creación: " + dhora + "\n" + lblGeneralData.Text + " DEL " + dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") +"  AL  "+ dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss"));
                fecha.SetFontSize(12);

                PdfDocument pdfDoc = new PdfDocument(new PdfReader("ReportesPdf/prueba.pdf"), new PdfWriter("ReportesPdf/'" + nameRepo + "'.pdf"));
                Document doc = new Document(pdfDoc);

                int numeros = pdfDoc.GetNumberOfPages();
                //Adicion de posicionamiento al diseño
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
