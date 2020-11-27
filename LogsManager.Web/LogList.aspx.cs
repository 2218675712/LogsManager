using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using LogsManager.BLL;
using LogsManager.DBUtility;

namespace LogsManager.Web
{
    public partial class LogList : System.Web.UI.Page
    {
        public string AccountNum;
        public string UserID;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request["AccountNum"]))
            {
                LinkButton1.Text = Request["AccountNum"];
                AccountNum = Request["AccountNum"];
                UserID = Request["UserID"];
            }

            GetLogsList();
        }

        private void GetLogsList(string sql = null)
        {
            if (string.IsNullOrEmpty(sql))
            {
                sql = "select IL.*,IU.UserName from Info_Logs IL left join Info_User IU on IL.CreateUser = IU.UserID";
            }

            Info_Logs_BLL infoLogsBll = new Info_Logs_BLL();
            Repeater1.DataBind();
            DataSet ds = DbHelperSQL.Query(sql);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        /// <summary>
        /// 如果不是管理员登录,不显示操作按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Repeater1_OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            // throw new NotImplementedException();
            // rpt 循环绑定类型==行||rpt循环绑定类型==头模板的时候

            // 判断当前有没有登录信息  没有登录信息的时候,认定为游客
            if (string.IsNullOrEmpty(AccountNum))
            {
                // e.Item.ItemType==ListItemType.Item||
                if (!(e.Item.ItemType == ListItemType.Header))
                {
                    var Add = ((LinkButton) e.Item.FindControl("ADD"));
                    if (Add != null)
                    {
                        Add.Visible = false;
                    }

                    var Edit = ((LinkButton) e.Item.FindControl("Edit"));
                    if (Edit != null)
                    {
                        Edit.Visible = false;
                    }

                    var Delete = ((LinkButton) e.Item.FindControl("Delete"));
                    if (Delete != null)
                    {
                        Delete.Visible = false;
                    }
                }
            }
        }

        protected void Repeater1_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string LogsID = ((HiddenField) e.Item.FindControl("HiddenField1")).Value;
            if (e.CommandName == "ADD")
            {
                Response.Redirect("LogDetail.aspx?LogsID=" + LogsID+"&AccountNum="+AccountNum+"&UserID="+UserID);
            }
        }

        protected void LinkButton2_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("LogDetail.aspx?UserID="+UserID+"&AccountNum="+AccountNum);
        }
    }
}