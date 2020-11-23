<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogList.aspx.cs" Inherits="LogsManager.Web.LogList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
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
            <table class="w-75 table">
                <asp:Repeater ID="Repeater1" runat="server">
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
                            <td ><%#Eval("LogsTitle") %></td>
                            <td ><%#Eval("UserName") %></td>
                            <td > <%#Eval("CreateTime") %></td>
                            <td >
                                <a href="" class="btn btn-light">查看</a>
                            </td>
                            <td >
                                <a href="" class="btn btn-info">更新</a>
                            </td>
                            <td >
                                <a href="" class="btn btn-danger">删除</a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>

        </div>
    </div>
</form>
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>
</body>
</html>