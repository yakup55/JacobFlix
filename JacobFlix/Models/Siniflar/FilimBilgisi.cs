using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JacobFlix.Models.Siniflar
{
    public class FilimBilgisi
    {
        [Key]
        public int FilimID { get; set; }

        public string Ad { get; set; }

        public string Resim { get; set; }

        public string Konu { get; set; }


        public string İzle { get; set; }

        public string Fragman { get; set; }
        public double ElestirmenDerece { get; set; }

        public string Tur { get; set; }
        public double Sure { get; set; }
        public string Yonetmen { get; set; }
        public string CikisTarihi { get; set; }

        public int TurID { get; set; }
        public virtual Tur tur  { get; set; }

        public ICollection<Yorumlar> yorumlars { get; set; }
    }
}