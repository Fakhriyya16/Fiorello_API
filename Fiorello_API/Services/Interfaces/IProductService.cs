using Fiorello_API.DTOs.CategoryDto;
using Fiorello_API.DTOs.ProductDto;
using Fiorello_API.Models;

namespace Fiorello_API.Services.Interfaces
{
    public interface IProductService
    {
        Task Create(Product product);
        Task Delete(Product product);
        Task Edit(Product product, ProductEditDTO request);
        Task<Product> GetById(int id);
        Task<List<Product>> GetAll();
        Task<bool> ExistProduct(string name);
    }
}
