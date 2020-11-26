<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogDetail.aspx.cs" Inherits="LogsManager.Web.LogDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>

        标题:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br/>
        内容:<textarea id="TextArea1" runat="server" cols="20" rows="2"></textarea>
        <br/>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
    </div>
</form>
</body>
</html>