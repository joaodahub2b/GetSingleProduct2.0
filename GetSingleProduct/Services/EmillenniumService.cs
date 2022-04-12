using GetSingleProduct.Models.EmillenniumModels;
using RestSharp;
using System;
using System.Text.Json;

namespace GetSingleProduct.Services
{
    public class EmillenniumService
    {
        public string GetSingleProduct(int idTenant)
        {
            var session = GetSession(idTenant);
            var client = new RestClient("http://millennium.selia.com.br:6017/api/millenium_eco/produtos/listavitrine?vitrine=201&lista_preco=true");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("wts-session", $"{session}");
            var body = @"";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var teste = response.Content;
            return teste;
        }

        private string GetSession(int idTenant)
        {
            var client = new RestClient("http://k8s.hub2b.com.br:32408/Token/4175");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var jsonString = response.Content.ToString();
            EmillenniumModel? emillenniumModel = JsonSerializer.Deserialize<EmillenniumModel>(jsonString);
            //WeatherForecast? weatherForecast =
            //    JsonSerializer.Deserialize<WeatherForecast>(jsonString);
            return emillenniumModel.session;
        }
    }
}
