using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JacobFlix.Models.Siniflar;
namespace JacobFlix.Controllers
{
    public class KullaniciGirisController : Controller
    {
        // GET: KullaniciGiris
        Context c = new Context();
        public ActionResult Index()
        {
            
         
            return View();
        }
        [HttpGet]
        public ActionResult KayitOl()
        {
            return View();

        }
        [HttpPost]
        public ActionResult KayitOl(KullaniciGiris k1)
        {
            c.KullaniciGirisis.Add(k1);
            c.SaveChanges();
            return View();

        }
    }
}