using GetSingleProduct.Data.Dtos;
using GetSingleProduct.Data.Repository;
using RestSharp;
using System;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace GetSingleProduct.Services
{
    public class MagentoService
    {
        private const string urlMagento = "URL_V1_MAGENTO";
        private const string userMagento = "USER_MAGENTO";
        private const string apiKeyMagento = "API_KEY_MAGENTO";
        private readonly ITenantSystemApiKeyRepository repository;

        public MagentoService(ITenantSystemApiKeyRepository repository)
        {
            this.repository = repository;
        }
        internal void GetSingleProduct(int tenant, string sku)
        {
            GetSession(tenant);/*
            var client = new RestClient("https://maisdecasa.com.br/index.php/api/index/index/");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/xml");
            request.AddHeader("Cookie", "PHPSESSID=lvvvrf103ecmvsai3nsiep59p6; external_no_cache=1");
            var body = @"<SOAP-ENV:Envelope xmlns:SOAP-ENV=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:SOAP-ENC=""http://schemas.xmlsoap.org/soap/encoding/"" xmlns:ns1=""urn:Magento"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" SOAP-ENV:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">" + "\n" +
            @"   <SOAP-ENV:Body>" + "\n" +
            @"      <ns1:call>" + "\n" +
            @"         <sessionId xsi:type=""xsd:string"">0e1c45172e25531234fd71ac07ee7450</sessionId>" + "\n" +
            @"         <resourcePath xsi:type=""xsd:string"">catalog_product.info</resourcePath>" + "\n" +
            @"         <args xsi:type=""xsd:string"">ARMD253130</args>" + "\n" +
            @"      </ns1:call>" + "\n" +
            @"   </SOAP-ENV:Body>" + "\n" +
            @"</SOAP-ENV:Envelope>";
            request.AddParameter("application/xml", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            //return response;
            Console.WriteLine(response.Content.ToString());*/
        }

        private string GetSession(int idTenant)
        {
            var erpKey = repository.GetKey(idTenant, apiKeyMagento);
            var erpUser = repository.GetKey(idTenant, userMagento);
            var erpUrl = repository.GetKey(idTenant, urlMagento);
            
            var client = new RestClient($"{erpUrl}");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "text/plain");
            var body = @$"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:urn=""urn:Magento"">
            <soapenv:Header/>
            <soapenv:Body>
            <urn:login soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
            <username xsi:type=""xsd:string"">{erpUser}</username>
            <apiKey xsi:type=""xsd:string"">{erpKey}</apiKey>
            </urn:login>
            </soapenv:Body>
            </soapenv:Envelope>";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            var response = client.Execute(request);

            

            XDocument xmlDocument = XDocument.Parse(response.Content);
            XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
            var envelope = (Envelope)serializer.Deserialize(xmlDocument.CreateReader());
            var result = envelope.Body.loginResponse.loginReturn;

            Console.WriteLine(response.Content);
            return null;
        }
    }
}
