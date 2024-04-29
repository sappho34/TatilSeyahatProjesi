using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Models.Classes;

namespace TatilSeyahat.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context db=new Context();   
        public ActionResult Index()
        {
            var items=db.Abouts.ToList();
            return View(items);
        }
    }
}