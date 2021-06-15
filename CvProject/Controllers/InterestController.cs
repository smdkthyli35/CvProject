using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProject.Repositories;
using CvProject.Models.Entity;

namespace CvProject.Controllers
{
    public class InterestController : Controller
    {
        InterestRepository repo = new InterestRepository();
        // GET: Interest
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddInterest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddInterest(Interest p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index", "Interest");
        }

        public ActionResult DeleteInterest(int id)
        {
            var values = repo.Find(x => x.Id == id);
            repo.TDelete(values);
            return RedirectToAction("Index", "Interest");
        }

        [HttpGet]
        public ActionResult UpdateInterest(int id)
        {
            var values = repo.Find(x => x.Id == id);
            return View(values);
        }

        public ActionResult UpdateInterest(Interest p)
        {
            var values = repo.Find(x => x.Id == p.Id);
            values.InterestName = p.InterestName;
            repo.TUpdate(values);
            return RedirectToAction("Index", "Interest");
        }

    }
}