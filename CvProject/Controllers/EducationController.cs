using CvProject.Models.Entity;
using CvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvProject.Controllers
{
    [Authorize]
    public class EducationController : Controller
    {
        EducationRepository repo = new EducationRepository();
        // GET: Education
        public ActionResult Index()
        {
            var education = repo.List();
            return View(education);
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEducation(Education p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index", "Education");
        }

        public ActionResult DeleteEducation(int id)
        {
            var education = repo.Find(x => x.Id == id);
            repo.TDelete(education);
            return RedirectToAction("Index", "Education");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var values = repo.Find(x => x.Id == id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateEducation(Education p)
        {
            var education = repo.Find(x => x.Id == p.Id);
            education.Title = p.Title;
            education.Subtitle = p.Subtitle;
            education.Department = p.Department;
            education.GPA = p.GPA;
            education.Date = p.Date;
            repo.TUpdate(education);
            return RedirectToAction("Index", "Education");
        }

    }
}