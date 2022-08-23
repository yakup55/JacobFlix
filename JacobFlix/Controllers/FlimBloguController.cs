using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JacobFlix.Models.Siniflar;
namespace JacobFlix.Controllers
{
    public class FlimBloguController : Controller
    {
        // GET: FlimBlogu
        Context c = new Context();
   
        public ActionResult Index()
        {
            var degerler = c.FilimBilgisis.ToList();
            return View(degerler);
        }
     
    }
}