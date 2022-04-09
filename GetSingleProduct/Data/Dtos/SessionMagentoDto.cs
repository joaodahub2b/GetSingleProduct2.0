using System.ComponentModel.DataAnnotations;

namespace GetSingleProduct.Data.Dtos
{
    public class SessionMagentoDto
    {
        [Required]
        public string Route { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Key { get; set; }

    }
}
