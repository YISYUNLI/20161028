using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id,string name,string sex)
        {
            ViewBag.ID = id;
            return View();
            //string show= "<h1>hello "+ name+" you are " +sex+"</h1>"+id;
            //return Content(show);
        }
    }
}