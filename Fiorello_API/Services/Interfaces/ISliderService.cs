using Fiorello_API.DTOs.SliderDto;
using Fiorello_API.Models;

namespace Fiorello_API.Services.Interfaces
{
    public interface ISliderService
    {
        Task<List<SliderHomeDTO>> GetAllForHome();
        Task Create(Slider slider);
        Task<Slider> GetById(int id);
        Task Delete(Slider slider);
        Task Edit(Slider slider,SliderEditDTO request);
    }
}
