using AutoMapper;
using Fiorello_API.DTOs.BlogDto;
using Fiorello_API.DTOs.CategoryDto;
using Fiorello_API.DTOs.ProductDto;
using Fiorello_API.DTOs.SliderDto;
using Fiorello_API.Models;

namespace Fiorello_API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Slider, SliderHomeDTO>();
            CreateMap<SliderCreateDTO, Slider>();
            CreateMap<SliderEditDTO, Slider>();
            CreateMap<Slider,SliderDetailDTO>();

            CreateMap<Blog, BlogHomeDTO>();
            CreateMap<BlogEditDTO, Blog>();
            CreateMap<BlogCreateDTO, Blog>();
            CreateMap<Blog, BlogDetailDTO>();

            CreateMap<Category, CategoryHomeDTO>();
            CreateMap<CategoryEditDTO, Category>();
            CreateMap<CategoryCreateDTO, Category>();
            CreateMap<Category,CategoryDetailDTO>();

            CreateMap<Product, ProductHomeDTO>().ForMember(
                                                dest => dest.Image,
                                                opt => opt.MapFrom(src => src.ProductImages.FirstOrDefault(m=>m.isMain).Name));
            CreateMap<ProductEditDTO, Product>().ForMember(
                                                dest => dest.ProductImages,
                                                opt => opt.MapFrom(src => src.Images.Select(m => new ProductImage { Name = m }).ToList()))
                                                .ForPath(
                                                dest => dest.Category.Name,
                                                opt => opt.Ignore());
            CreateMap<ProductCreateDTO, Product>().ForMember(
                                                dest => dest.ProductImages,
                                                opt => opt.MapFrom(src => src.Images.Select(m => new ProductImage { Name = m }).ToList()))
                                                .ForPath(
                                                dest => dest.Category.Name,
                                                opt => opt.Ignore());

            CreateMap<Product, ProductDetailDTO>().ForMember(
                                                dest => dest.Category,
                                                opt => opt.MapFrom(src => src.Category.Name))
                                                .ForMember(
                                                dest => dest.Images,
                                                opt => opt.MapFrom(src => src.ProductImages.Select(m => m.Name)));
        }
    }
}
