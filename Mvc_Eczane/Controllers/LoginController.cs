using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Mvc_Eczane.Models.Entity;
namespace Mvc_Eczane.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult GirisYap()
        {
            return View();
        }
        DbEczaneOtomasyonEntities db=new DbEczaneOtomasyonEntities();
        [HttpPost]
        public ActionResult GirisYap(TBLPERSONEL p)
        {
            var bilgi=db.TBLPERSONEL.FirstOrDefault(x=>x.MAIL==p.MAIL && x.SIFRE==p.SIFRE);
            if ((bilgi != null))
            {
                FormsAuthentication.SetAuthCookie(bilgi.MAIL, false);
                Session["Mail"] = bilgi.MAIL.ToString();

                return RedirectToAction("Index", "AnaSayfa");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("GirisYap", "Login");
        }
    }
}