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
    public partial class LogDetail : System.Web.UI.Page
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

                if (LogsID != null)
                {
                    Info_Logs_BLL infoLogsBll = new Info_Logs_BLL();
                    Info_Logs_Model infoLogsModel = infoLogsBll.GetModel(new Guid(LogsID));
                    if (infoLogsModel != null)
                    {
                        TextBox1.Text = infoLogsModel.LogsTitle;
                        TextArea1.Value = infoLogsModel.LogsContent;
                        HiddenField1.Value = infoLogsModel.LogsID.ToString();
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string LogsTitle = TextBox1.Text;
            string LogsContent = TextArea1.Value;
            Info_Logs_BLL infoLogsBll = new Info_Logs_BLL();
            if(LogsID!=null)
            {
                Info_Logs_Model infoLogsModel = infoLogsBll.GetModel(new Guid(LogsID));
                // 更新
                infoLogsModel.LogsTitle = LogsTitle;
                infoLogsModel.LogsContent = LogsContent;
                infoLogsModel.isDelete = false;
                infoLogsModel.UpdateTime = DateTime.Now;
                infoLogsModel.UpdateUser = infoLogsModel.CreateUser;
                bool result = infoLogsBll.Update(infoLogsModel);
                if (result)
                {
                    Response.Write("更新成功");
                    // Response.Redirect("LogList.aspx");
                    Response.Redirect("LogList.aspx?LogsID=" + LogsID+"&AccountNum="+AccountNum+"&UserID="+UserID);

                }
            }
            // 为空.添加
            if (UserID!=null)
            {
                两种写法
                Info_Logs_Model infoLogsModel = new Info_Logs_Model()
                {
                    LogsTitle = LogsTitle,
                    LogsContent = LogsContent,
                    isDelete = false,
                    CreateTime = DateTime.Now,
                    CreateUser = new Guid(UserID)
                };
                /*infoLogsModel.LogsTitle = LogsTitle;
                infoLogsModel.LogsContent = LogsContent;
                infoLogsModel.isDelete = false;
                infoLogsModel.CreateTime = DateTime.Now;
                infoLogsModel.CreateUser = new Guid(UserID);*/
                bool result = infoLogsBll.Add(infoLogsModel);
                if (result)
                {
                    Response.Write("添加成功");
                    Response.Redirect("LogList.aspx?LogsID=" + LogsID+"&AccountNum="+AccountNum+"&UserID="+UserID);

                }
            }

        }
    }
}