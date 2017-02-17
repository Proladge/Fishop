using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebSite2.UTIL;

namespace MyWebSite2.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetHtml()
        {
            return new HtmlResult("<h2>Привет мир!</h2>");
        }
    }
}