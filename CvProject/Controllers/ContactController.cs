using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProject.Models.Entity;
using CvProject.Repositories;

namespace CvProject.Controllers
{
    public class ContactController : Controller
    {
        GenericRepository<Contact> repo = new GenericRepository<Contact>();

        // GET: Contact
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }
    }
}