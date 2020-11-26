using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogsManager.BLL;
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
            // 是否登录
            List<Info_User_Model> ds=infoUserBll.GetModelList("AccountNum='" + AccountNum + "' and Pwd='" + Pwd + "'");
            if (ds.Count>0)
            {
               Response.Write("<div class='alert alert-success' role='alert'>登录成功</div>"); 
               Response.Redirect("LogList.aspx?AccountNum="+AccountNum+"&UserID="+ds.FirstOrDefault().UserID);
            }
            else
            {
                Response.Write("<div class='alert alert-danger' role='alert'>登录失败</div>");
            }

        }
    }
}