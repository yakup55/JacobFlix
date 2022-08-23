using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace JacobFlix.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<AdminGirisi> Admin { get; set; }
        public DbSet<Degerlendirme> Degerlendirmes { get; set; }
        public DbSet<İletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<KullaniciGirisi> KullaniciKayits { get; set; }
        public DbSet<KullaniciGiris> KullaniciGirisis { get; set; }
        public DbSet<FilimBilgisi> FilimBilgisis { get; set; }
        public DbSet<Tur> Turs { get; set; }
    }
}