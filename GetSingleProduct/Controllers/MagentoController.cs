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
        public void GetSingleProduct(int tenant, string sku)
        {
            magentoService.GetSingleProduct(tenant, sku);
            //Tenant 4114 para os testes
        }

        //[HttpPost("{id}")]
        //public void GetSession(int id, SessionMagentoDto sessionDto)
        //{
        //    magentoService.GetSession(sessionDto);

        //}
    }
}
