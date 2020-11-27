using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LogsManager.Common
{
    public class CookieHelper
    {
        /// <summary>
        /// cookie前缀123
        /// </summary>
        private const string _prevFix = "LogsManagerWeb_";

        /// <summary>
        /// 设置一个cookie
        /// 2020年11月03日 14:47:09
        /// </summary>
        /// <param name="CookieName">cookie名</param>
        /// <param name="CookieValue">cookie值</param>
        /// <param name="Expires">过期时间</param>
        public static void SetCookie(string CookieName, string CookieValue, DateTime Expires)
        {
            HttpCookie cookie = new HttpCookie(_prevFix + CookieName)
            {
                Value = HttpUtility.UrlEncode(CookieValue),
                Expires = DateTime.Now.AddMinutes(15)
            };
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        /// <summary>
        /// 清除指定cookie
        /// 2020年11月03日 14:59:52
        /// </summary>
        /// <param name="CookieName">cookie名</param>
        public static void ClearCookie(string CookieName)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[_prevFix + CookieName];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddYears(-3);
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
        }

        /// <summary>
        /// 获取指定cookie值
        /// </summary>
        /// <param name="CookieName">cookie名</param>
        /// <returns></returns>
        public static string GetCookieValue(string CookieName)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[_prevFix + CookieName];
            string Str = string.Empty;
            if (cookie != null)
            {
                Str = HttpUtility.UrlDecode(cookie.Value);
            }
            return Str;
        }
    }
}
