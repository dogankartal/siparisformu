using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace pasta_siparis.Content.Helper
{
    public class SmsSend
    {

        string xmlData = "<? xml version = '1.0' encoding='UTF-8'?><mainbody><header><company>NETGSM</company><usercode>2129092506</usercode><password>R48WFR5V</password><startdate></startdate><stopdate></stopdate><type>1:n</type><msgheader>02129092506</msgheader></header><body><msg><![CDATA[Test Mesaji]]></msg><no>905319404959</no></body></mainbody>";

        string PostAddress = "http://api.netgsm.com.tr/xmlbulkhttppost.asp";

        public bool SingleSmsSend(string Message,string Telefon)
        {
            bool rtr = false;

            //xmlData = "<? xml version = '1.0' encoding='UTF-8'?><mainbody><header><company>NETGSM</company><usercode>2129092506</usercode><password>R48WFR5V</password><startdate></startdate><stopdate></stopdate><type>1:n</type><msgheader>02129092506</msgheader></header><body><msg><![CDATA["+Message+"]]></msg><no>905319404959</no></body></mainbody>";

            string ss = "";
            ss += "<?xml version='1.0' encoding='UTF-8'?>";
            ss += "<mainbody>";
            ss += "<header>";
            ss += "<company>NETGSM</company>";
            ss += "<usercode>2129092506</usercode>";
            ss += "<password>R48WFR5V</password>";
            ss += "<startdate></startdate>";
            ss += "<stopdate></stopdate>";
            ss += "<type>1:n</type>";
            ss += "<msgheader>02129092506</msgheader>";
            ss += "</header>";
            ss += "<body>";
            ss += "<msg><![CDATA[" + StringCut(Message) + "]]></msg>";
            ss += "<no>"+Telefon+"</no>";
            ss += "</body>";
            ss += "</mainbody>";

            try
            {
                string MessageResponse = XMLPOST(PostAddress, ss);
                if (MessageResponse.Contains("-1"))
                {
                    rtr = false;
                }
                else
                {
                    rtr = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return rtr;
        }

        private string XMLPOST(string PostAddress, string xmlData)
        {
            try
            {
                WebClient wUpload = new WebClient();
                HttpWebRequest request = WebRequest.Create(PostAddress) as HttpWebRequest;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                Byte[] bPostArray = Encoding.UTF8.GetBytes(xmlData);
                Byte[] bResponse = wUpload.UploadData(PostAddress, "POST", bPostArray);
                Char[] sReturnChars = Encoding.UTF8.GetChars(bResponse);
                string sWebPage = new string(sReturnChars);
                return sWebPage;
            }

            catch
            {
                return "-1";
            }
        }

        public string StringCut(string str)
        {
            if (str.Length > 150)
            {
                str = str.Substring(0, 150) + "...";
            }

            return str;
        }
    }
}