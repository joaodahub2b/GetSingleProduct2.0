using RestSharp;
using System;

namespace GetSingleProduct.Services
{
    public class DafitiService
    {
        internal string GetSingleProduct(int tenant, string userId, string sku, string apiKey)
        {
            var client = new RestClient($"https://eb-api.plataformahub.com.br/RestServiceImpl.svc/AuthSellerCenter/{tenant}");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "text/plain");
            var body = @$"https://api.sellercenter.com.br/?Action=GetProducts&Filter=all&Format=XML&UserID={userId}&Version=1.0&Offset=0&Search={sku}HUB_SC_PARAM{apiKey}HUB_SC_PARAMGET";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
