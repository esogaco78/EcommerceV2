using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceV2.Models;

namespace EcommerceV2.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                var db = new DataAccess();
                db.InsertUser(user.Email, user.Password);
                return Redirect("/");
            }

            return View("Register");
        }
    }
}