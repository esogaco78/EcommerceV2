using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceV2.Models;

// NOTE: By default you don't need to pass anything into View()
// and the framework will infer the correct view to call if the 
// view name is the same as the controller ActionResult name. 
// However, for testing purposes you need to explicitly pass the
// name of the view in order for the test method to have access the
// ViewResult object (if you so desire to test for that).

namespace EcommerceV2.Controllers
{
    public class HomeController : Controller
    {
        // Display the home page
        public ActionResult Index()
        {
            return View("Index");
        }

        // Display the computer product page
        public ActionResult Computers()
        {
            ViewBag.Message = "Computers here.";

            return View("Computers");
        }

        // Display the video game product page
        public ActionResult VideoGames()
        {
            ViewBag.Message = "Video Games here.";

            return View("VideoGames");
        }

        public ActionResult Televisions()
        {
            ViewBag.Message = "Televisions here.";

            return View("Televisions");
        }

        public ActionResult Login()
        {
            return View("Login");
        }

    }
}