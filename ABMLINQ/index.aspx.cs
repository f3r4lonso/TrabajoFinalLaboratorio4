using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //NorthwindDSDataContext dc = new NorthwindDSDataContext();
        //var suppliers_temp = from item in dc.Suppliers
        //                     select new
        //                     {
        //                         item.SupplierID,
        //                         item.CompanyName,
        //                         item.ContactName,
        //                         item.Address,
        //                         item.Phone
        //                     };
        //grd_suppliers.DataSource = suppliers_temp;
        //grd_suppliers.DataBind();

        lbl_error.Text = "";

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void grd_suppliers_RowCommand(object sender, GridViewCommandEventArgs e)
    {        
        /*
         * No se puede porque no se ha seleccioando ninguna linea
         * GridViewRow fila = grd_suppliers.SelectedRow;
        int id = Convert.ToInt32(grd_suppliers.DataKeys[fila.RowIndex].Value);*/        

        // ELIMINA UN REGISTRO
        if(e.CommandName == "eliminar")
        {
            // obtenemos el ID
            NorthwindDSDataContext ds = new NorthwindDSDataContext();
            int id = Convert.ToInt32(e.CommandArgument);

            var supplierTemp = (from item in ds.Suppliers
                                where item.SupplierID == id
                                select item).Single();

            ds.Suppliers.DeleteOnSubmit(supplierTemp);
            ds.SubmitChanges();
            grd_suppliers.DataBind();
                               
        }
        // LLENA LOS DATOS DEL FORMULARIO DE MODIFICACION
        else if (e.CommandName == "modificar") 
        {
            // obtenemos el ID
            NorthwindDSDataContext ds = new NorthwindDSDataContext();
            int id = Convert.ToInt32(e.CommandArgument);

            btn_insertar_modificar.Text = "Modificar";            

            //obtenemos los datos mediante el id
            var supplierTemp = (from item in ds.Suppliers
                               where item.SupplierID == id
                               select new
                               {
                                   item.CompanyName,
                                   item.ContactName,
                                   item.Address,
                                   item.Phone
                               }).Single();
            
            // llenamos los datos en el formulario
            lbl_id.Text = id.ToString();
            txt_comanyName.Text = supplierTemp.CompanyName;
            txt_contactName.Text = supplierTemp.ContactName;
            txt_direccion.Text = supplierTemp.Address;
            txt_telefono.Text = supplierTemp.Phone;                  
        }
    }



    protected void btn_insertar_Click(object sender, EventArgs e)
    {
        btn_insertar_modificar.Text = "Agregar";
        lbl_id.Text = "default";
        txt_comanyName.Text = "";
        txt_contactName.Text = "";
        txt_direccion.Text = "";
        txt_telefono.Text = "";
    }
    protected void btn_insertar_modificar_Click(object sender, EventArgs e)
    {
        NorthwindDSDataContext ds = new NorthwindDSDataContext();

        if(btn_insertar_modificar.Text == "Agregar"){

            //creamos el objeto
            Supplier temp = new Supplier();
            temp.CompanyName = txt_comanyName.Text;
            temp.ContactName= txt_contactName.Text;
            temp.Address = txt_direccion.Text;
            temp.Phone = txt_telefono.Text;

            //lo agregamos
            ds.Suppliers.InsertOnSubmit(temp);
            ds.SubmitChanges();
            grd_suppliers.DataBind();

        
        }else if(btn_insertar_modificar.Text == "Modificar"){

            // obtenemos el id
            int id = Convert.ToInt32(lbl_id.Text);

            //obtenemos la fuente de datos
            var suppliersTemp = (from item in ds.Suppliers
                                 where item.SupplierID == id
                                 select item).Single();

            // hacemos las modificaciones
            suppliersTemp.CompanyName = txt_comanyName.Text;
            suppliersTemp.ContactName = txt_contactName.Text;
            suppliersTemp.Address = txt_direccion.Text;
            suppliersTemp.Phone = txt_telefono.Text;

            // actualizamos
            ds.SubmitChanges();
            grd_suppliers.DataBind();            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReporteFull.ashx", false);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (grd_suppliers.SelectedRow == null)
        {
            lbl_error.Text = "Debe seleccionar una fila";
            return;
        }
        GridViewRow fila = grd_suppliers.SelectedRow;
        int id = Convert.ToInt32(grd_suppliers.DataKeys[fila.RowIndex].Value);
                
        string idSelected = id.ToString();
        string companyNameSelected = fila.Cells[1].Text;
        string contactNameSSelected = fila.Cells[2].Text;
        string direccionSelected = fila.Cells[3].Text;
        string telefonoSelected = fila.Cells[4].Text;

        //Creo la url mediante la cual voy a redireccionar a el segundo reporte pasandole los valores en las variables
        string urlReporte = "ReporteSimple.ashx?id=" + idSelected
                            + "&companyName=" + companyNameSelected
                            + "&contactName=" + contactNameSSelected
                            + "&direccion=" + direccionSelected
                            + "&telefono=" + telefonoSelected;

        Response.Redirect(urlReporte, false);
    }
}
