using Fiorello_API.Models;

namespace Fiorello_API.DTOs.CategoryDto
{
    public class CategoryDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
