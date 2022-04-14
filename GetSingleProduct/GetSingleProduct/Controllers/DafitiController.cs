using GetSingleProduct.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetSingleProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DafitiController : ControllerBase
    {
        DafitiService dafitiService;

        public DafitiController(DafitiService dafitiService)
        {
            this.dafitiService = dafitiService;
        }

        [HttpGet]
        public IActionResult GetSingleProduct(int tenant, string userId, string sku, string apiKey)
        {
            var response = dafitiService.GetSingleProduct(tenant, userId, sku, apiKey);
            return Ok(response);
        }
    }
}
