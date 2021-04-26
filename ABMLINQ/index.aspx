<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="index.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ABM LINQ</title>
    <script>
    function ver(url) {
        window.open(url, 'Detalle', 'width=400,height=500');
    }
</script>
</head>
<body>
    <h3>LINQ y REPORTE ITEXT NET</h3>
    <form id="form1" runat="server">
    <div>
        <fieldset>
        <legend>Alta/Modificacion de Supplier</legend>
        
        <asp:Button ID="btn_insertar" runat="server" onclick="btn_insertar_Click" 
                     Text="Limpiar para insertar" />
                 <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Reporte Full" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="Reporte Simple" />
                <asp:Label ID="lbl_error" runat="server"></asp:Label>
                 <table style="width:100%;">
                     <tr>
                         <td>
                             ID</td>
                         <td>
                             <asp:Label ID="lbl_id" runat="server"></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             Company Name</td>
                         <td>
                             <asp:TextBox ID="txt_comanyName" runat="server"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             Contact Name</td>
                         <td>
                             <asp:TextBox ID="txt_contactName" runat="server"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             Direccion</td>
                         <td>
                             <asp:TextBox ID="txt_direccion" runat="server"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             Telefono</td>
                         <td>
                             <asp:TextBox ID="txt_telefono" runat="server"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             &nbsp;</td>
                        <td>
                            <asp:Button ID="btn_insertar_modificar" runat="server" Text="Agregar" 
                                onclick="btn_insertar_modificar_Click" />
                        </td>
                    </tr>
                </table>
        </fieldset>     
             <br />
    
        <asp:GridView ID="grd_suppliers" runat="server"             
            BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
            CellPadding="4" CellSpacing="2" ForeColor="Black" 
            onrowcommand="grd_suppliers_RowCommand" AllowPaging="True" 
            DataKeyNames="SupplierID"
            AllowSorting="True" AutoGenerateColumns="False" DataSourceID="LinqDataSource1" EnableModelValidation="True">
            <RowStyle BackColor="White" />
            <Columns>                
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" ReadOnly="True" 
                    SortExpression="SupplierID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" 
                    ReadOnly="True" SortExpression="CompanyName" />
                <asp:BoundField DataField="ContactName" HeaderText="ContactName" 
                    ReadOnly="True" SortExpression="ContactName" />
                <asp:BoundField DataField="Address" HeaderText="Address" ReadOnly="True" 
                    SortExpression="Address" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" ReadOnly="True" 
                    SortExpression="Phone" />
                <asp:TemplateField HeaderText="Detalle">
                    <ItemTemplate>
                        <a href="#" onclick="ver('detalle.aspx?id=<%# Eval("SupplierID") %>')">
                                    <img alt="Info" src="images/detalles.png" border="0px" />
                                </a>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Modificar">
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" 
                            CommandArgument='<%# Eval("SupplierID") %>' CommandName="modificar" 
                            ImageUrl="~/images/modificar.png" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Eliminar">
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton2" runat="server" 
                            CommandArgument='<%# Eval("SupplierID") %>' CommandName="eliminar" 
                            ImageUrl="~/images/eliminar.png" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#d7d6ce" Font-Bold="True" ForeColor="Black" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            
            
        </asp:GridView>                         
    
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="NorthwindDSDataContext" 
            Select="new (SupplierID, CompanyName, ContactName, Address, Phone)" 
            TableName="Suppliers" OrderBy="SupplierID desc">
        </asp:LinqDataSource>
    
    </div>
    </form>
</body>
</html>
