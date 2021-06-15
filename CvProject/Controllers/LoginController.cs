using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProject.Models.Entity;
using System.Web.Security;

namespace CvProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            DbCvEntities1 db = new DbCvEntities1();
            var values = db.Admin.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["Username"] = values.Username.ToString();
                return RedirectToAction("Index", "About");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}