using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Eczane.Models.Entity;
namespace Mvc_Eczane.Controllers
{   
    [Authorize]
    public class PersonelController : Controller
    {
       
        // GET: Personel
        DbEczaneOtomasyonEntities db = new DbEczaneOtomasyonEntities();
        
        public ActionResult Index()
        {
            var prsnl=db.TBLPERSONEL.ToList();
            return View(prsnl);
        }
        public ActionResult PersonelSil(int id)
        {
            var prsnl=db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(prsnl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PersonelGetir(int id)
        {
            var prsnl = db.TBLPERSONEL.Find(id);
            return View("PersonelGetir",prsnl);
        }
        public ActionResult Guncelle(TBLPERSONEL p)
        {
            if (!ModelState.IsValid)
            {
                return View("PersonelGetir");
            }
            var prsnl = db.TBLPERSONEL.Find(p.ID);
            prsnl.AD = p.AD;
            prsnl.SOYAD=p.SOYAD;
            prsnl.TELEFON=p.TELEFON;
            prsnl.MAIL = p.MAIL;
            prsnl.SIFRE = p.SIFRE;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}