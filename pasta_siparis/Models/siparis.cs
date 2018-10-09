﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pasta_siparis.Models
{
    public class Siparis
    {
        public string AdSoyad { get; set; }
        public string TelefonNumarasi { get; set; }
        public Kurabiye_siparisi kurabiye { get; set; }
        public Paasta_siparisi Pasta { get; set; }
        public Cupcake_siparisi Cupcake { get; set; }
        public string Not { get; set; }

    }

    public class Kurabiye_siparisi
    {
        
        public string SiparisTuru { get; set; }
        public string HamurSecimi { get; set; }
        public string SuslemeSecimi { get; set; }
        public int Kurabiye_Adet { get; set; }

    }

    public class Paasta_siparisi
    {
      
        public string SiparisTuru { get; set; }
        public string HamurSecimi { get; set; }
        public string SuslemeSecimi { get; set; }
        public int Adet { get; set; }

    }

    public class Cupcake_siparisi
    {
        public string SiparisTuru { get; set; }
        public string HamurSecimi { get; set; }
        public string SuslemeSecimi { get; set; }
        public int Adet { get; set; }
    }
}