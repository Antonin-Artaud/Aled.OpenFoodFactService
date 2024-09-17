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

    public string Quantity { get; set; }

    public int NovaGroup { get; set; }
    
    public NutrientLevelsDto NutrientLevels { get; set; }

    public string Nutriscore { get; set; }

    public NutrientsDto Nutrients { get; set; }
    
    public VitaminsDto Vitamins { get; set; }

    public VitaminsDto GetVitamins()
    {
        return new VitaminsDto
        {
            B1 = Nutrients.B1,
            B2 = Nutrients.B2,
            B6 = Nutrients.B6,
            B12 = Nutrients.B12,
            C = Nutrients.C,
        };
    }
}