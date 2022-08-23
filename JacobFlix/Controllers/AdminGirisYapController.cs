using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using JacobFlix.Models.Siniflar;
namespace JacobFlix.Controllers
{
    public class AdminGirisYapController : Controller
    {
        // GET: AdminGirisYap
        Context c = new Context();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AdminGirisi ad)
        {
            var bilgiler = c.Admin.FirstOrDefault(x => x.KullanıcıAdı == ad.KullanıcıAdı && x.Sifre == ad.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullanıcıAdı, false);
                Session["KullanıcıAdı"] = bilgiler.KullanıcıAdı.ToString();
                return RedirectToAction("Index", "AdminGiris");
            }
            else
            {
                return View();
            }

        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "AdminGirisYap");
        }
    }
}