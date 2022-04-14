using System;
using System.Linq;

namespace GetSingleProduct.Data.Repository
{
    public class TenantSystemApiKeyRepository : ITenantSystemApiKeyRepository
    {
        private readonly HubContext hubContext;

        public TenantSystemApiKeyRepository(HubContext hubContext)
        {
            this.hubContext = hubContext;
        }

        public string GetKey(int idTenant, string value)
        {
            //Implementar a solução para a exceção que este código abaixo está retornando quando enviamos um tenant que não existe
            try
            {
                var key = hubContext.TenantSystemApiKeys.FirstOrDefault(
                x => x.IdTenant == idTenant &&
                x.IdApiKey.Contains(value))
                    .Value;

                return key;
            }
            catch (NullReferenceException)
            {
                throw;
            }
        } 
    }
}
