using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RehberlikUygulaması.Models.entities
{
    public class kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string CepTelefon { get; set; }
        public int SehirId { get; set; }
        public Sehir Sehir { get; set; }
    }
}