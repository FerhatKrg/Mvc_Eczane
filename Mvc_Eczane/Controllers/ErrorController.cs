using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Eczane.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Sayfa400()
        {
            Response.StatusCode = 400;
            Response.TrySkipIisCustomErrors=true;   
            return View();
        }
        public ActionResult Sayfa403()
        {
            Response.StatusCode = 403;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Sayfa404()
        {
            Response.StatusCode = 400;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
    }
}