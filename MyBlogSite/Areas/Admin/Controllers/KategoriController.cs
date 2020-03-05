using MyBlogSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogSite.Areas.Admin.Controllers
{
    public class KategoriController : Controller
    {
        BlogContext db = new BlogContext();
        // GET: Admin/Ekle
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Kategori model)
        {
            Kategori kat = new Kategori();
            kat.KategoriAdi = model.KategoriAdi;
            db.Kategori.Add(kat);
            db.SaveChanges();
            return RedirectToAction("KatListele");
        }

        public ActionResult KatListele()
        {
            List<Kategori> katList = db.Kategori.ToList();
            return View(katList);
        }

        public ActionResult KatSil(int id)
        {
            Kategori silKat = db.Kategori.Find(id);
            db.Kategori.Remove(silKat);
            db.SaveChanges();
            return RedirectToAction("KatListele");
        }

        public ActionResult KatGuncelle(int ? id)
        {
            var kat = db.Kategori.SingleOrDefault(k => k.KategoriID==id);
            return View(kat);
        }

        [HttpPost]
        public ActionResult KatGuncelle(Kategori model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("KatListele");
        }
    }
}