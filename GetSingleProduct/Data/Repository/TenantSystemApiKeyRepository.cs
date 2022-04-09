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

        public string GetKey(int idTenant, string value) => hubContext.TenantSystemApiKeys.FirstOrDefault(
                x => x.IdTenant == idTenant &&
                    x.IdApiKey.Contains(value))
                        .Value;
    }
}
