using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pasta_siparis.Models;
using pasta_siparis.Content.Helper;

namespace pasta_siparis.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(siparis GelenSiparis)
        {
           SiparisBildirim bildirim = new SiparisBildirim();

            if (GelenSiparis != null)
            {
                bildirim.SendEmail("Metin");
            }
           return Content("<script src='https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.0/sweetalert.min.js'></script> <body> <script language='javascript' type='text/javascript'>swal('Başarılı!','En kısa sürede yanıt vereceğim.','success').then(() => { window.location.href = '/Default' }); </script></body>");
        }
    }
}