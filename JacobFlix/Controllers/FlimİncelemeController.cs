using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mvc;
using JacobFlix.Models.Siniflar;
using PagedList;
using PagedList.Mvc;
namespace JacobFlix.Controllers
{
    public class FlimİncelemeController : Controller
    {
        // GET: Flimİnceleme
        Context c = new Context();
        FlimYorum fy = new FlimYorum();
        Yorumlar y = new Yorumlar();
        // [Authorize]
        public ActionResult Index( int p = 1)
        {
            //   fy.Deger1 = c.degerlendirmes.ToList();

           var deger = c.FilimBilgisis.OrderByDescending(x => x.FilimID).ToPagedList(p,8);
            return View(deger);
        }
        public ActionResult Detay(int id)
        {

            fy.Deger3 = c.FilimBilgisis.Where(x => x.FilimID == id).ToList();
            fy.Deger2 = c.Yorumlars.Where(x=>x.FilimID==id && x.Durum==true).ToList();
            return View(fy);
        }   
        [AcceptVerbs(HttpVerbs.Get)]
        [Authorize]
        public PartialViewResult YorumYap(int id)
        {
           
            ViewBag.deger = id;
            return PartialView();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            Yorumlar yorumlar = new Yorumlar();
            yorumlar.Durum = false;
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();   
        }
        public PartialViewResult YeniFilimList()
        {
            var list = c.FilimBilgisis.OrderByDescending(x => x.FilimID).Take(12).ToList();
            return PartialView(list);
        }
        public PartialViewResult YeniTurList(int id)
        {
            var list = c.Turs.OrderByDescending(x => x.TurID).ToList();
            return PartialView(list);
        }

        public ActionResult TurList(int id,int p=1)
        {
            var list = c.FilimBilgisis.Where(x=>x.TurID==id).ToList().ToPagedList(p,8);
            return View(list);
        }
    }
}