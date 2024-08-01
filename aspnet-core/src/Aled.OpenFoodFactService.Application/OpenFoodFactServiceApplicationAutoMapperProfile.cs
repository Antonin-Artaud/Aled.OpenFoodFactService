using Aled.OpenFoodFactService.Entities.Products;
using Aled.OpenFoodFactService.Products.Dtos;
using AutoMapper;

namespace Aled.OpenFoodFactService;

public class OpenFoodFactServiceApplicationAutoMapperProfile : Profile
{
    public OpenFoodFactServiceApplicationAutoMapperProfile()
    {
        CreateMap<Product, ProductDto>();
    }
}
