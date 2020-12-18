﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using LogsManager.BLL;
using LogsManager.Common;
using LogsManager.DBUtility;
using LogsManager.Model;
using Maticsoft.Model;

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
                GetUserInfo();
            }

            // 显示注销按钮
            if (LinkButton1.Text != "登录")
            {
                LinkButton2.Visible = true;
                LinkButton1.PostBackUrl = "UserDetail.aspx?UserID=" + UserID;
            }

            GetLogsList();
        }

        private void GetLogsList(string sql = null)
        {
            if (string.IsNullOrEmpty(sql))
            {
                sql =
                    "select IL.*,IU.UserName from Info_Logs IL left join Info_User IU on IL.CreateUser = IU.UserID where IL.isDelete=0";
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
            // 三种判断
            //1游客除查看按钮把所有按钮隐藏掉
            //2登录人不是日志创建人更新和删除按钮隐藏
            //3登录人是日志创建人无需操作


            // throw new NotImplementedException();
            // rpt 循环绑定类型==行||rpt循环绑定类型==头模板的时候

            // 判断当前有没有登录信息  没有登录信息的时候,认定为游客
            if (string.IsNullOrEmpty(AccountNum))
            {
                // e.Item.ItemType==ListItemType.Item||
                if ((e.Item.ItemType == ListItemType.Header))
                {
                    var ADD = ((LinkButton) e.Item.FindControl("ADD"));
                    if (ADD != null)
                    {
                        ADD.Visible = false;
                    }
                }
                else
                {
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

                return;
            }

            if (e.Item.ItemType != ListItemType.Header)
            {
                // 创建人id
                string CreateUser = ((HiddenField) e.Item.FindControl("HiddenField2")).Value;
                if (CreateUser != UserID)
                {
                    // 判断这条文章是不是当前登录用户发布的
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
            if (e.CommandName == "Edit")
            {
                string LogsID = ((HiddenField) e.Item.FindControl("HiddenField1")).Value;

                Response.Redirect("LogDetail.aspx?LogsID=" + LogsID + "&AccountNum=" + AccountNum + "&UserID=" +
                                  UserID);
            }
            else if (e.CommandName == "Check")
            {
                string LogsID = ((HiddenField) e.Item.FindControl("HiddenField1")).Value;

                Response.Redirect("LogShow.aspx?LogsID=" + LogsID + "&AccountNum=" + AccountNum + "&UserID=" +
                                  UserID);
            }
            else if (e.CommandName == "Delete")
            {
                string LogsID = ((HiddenField) e.Item.FindControl("HiddenField1")).Value;
                Info_Logs_BLL infoLogsBll = new Info_Logs_BLL();
                Info_Logs_Model infoLogsModel = infoLogsBll.GetModel(new Guid(LogsID));
                infoLogsModel.isDelete = true;
                infoLogsModel.UpdateUser = new Guid(UserID);
                infoLogsModel.UpdateTime = DateTime.Now;
                infoLogsBll.Update(infoLogsModel);
                GetLogsList();
                // infoLogsBll.Update("")
            }

            if (e.CommandName == "ADD")
            {
                Response.Redirect("LogDetail.aspx?UserID=" + UserID + "&AccountNum=" + AccountNum);
            }
        }

        protected void LinkButton2_OnClick(object sender, EventArgs e)
        {
            CookieHelper.ClearCookie("UserID");
            Response.Redirect("Login.aspx");
        }

        public void GetUserInfo()
        {
            Info_User_BLL infoUserBll = new Info_User_BLL();
            Info_User_Model infoUserModel = new Info_User_Model();
            infoUserModel = infoUserBll.GetModel(new Guid(UserID));
            if (string.IsNullOrEmpty(infoUserModel.UserName) | string.IsNullOrEmpty(infoUserModel.UserSex.ToString()) |
                string.IsNullOrEmpty(infoUserModel.UserPhone) | string.IsNullOrEmpty(infoUserModel.AccountNum) |
                string.IsNullOrEmpty(infoUserModel.Pwd))
            {
                Response.Redirect("UserDetail.aspx?UserID=" + infoUserModel.UserID);
            }
        }
        
    }
}