using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetSynthese_1._0.Modeles
{
    public class Sms
    {
        public static string SendSms(string msg)
        {
            string result = null;
            string url = "http://smsc.vianett.no/v3/send.ashx?"+
                         "src=" + "0014389283281" + "&" + "dst=" + 
                         "0015149983281" + "&" + "msg=" + msg + "&" + 
                         "username=" + "12345@yahoo.fr" + "&" + 
                         "password=" + "12345";
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                result = client.DownloadString(url);
            }
            return result;
        }
    }
}