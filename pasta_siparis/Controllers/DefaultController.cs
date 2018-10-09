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
           return View();
        }
    }
}