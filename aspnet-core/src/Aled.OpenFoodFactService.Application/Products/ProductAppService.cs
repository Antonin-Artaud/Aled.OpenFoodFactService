using System.Threading.Tasks;
using Aled.OpenFoodFactService.Entities.Products;
using Aled.OpenFoodFactService.Managers.Products;
using Aled.OpenFoodFactService.Products.Dtos;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;

namespace Aled.OpenFoodFactService.Products;

[Authorize]
public class ProductAppService : ApplicationService, IProductAppService
{
    private readonly IProductManager _productManager;

    public ProductAppService(IProductManager productManager)
    {
        _productManager = productManager;
    }

    public async Task<ProductDto> GetAsync(GetProductDto getProductDto)
    {
        var code = getProductDto.Code;
        var product = await _productManager.GetOrCreateAsync(code);

        return ObjectMapper.Map<Product, ProductDto>(product);
    }
}