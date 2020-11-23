using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogsManager.BLL;
using LogsManager.DBUtility;

namespace LogsManager.Web
{
    public partial class LogList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Info_Logs_BLL infoLogsBll = new Info_Logs_BLL();
            // DataSet ds = infoLogsBll.GetAllList();
            // Repeater1.DataSource = ds;
            Repeater1.DataBind();
            DataSet ds = DbHelperSQL.Query(
                "select IL.*,IU.UserName from Info_Logs IL left join Info_User IU on IL.CreateUser = IU.UserID");
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
            if (!string.IsNullOrEmpty(Request["AccountNum"]))
            {
                LinkButton1.Text = Request["AccountNum"];
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}