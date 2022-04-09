using GetSingleProduct.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetSingleProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlingController : ControllerBase
    {
        BlingService blingService;

        public BlingController(BlingService blingService)
        {
            this.blingService = blingService;
        }

        [HttpGet]
        public IActionResult GetSingleProduct(string sku, string apikey)
        {
            string response = blingService.GetSingleProduct(sku, apikey);
            return Ok(response);
        }
    }
}
