<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="Assignment1_ASP_.ProductDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Product Selection</h1>

            <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
                <asp:ListItem Text="Select a product" Value="0" />
                <asp:ListItem Text="Mobile" Value="1" />
                <asp:ListItem Text="Laptop" Value="2" />
                <asp:ListItem Text="Tab" Value="3" />
                <asp:ListItem Text="Power Bank" Value="4" />
            </asp:DropDownList>
 
            <br /><br />

            <asp:Image ID="imgProduct" runat="server" CssClass="product-image" Visible="false" />
 
            <br /><br />

            <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click" />
            
            <br /><br />

            <asp:Label ID="lblPrice" runat="server" Text="Price: $" Visible="false" />
        </div>
    </form>
</body>
</html>
