using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JacobFlix.Models.Siniflar
{
    public class AdminGirisi
    {
        [Key]
        public int İD { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Sifre { get; set; }
    }
}