using RestSharp;
using System;
using Newtonsoft.Json;
using static GetSingleProduct.Models.MercadoLivreModels.MercadoLivreModel;

namespace GetSingleProduct.Services
{
    public class MercadoLivreService
    {
        internal String GetSingleProduct(string mlb)
        {
            var client = new RestClient($"https://api.mercadolibre.com/items/{mlb}");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(response.ToString());
            return response.Content;
        }
    }
}
