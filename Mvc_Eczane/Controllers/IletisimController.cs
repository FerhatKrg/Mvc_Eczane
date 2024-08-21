using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Eczane.Models.Entity;
namespace Mvc_Eczane.Controllers
{
    [Authorize]
    public class IletisimController : Controller
    {
        // GET: Iletisim
        DbEczaneOtomasyonEntities db = new DbEczaneOtomasyonEntities();
        public ActionResult Index()
        {
            var dgr=db.TBLILETISIM.Where(x=>x.Durum==false).ToList();
            return View(dgr);
            
        }

        public ActionResult Oku(int id)
        {
            var msj = db.TBLILETISIM.Find(id);
            msj.Durum=true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}