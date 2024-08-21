using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Eczane.Models.Entity;
namespace Mvc_Eczane.Controllers
{
    [AllowAnonymous]
    public class KayitolController : Controller
    {
        // GET: Kayitol
        DbEczaneOtomasyonEntities db = new DbEczaneOtomasyonEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TBLPERSONEL P)
        {
            var dgr = db.TBLPERSONEL.FirstOrDefault(x => x.MAIL == P.MAIL);
            if (dgr == null)
            {
                db.TBLPERSONEL.Add(P);
                db.SaveChanges();
                return View(P);
            }
            else
            {
                ViewBag.hata = "Bu mail sistemde önceden kullanılmış";
                return View(P);
            }
            
        }
    }
}