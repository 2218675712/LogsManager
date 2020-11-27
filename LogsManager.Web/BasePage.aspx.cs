using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogsManager.Common;

namespace LogsManager.Web
{
    public partial class BasePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OnInit(null);
        }

        public string LoginUserID
        {
            get
            {
                if (string.IsNullOrEmpty(CurrentUser))
                {
                    if (Session["UserID"] != null)
                        return Session["UserID"].ToString();
                    else
                        return "";
                }
                else
                    return (string)CookieHelper.GetCookieValue("UserID");
            }
        }

        public string CurrentUser
        {
            get
            {
                return (string)CookieHelper.GetCookieValue("UserID");
            }
            set
            {

            }
        }
        protected override void OnInit(EventArgs e)
        {
            //默认取Cookie Cookie 没取到的情况
            if (string.IsNullOrEmpty(CurrentUser))
            {
                //看看用户是不是只接登录的
                //是直接登陆的在登录里存了Session 保证页面关闭前可以完成校验
                if (Session["UserID"] == null)
                {
                    Response.Write("<script type='text/javascript'>alert('您需要重新登陆');</script>");
                    Response.Redirect("LogList.aspx");
                }
            }
            base.OnInit(e);
        }
    }
}