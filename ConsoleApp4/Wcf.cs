using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class WCFServer
    {
        public WCFServer(string uri)
        {
            var host = new WebServiceHost(typeof(WebService), new Uri(uri));
            try
            {
                var ep = host.AddServiceEndpoint(typeof(IWebService), CreateBinding(), "");
                host.Open();
                Console.WriteLine("WCF: OK");
            }
            catch (CommunicationException cex)
            {
                Console.WriteLine("An exception occurred: {0}", cex.Message);
                host.Abort();
            }
        }
        private WebHttpBinding CreateBinding()
        {
            var timeOut = new TimeSpan(0, 0, 10);
            return new WebHttpBinding()
            {
                OpenTimeout = timeOut,
                CloseTimeout = timeOut,
                ReceiveTimeout = timeOut,
                SendTimeout = timeOut
            };
        }
    }

}
