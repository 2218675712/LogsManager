<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogShow.aspx.cs" Inherits="LogsManager.Web.LogShow" %>

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
            <!-- As a link -->
            <nav class="navbar navbar-light bg-light">
                <div class="container-fluid">
                    <a class="navbar-brand" href="#">Navbar</a>
                </div>
            </nav>
            <div>
                <div class="row mt-3 col-8 offset-2">
                    <asp:Label ID="Label1" runat="server" Text="" class="h3"></asp:Label>
                </div>
                <div class="row mb-4">
                    <div class="col-10 offset-1 mt-5">
                        <asp:Label ID="Label2" runat="server" Text="" class="p  lead text-body"></asp:Label>
                    </div>
                </div>
                <%-- <br/> --%>
                <%-- <br/> --%>
                <p class="text-right text-muted">
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                </p>
            </div>
            <div class="mt-5 col-10 offset-1 ">
                <div class="h3 mb-5">评论列表</div>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="mb-5">
                            <asp:Label ID="Label4" runat="server" Text=""><%#Eval("CommentContent") %></asp:Label>
                            <div class="d-flex justify-content-between mt-2">
                                <asp:Label ID="Label5" runat="server" Text="" CssClass=""><%#Eval("CommentTime") %></asp:Label>
                                <asp:Label ID="Label6" runat="server" Text="" CssClass=""><%#Eval("UserName") %></asp:Label>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="col-10 offset-1 mb-5">
                <div class="mt-2">
                    <asp:Label ID="Label7" runat="server" Text="提交评论" class="h5"></asp:Label>
                </div>
                <div class="mb-3">
                    <textarea runat="server" id="TextArea1" cols="20" rows="2" placeholder="请输入评论" class="form-control mt-3"></textarea>
                    <div class="invalid-feedback">
                        <%-- invalid-feedback --%>
                        <asp:Label runat="server" ID="Label8" Visible="False"></asp:Label>
                    </div>
                </div>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_OnClick" CssClass="btn btn-primary">提交</asp:LinkButton>
                <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger" OnClick="LinkButton2_OnClick">返回</asp:LinkButton>
            </div>
        </div>

    </div>
</form>
<script src="js/jquery-3.5.1.slim.min.js"></script>
<script src="js/bootstrap.bundle.min.js"></script>
</body>
</html>