using GetSingleProduct.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetSingleProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SoftvarController : ControllerBase
    {
        SoftvarService softvarService;

        public SoftvarController(SoftvarService softvarService)
        {
            this.softvarService = softvarService;
        }

        [HttpGet]
        public void GetSingleProduct(int idTenant, string sku)
        {
            softvarService.GetSingleProduct(idTenant, sku);
        }
    }
}
