using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JacobFlix.Models.Siniflar;
namespace JacobFlix.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        
        Context c = new Context();
     
        public ActionResult Index()
        {
            var degerler=c.FilimBilgisis.ToList();
         
            return View(degerler);
        }
        [HttpGet]
        public PartialViewResult İletisimYap()
        {
            var degerler = c.FilimBilgisis.ToList();

            return PartialView(degerler);
        }
        [HttpPost]
        public PartialViewResult İletisimYap(İletisim i)
        {
            c.iletisims.Add(i);
            c.SaveChanges();
            return PartialView();
        }

        //[HttpGet]
        //public PartialViewResult YorumYap()
        //{
        //    return PartialView();
        //}
        //[HttpPost]
        //public PartialViewResult YorumYap(Yorumlar y)
        //{
        //    c.Yorumlars.Add(y);
        //    c.SaveChanges();
        //    return PartialView();
        //}
        public ActionResult FlimDetay()
        {
            var degerler = c.FilimBilgisis.ToList();
            return View(degerler);
        }

    }
}