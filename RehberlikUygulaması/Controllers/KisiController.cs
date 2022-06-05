using RehberlikUygulaması.Models.Context;
using RehberlikUygulaması.Models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RehberlikUygulaması.Controllers
{
    public class KisiController : Controller
    {
        RehberlikContext db = new RehberlikContext();
        // GET: Kisi
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(kisi kisi)
        {
            db.kisiler.Add(kisi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}