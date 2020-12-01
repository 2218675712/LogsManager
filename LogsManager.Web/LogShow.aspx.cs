using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogsManager.BLL;
using LogsManager.DBUtility;
using Maticsoft.Model;

namespace LogsManager.Web
{
    public partial class LogShow : System.Web.UI.Page
    {
        public string LogsID;
        public string UserID;
        public string AccountNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            // 获取传值
            LogsID = Request["LogsID"];
            UserID = Request["UserID"];
            AccountNum = Request["AccountNum"];
            if (!IsPostBack)
            {
                GetInfoLogs();
                GetComments();
            }
        }

        /// <summary>
        /// 获取页面内容
        /// </summary>
        private void GetInfoLogs()
        {
            Info_Logs_BLL infoLogsBll = new Info_Logs_BLL();
            Info_Logs_Model infoLogsModel = infoLogsBll.GetModel(new Guid(LogsID));
            Label1.Text = infoLogsModel.LogsTitle;
            Label2.Text = infoLogsModel.LogsContent;
            Label3.Text = infoLogsModel.UpdateTime.ToString();
        }

        private void GetComments()
        {
            V_Com_User_BLL vComUserBll = new V_Com_User_BLL();
            Repeater1.DataSource=vComUserBll.GetModelList("LogsID='" + LogsID + "'");
            Repeater1.DataBind();
        }
    }
}