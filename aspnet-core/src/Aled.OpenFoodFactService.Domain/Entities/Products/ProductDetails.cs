using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Aled.OpenFoodFactService.Entities.Products;

public class ProductDetails
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("product_name")] 
    public string ProductName { get; set; }

    [JsonPropertyName("brands")] 
    public string Brands { get; set; }

    [JsonPropertyName("ingredients_text_fr")]
    public string IngredientsText { get; set; }

    [JsonPropertyName("ingredients_text_with_allergens_fr")]
    public string Allergens { get; set; }

    [JsonPropertyName("image_front_url")]
    public string ImageFrontUrl { get; set; }

    [JsonPropertyName("categories_tags")]
    public List<string> CategoryTags { get; set; }
    
    [JsonPropertyName("origins")]
    public string IngredientsOrigins { get; set; }
    
    [JsonPropertyName("manufacturing_places")]
    public string Manufacturing { get; set; }
    
    [JsonPropertyName("packaging")]
    public string Packaging { get; set; }

    [JsonPropertyName("product_quantity")]
    public string Quantity { get; set; }

    //nova_group
    [JsonPropertyName("nova_group")]
    public int NovaGroup { get; set; }
    
    //nutrient
    [JsonPropertyName("nutrient_levels")]
    public NutrientLevels NutrientLevels{ get; set; }

    //nutriscore
    [JsonPropertyName("nutriscore_grade")]
    public string Nutriscore { get; set; }

    //nutriments
    [JsonPropertyName("nutriments")]
    public Nutrients Nutrients { get; set; }
    
    //vitamins
    [JsonPropertyName("vitamins")]
    public Vitamins Vitamins { get; set; }

}