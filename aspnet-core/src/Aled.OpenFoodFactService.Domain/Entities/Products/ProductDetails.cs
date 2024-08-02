using System.Text.Json.Serialization;

namespace Aled.OpenFoodFactService.Entities.Products;

public class ProductDetails
{
    [JsonPropertyName("_id")] public string Id { get; set; }

    [JsonPropertyName("product_name")] public string ProductName { get; set; }

    [JsonPropertyName("brands")] public string Brands { get; set; }

    [JsonPropertyName("ingredients_text_fr")]
    public string IngredientsText { get; set; }

    [JsonPropertyName("ingredients_text_with_allergens_fr")]
    public string Allergens { get; set; }

    [JsonPropertyName("image_front_url")] public string ImageFrontUrl { get; set; }
}