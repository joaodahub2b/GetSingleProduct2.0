using GetSingleProduct.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetSingleProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MercadoLivreController : ControllerBase
    {
        MercadoLivreService meliService;

        public MercadoLivreController(MercadoLivreService meliService)
        {
            this.meliService = meliService;
        }

        [HttpGet]
        public IActionResult GetSingleProduct(string mlb)
        {
            //string teste = "testando retorno na Api";
            var response = meliService.GetSingleProduct(mlb);
            return Ok(response);
        }
    }
}
