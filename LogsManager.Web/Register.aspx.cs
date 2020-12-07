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
            string AccountNum = TextBox1.Text.Trim();
            string Pwd = TextBox2.Text.Trim();

            //todo 写一个个人详情页补全个人信息
            List<Info_User_Model> infoUserModels = infoUserBll.GetModelList("AccountNum='" + AccountNum + "'");
            // lambda表达式 .tolist转换为list列表
            if (infoUserModels.Where(x => x.AccountNum == AccountNum).ToList().Count > 0)
            {
                Response.Write("用户账户已经重复,请输入其他的");
                return;
            }


            infoUserModel.UserID = Guid.NewGuid();
            infoUserModel.AccountNum = AccountNum;
            infoUserModel.Pwd = Pwd;
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