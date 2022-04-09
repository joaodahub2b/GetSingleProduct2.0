using RestSharp;
using System;

namespace GetSingleProduct.Services
{
    public class BlingService
    {
        internal String GetSingleProduct(string sku, string apikey)
        {
            var client = new RestClient($"https://bling.com.br/Api/v2/produto/{sku}/xml?apikey={apikey}");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
