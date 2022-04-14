using GetSingleProduct.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetSingleProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EccosysController : ControllerBase
    {
        EccosysService eccosysService;

        public EccosysController(EccosysService eccosysService)
        {
            this.eccosysService = eccosysService;
        }

        [HttpGet]
        public IActionResult GetSingleProduct(int idTenant, string sku)
        {
            var product = eccosysService.GetSingleProduct(idTenant, sku);
            return Ok(product);
        }
    }
}
