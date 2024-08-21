using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Mvc_Eczane.Models.Entity;
namespace Mvc_Eczane.Controllers
{
    [Authorize]
    public class StokController : Controller
    {
        // GET: Stok
        DbEczaneOtomasyonEntities db = new DbEczaneOtomasyonEntities();
        [HttpGet]
        public ActionResult StokEkle()
        {                     
            return View();
        }
        [HttpPost]
        public ActionResult StokEkle(int stok=0,int id=0,int fiyat=0)
        {
            var ilac = db.TBLILAC.Find(id);
            var kasa_para=db.TBLKASA.Find(1);
            if ((stok * fiyat) < kasa_para.Para)
            {
                ilac.STOK += stok;
                kasa_para.Para -= (stok * fiyat);
                db.SaveChanges();
                return View();
            }
            else
            {
                ViewBag.msj = "Kasada Yeterli Para Yok";
                return View();
            }
            
        }
    }
}