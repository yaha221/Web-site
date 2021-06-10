using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySite.Models;
using System.Net;
using System.Data.Entity;

namespace MySite.Controllers
{
    public class ArticleController : Controller
    {

        [HttpGet]
        [Route("Статья/{articleName}")]
        public ActionResult ReadArticle(string articleName)
        {
            BaristaContext db = new BaristaContext();
            if (articleName == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.
                Include(c=>c.Chapter).
                Include(x=>x.Author).
                FirstOrDefault(a=>a.NameArticle == articleName);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }
    }
}