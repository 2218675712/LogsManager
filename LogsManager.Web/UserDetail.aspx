<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserDetail.aspx.cs" Inherits="LogsManager.Web.UserDetail" %>

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
            <h4 class="text-center mt-5">个人详情 </h4>
            <div class="mt-5 offset-4">
                <div class="mb-3 row">
                    <label class="col-sm-2 col-form-label">用户姓名</label>
                    <div class="col-6">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="mb-3 row">
                    <label class="col-sm-2 col-form-label">用户年龄</label>
                    <div class="col-6">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="mb-3 row">
                    <label class="col-sm-2 col-form-label">用户手机号</label>
                    <div class="col-6">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="mb-3 row">
                    <label class="col-sm-2 col-form-label">用户账号</label>
                    <div class="col-6">
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="mb-3 row">
                    <label class="col-sm-2 col-form-label">用户密码</label>
                    <div class="col-6">
                        <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="d-grid offset-2 mt-5">
                    <asp:Button ID="Button1" runat="server" Text="提交" class="btn btn-primary w-25" OnClick="Button1_OnClick" />
                </div>
            </div>

        </div>
    </div>
</form>
<script src="js/jquery-3.5.1.slim.min.js"></script>
<script src="js/bootstrap.bundle.min.js"></script>
</body>
</html>