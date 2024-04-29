using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services.Description;
using TatilSeyahat.Models.Classes;


namespace TatilSeyahat.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context db=new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var item=db.Admins.FirstOrDefault(x=>x.Name==ad.Name && x.Password==ad.Password);
            if (item!=null)
            {
                FormsAuthentication.SetAuthCookie(item.Name, false);
                Session["Name"]=item.Name;
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
                
            }

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}