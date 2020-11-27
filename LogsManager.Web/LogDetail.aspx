<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogDetail.aspx.cs" Inherits="LogsManager.Web.LogDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="css/bootstrap.min.css">

</head>
<body>
<form id="form1" runat="server">
    <div class="container mt-5">
        <div class="mb-3">
            <label class="form-label">
                标题:
            </label>
            <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div>
            <label class="form-label">
                内容:
            </label>
            <textarea id="TextArea1" class="form-control" runat="server" cols="20" rows="4"></textarea>
        </div>
        <br/>
        <asp:HiddenField ID="HiddenField1" runat="server"/>
        <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="确定" OnClick="Button1_Click"/>
    </div>
</form>
<script src="js/jquery-3.5.1.slim.min.js"></script>
<script src="js/bootstrap.bundle.min.js"></script>
</body>
</html>