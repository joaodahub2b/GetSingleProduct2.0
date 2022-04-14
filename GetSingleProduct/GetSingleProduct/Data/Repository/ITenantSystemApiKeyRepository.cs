namespace GetSingleProduct.Data.Repository
{
    public interface ITenantSystemApiKeyRepository
    {
        string GetKey(int idTenant, string value);
    }
}