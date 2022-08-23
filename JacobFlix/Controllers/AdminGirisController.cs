using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JacobFlix.Models.Siniflar;
namespace JacobFlix.Controllers
{
    public class AdminGirisController : Controller
    {
        // GET: AdminGiris
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.FilimBilgisis.ToList();
           ViewBag.filim = c.FilimBilgisis.Count();
           ViewBag.yorum = c.Yorumlars.Count();
            ViewBag.kullanıcı=c.KullaniciGirisis.Count();
            ViewBag.iletisim=c.iletisims.Count();
            ViewBag.yorum = c.Yorumlars.Count(x=>x.Durum==false);
            return View(degerler);
        }
        public ActionResult text()
        {
           
            return View();
        }
        [HttpGet]
        public ActionResult YeniFlim()
        {
            List<SelectListItem> valuefilim = (from x in c.Turs.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.TurName,
                                                   Value = x.TurID.ToString()
                                               }).ToList();
            ViewBag.vlf = valuefilim;
            return View();
        }
        [HttpPost]
        public ActionResult YeniFlim(FilimBilgisi flm)
        {
            c.FilimBilgisis.Add(flm);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FlimListesi()
        {
            var degerler = c.FilimBilgisis.ToList();
            return View(degerler);
        }
        public ActionResult FlimSil(int id)
        {
            var degerler = c.FilimBilgisis.Find(id);
            c.FilimBilgisis.Remove(degerler);
            c.SaveChanges();
            return RedirectToAction("FlimListesi");
        }
        public ActionResult FlimGetir(int id)
        {
            var degerler = c.FilimBilgisis.Find(id);
            return View("FlimGetir",degerler);
        }
        [HttpGet]
        public ActionResult FlimGuncelle()
        {
            return View();
        }
        [HttpPost]
            public ActionResult FlimGuncelle(FilimBilgisi flm1)
        {
            var degerler = c.FilimBilgisis.Find(flm1.FilimID);
            degerler.Ad = flm1.Ad;
            degerler.Konu = flm1.Konu;
            degerler.Resim = flm1.Resim;
            degerler.ElestirmenDerece = flm1.ElestirmenDerece;
            degerler.Yonetmen = flm1.Yonetmen;
            degerler.CikisTarihi = flm1.CikisTarihi;
            degerler.Tur = flm1.Tur;
            degerler.Sure = flm1.Sure;
            degerler.İzle = flm1.İzle;
            degerler.Fragman = flm1.Fragman;
            c.SaveChanges();
            return RedirectToAction("FlimListesi");
        }
        //Admin Profili
        public ActionResult AdminProfile()
        {
            var admin = c.Admin.ToList();
            return View(admin);
        }
        public ActionResult AdminGuncelle(AdminGirisi p)
        {
            var admin = c.Admin.Find(p.İD);
            admin.KullanıcıAdı = p.KullanıcıAdı;
            admin.Sifre = p.Sifre;
            c.SaveChanges();
            return RedirectToAction("AdminProfile");
        }
        public ActionResult AdminGetir(int id)
        {
            var adming = c.Admin.Find(id);
            return View("AdminGetir", adming);
        }

        //Türler
        public ActionResult TurListesi()
        {
            var tur=c.Turs.ToList();
            return View(tur);
        }
        [HttpGet]
        public ActionResult YeniTur()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniTur(Tur flm)
        {
            flm.Durum = true;
            c.Turs.Add(flm);
            c.SaveChanges();
            return RedirectToAction("TurListesi");
        }
        public ActionResult TurGetir(int id)
        {
            var degerler = c.Turs.Find(id);
            return View("TurGetir", degerler);
        }
       
        public ActionResult TurSil(int id)
        {
            var yorum = c.Turs.Find(id);
            c.Turs.Remove(yorum);
            c.SaveChanges();
            return RedirectToAction("TurListesi");
        }
        public ActionResult TurGuncelle(Tur tur)
        {
            var turs = c.Turs.Find(tur.TurID);
            turs.TurName = tur.TurName;
            turs.Durum = tur.Durum;
            c.SaveChanges();
            return RedirectToAction("TurListesi");
        }
        public ActionResult TurAktif(int id)
        {
            Tur tur = new Tur();
            var status = c.Turs.Find(id);
            status.Durum = true;
            tur.Durum = status.Durum;
            c.SaveChanges();

            return RedirectToAction("TurListesi");
        }
        public ActionResult TurPasif(int id)
        {
            Tur tur = new Tur();
            var status = c.Turs.Find(id);
            status.Durum = false;
            tur.Durum = status.Durum;
            c.SaveChanges();

            return RedirectToAction("TurListesi");
        }
        //[HttpGet]
        //public ActionResult YeniDegerlendirme()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult YeniDegerlendirme(FilimBilgisi dgr)
        //{
        //    c.FilimBilgisis.Add(dgr);
        //    c.SaveChanges();
        //    return RedirectToAction("DegerlendirmeListesi");
        //}
        //public ActionResult DegerlendirmeListesi()
        //{
        //    var degerler = c.FilimBilgisis.ToList();
        //    return View(degerler);
        //}
        //public ActionResult DegerlendirmeSil(int id)
        //{
        //    var degerler = c.FilimBilgisis.Find(id);
        //    c.FilimBilgisis.Remove(degerler);
        //    c.SaveChanges();
        //    return RedirectToAction("DegerlendirmeListesi");
        //}
        //public ActionResult DegerlendirmeGetir(int id)
        //{
        //    var degerler = c.FilimBilgisis.Find(id);
        //    return View("DegerlendirmeGetir", degerler);
        //}
        //public ActionResult DegerlendirmeGuncelle(FilimBilgisi dgr1)
        //{
        //    var degerler = c.FilimBilgisis.Find(dgr1.FilimID);
        //    degerler.ElestirmenDerece = dgr1.ElestirmenDerece;
        //   degerler.Yonetmen=dgr1.Yonetmen; 
        //    degerler.CikisTarihi=dgr1.CikisTarihi;
        //    degerler.Tur = dgr1.Tur;
        //    degerler.Sure = dgr1.Sure;
        //    degerler.İzle= dgr1.İzle;
        //    degerler.Fragman = dgr1.Fragman;
        //    c.SaveChanges();
        //    return RedirectToAction("DegerlendirmeListesi");
        //}

        //iletişim paneli

        public ActionResult İletisimGetir(int  id)
        {
            var degerler = c.iletisims.Find(id);
            return View("İletisimGetir", degerler);
        }
        public ActionResult İletisimListesi()
        {
            var degerler = c.iletisims.ToList();
            return View(degerler);
        }

        public ActionResult İletisimSil(int id)
        {
            var degerler = c.iletisims.Find(id);
            c.iletisims.Remove(degerler);
            c.SaveChanges();
            return RedirectToAction("İletisimListesi");
        }

        public ActionResult İletisimGuncelle(İletisim i)
        {
            var degerler = c.iletisims.Find(i.İD);
            degerler.AdSoyad = i.AdSoyad;
            degerler.Eposta = i.Eposta;
            degerler.Telefon = i.Telefon;
            degerler.Mesaj = i.Mesaj;
            return RedirectToAction("İletisimListesi");
        }

        //YORUM PANELİ
        public ActionResult YorumGetir(int id)
        {
            var degerler = c.Yorumlars.Find(id);
            return View("YorumGetir", degerler);
        }
        public ActionResult YorumListesi()
        {
            var yorum = c.Yorumlars.ToList();
            return View(yorum);
        }
        public ActionResult YorumSil(int id)
        {
            var yorum = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(yorum);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yorum = c.Yorumlars.Find(y.İD);
            yorum.KullanıcıAdı = y.KullanıcıAdı;
            yorum.Mail = y.Mail;
           yorum.FilimID = y.FilimID;   
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumAktif(int id)
        {
            Yorumlar yorumlar = new Yorumlar();
            var status = c.Yorumlars.Find(id);
            status.Durum = true;
            yorumlar.Durum = status.Durum;
            c.SaveChanges();

            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumPasif(int id)
        {
            Yorumlar yorumlar = new Yorumlar();
            var status = c.Yorumlars.Find(id);
            status.Durum = false;
            yorumlar.Durum = status.Durum;
            c.SaveChanges();

            return RedirectToAction("YorumListesi");
        }
        //KULLANICI BİLGİLERİ SAYFASI

        public ActionResult KullaniciListesi()
        {
            var degerler = c.KullaniciGirisis.ToList();
            return View(degerler);
        }
        public ActionResult KullaniciSil(int id)
        {
            var degerler = c.KullaniciGirisis.Find(id);
            c.KullaniciGirisis.Remove(degerler);
            c.SaveChanges();
            return RedirectToAction("KullaniciListesi");
        }
        

    }
}