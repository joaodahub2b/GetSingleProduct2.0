using GetSingleProduct.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetSingleProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmillenniumController : ControllerBase
    {
        EmillenniumService emillenniumService;

        public EmillenniumController(EmillenniumService emillenniumService)
        {
            this.emillenniumService = emillenniumService;
        }

        [HttpGet]
        public IActionResult GetSingleProduct(int idTenant)
        {
            var product = emillenniumService.GetSingleProduct(idTenant);
            //Verificar o porque quando insiro product dentro deste Ok abaixo o programa trava
            return Ok();
        }
    }
}
