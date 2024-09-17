using Aled.OpenFoodFactService.Entities.Products;
using Aled.OpenFoodFactService.Products.Dtos;
using AutoMapper;

namespace Aled.OpenFoodFactService;

public class OpenFoodFactServiceApplicationAutoMapperProfile : Profile
{
    public OpenFoodFactServiceApplicationAutoMapperProfile()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<ProductDetails, ProductDetailsDto>();
        CreateMap<NutrientLevels, NutrientLevelsDto>();
        CreateMap<Nutrients, NutrientsDto>();
        CreateMap<Vitamins, VitaminsDto>();
    }
}