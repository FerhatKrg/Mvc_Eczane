using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Mvc_Eczane.Models.Entity;
namespace Mvc_Eczane.Controllers
{
    [Authorize]
    public class AnaSayfaController : Controller
    {
        DbEczaneOtomasyonEntities db = new DbEczaneOtomasyonEntities();
        // GET: AnaSayfa
        [Authorize]
        public ActionResult Index()
        {
            var kullanici_mail = (string)Session["Mail"];
            var prsnl=db.TBLPERSONEL.FirstOrDefault(x=>x.MAIL==kullanici_mail);
            return View(prsnl);
        }
    }
}