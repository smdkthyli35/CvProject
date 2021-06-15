using CvProject.Models.Entity;
using CvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvProject.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceRepository repo = new ExperienceRepository();
        // GET: Experience
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(Experience p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index", "Experience");
        }

        public ActionResult DeleteExperience(int id)
        {
            Experience t = repo.Find(x => x.Id == id);
            repo.TDelete(t);
            return RedirectToAction("Index", "Experience");
        }

        [HttpGet]
        public ActionResult BringExperience(int id)
        {
            Experience t = repo.Find(x => x.Id == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult BringExperience(Experience p)
        {
            Experience t = repo.Find(x => x.Id == p.Id);
            t.Title = p.Title;
            t.Subtitle = p.Subtitle;
            t.Date = p.Date;
            t.Details = p.Details;
            repo.TUpdate(t);
            return RedirectToAction("Index", "Experience");
        }
    }
}