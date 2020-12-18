<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checked.aspx.cs" Inherits="LogsManager.Web.Checked" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <table>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <tr>
                        <td></td>
                        <td>选项</td>
                        <td>标题</td>
                        <td>
                            
                        </td>
                    </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:HiddenField runat="server" ID="HiddenField1" Value='<%#Eval("LogsID") %>'/>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox1" runat="server" onclick="check(this)" AutoPostBack="True"/>
                        </td>
                        <td>
                            <%#Eval("LogsTitle") %>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </table>
            <tr>
            <td><asp:CheckBox ID="CheckBox2" runat="server" onclick="checkAll()" AutoPostBack="True"/></td>
                <td><asp:Button ID="Button1" runat="server" Text="删除" OnClick="Button1_OnClick"/></td>
            </tr>
    </div>
</form>
<script src="js/jquery-3.5.1.slim.min.js"></script>
<script>
function check(obj) {
    $("#" + obj.id).attr("checked", true);
    checkChild()
}

function checkAll() {

    if ($("#CheckBox2").attr("checked") == undefined) {
        $("#CheckBox2").attr("checked", true)
    } else {
        $("#CheckBox2").removeAttr("checked")
    }
    
    $(":checkbox[id!='CheckBox2']").each(function () {
        if ($("#CheckBox2").attr("checked") == "checked") {
            //每一个checkbox checked=checked
            $(this).attr("checked", true);
            $("#CheckBox2").attr("checked")
            
        }
        if ($("#CheckBox2").attr("checked") == undefined) {
            //每一个checkbox checked=checked
            $(this).attr("checked", false);
            $("#CheckBox2").removeAttr("checked")


        }
    });
    checkChild()


}
function checkChild() {
    let checkLength = $("tbody :checkbox[id!='CheckBox2']").length;
    let childCheckedLength = $("tbody :checkbox[id!='CheckBox2']:checked").length;
    if (checkLength == childCheckedLength) {
        $("#CheckBox2").attr("checked", true)
    } else {
        $("#CheckBox2").attr("checked", false)
    }
}

</script>
</body>
</html>