using System;
using LogsManager.BLL;
using LogsManager.Model;

namespace LogsManager.Web
{
    public partial class UserDetail : System.Web.UI.Page
    {
        public string UserID;

        protected void Page_Load(object sender, EventArgs e)
        {
            UserID = Request["UserID"];
            if (!IsPostBack)
            {
                GetUserInfo();
            }
        }

        /// <summary>
        /// 获取数据库用户信息
        /// </summary>
        private void GetUserInfo()
        {
            Info_User_BLL infoUserBll = new Info_User_BLL();
            Info_User_Model infoUserModel = infoUserBll.GetModel(new Guid(UserID));
            TextBox1.Text = infoUserModel.UserName;
            TextBox2.Text = infoUserModel.UserSex.ToString();
            TextBox3.Text = infoUserModel.UserPhone;
            TextBox4.Text = infoUserModel.AccountNum;
            TextBox4.ReadOnly = true;
            TextBox5.Text = infoUserModel.Pwd;
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            Info_User_BLL infoUserBll = new Info_User_BLL();
            Info_User_Model infoUserModel = infoUserBll.GetModel(new Guid(UserID));
            infoUserModel.UserName = TextBox1.Text;
            infoUserModel.UserSex = Convert.ToInt32(TextBox2.Text);
            infoUserModel.UserPhone = TextBox3.Text;
            infoUserModel.AccountNum = TextBox4.Text;
            infoUserModel.Pwd = TextBox5.Text;
            bool result =infoUserBll.Update(infoUserModel);
            if (result)
            {
                Response.Write("更新成功");
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("更新失败,请联系管理员");
            }
        }
    }
}