using GetSingleProduct.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetSingleProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class B2WSkyHubController : ControllerBase
    {
        B2WSkyHubService b2WSkyHubService;

        public B2WSkyHubController(B2WSkyHubService b2WSkyHubService)
        {
            this.b2WSkyHubService = b2WSkyHubService;
        }

        [HttpGet]
        public IActionResult GetSingleProduct(int idTenant, string sku)
        {
            b2WSkyHubService.GetSingleProduct(idTenant, sku);
            return Ok();
        }
    }
}
