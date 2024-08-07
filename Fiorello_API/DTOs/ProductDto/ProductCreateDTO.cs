﻿namespace Fiorello_API.DTOs.ProductDto
{
    public class ProductCreateDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<IFormFile> ImageFiles { get; set; }
        public List<string> Images { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
