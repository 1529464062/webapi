using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class ExplainController : Controller
    {
        public ActionResult Major()
        {
            ViewData["list"] = "[[123,234],[345,456]]";
            return View();
        }
    }
}
