using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogsManager.BLL;
using LogsManager.DBUtility;
using LogsManager.Model;
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
            Repeater1.DataSource = vComUserBll.GetModelList("LogsID='" + LogsID + "'");
            Repeater1.DataBind();
        }

        protected void LinkButton1_OnClick(object sender, EventArgs e)
        {
            string comments = TextArea1.Value.Trim();
            if (string.IsNullOrEmpty(comments))
            {
                Label8.Text = "评论不能为空";
                Label8.Visible = true;
                TextArea1.Attributes.Add("class","is-invalid form-control mt-3");
                return;
            }

            if (string.IsNullOrEmpty(UserID))
            {
                Label8.Text = "请登录后再评论";
                Label8.Visible = true;
                TextArea1.Attributes.Add("class","is-invalid form-control mt-3");
                return;
            }

            Info_Comment_BLL infoCommentBll = new Info_Comment_BLL();
            Info_Comment_Model infoCommentModel = new Info_Comment_Model();
            infoCommentModel.CommentID = Guid.NewGuid();
            infoCommentModel.LogsID = new Guid(LogsID);
            infoCommentModel.CommentContent = comments;
            infoCommentModel.Commentator = new Guid(UserID);
            infoCommentModel.CommentTime = DateTime.Now;
            infoCommentBll.Add(infoCommentModel);
            GetComments();
        }
    }
}