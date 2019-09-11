using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View(new AuthLogin());
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View(form);

            // Authenticate user in order to use ASP.NET MVC authorization library
            FormsAuthentication.SetAuthCookie(form.Username, false);

            return Redirect(returnUrl ?? Url.RouteUrl("Home"));
        }

    } // class
}

//if(form.Username != "nelson")
//{
//    ModelState.AddModelError("Username", "Username or password isn't 20% cooler.");
//    return View(form);
//}