using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Models.Classes;

namespace TatilSeyahat.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context db=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var item=db.Blogs.ToList();
            return View(item);
        }
        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            db.Blogs.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }
        public ActionResult DeleteBlog(int id) 
        { 
            var item=db.Blogs.Find(id);
            db.Blogs.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var item=db.Blogs.Find(id);
            return View(item);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            var item = db.Blogs.Find(blog.BlogId);
            item.Title = blog.Title;
            item.Description = blog.Description;
            item.BlogImage= blog.BlogImage;
            item.Date = blog.Date;
            db.SaveChanges();
            return RedirectToAction("Index");   
        }
       

    }
}