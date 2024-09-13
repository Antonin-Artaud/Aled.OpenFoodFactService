using System.Text.Json.Serialization;

namespace Aled.OpenFoodFactService.Entities.Products;

public class Nutriments
{
    [JsonPropertyName("calcium_100g")]
    public double Calcium { get; set; }
    
    [JsonPropertyName("energy_100g")]
    public double Energy { get; set; }
    
    [JsonPropertyName("energy-kcal_100g")]
    public double Calories { get; set; }
    
    [JsonPropertyName("fat_100g")]
    public double Fats { get; set; }
    
    [JsonPropertyName("saturated-fat_100g")]
    public double SaturatedFats { get; set; }
    
    [JsonPropertyName("carbohydrates_100g")]
    public double Carbohydrates { get; set; }
    
    [JsonPropertyName("sugars_100g")]
    public double Sugars { get; set; }
    
    [JsonPropertyName("fiber_100g")]
    public double Fibers { get; set; }
    
    [JsonPropertyName("proteins_100g")]
    public double Proteins { get; set; }
    
    [JsonPropertyName("salt_100g")]
    public double Salt { get; set; }
}