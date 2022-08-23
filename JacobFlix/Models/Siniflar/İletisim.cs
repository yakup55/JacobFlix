using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JacobFlix.Models.Siniflar
{
    public class İletisim
    {
        [Key]
        public int İD { get; set; }
        public string AdSoyad { get; set; }
        public string Eposta { get; set; }
        [StringLength(11)]
        public string Telefon { get; set; }
        public string Mesaj { get; set; }
    }
}