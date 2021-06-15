using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProject.Repositories;
using CvProject.Models.Entity;

namespace CvProject.Controllers
{
    public class SocialMediaController : Controller
    {
        GenericRepository<SocialMedia> repo = new GenericRepository<SocialMedia>();
        // GET: SocialMedia
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMedia(SocialMedia p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index", "SocialMedia");
        }

        [HttpGet]
        public ActionResult UpdateMedia(int id)
        {
            var social = repo.Find(x => x.Id == id);
            return View(social);
        }

        [HttpPost]
        public ActionResult UpdateMedia(SocialMedia p)
        {
            var social = repo.Find(x => x.Id == p.Id);
            social.Name = p.Name;
            social.State = true;
            social.Link = p.Link;
            social.Icon = p.Icon;
            repo.TUpdate(social);
            return RedirectToAction("Index", "SocialMedia");
        }

        public ActionResult DeleteMedia(int id)
        {
            var media = repo.Find(x => x.Id == id);
            media.State = false;
            repo.TUpdate(media);
            return RedirectToAction("Index", "SocialMedia");
        }

    }
}