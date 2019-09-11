using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.Infrastructure;
using SimpleBlog.Areas.Admin.ViewModels;
using SimpleBlog.Models;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [SelectedTab("Users")]
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return View(new UsersIndex { Users = UserRepository.Retrieve() });
        }

        [HttpGet]
        public ActionResult New()
        {
            return View(new UsersNew());
        }

        [HttpPost]
        public ActionResult New(UsersNew form)
        {
            if (UserRepository.UserExists(form.Username))
                ModelState.AddModelError("Username", "Username must be unique!");

            if(!ModelState.IsValid)
            {
                return View(form);
            }

            var user = new User
            {
                Username =form.Username,
                Email = form.Email
            };
            user.SetPassword(form.Password);
            UserRepository.Save(user);

            return RedirectToAction("Index");
        }

    } // class
}