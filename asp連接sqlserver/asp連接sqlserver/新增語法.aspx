<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="新增語法.aspx.cs" Inherits="asp連接sqlserver.新增語法" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="Content/buttons.css"/>
</head>
<body>
    <form id="form1" runat="server">

        <div >
            <asp:TextBox ID="TextBox1" runat="server" Height="50px" Width="100px" Font-Size="30px" ></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="新增" class="button button-3d button-action button-circle button-jumbo" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
