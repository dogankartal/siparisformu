using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pasta_siparis.Content.Helper
{
    public class SiparisBildirim
    {
        public string SendEmail(string v)
        {
            return "E-mail gönderildi";
        }

        public string SendSMS()
        {
            return "Sms gönderildi";
        }

        public string SavePage()
        {
            return "Sipariş sayfasına kaydedildi";
        }

    }
}