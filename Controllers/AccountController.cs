using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySite.Models;
using System.Web.Security;

namespace MySite.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(Account model)
        {
            if (ModelState.IsValid)
            {
                Account account = null;
                using (BaristaContext db = new BaristaContext())
                {
                    account = db.Accounts.FirstOrDefault(u => u.Login == model.Login && u.Password == model.Password);
                }
                if (account!=null)
                {
                    FormsAuthentication.SetAuthCookie(model.Login, true);
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ModelState.AddModelError("","Пользователя с таким логином и паролем не существует!");
                }
            }
            return View(model);
        }
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(Account model)
        {
            if (ModelState.IsValid)
            {
                Account account = null;
                if (account == null)
                {
                    using (BaristaContext db = new BaristaContext())
                    {
                        db.Accounts.Add(new Account { Email = model.Email, Login = model.Login, Password = model.Password, RoleAccount=model.RoleAccount });
                        db.SaveChanges();
                        account = db.Accounts.Where(u => u.Login == model.Login && u.Password == model.Password).FirstOrDefault();
                    }
                    if (account!=null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Login,true);
                        model.RoleAccount = "user";
                        return RedirectToAction("Index","Home");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Пользователь с таким логином или почтой уже существует!");
            }
            return View(model);
        }
    }
}