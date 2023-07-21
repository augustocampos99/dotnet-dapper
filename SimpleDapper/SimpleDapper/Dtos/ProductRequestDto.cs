using System.ComponentModel.DataAnnotations;

namespace SimpleDapper.Dtos
{
    public class ProductRequestDto
    {
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }
    }
}
