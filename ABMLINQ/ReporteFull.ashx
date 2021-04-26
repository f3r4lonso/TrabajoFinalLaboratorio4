<%@ WebHandler Language="C#" Class="ReporteFull" %>

using System;
using System.Web;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Linq;

public class ReporteFull : IHttpHandler {
    
    //llamado por defecto
    public void ProcessRequest (HttpContext context) {
        
        // asigno reporte tipo PDF
        context.Response.ContentType = "application/pdf";

        // Asigno el tipo de descarga y nombre de archivo              
        context.Response.AddHeader("Content-disposition", "inline; filename=Supplier.pdf");

        // creo un streem de memoria para almacenar el documento
        // tambien se podria crear en el disco del server
        using (MemoryStream m = new MemoryStream())
        {
            //Creo el documento PDF
            Document documento = new Document();
            PdfWriter.GetInstance(documento, m);

            //Abro el documento para poder escribirlo
            documento.Open();

            //Creo una tabla de 5 columnas
            PdfPTable tabla = new PdfPTable(5);

            //Creo una fuente para resaltar el encabezado
            Font fuenteAzul = new Font(Font.FontFamily.HELVETICA, Font.DEFAULTSIZE, Font.UNDERLINE, BaseColor.BLUE);

            //Creo el encabezado de la tabla
            PdfPCell cell_id = new PdfPCell(new Phrase("ID", fuenteAzul));
            PdfPCell cell_companyName = new PdfPCell(new Phrase("Company Name", fuenteAzul));
            PdfPCell cell_contactName = new PdfPCell(new Phrase("Contact Name", fuenteAzul));
            PdfPCell cell_direccion = new PdfPCell(new Phrase("Dirección", fuenteAzul));
            PdfPCell cell_telefono = new PdfPCell(new Phrase("Teléfono", fuenteAzul));

            //Agrego las celdas a la tabla
            tabla.AddCell(cell_id);
            tabla.AddCell(cell_companyName);
            tabla.AddCell(cell_contactName);
            tabla.AddCell(cell_direccion);
            tabla.AddCell(cell_telefono);

            //Realizo la consulta por Linq de todos los elementos en Suppliers
            //DataContext de Conexion.dbml
            
            NorthwindDSDataContext ds = new NorthwindDSDataContext();

            //Consulta
            var consulta = from suppliers in ds.Suppliers 
                           select new { 
                               suppliers.SupplierID, 
                               suppliers.CompanyName, 
                               suppliers.ContactName, 
                               suppliers.Address, 
                               suppliers.Phone };

            //Recorro todos los items de la consulta
            foreach (var item in consulta)
            {
                //Creo celdas en las cual agrego una frase con el valor del campo correspondiente
                PdfPCell id = new PdfPCell(new Phrase(item.SupplierID.ToString()));
                PdfPCell companyName = new PdfPCell(new Phrase(item.CompanyName));
                PdfPCell contactName = new PdfPCell(new Phrase(item.ContactName));
                PdfPCell direccion = new PdfPCell(new Phrase(item.Address));
                PdfPCell telefono = new PdfPCell(new Phrase(item.Phone));

                //Agrego las celdas a la tabla
                tabla.AddCell(id);
                tabla.AddCell(companyName);
                tabla.AddCell(contactName);
                tabla.AddCell(direccion);
                tabla.AddCell(telefono);
            }
            
            documento.Add(tabla);        
            documento.Close();

            // stream the PDF to the user
            // el browser recibe esta info como pdf gracias al ContentType y Header
            context.Response.OutputStream.Write(m.GetBuffer(), 0, m.GetBuffer().Length);
        }
        context.Response.End();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}