using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Eczane.Models.Entity;
namespace Mvc_Eczane.Controllers
{
    [Authorize]
    public class IslemlerController : Controller
    {
        // GET: Islemler
        DbEczaneOtomasyonEntities db=new DbEczaneOtomasyonEntities();
        public ActionResult Index()
        {
            var satislar=db.TBLSATIS.ToList();
            return View(satislar);
        }
    }
}