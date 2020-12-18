<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LogsManager.Web.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <link rel="stylesheet" href="css/bootstrap.min.css">

</head>

<body>
<form id="form1" runat="server">
    <div>
        <div class="container">
            <div class="mt-5 offset-3">
                <div class="mb-3 row">
                    <div class="col-auto">
                        <asp:Label ID="Label1" runat="server" Text="用户账户" class="col-form-label"></asp:Label>
                    </div>
                    <div class="col-auto">
                        <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="mb-3 row">
                    <div class="col-auto">
                        <asp:Label ID="Label2" runat="server" Text="用户密码" class="col-form-label"></asp:Label>

                    </div>
                    <div class="col-auto">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <asp:Button ID="Button1" runat="server" Text="注册" class=" col-2 btn btn-primary offset-1 " OnClick="Button1_OnClick"/>

            </div>
        </div>
    </div>
</form>
<script src="js/jquery-3.5.1.slim.min.js"></script>
<script src="js/bootstrap.bundle.min.js"></script>
</body>
</html>