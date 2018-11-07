using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceV2.Models;
using System.Net;

namespace EcommerceV2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Computers()
        {
            var db = new DataAccess();
            List<Product> computerProducts = db.SelectAllComputerProducts();
            ViewBag.ComputerProducts = computerProducts;
            
            return View();
            
        }

        public ActionResult VideoGames()
        {
            var db = new DataAccess();
            List<Product> videoGameProducts = db.SelectAllVideoGames();
            ViewBag.VideoGameProducts = videoGameProducts;

            return View();
        }

        public ActionResult TVs ()
        {
            var db = new DataAccess();
            List<Product> tvProducts = db.SelectAllTVs();
            ViewBag.TVProducts = tvProducts;

            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var db = new DataAccess();
            Product product = db.SelectProductById((int)id);
            if (product == null)
            {
                return HttpNotFound();
            }

            // Round the price from 4 to 2 decemal points.
            product.Price = decimal.Round(product.Price, 2, MidpointRounding.AwayFromZero);

            ViewBag.Product = product;

            return View();
        }

    }
}