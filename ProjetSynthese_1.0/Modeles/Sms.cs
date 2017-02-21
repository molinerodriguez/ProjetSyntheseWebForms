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
                         "src=" + "4389283281" + "&" + "dst=" + "5149983281" + "&" + "msg=" + msg + "&" + "username=" + "molinerodriguez@yahoo.fr" + "&" + "password=" + "mefwc";
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                result = client.DownloadString(url);
            }
            return result;
        }
    }
}