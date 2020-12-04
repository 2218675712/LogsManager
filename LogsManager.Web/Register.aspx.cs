using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogsManager.BLL;
using LogsManager.Model;
using Maticsoft.Model;

namespace LogsManager.Web
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void UserRegister()
        {
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            Info_User_BLL infoUserBll = new Info_User_BLL();
            Info_User_Model infoUserModel = new Info_User_Model();
            infoUserModel.UserID = Guid.NewGuid();
            infoUserModel.AccountNum = TextBox1.Text.Trim();
            infoUserModel.Pwd = TextBox2.Text.Trim();
            infoUserModel.CreateUser = Guid.NewGuid();
            infoUserModel.CreateTime = DateTime.Now;
            bool result = infoUserBll.Add(infoUserModel);
            if (result)
            {
                Response.Write("添加成功");
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("添加失败,请联系管理员");
            }
        }
    }
}