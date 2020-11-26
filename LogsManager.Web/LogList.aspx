<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogList.aspx.cs" Inherits="LogsManager.Web.LogList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <style>
        
    </style>
</head>
<body>
<form id="form1" runat="server">
    <div class="container">
        <ul class="nav  justify-content-end">
            <li class="nav-item">
                <%-- <a class="nav-link active" href="/Login.aspx">登录</a> --%>
                <asp:LinkButton ID="LinkButton1" class="nav-link active" runat="server" OnClick="LinkButton1_Click">登录</asp:LinkButton>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="#">注册</a>
            </li>
        </ul>
        <div class="row">
            <table class="w-80 table">
                <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_OnItemDataBound" OnItemCommand="Repeater1_OnItemCommand">
                    <HeaderTemplate>
                        <thead>
                        <tr>
                            <th>标题</th>
                            <th>发布用户</th>
                            <th>发布时间</th>
                            <th>查看</th>
                            <th>更新</th>
                            <th>删除</th>
                        </tr>
                        </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("LogsTitle") %></td>
                            <td ><%#Eval("UserName") %></td>
                            <td > <%#Eval("CreateTime") %></td>
                            <td >
                                <asp:LinkButton ID="ADD" runat="server" class="btn btn-light" CommandName="ADD">查看</asp:LinkButton>
                            </td>
                            <td >
                                <asp:LinkButton ID="Edit" runat="server" class="btn btn-info" CommandName="Edit">更新</asp:LinkButton>
                            </td>
                            <td >
                                <asp:LinkButton ID="Delete" runat="server" class="btn btn-danger" CommandName="Delete">删除</asp:LinkButton>
                            </td>
                            <td>
                                <asp:HiddenField ID="HiddenField1" runat="server"  Value='<%#Eval("LogsID") %>' />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:LinkButton runat="server" ID="LinkButton2" class="btn btn-light" OnClick="LinkButton2_OnClick">添加</asp:LinkButton>
            </table>

        </div>
    </div>
</form>
<script src="js/jquery-3.5.1.slim.min.js"></script>
<script src="js/bootstrap.bundle.min.js"></script>
</body>
</html>