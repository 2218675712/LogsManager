using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogsManager.BLL;
using LogsManager.Common;
using LogsManager.Model;

namespace LogsManager.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            string AccountNum = TextBox1.Text.Trim();
            string Pwd = TextBox2.Text.Trim();
            Info_User_BLL infoUserBll = new Info_User_BLL();


            /*
            // 是否登录
            List<Info_User_Model> ds =
                infoUserBll.GetModelList("AccountNum='" + AccountNum + "' and Pwd='" + Pwd + "'");
            if (ds.Count > 0)
            {
                Info_User_Model infoUserModel = ds.FirstOrDefault();
                Response.Write("<div class='alert alert-success' role='alert'>登录成功</div>");
                CookieHelper.SetCookie("UserID", infoUserModel.UserID.ToString(), DateTime.Now.AddMinutes(10));
                Response.Redirect("LogList.aspx?AccountNum=" + AccountNum + "&UserID=" + infoUserModel.UserID);
            }
            else
            {
                Response.Write("<div class='alert alert-danger' role='alert'>登录失败</div>");
            }
            */
            // 自定义登录
            Info_User_Model infoUserModel = infoUserBll.GetModel(AccountNum, Pwd);
            if (infoUserModel != null)
            {
                Response.Write("<div class='alert alert-success' role='alert'>登录成功</div>");
                CookieHelper.SetCookie("UserID", infoUserModel.UserID.ToString(), DateTime.Now.AddMinutes(10));
                Response.Redirect("LogList.aspx?AccountNum=" + AccountNum + "&UserID=" + infoUserModel.UserID);
            }
            else
            {
                Response.Write("<div class='alert alert-danger' role='alert'>登录失败</div>");
            }
        }
    }
}