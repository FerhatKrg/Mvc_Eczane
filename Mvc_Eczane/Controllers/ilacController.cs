using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Eczane.Models.Entity;
namespace Mvc_Eczane.Controllers
{        [Authorize]
    public class ilacController : Controller
    {
        // GET: ilac

        DbEczaneOtomasyonEntities db = new DbEczaneOtomasyonEntities();
       
        public ActionResult Index(string p)
        {
            var deger = from i in db.TBLILAC select i;
            
            if (!string.IsNullOrEmpty(p))
            {
                deger = db.TBLILAC.Where(x => x.ILACADI.Contains(p));
                
            }
            
            return View(deger.ToList());
        }

        [HttpGet]
        public ActionResult IlacEkle()
        {
            List<SelectListItem> deger = (from i in db.TBLKATEGORI.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.AD,
                                              Value = i.ID.ToString()
                                          }).ToList() ;
            ViewBag.dgr = deger;
            return View();
        }

        [HttpPost]
        public ActionResult IlacEkle(TBLILAC p)
        {
            var ktgr = db.TBLKATEGORI.Where(x => x.ID == p.TBLKATEGORI.ID).FirstOrDefault();
            p.TBLKATEGORI=ktgr;
            db.TBLILAC.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult IlacGetir(int id)
        {
            List<SelectListItem> ktgr = (from i in db.TBLKATEGORI.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.AD,
                                              Value = i.ID.ToString()
                                          }).ToList();
            ViewBag.dgr1= ktgr;
            var deger = db.TBLILAC.Find(id);
            return View("IlacGetir",deger);
        }
        public ActionResult Guncelle(TBLILAC p)
        {
            var ktgr = db.TBLKATEGORI.Where(x => x.ID == p.TBLKATEGORI.ID).FirstOrDefault();
            var ilaclar = db.TBLILAC.Find(p.ID);
            ilaclar.TBLKATEGORI = ktgr;
            ilaclar.ILACADI = p.ILACADI;
            ilaclar.STOK=p.STOK;
            ilaclar.FIYAT = p.FIYAT;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult IlacSil(int id)
        {
            var ilaclar = db.TBLILAC.Find(id);
            db.TBLILAC.Remove(ilaclar);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}