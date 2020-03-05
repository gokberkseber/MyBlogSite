using MyBlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogSite.Controllers
{
    public class KategoriController : Controller
    {
        BlogContext db = new BlogContext();
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult KategoriWidget()
        {
            return PartialView(db.Kategori.ToList());
        }
    }
}