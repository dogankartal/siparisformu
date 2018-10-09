using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pasta_siparis.Models
{
    public class siparis
    {
        public string AdSoyad { get; set; }
        public string TelefonNumarasi { get; set; }
        public kurabiye_siparisi kurabiye { get; set; }
        public pasta_siparisi pasta { get; set; }
        public cupcake_siparisi cupcake { get; set; }
        public string Not { get; set; }

    }

    public class kurabiye_siparisi
    {
        
        public string SiparisTuru { get; set; }
        public string HamurSecimi { get; set; }
        public string SuslemeSecimi { get; set; }
        public int Adet { get; set; }

    }

    public class pasta_siparisi
    {
      
        public string SiparisTuru { get; set; }
        public string HamurSecimi { get; set; }
        public string SuslemeSecimi { get; set; }
        public int Adet { get; set; }

    }

    public class cupcake_siparisi
    {
        public string SiparisTuru { get; set; }
        public string HamurSecimi { get; set; }
        public string SuslemeSecimi { get; set; }
        public int Adet { get; set; }
    }
}