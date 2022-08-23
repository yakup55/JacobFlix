using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JacobFlix.Models.Siniflar
{
    public class Tur
    {
        public int TurID { get; set; }
        public string TurName { get; set; }
        public bool Durum { get; set; }

        public ICollection<FilimBilgisi>filimBilgisis { get; set; }
    }
}