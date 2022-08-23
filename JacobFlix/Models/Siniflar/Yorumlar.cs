using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JacobFlix.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int İD { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public bool Durum { get; set; }

       

        public int DegerlendirmeId { get; set; }
        public virtual Degerlendirme Degerlendirme { get; set; }

        public int FilimID { get; set; }
        public virtual FilimBilgisi FilimBilgisi { get; set; }
    }
}