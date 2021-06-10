using System;
using System.Collections.Generic;
using System.Linq;
using MySite.Models;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MySite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            BaristaContext db = new BaristaContext();
            var article = db.Articles.
                Include(c => c.Chapter);
            return View(article.ToList());
        }
    }
}