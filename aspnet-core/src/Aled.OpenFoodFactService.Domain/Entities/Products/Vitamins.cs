using System.Text.Json.Serialization;

namespace Aled.OpenFoodFactService.Entities.Products;

public class Vitamins
{
    [JsonPropertyName("b1_value_100g")]
    public double B1 { get; set; }
    
    [JsonPropertyName("b2_value_100g")]
    public double B2 { get; set; }
    
    [JsonPropertyName("b6_value_100g")]
    public double B6 { get; set; }
    
    [JsonPropertyName("b12_value_100g")]
    public double B12 { get; set; }
}