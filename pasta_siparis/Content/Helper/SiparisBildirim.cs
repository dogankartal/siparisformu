using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using pasta_siparis.Content.Helper;

namespace pasta_siparis.Content.Helper
{
    public class SiparisBildirim
    {
        public bool MailFormSend(string body)
        {
            bool rtr = false;
            var fromAddress = new MailAddress("smtpmail@doabil.com");
            var toAddress = new MailAddress("dogankartal52@gmail.com");
            var toBccAddress = "doabil@yandex.com";
            const string subject = "MagicMiks - Yeni Form Gönderildi!";
            using (var smtp = new SmtpClient
            {

                Host = "mail.doabil.com",
                Port = 587,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "kkU-P2uuZ?CB")
            })
            {
                if (body != null)
                {

                    using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                    {
                        message.Bcc.Add(new MailAddress(toBccAddress));
                        smtp.Send(message);
                        rtr = true;
                    }
                }

                else
                    rtr = false;

            }

            return rtr;
        }

        public bool SendSMS(string Mesaj)
        {
            SmsSend Sms = new SmsSend();
            bool rtr = false;
            try
            {
                Sms.SingleSmsSend(Mesaj, "905511702481");
                Sms.SingleSmsSend(Mesaj, "905059448394");
                rtr = true;
            }
            catch (Exception)
            {
                rtr = false;             
            }

            return rtr;
        }

        public string SavePage()
        {
            return "Sipariş sayfasına kaydedildi";
        }

    }
}