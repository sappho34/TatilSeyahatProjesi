using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Models.Classes;

    namespace TatilSeyahat.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context db=new Context();   
        public ActionResult Index()
        {
            var item = db.Blogs.Take(7).ToList();
            return View(item);
        }

        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult EnPopuler()
        {
            var item=db.Blogs.Take(8).ToList();
            return PartialView(item);
        }
        public PartialViewResult EnBegendigim()
        {
            var item = db.Blogs.OrderByDescending(x=>x.BlogId).Take(3).ToList();
            return PartialView(item);
        }
        public PartialViewResult Partial3()
        {
            var item = db.Blogs.OrderByDescending(x => x.BlogId).Take(2).ToList();
            return PartialView(item);
        }
        public PartialViewResult Partial4()
        {
            var item = db.Blogs.Where(x => x.BlogId==1).ToList();
            return PartialView(item);
        }
        public ActionResult EnBegendigim2()
        {
            var x = db.Blogs.Take(3).ToList();
            return PartialView(x);
        }
     
    }
}