using System.Text.Json.Serialization;

namespace Aled.OpenFoodFactService.Entities.Products;

public class Nutrients
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

    [JsonPropertyName("vitamin-b1_value")]
    public double B1 { get; set; }
    
    [JsonPropertyName("vitamin-b2_value")]
    public double B2 { get; set; }
    
    [JsonPropertyName("vitamin-b6_value")]
    public double B6 { get; set; }
    
    [JsonPropertyName("vitamin-b12_value")]
    public double B12 { get; set; }

    [JsonPropertyName("vitamin-c_value")]
    public double C { get; set; }
}