using System.ComponentModel.DataAnnotations;

namespace GetSingleProduct.Data.Dtos
{
    public class ReadMagentoDto
    {
        [Required]
        public string Route { get; set; }
        [Required]
        public string key { get; set; }
        [Required]
        public string ProductId { get; set; }
    }
}
