using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.ViewModels;
using Service.Interfaces;
using Service.Serivices;

namespace Web.Controllers
{
    public class AccountController : BaseController
    {
        #region Fields

        private readonly IUserService _userService;

        public AccountController()
        {
            this._userService = new UserService(uow);
        }
        #endregion

        #region Actions
        // GET: Login
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.GetUser(loginViewModel.UserName, loginViewModel.Password);
                if (user != null)
                {
                    return Content("Ok baby");
                }
                
            }
            return View();
        }
        #endregion
    }
}