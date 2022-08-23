using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JacobFlix.Models.Siniflar
{
    public class Degerlendirme
    {
        [Key]
        public int İD { get; set; }
       
         public string FlimAd { get; set; }

        public string FlimResim { get; set; }

        public string FlimKonu { get; set; }


        public string Flimİzle { get; set; }
        
        public string FlimFragman { get; set; }
        public double ElestirmenDerece { get; set; }
      
        public string Tur { get; set; }
        public double Sure { get; set; }
        public string Yonetmen { get; set; }
        public string CikisTarihi { get; set; }



        public ICollection<Yorumlar> yorumlars { get; set; }
    }


}
