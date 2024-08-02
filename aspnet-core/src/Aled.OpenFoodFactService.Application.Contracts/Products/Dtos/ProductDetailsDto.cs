using Volo.Abp.Application.Dtos;

namespace Aled.OpenFoodFactService.Products.Dtos;

public class ProductDetailsDto : EntityDto
{
    public string ProductName { get; set; } = string.Empty;

    public string Brands { get; set; } = string.Empty;

    public string IngredientsText { get; set; } = string.Empty;

    public string Allergens { get; set; } = string.Empty;

    public string ImageFrontUrl { get; set; } = string.Empty;
}