<%@ WebHandler Language="C#" Class="ReporteSimple" %>

using System;
using System.Web;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Linq;

public class ReporteSimple : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        
        //Recibo valores mediante Request
        string tempId = context.Request.QueryString["id"];
        string tempContactName = context.Request.QueryString["contactName"];
        string tempCompanyName = context.Request.QueryString["companyName"];
        string tempDireccion = context.Request.QueryString["direccion"];
        string tempTelefono = context.Request.QueryString["telefono"];

        //Tipo de reporte PDF
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
            PdfPTable tabla = new PdfPTable(2);
            
            Font fuenteAzul = new Font(Font.FontFamily.HELVETICA, Font.DEFAULTSIZE, Font.UNDERLINE, BaseColor.BLUE);

            //Creo el encabezado de la tabla
            PdfPCell cell_id = new PdfPCell(new Phrase("ID", fuenteAzul));
            PdfPCell cell_companyName = new PdfPCell(new Phrase("Company Name", fuenteAzul));
            PdfPCell cell_contactName = new PdfPCell(new Phrase("Contact Name", fuenteAzul));
            PdfPCell cell_direccion = new PdfPCell(new Phrase("Dirección", fuenteAzul));
            PdfPCell cell_telefono = new PdfPCell(new Phrase("Teléfono", fuenteAzul));
            //Creo celdas en las cual agrego una frase con el valor del campo correspondiente
            PdfPCell id = new PdfPCell(new Phrase(tempId));
            PdfPCell companyName = new PdfPCell(new Phrase(tempCompanyName));
            PdfPCell contactName = new PdfPCell(new Phrase(tempContactName));
            PdfPCell direccion = new PdfPCell(new Phrase(tempDireccion));
            PdfPCell telefono = new PdfPCell(new Phrase(tempTelefono));

            //Agrego las celdas a la tabla
            //Agrego las celdas a la tabla
            tabla.AddCell(cell_id);
            tabla.AddCell(id);
            tabla.AddCell(cell_companyName);
            tabla.AddCell(companyName);
            tabla.AddCell(cell_contactName);
            tabla.AddCell(contactName);
            tabla.AddCell(cell_direccion);
            tabla.AddCell(direccion);
            tabla.AddCell(cell_telefono);
            tabla.AddCell(telefono);
            
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