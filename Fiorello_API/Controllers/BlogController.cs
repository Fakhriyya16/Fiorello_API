using AutoMapper;
using Fiorello_API.DTOs.BlogDto;
using Fiorello_API.Models;
using Fiorello_API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_API.Controllers
{
    public class BlogController : BaseController
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public BlogController(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllForHome()
        {
            var data = await _blogService.GetAll();

            if (data == null) return null;

            var mappedData = _mapper.Map<List<BlogHomeDTO>>(data);

            return Ok(mappedData);
        }
    }
}
