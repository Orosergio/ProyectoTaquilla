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
using Microsoft.SqlServer.Server;
using AdministrativoReportes;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;

namespace WindowsFormsApp1
{
    public partial class frmReporteVentas : Form
    {
        clsConexion cn = new clsConexion();
        public frmReporteVentas()
        {
            InitializeComponent();
            cargarDatos();        
        }
      
        //Realiza la consulta sin aplicar ningun filtro y lo agrega al DataGridView
        void cargarDatos()
        {
            try
            {
                string cadena = "SELECT FACENC.idFacturaEncabezado,FACENC.fecha,C.nombreClienteTarjeta,C.apellidoClienteTarjeta,FACENC.total,FACENC.descuento FROM CLIENTE C,FACTURAENCABEZADO FACENC WHERE FACENC.nitCliente = C.nitCliente AND FACENC.estatus = true; ";
                OdbcCommand cma = new OdbcCommand(cadena,cn.nuevaConexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while(reader.Read()){
                    dgvventas.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2) +" "+ reader.GetString(3), "Q."+reader.GetDouble(4).ToString(), "Q."+reader.GetDouble(5).ToString());
                }
               

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + e);
            }           

        }
        private void Reporte_Ventas_Load(object sender, EventArgs e)
        {

        }
        
        private void Dgvventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Administración de objetos
            if (cboEleccion.SelectedIndex == 0)
            {                
                lblTexto.Visible = true;
                cboMes.Visible = true;
                lblDiaInicio.Visible = false;
                dtpInicio.Visible = false;
                lblDiaFin.Visible = false;
                dtpFin.Visible = false;
                
            }else if (cboEleccion.SelectedIndex==1)
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
            btnPdf.Visible = true;
            int mes = Int32.Parse(cboMes.SelectedIndex.ToString()) + 1;
            //Si selecciona la opción de mes
            if (cboEleccion.SelectedIndex == 0)
            {
                dgvventas.Rows.Clear();
                string texto = cboMes.Text;
                Double gananciames = 0;
                lblGanancia.Visible = true;
                lblGeneralData.Text = "REPORTE CORRESPONDIENTE AL MES DE " + texto;
                //Realiza la consulta y actualiza el DataGridView
                try
                {
                    string cadena = "SELECT FACENC.idFacturaEncabezado,FACENC.fecha,C.nombreClienteTarjeta,C.apellidoClienteTarjeta,FACENC.total,FACENC.descuento FROM CLIENTE C,FACTURAENCABEZADO FACENC WHERE FACENC.nitCliente = C.nitCliente AND MONTH(fecha) = " + mes + " AND FACENC.estatus=true;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvventas.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2) + " " + reader.GetString(3), "Q." + reader.GetDouble(4).ToString(), "Q." + reader.GetDouble(5).ToString());
                        gananciames += reader.GetDouble(4);
                        lblGanancia.Text = "TOTAL DE GANANCIAS: " + gananciames;
                    }
                    clsBitacora bitacora = new clsBitacora();
                    string proceso = "Reporte de ganancias por mes";
                    string tabla = cadena;
                    bitacora.GuardarBitacora(proceso, tabla);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }

            }//Si selecciona la opcino de semana
            else if (cboEleccion.SelectedIndex == 1)
            {
                dgvventas.Rows.Clear();
                string inicio = dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string fin = dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss");   
                Double ganancia = 0;
                lblGanancia.Visible = true;
                lblGeneralData.Text = "REPORTE DE SEMANA";
                clsBitacora bitacora = new clsBitacora();
                string proceso = "Reporte de ganancias por semana";
                string tabla = "SELECT FACENC.idFacturaEncabezado,FACENC.fecha,C.nombreClienteTarjeta,C.apellidoClienteTarjeta,FACENC.total,FACENC.descuento FROM CLIENTE C,FACTURAENCABEZADO FACENC WHERE FACENC.nitCliente = C.nitCliente AND fecha BETWEEN " + dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") + " AND " + dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss") + " AND FACENC.estatus=true;";
                bitacora.GuardarBitacora(proceso, tabla);
                //Realiza la consulta y actualiza el DataGridView
                try
                {
                    string cadena = "SELECT FACENC.idFacturaEncabezado,FACENC.fecha,C.nombreClienteTarjeta,C.apellidoClienteTarjeta,FACENC.total,FACENC.descuento FROM CLIENTE C,FACTURAENCABEZADO FACENC WHERE FACENC.nitCliente = C.nitCliente AND fecha BETWEEN '"+ dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND FACENC.estatus=true;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvventas.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2) + " " + reader.GetString(3), "Q." + reader.GetDouble(4).ToString(), "Q." + reader.GetDouble(5).ToString());
                        ganancia += reader.GetDouble(4);
                        lblGanancia.Text="TOTAL DE GANANCIAS: " +ganancia ;
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL MOSTRAR DATOS AL DATAGRIDVIEW " + ex);
                }
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
            documento.SetMargins(200, 20, 55, 20);
            //var parrafo = new Paragraph("Hello PDF World");
            //documento.Add(parrafo);
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            //CONTENIDO
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
            //Definicion de los encabezados del DataGridView
            string[] columnas = { "idReservacion", "Fecha y Hora", "Nombre","Apellido", "Total", "Descuento"};

            //crear tabla para mostrar los datos
            float[] tamanios = { 1, 4, 4, 4, 3, 3};
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas))); //PARA ENCABEZADO DE TABLA
            }
            //Si selecciona la opcion por mes 
            if (cboEleccion.SelectedIndex == 0)
            {
                int mes = Int32.Parse(cboMes.SelectedIndex.ToString()) + 1;
                //Adición a la Bitácora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "GENERACION REPORTE PDF DE GANANCIAS POR MES";
                string tablaEnvio = "SELECT FACENC.idFacturaEncabezado,FACENC.fecha,C.nombreClienteTarjeta,C.apellidoClienteTarjeta,FACENC.total,FACENC.descuento FROM CLIENTE C,FACTURAENCABEZADO FACENC WHERE FACENC.nitCliente = C.nitCliente AND MONTH(fecha) = " + mes + " AND FACENC.estatus=true;";
                bitacora.GuardarBitacora(proceso, tablaEnvio);
                Double ganancia = 0;
                //Realizar la consulta y actualiza el DataGridView
                try
                {                    
                    string cadena = "SELECT FACENC.idFacturaEncabezado,FACENC.fecha,C.nombreClienteTarjeta,C.apellidoClienteTarjeta,FACENC.total,FACENC.descuento FROM CLIENTE C,FACTURAENCABEZADO FACENC WHERE FACENC.nitCliente = C.nitCliente AND MONTH(fecha) = " + mes + " AND FACENC.estatus=true;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[0].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[1].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[2].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[3].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph("Q. "+reader[4].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph("Q. "+reader[5].ToString()).SetFont(fontContenido)));
                        ganancia += reader.GetDouble(4);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL OBTENER DATOS PARA INGRESO" + ex);
                }
                documento.Add(tabla);
                documento.Close();
                //Adicion de diseño
                var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("logoCine.jpeg")).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);
                var titulo = new Paragraph("REPORTE DE GANANCIAS");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(15);

                var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha de Creación: " + dfecha + "\nHora de Creación: " + dhora + "\nGanacia: " + ganancia + "\n" + lblGeneralData.Text);
                fecha.SetFontSize(12);

                PdfDocument pdfDoc = new PdfDocument(new PdfReader("ReportesPdf/prueba.pdf"), new PdfWriter("ReportesPdf/'" + nameRepo + "'.pdf"));
                Document doc = new Document(pdfDoc);

                int numeros = pdfDoc.GetNumberOfPages();
                //Adicion de posicionamiento del diseño
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
            }//Si selecciona el reporte por semana
            else if (cboEleccion.SelectedIndex == 1)
            {
                //Adición de la bitacora
                clsBitacora bitacora = new clsBitacora();
                string proceso = "GENERACION REPORTE PDF DE GANANCIAS POR SEMANA";
                string tablaEnvio = "SELECT FACENC.idFacturaEncabezado,FACENC.fecha,C.nombreClienteTarjeta,C.apellidoClienteTarjeta,FACENC.total,FACENC.descuento FROM CLIENTE C,FACTURAENCABEZADO FACENC WHERE FACENC.nitCliente = C.nitCliente AND fecha BETWEEN " + dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") + " AND " + dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss") + " AND FACENC.estatus=true;";
                bitacora.GuardarBitacora(proceso, tablaEnvio);
                Double ganancia = 0;
                //Realiza la consulta y actualiza el DataGridView
                try
                {
                    
                    string cadena = "SELECT FACENC.idFacturaEncabezado,FACENC.fecha,C.nombreClienteTarjeta,C.apellidoClienteTarjeta,FACENC.total,FACENC.descuento FROM CLIENTE C,FACTURAENCABEZADO FACENC WHERE FACENC.nitCliente = C.nitCliente AND fecha BETWEEN '" + dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND FACENC.estatus=true;";
                    OdbcCommand cma = new OdbcCommand(cadena, cn.nuevaConexion());
                    OdbcDataReader reader = cma.ExecuteReader();
                    while (reader.Read())
                    {
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[0].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[1].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[2].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(reader[3].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph("Q. "+reader[4].ToString()).SetFont(fontContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph("Q." +reader[5].ToString()).SetFont(fontContenido)));

                        ganancia += reader.GetDouble(4);
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
                var titulo = new Paragraph("REPORTE DE GANANCIAS");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(15);

                var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
                var dhora = DateTime.Now.ToString("hh:mm:ss");
                var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora + "\nGanancia: " + ganancia + "\n" + lblGeneralData.Text + " DEL " + dtpInicio.Value.ToString("yyyy-MM-dd hh:mm:ss") +"  AL  "+ dtpFin.Value.ToString("yyyy-MM-dd hh:mm:ss"));
                fecha.SetFontSize(12);

                PdfDocument pdfDoc = new PdfDocument(new PdfReader("ReportesPdf/prueba.pdf"), new PdfWriter("ReportesPdf/'" + nameRepo + "'.pdf"));
                Document doc = new Document(pdfDoc);

                int numeros = pdfDoc.GetNumberOfPages();
                //Adición de posicionamiento al diseño
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

        private void btnCrystalGanancia_Click(object sender, EventArgs e)
        {
            
        }
    }
}
