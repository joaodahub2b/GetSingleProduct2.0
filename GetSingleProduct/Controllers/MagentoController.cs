using GetSingleProduct.Data.Dtos;
using GetSingleProduct.Services;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace GetSingleProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MagentoController : ControllerBase
    {
        private MagentoService magentoService;

        public MagentoController(MagentoService magentoService)
        {
            this.magentoService = magentoService;
        }

        [HttpGet]
        public IActionResult GetSingleProduct(int tenant, string sku)
        {
            var product = magentoService.GetSingleProduct(tenant, sku);
            return Ok(product);
        }
    }
}
