using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TatilSeyahat.Models.Classes;


namespace TatilSeyahat.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context db=new Context();
        public ActionResult Index()
        {
            var item = db.Blogs.ToList();
            return View(item);
        }
        public ActionResult Details(int id) 
        { 
            var item=db.Blogs.Where(x=>x.BlogId==id).ToList();
            return View(item);
        }
        [HttpGet]
        public PartialViewResult EditComment(int id)
        {
            ViewBag.item =id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult EditComment(Comment c)
        {
            db.Comments.Add(c);
            db.SaveChanges();
            return PartialView();
        }
    }
}