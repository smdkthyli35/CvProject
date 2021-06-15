using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProject.Repositories;
using CvProject.Models.Entity;

namespace CvProject.Controllers
{
    public class AboutController : Controller
    {
        AboutRepository repo = new AboutRepository();
        // GET: About

        [HttpGet]
        public ActionResult Index()
        {
            var aboutvalues = repo.List();
            return View(aboutvalues);
        }

        [HttpPost]
        public ActionResult Index(About p)
        {
            var aboutvalues = repo.Find(x => x.Id == 1);
            aboutvalues.Name = p.Name;
            aboutvalues.Surname = p.Surname;
            aboutvalues.Address = p.Address;
            aboutvalues.Phone = p.Phone;
            aboutvalues.Mail = p.Mail;
            aboutvalues.Explanation = p.Explanation;
            aboutvalues.Image = p.Image;
            repo.TUpdate(aboutvalues);
            return RedirectToAction("Index", "About");
        }
    }
}