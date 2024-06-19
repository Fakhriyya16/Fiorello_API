using Fiorello_API.DTOs.BlogDto;
using Fiorello_API.DTOs.CategoryDto;
using Fiorello_API.Models;

namespace Fiorello_API.Services.Interfaces
{
    public interface IBlogService
    {
        Task Create(Blog blog);
        Task Delete(Blog blog);
        Task Edit(Blog blog, BlogEditDTO request);
        Task<Blog> GetById(int id);
        Task<List<Blog>> GetAll();
        Task<bool> ExistBlog(string title);
    }
}
