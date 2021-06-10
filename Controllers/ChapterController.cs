using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using MySite.Models;
using System.Data.Entity;

namespace MySite.Controllers
{[RoutePrefix ("Глава")]
    public class ChapterController : Controller
    {
        // GET: Chapter
        BaristaContext db = new BaristaContext();
        [HttpGet]
        [Route("{сhapterName}")]
        public ActionResult GetNameChapter(string сhapterName)
        {
            string Name = сhapterName;
            if (Name==null)
            {
                return HttpNotFound();
            }
            Chapter chapter = db.Chapters.Include(c => c.Articles).FirstOrDefault(c => c.NameChapter == Name);
            if (chapter == null)
            {
                HttpNotFound();
            }
            return View(chapter);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}