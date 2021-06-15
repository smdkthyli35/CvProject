using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProject.Models.Entity;
using CvProject.Repositories;

namespace CvProject.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        DbCvEntities1 db = new DbCvEntities1();
        AboutRepository repo = new AboutRepository();
        // GET: Default
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }

        public PartialViewResult About()
        {
            var degerler = db.About.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult SocialMedia()
        {
            var degerler = db.SocialMedia.Where(x=>x.State == true).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Experience()
        {
            var degerler = db.Experience.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Education()
        {
            var degerler = db.Education.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Skill()
        {
            var degerler = db.Skill.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Interest()
        {
            var degerler = db.Interest.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Award()
        {
            var degerler = db.Award.ToList();
            return PartialView(degerler);
        }

        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Contact(Contact p)
        {
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Contact.Add(p);
            db.SaveChanges();
            return PartialView();
        }
    }
}