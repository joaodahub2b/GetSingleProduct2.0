using GetSingleProduct.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetSingleProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TinyController : ControllerBase
    {
        TinyService tinyService;

        public TinyController(TinyService tinyService)
        {
            this.tinyService = tinyService;
        }

        [HttpGet]
        public IActionResult GetSingleProduct(int idTenant, string sku)
        {
            var product = tinyService.GetSingleProduct(idTenant, sku);
            return Ok(product);
        }
    }
}
