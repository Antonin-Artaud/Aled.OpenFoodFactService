using System;
using Volo.Abp.Application.Dtos;

namespace Aled.OpenFoodFactService.Products.Dtos;

public class ProductDto : EntityDto<Guid>
{
    public string Code { get; set; } = string.Empty;

    public ProductDetailsDto ProductDetails { get; set; }
}