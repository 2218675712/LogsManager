using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogsManager.BLL;
using LogsManager.DBUtility;
using LogsManager.Model;
using LogsManager.Model.Enum;
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
            // 添加日志
            Sys_ProcessLog_Model sysProcessLogModel = new Sys_ProcessLog_Model();
            sysProcessLogModel.ID = Guid.NewGuid();
            sysProcessLogModel.LogType = (int) SystemLogType.UserRegister;
            sysProcessLogModel.LogDescription = "插入了一个用户";
            sysProcessLogModel.CreateUser = new Guid("CB693BE8-D36C-4B27-8E6B-892987DC5D9E");
            sysProcessLogModel.CreateTime = DateTime.Now;
            // 修改成使用事务
            bool result = infoUserBll.Add(infoUserModel, sysProcessLogModel);
            if (result)
            {
                Response.Write("添加成功");
                // Response.Redirect("Login.aspx");
                Response.Redirect("LogList.aspx?AccountNum=" + infoUserModel.AccountNum + "&UserID=" +
                                  infoUserModel.UserID);
            }
            else
            {
                Response.Write("添加失败,请联系管理员");
            }
        }
    }
}