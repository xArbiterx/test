using System.Text;

namespace LabTools
{
    public class SoapHelper
    {
        string WsdlUrl { get; set; }

        public SoapHelper(string wsdlUrl)
        {
            WsdlUrl = wsdlUrl;
        }

        public string SOAPAction(string sendXml)
        {
            HttpClient httpClient = new HttpClient();
            var httpContent = new StringContent(sendXml, Encoding.UTF8, "text/xml");
            httpContent.Headers.Add("SOAPAction", WsdlUrl);
            var ResponseXmlString = httpClient.PostAsync(WsdlUrl, httpContent).Result.Content.ReadAsStringAsync().Result;
            return ResponseXmlString;
        }
    }
}