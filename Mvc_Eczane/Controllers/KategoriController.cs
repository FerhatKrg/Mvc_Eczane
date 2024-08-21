using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Eczane.Models.Entity;
namespace Mvc_Eczane.Controllers
{
    [Authorize]
    public class KategoriController : Controller
    {
        // GET: Kategori
        DbEczaneOtomasyonEntities db = new DbEczaneOtomasyonEntities();
        public ActionResult Index()
        {
            var deger = db.TBLKATEGORI.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(TBLKATEGORI p)
        {
            db.TBLKATEGORI.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var dgr=db.TBLKATEGORI.Find(id);
            return View("KategoriGetir", dgr);
        }

        public ActionResult Guncelle(TBLKATEGORI p)
        {
            var dgr = db.TBLKATEGORI.Find(p.ID);
            dgr.AD = p.AD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}