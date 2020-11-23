<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LogsManager.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
</head>
<body>
<form id="form1" runat="server">
    <div class="container">
        <div class="mt-5 offset-3">
            <div class="mb-3 row">
                <div class="col-auto">
                    <%-- <label for="exampleInputEmail1" class="col-form-label">用户账户</label> --%>
                    <asp:Label ID="Label1" runat="server" Text="Label" class="col-form-label">用户账户</asp:Label>
                </div>
                <div class="col-auto">
                    <%-- <input type="password" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp"> --%>
                    <asp:TextBox class="form-control"  ID="TextBox1" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row">
                <div class="col-auto">
                    <asp:Label ID="Label2" runat="server" Text="Label" class="col-form-label">用户密码</asp:Label>
                </div>
                <div class="col-auto">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="password" class="form-control"></asp:TextBox>
                </div>
            </div>
            <asp:Button ID="Button1" runat="server" Text="登录"  class="btn btn-primary offset-1" OnClick="Button1_OnClick" />
        </div>
    </div>
</form>
<script src="js/jquery-3.5.1.slim.min.js"></script>
<script src="js/bootstrap.bundle.min.js"></script>
</body>
</html>