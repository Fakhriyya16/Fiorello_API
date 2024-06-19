using AutoMapper;
using Fiorello_API.DTOs.SliderDto;
using Fiorello_API.Models;
using Fiorello_API.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace Fiorello_API.Controllers
{
    public class SliderController : BaseController
    {
        private readonly ISliderService _sliderService;
        public SliderController(ISliderService sliderService, IMapper mapper , IWebHostEnvironment webHostEnvironment)
        {
            _sliderService = sliderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllForHome()
        {
            return Ok(await _sliderService.GetAllForHome());
        }

        
    }
}
