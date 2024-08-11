using System.Threading.Tasks;
using Aled.OpenFoodFactService.Products.Dtos;

namespace Aled.OpenFoodFactService.Products;

public interface IProductAppService
{
    Task<ProductDto> GetAsync(GetProductDto getProductDto);
}