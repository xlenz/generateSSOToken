using System;
using System.IO;
using System.Text;
using System.Xml;

namespace generateSSOToken.SSO
{
    public class SsoToken : IDisposable
    {
        private const string Endpoint = "idp/services/Trust";
        private const string ContentType = "application/xml";
        private string _ssoTokenBase64;
        private string _ssoTokenDecoded;
        private XmlNode _ssoTokenXmlNode;
        private string _ssoTokenXmlString;
        private WebReq webReq;

        public SsoToken(string oeHost, string username, string password, string oePort = "8085", bool isHttps = false)
        {
            _disposed = false;
            webReq = new WebReq();
            if (string.IsNullOrEmpty(oeHost) || string.IsNullOrEmpty(oePort) || string.IsNullOrEmpty(oePort) || password == null)
            {
                throw new Exception(string.Format("Following params are required:\n" +
                                                  "oeHost='{0}'\n" +
                                                  "oePort='{1}'\n" +
                                                  "username='{2}'\n" +
                                                  "password='{3}'\n", oeHost, oePort, username, password));
            }
            GetToken(oeHost, oePort, username, password, isHttps);
        }

        public string GetBase64()
        {
            return _ssoTokenBase64;
        }

        public XmlNode GetXmlNode()
        {
            return _ssoTokenXmlNode;
        }

        public string GetDecoded()
        {
            return _ssoTokenDecoded;
        }

        public string GetXmlString()
        {
            return _ssoTokenXmlString;
        }


        private void GetToken(string oeHost, string oePort, string username, string password, bool isHttps)
        {
            string requestData;

            using (Stream stream = GetType().Assembly.GetManifestResourceStream("generateSSOToken.SSO.ssoTokenRequest.xml"))
            {
                using (var sr = new StreamReader(stream))
                {
                    requestData = sr.ReadToEnd();
                }
            }

            requestData = requestData.Replace("{{Username}}", username).Replace("{{Password}}", password);
            string url = string.Format("http{0}://{1}:{2}/{3}", isHttps ? "s" : string.Empty, oeHost, oePort, Endpoint);

            var response = webReq.Make(url, contentType: ContentType, data: requestData);

            if (string.IsNullOrEmpty(response))
            {
                throw new Exception("There were no response from SBM at all.");
            }

            //convert value to XML
            var xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.LoadXml(response);
            }
            catch (Exception)
            {
                throw new Exception("Not proper XML response recieved from SBM: \n" + response);
            }

            //we need to add namespace in order to be able to look for saml: nodes
            var nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsmgr.AddNamespace("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
            nsmgr.AddNamespace("saml", "urn:oasis:names:tc:SAML:1.0:assertion");
            //get node with required for SSO
            var fault = xmlDoc.SelectSingleNode("//soapenv:Fault", nsmgr);
            if (fault != null)
            {
                var explanation = fault.SelectSingleNode("//Explanation");
                if (explanation == null)
                {
                    throw new Exception("Failed to obtain SSO Token, no explanation has been provided in response.");
                }
                throw new Exception(explanation.InnerText);
            }

            var tokenShort = xmlDoc.SelectSingleNode("//saml:Assertion", nsmgr);
            _ssoTokenXmlNode = xmlDoc.SelectSingleNode("//soapenv:Envelope", nsmgr);
            if (tokenShort == null || _ssoTokenXmlNode == null)
            {
                throw new Exception("SSO: Failed to find nodes in response '//saml:Assertion' or '//soapenv:Envelope'");
            }

            _ssoTokenXmlString = _ssoTokenXmlNode.OuterXml;
            _ssoTokenDecoded = tokenShort.OuterXml;
            var bytes = Encoding.UTF8.GetBytes(_ssoTokenDecoded);
            _ssoTokenBase64 = Convert.ToBase64String(bytes);
        }

        bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                webReq.Dispose();
            }

            _disposed = true;
        }
    }
}