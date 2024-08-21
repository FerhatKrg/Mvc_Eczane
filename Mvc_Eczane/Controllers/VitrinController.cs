using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Eczane.Models.Entity;
using PagedList;
using PagedList.Mvc;
namespace Mvc_Eczane.Controllers
{
    [AllowAnonymous]
    public class VitrinController : Controller
    {
        // GET: Vitrin
        DbEczaneOtomasyonEntities   db = new DbEczaneOtomasyonEntities();

        public ActionResult Index(int sayfa = 1)
        {
            var ilac = db.TBLILAC.ToList().ToPagedList(sayfa, 5);
            return View(ilac);
        }

      
        public ActionResult Ekle(TBLILETISIM p)
        {
            db.TBLILETISIM.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}