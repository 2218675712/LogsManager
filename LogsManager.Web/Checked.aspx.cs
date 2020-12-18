using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogsManager.BLL;
using Maticsoft.Model;

namespace LogsManager.Web
{
    public partial class Checked : System.Web.UI.Page
    {
        int success = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetList();
            }
        }

        private void GetList()
        {
            Info_Logs_BLL infoLogsBll = new Info_Logs_BLL();
            DataSet ds = infoLogsBll.GetList("isDelete=0");
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
          
            for (int i = 0; i < Repeater1.Items.Count; i++)
            {
                CheckBox cbx = (CheckBox) Repeater1.Items[i].FindControl("CheckBox1");
                if (cbx.Checked)
                {
                    string id = ((HiddenField) Repeater1.Items[i].FindControl("HiddenField1")).Value;
                    Info_Logs_BLL infoLogsBll = new Info_Logs_BLL();
                    Info_Logs_Model infoLogsModel = new Info_Logs_Model();
                    infoLogsModel = infoLogsBll.GetModel(new Guid(id));
                    infoLogsModel.isDelete = true;
                    bool result = infoLogsBll.Update(infoLogsModel);
                    if (result)
                    {
                        success += 1;
                    }

                }

            }
                            
            if (success >= 0)
            {
                Response.Write("删除成功,删除了" + success + "行");
            }
            else
            {
                Response.Write("删除失败");
            }
            GetList();
        }
    }
}