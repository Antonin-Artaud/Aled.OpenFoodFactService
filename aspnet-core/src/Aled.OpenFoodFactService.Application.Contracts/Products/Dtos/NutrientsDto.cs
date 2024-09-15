using System.Text.Json.Serialization;

namespace Aled.OpenFoodFactService.Products.Dtos;

public class NutrientsDto
{
    public double Calcium { get; set; }
    
    public double Energy { get; set; }
    
    public double Calories { get; set; }
    
    public double Fats { get; set; }
    
    public double SaturatedFats { get; set; }
    
    public double Carbohydrates { get; set; }
    
    public double Sugars { get; set; }
    
    public double Fibers { get; set; }
    
    public double Proteins { get; set; }
    
    public double Salt { get; set; }

    public double B1 { get; set; }

    public double B2 { get; set; }

    public double B6 { get; set; }

    public double B12 { get; set; }

    public double C { get; set; }
}