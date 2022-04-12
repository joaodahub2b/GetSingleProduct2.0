using GetSingleProduct.Data.Repository;
using GetSingleProduct.Models.SoftvarModels;
using RestSharp;
using System;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GetSingleProduct.Services
{
    public class SoftvarService
    {

        ITenantSystemApiKeyRepository repository;

        public SoftvarService(ITenantSystemApiKeyRepository repository)
        {
            this.repository = repository;
        }

        internal void GetSingleProduct(int idTenant, string sku)
        {
            //repository.GetKey(idTenant);
        }

        private SoftvarModel GetConfigFile(int idTenant)
        {
            var client = new RestClient($"http://k8s.hub2b.com.br:30015/api/cache/SoftvarConfigFile{idTenant}");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            XDocument xmlDocument = XDocument.Parse(response.Content);
            XmlSerializer serializer = new XmlSerializer(typeof(SoftvarModel));
            return (SoftvarModel)serializer.Deserialize(xmlDocument.CreateReader());
            
        }
    }
}
