using System.Text.Json.Serialization;

namespace Aled.OpenFoodFactService.Entities.Products;

public class NutrientLevels
{
    [JsonPropertyName("fat")]
    public string Fat { get; init; }
    
    [JsonPropertyName("salt")]
    public string Salt { get; init; }
    
    [JsonPropertyName("saturated-fat")]
    public string SaturatedFat { get; init; }
    
    [JsonPropertyName("sugars")]
    public string Sugars { get; init; }
}