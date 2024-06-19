using AutoMapper;
using Fiorello_API.DTOs.ProductDto;
using Fiorello_API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_API.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _mapper = mapper;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllForHome()
        {
            var data = await _productService.GetAll();
            if(data is null) return NotFound(ModelState);
            var mappedData = _mapper.Map<List<ProductHomeDTO>>(data);
            return Ok(mappedData);
        }
    }
}
