using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Models.Classes;
namespace TatilSeyahat.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        Context db=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var item = db.Comments.ToList();
            return View(item);
        }
        public ActionResult DeleteComment(int id)
        {
            var item = db.Comments.Find(id);
            db.Comments.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditComment(int id)
        {
            var item = db.Comments.Find(id);
            return View(item);
        }

        [HttpPost]
        public ActionResult EditComment(Comment comment) 
        {
            var item = db.Comments.Find(comment.CommentId);
            item.UserName = comment.UserName;
            item.UserEmail = comment.UserEmail;
            item.Comments = comment.Comments;
            db.SaveChanges();
            return RedirectToAction("Index");
        
        }
    }
}