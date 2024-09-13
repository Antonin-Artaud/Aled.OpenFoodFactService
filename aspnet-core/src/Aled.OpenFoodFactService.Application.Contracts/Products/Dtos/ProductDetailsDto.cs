using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Aled.OpenFoodFactService.Products.Dtos;

public class ProductDetailsDto : EntityDto
{
    public string ProductName { get; set; } = string.Empty;

    public string Brands { get; set; } = string.Empty;

    public string IngredientsText { get; set; } = string.Empty;

    public string Allergens { get; set; } = string.Empty;

    public string ImageFrontUrl { get; set; } = string.Empty;
    
    public List<string> CategoryTags { get; set; } = [];
    
    public string IngredientsOrigins { get; set; } = string.Empty;
    
    public string Manufacturing { get; set; } = string.Empty;
    
    public string Packaging { get; set; } = string.Empty;
    
    public int NovaGroup { get; set; }
    
    public NutrientLevelsDto NutriscoreGrade { get; set; }
    
    public NutrimentsDto Nutriments { get; set; }
    
    public VitaminsDto Vitamins { get; set; }
}