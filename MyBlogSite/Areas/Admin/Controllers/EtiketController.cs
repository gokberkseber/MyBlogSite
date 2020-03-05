using MyBlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogSite.Areas.Admin.Controllers
{
    public class EtiketController : Controller
    {
        BlogContext db = new BlogContext(); 
        // GET: Admin/Etiket
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult EtiketEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EtiketEkle(Etiket model)
        {
            Etiket etk = new Etiket();
            etk.EtiketAdi = model.EtiketAdi;
            db.Etiket.Add(etk);
            db.SaveChanges();
            return RedirectToAction("EtiketListele");
        }


        public ActionResult EtiketGuncelle(int ? id)
        {
            var etk = db.Etiket.SingleOrDefault(e => e.EtiketID == id);
            return View(etk);
        }

        [HttpPost]
        public ActionResult EtiketGuncelle(Etiket model)
        {
            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("EtiketListele");
            return View();
        }


        public ActionResult EtiketSil(int id)
        {
            Etiket etiketSil = db.Etiket.Find(id);
            db.Etiket.Remove(etiketSil);
            db.SaveChanges();
            return RedirectToAction("EtiketListele");
            
        }




        public ActionResult EtiketListele()
        {
            List<Etiket> etkList = db.Etiket.ToList();
            return View(etkList);
        }
    }
}