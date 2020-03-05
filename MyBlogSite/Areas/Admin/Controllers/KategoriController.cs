using MyBlogSite.Models;
using System;
using System.Collections.Generic;
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
            return RedirectToAction("KategoriEkle");
        }
    }
}