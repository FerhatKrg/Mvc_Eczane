using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Eczane.Models.Entity;
namespace Mvc_Eczane.Controllers
{
    [Authorize]
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        DbEczaneOtomasyonEntities db = new DbEczaneOtomasyonEntities();
        public ActionResult Index()
        {
            ViewBag.dgr1 = db.TBLECZANE.Count();
            ViewBag.dgr2 = db.TBLILAC.Count();
            ViewBag.dgr3 = db.TBLILAC.Select(x=>x.STOK).Sum();
            ViewBag.dgr4 = db.TBLSATIS.Select(x=>x.SATISADET).Sum();
            ViewBag.dgr5 = db.TBLILETISIM.Where(x => x.Durum == true).Count();
            ViewBag.dgr6 = db.TBLILETISIM.Where(x => x.Durum == false).Count();
            ViewBag.dgr7 = db.TBLPERSONEL.Count();
            ViewBag.dgr8 = db.TBLKASA.Select(x=>x.Para).Sum();
           
           
            return View();
        }
    }
}