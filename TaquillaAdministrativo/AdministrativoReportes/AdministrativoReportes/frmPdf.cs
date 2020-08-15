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
    public partial class frmPdf : Form
    {
        Conexion cn = new Conexion();
        public frmPdf()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            funcCrearPdf();
        }

        private void funcCrearPdf()
        {
            //CREACION DEL DOCUMENTO
            string nameRepo = "reportePruebaName";
            PdfWriter pdfWriter = new PdfWriter("C:/Users/Yavhé Orozco/Documents/GitHub/ProyectoTaquilla/TaquillaAdministrativo/AdministrativoReportes/ReportesPdf/'" + nameRepo + "'.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf,PageSize.LETTER);

            documento.SetMargins(80,20,55,20);
            //var parrafo = new Paragraph("Hello PDF World");
            //documento.Add(parrafo);
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            //CONTENIDO
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);

            string[] columnas = { "Nombre", "Clasificación", "Duración", "Cantidad Recaudada" };

            //crear tabla para mostrar los datos
            float[] tamanios = { 5, 2, 2, 3 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas))); //PARA ENCABEZADO DE TABLA
            }
            
            try
            {
                string cadena = "SELECT P.nombre, CLAS.nombre as clasificacion, P.duracion, SUM(FACENC.total) AS Cantidad_Recaudada FROM FACTURAENCABEZADO FACENC, PROYECCIONPELICULA PP, PELICULA P, CLASIFICACIONPELICULA CLAS WHERE FACENC.idProyeccionPelicula = PP.idProyeccionPelicula AND PP.idPelicula = P.idPelicula AND P.idClasificacion = CLAS.idClasificacionPelicula AND FACENC.estatus = true AND MONTH(FACENC.fecha) = 3 GROUP BY P.idPelicula ORDER BY Cantidad_Recaudada DESC; ";
                OdbcCommand cma = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(reader[0].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader[1].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader[2].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader[3].ToString()).SetFont(fontContenido)));

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
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("C:/Users/Yavhé Orozco/Documents/GitHub/ProyectoTaquilla/TaquillaAdministrativo/AdministrativoReportes/ReportesPdf/reporte.pdf"), new PdfWriter("C:/Users/Yavhé Orozco/Documents/GitHub/ProyectoTaquilla/TaquillaAdministrativo/AdministrativoReportes/ReportesPdf/reporteP.pdf"));
            Document doc = new Document(pdfDoc);

            int numeros = pdfDoc.GetNumberOfPages();

            for (int i=1; i<=numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);
                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop()-15);
                doc.ShowTextAligned(plogo,40,y,i,TextAlignment.CENTER,VerticalAlignment.TOP,0);
                doc.ShowTextAligned(titulo, 150, y-15,i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 520, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth()/2, pdfDoc.GetPage(i).GetPageSize().GetBottom() / 2 - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

            }
            doc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsBitacora bitacora = new clsBitacora();
           
            string proceso = "PRINCIPAL";
            string tabla = "NOSE";
            bitacora.GuardarBitacora(proceso, tabla);


        }
    }
}
