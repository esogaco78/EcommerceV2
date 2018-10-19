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
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            var db = new DataAccess();
            

            return View("Register");
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            // Check to make sure the entered email is unique
            //ViewBag.EmailIsValid = true;
            //var db = new DataAccess();
            //var emails = db.SelectAllUserEmails();
            //foreach (var email in emails)
            //{
            //    if (email == user.Email)
            //    {
            //        ViewBag.EmailIsValid = false;
            //        return View("Register");
            //    }
            //}

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