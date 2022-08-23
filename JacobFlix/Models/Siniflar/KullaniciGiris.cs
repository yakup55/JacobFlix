using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JacobFlix.Models.Siniflar
{
    public class KullaniciGiris
    {
        [Key]
        public int İd { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
       
    }
}