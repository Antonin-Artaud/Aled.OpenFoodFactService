using System;
using System.Text.Json.Serialization;
using Volo.Abp.Domain.Entities;

namespace Aled.OpenFoodFactService.Entities.Products;

public class Product : AggregateRoot<Guid>
{
    [JsonPropertyName("code")] public string Code { get; set; } = string.Empty;

    [JsonPropertyName("product")] public ProductDetails ProductDetails { get; set; }
}