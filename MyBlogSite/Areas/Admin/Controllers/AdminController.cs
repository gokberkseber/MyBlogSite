using MyBlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogSite.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        BlogContext db = new BlogContext();
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }

      
    }
}