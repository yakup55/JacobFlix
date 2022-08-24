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
        public double FilimDerecesi { get; set; }

        public string FilimTur { get; set; }
        public double FilimSure { get; set; }
        public string FilimYonetmen { get; set; }
        public string FilimCikisTarihi { get; set; }

        public int TurID { get; set; }
        public virtual Tur tur  { get; set; }

        public ICollection<Yorumlar> yorumlars { get; set; }
    }
}