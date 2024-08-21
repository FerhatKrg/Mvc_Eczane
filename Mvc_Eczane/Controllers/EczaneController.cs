using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Eczane.Models.Entity;
namespace Mvc_Eczane.Controllers
{
    [Authorize]
    public class EczaneController : Controller
    {
        // GET: Eczane
        DbEczaneOtomasyonEntities db = new DbEczaneOtomasyonEntities();
        public ActionResult Index()
        {
            var ecz = db.TBLECZANE.ToList();
            return View(ecz);
        }

        [HttpGet]
        public ActionResult YeniEcz()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniEcz(TBLECZANE p)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            db.TBLECZANE.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EczSil(int id)
        {
            var dgr = db.TBLECZANE.Find(id);
            db.TBLECZANE.Remove(dgr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EczGetir(int id)
        {
            var dgr = db.TBLECZANE.Find(id);
            return View("EczGetir",dgr);
        }
        public ActionResult Guncelle(TBLECZANE p)
        {
            var dgr = db.TBLECZANE.Find(p.ID);
            dgr.AD = p.AD;
            dgr.SEHIR = p.SEHIR;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}