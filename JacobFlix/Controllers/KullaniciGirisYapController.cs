using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using JacobFlix.Models.Siniflar;
namespace JacobFlix.Controllers
{
    public class KullaniciGirisYapController : Controller
    {
        // GET: KullaniciGirisYap
        Context c = new Context();
        //[Authorize]
        [HttpGet]
        public ActionResult Login2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login2(KullaniciGiris kul)
        {

            var bilgiler = c.KullaniciGirisis.FirstOrDefault(x =>x.Sifre == kul.Sifre &&x.Email==kul.Email);
            if (bilgiler != null)
            {

                FormsAuthentication.SetAuthCookie(bilgiler.KullanıcıAdı, false);
                return RedirectToAction("Index", "Flimİnceleme");
                //return RedirectToAction("Login2", "KullaniciGiris");
            }
            else
            {
                return View();
            }

        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login2", "KullaniciGirisYap");
        }

      
    }
}