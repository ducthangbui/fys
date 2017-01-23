
using Datalayer.Repositories;

using System;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Core;
using Datalayer.Repository;
using Model;
using Service.Entities;
using Service.Interfaces;
using Service.Serivices;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
        protected UnitOfWork uow = new UnitOfWork();
        protected UserSession CurrentUser
        {
            get { return Session[Constants.SESSION.USER] as UserSession; }
        }

        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            string cultureName;

            // Attempt to read the culture cookie from Request
            HttpCookie cultureCookie = Request.Cookies["_culture"];
            if (cultureCookie != null)
                cultureName = cultureCookie.Value;
            else
            {
                /*cultureName = Request.UserLanguages != null && Request.UserLanguages.Length > 0 ?
                        Request.UserLanguages[0] :  // obtain it from HTTP header AcceptLanguages
                        null;*/
                cultureName = "vi-vn";//default vietnamese
                cultureCookie = new HttpCookie("_culture");
                cultureCookie.Value = cultureName.ToLower();
                cultureCookie.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cultureCookie);
            }

            // Validate culture name
            //cultureName = CultureHelper.GetImplementedCulture(cultureName); // This is safe

            // Modify current thread's cultures
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            DateTimeFormatInfo info = DateTimeFormatInfo.GetInstance(CultureInfo.GetCultureInfo("en-US"));
            Thread.CurrentThread.CurrentCulture.DateTimeFormat = info;

            //Load Authenticated user if it is null.
            if (User != null && User.Identity.IsAuthenticated)
            {
                if (Session[Constants.SESSION.USER] == null)
                {
                    //IUserService userService = new UserService(new UserRepository());
                    IUserService userService = new UserService(uow);

                    User user = userService.GetUserByUserName(User.Identity.Name);
                    if (user == null)
                    {
                        Session.RemoveAll();
                        FormsAuthentication.SignOut();
                        Response.Redirect(Url.RouteUrl(new { controller = "account", action = "login", area = "admin" }));
                    }
                    UserSession userSession = new UserSession(user);
                    Session[Constants.SESSION.USER] = userSession;
                }
            }
            return base.BeginExecuteCore(callback, state);
        }

        protected override void OnResultExecuting(ResultExecutingContext filterContext)
        {

        }
        protected override void Dispose(bool disposing)
        {
            //uow.Dispose();
            //base.Dispose(disposing);
        }
    }//end of class
}