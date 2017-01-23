using System;
using System.Web;

namespace Core
{
    public class CookieHelper
    {
        /// <summary>
        /// Reads the cookie.
        /// </summary>
        /// <param name="cookieName">Name of the cookie.</param>
        /// <returns></returns>
        public static string Read(string cookieName)
        {
            HttpCookie httpCookie = HttpContext.Current.Request.Cookies[cookieName];
            return httpCookie != null ? HttpContext.Current.Server.HtmlEncode(httpCookie.Value).Trim() : string.Empty;
        }

        /// <summary>
        /// Writes a cookie and auto sets the expire date to as current day plus one.
        /// </summary>
        /// <param name="cookieName">Name of the cookie.</param>
        /// <param name="cookieValue">The cookie value.</param>
        /// <param name="isHttpCookie">if set to <c>true</c> [is HTTP cookie].</param>
        public static void Write(string cookieName, string cookieValue, bool isHttpCookie)
        {
            var aCookie = new HttpCookie(cookieName) { Value = cookieValue, Expires = DateTime.Now.AddDays(1), HttpOnly = isHttpCookie };
            HttpContext.Current.Response.Cookies.Add(aCookie);
        }

        /// <summary>
        /// Writes a cookie.
        /// </summary>
        /// <param name="cookieName">Name of the cookie.</param>
        /// <param name="cookieValue">The cookie value.</param>
        /// <param name="isHttpCookie">if set to <c>true</c> [is HTTP cookie].</param>
        /// <param name="cookieExpireDate">The cookie expire date.</param>
        public static void Write(string cookieName, string cookieValue, bool isHttpCookie, DateTime cookieExpireDate)
        {
            var aCookie = new HttpCookie(cookieName) { Value = cookieValue, Expires = cookieExpireDate, HttpOnly = isHttpCookie };
            HttpContext.Current.Response.Cookies.Add(aCookie);
        }

        /// <summary>
        /// Deletes a single cookie.
        /// </summary>
        /// <param name="cookieName">Name of the cookie.</param>
        public static void Delete(string cookieName)
        {
            var aCookie = new HttpCookie(cookieName) { Expires = DateTime.Now.AddDays(-1) };
            HttpContext.Current.Response.Cookies.Add(aCookie);
        }

        /// <summary>
        /// Deletes all the cookies available to the application.
        /// </summary>
        /// <remarks>The technique creates a new cookie with the same name as the cookie to be deleted, but to set the cookie's expiration to a date earlier than today.</remarks>
        public static void DeleteAll()
        {
            for (int i = 0; i <= HttpContext.Current.Request.Cookies.Count - 1; i++)
            {
                HttpContext.Current.Response.Cookies.Add(new HttpCookie(HttpContext.Current.Request.Cookies[i].Name) { Expires = DateTime.Now.AddDays(-1) });
            }
        }
    }
}