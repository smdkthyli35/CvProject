using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProject.Models.Entity;
using CvProject.Repositories;

namespace CvProject.Controllers
{
    public class SkillController : Controller
    {
        SkillRepository repo = new SkillRepository();
        // GET: Skill
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(Skill p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index", "Skill");
        }

        public ActionResult DeleteSkill(int id)
        {
            Skill p = repo.Find(x => x.Id == id);
            repo.TDelete(p);
            return RedirectToAction("Index", "Skill");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            Skill t = repo.Find(x => x.Id == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult UpdateSkill(Skill p)
        {
            Skill t = repo.Find(x => x.Id == p.Id);
            t.SkillName = p.SkillName;
            t.Rating = p.Rating;
            repo.TUpdate(t);
            return RedirectToAction("Index", "Skill");
        }
    }
}