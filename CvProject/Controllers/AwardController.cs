using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProject.Models.Entity;
using CvProject.Repositories;

namespace CvProject.Controllers
{
    public class AwardController : Controller
    {
        GenericRepository<Award> repo = new GenericRepository<Award>(); 
        // GET: Award
        public ActionResult Index()
        {
            var award = repo.List();
            return View(award);
        }

        [HttpGet]
        public ActionResult BringAward(int id)
        {
            var awardvalue = repo.Find(x => x.Id == id);
            ViewBag.bring = id;
            return View(awardvalue);
        }

        [HttpPost]
        public ActionResult BringAward(Award p)
        {
            var awardvalue = repo.Find(x => x.Id == p.Id);
            awardvalue.AwardName = p.AwardName;
            awardvalue.Date = p.Date;
            repo.TUpdate(awardvalue);
            return RedirectToAction("Index", "Award");
        }

        [HttpGet]
        public ActionResult AddAward()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAward(Award p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index", "Award");
        }

        public ActionResult DeleteAward(int id)
        {
            var award = repo.Find(x => x.Id == id);
            repo.TDelete(award);
            return RedirectToAction("Index", "Award");
        }
    }
}