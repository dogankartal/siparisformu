using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pasta_siparis.Models;
using pasta_siparis.Content.Helper;
using System.Text;

namespace pasta_siparis.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Siparis siparismodel = null;
            return View(siparismodel);
        }

        [HttpPost]
        public ActionResult Index(Siparis GelenSiparis)
        {
            SiparisBildirim bildirim = new SiparisBildirim();

            if (GelenSiparis != null)
            {
                //bildirim.SendEmail("Metin");
            }
           return Content("<script src='https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.0/sweetalert.min.js'></script> <body> <script language='javascript' type='text/javascript'>swal('Başarılı!','En kısa sürede yanıt vereceğim.','success').then(() => { window.location.href = '/Default' }); </script></body>");
        }

        //[HttpGet]
        //public JsonResult AddOrder(string adsoyad,string telefon)
        //{
        //    string newId = adsoyad;
        //    return Json(newId, JsonRequestBehavior.AllowGet);
        //}


        [HttpPost]
        public ActionResult AddOrder(Siparis GelenSiparis)
        {
            SiparisBildirim bildirim = new SiparisBildirim();
            string rtr = "";

            if (GelenSiparis.SiparisTuru == "pasta")
            {
               // rtr = "Success!";
            }
            else if (GelenSiparis.SiparisTuru == "kurabiye")
            {
                try
                {
                    var body = new StringBuilder();
                    body.AppendLine("Yeni bir " + GelenSiparis.SiparisTuru.ToUpper() + " siparişin var!");
                    body.AppendLine("Ad Soyad: " + GelenSiparis.AdSoyad);
                    body.AppendLine("Telefon: " + GelenSiparis.TelefonNumarasi);
                    body.AppendLine("Sipariş Türü: " + GelenSiparis.SiparisTuru);
                    body.AppendLine("Not: " + GelenSiparis.Not);
                    body.AppendLine("  DETAYLAR  ");
                    body.AppendLine("HamurSecimi: " + GelenSiparis.kurabiye.HamurSecimi);
                    body.AppendLine("SuslemeSecimi: " + GelenSiparis.kurabiye.SuslemeSecimi);
                    body.AppendLine("Kurabiye_Adet: " + GelenSiparis.kurabiye.Kurabiye_Adet);
                    bildirim.MailFormSend(body.ToString());

                    var smsBody = new StringBuilder();
                    smsBody.AppendLine("Yeni bir " + GelenSiparis.SiparisTuru.ToUpper() + " siparişin var!");
                    smsBody.AppendLine(" AD: " + GelenSiparis.AdSoyad);
                    smsBody.AppendLine(" TEL: " + GelenSiparis.TelefonNumarasi);

                    bildirim.SendSMS(smsBody.ToString());

                    rtr = "Success!";
                }
                catch (Exception)
                {
                    rtr = "Fail!";
                }

                
            }
            else if (GelenSiparis.SiparisTuru =="cupcake")
            {
                //cupcake siparişiyle ilgili işlemler
            }



            // do something with data, probably create db record
            return Json(rtr);
        }

      
    }
}