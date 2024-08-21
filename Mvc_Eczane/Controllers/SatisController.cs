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
    public class SatisController : Controller
    {
        // GET: Satis
        DbEczaneOtomasyonEntities db = new DbEczaneOtomasyonEntities();
        [HttpGet]   
        public ActionResult Index()
        {
            var userMail =(string) Session["Mail"];
            var user = db.TBLPERSONEL.FirstOrDefault(x => x.MAIL == userMail);
            ViewBag.user = user.ID;    
            return View();
        }

        [HttpPost]
        public ActionResult Index(TBLSATIS p)
        {
            var para = db.TBLKASA.Find(1);
            var ilac = db.TBLILAC.Find(p.ILAC);
            if (ilac.STOK < p.SATISADET)
            {
                ViewBag.msj1 = "Yeterli Stok Yok";
                return View(p);
            }
            else
            {
                ilac.STOK -= p.SATISADET;
                para.Para += (p.SATISADET*ilac.FIYAT);
                db.TBLSATIS.Add(p);
                db.SaveChanges();
                return View(p);
            }
            
        }
    }
}