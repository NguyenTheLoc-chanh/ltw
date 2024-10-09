<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai10.aspx.cs" Inherits="Web10.Bai10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="Bai10.aspx" method="post">
        <div>
            <asp:TextBox TextMode="MultiLine" runat="server" ID="txtNoidung" name="txtNoidung" required></asp:TextBox>
            <asp:FileUpload runat="server" type="file" ID="txtFile" name="txtFile" required />
            <asp:Button runat="server" class="btn" value="Submit" Text="Submit"/>
        </div>
    </form>
    <div id="ketqua">
        <% Response.Write("txtNoidung: " + Request.Form["txtNoidung"]); %>
    </div>
</body>
</html>
