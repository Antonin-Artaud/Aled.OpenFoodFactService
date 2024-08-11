using System.Threading.Tasks;
using Aled.OpenFoodFactService.Entities.Products;
using Aled.OpenFoodFactService.Services;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace Aled.OpenFoodFactService.Managers.Products;

public class ProductManager : DomainService, IProductManager
{
    private readonly OpenFoodFactRestService _openFoodFactRestService;
    private readonly IMongoDbProductRepository _productRepository;

    public ProductManager(IMongoDbProductRepository productRepository, OpenFoodFactRestService openFoodFactRestService)
    {
        _productRepository = productRepository;
        _openFoodFactRestService = openFoodFactRestService;
    }

    public async Task<Product> GetOrCreateAsync(string code)
    {
        var isExisting = await _productRepository.AnyAsync(code);

        if (isExisting)
        {
            return await _productRepository.GetAsync(code);
        }

        var product = await _openFoodFactRestService.GetProductDetailAsync(code);

        if (product == null)
        {
            throw new BusinessException("Product not found in OpenFoodFact service.");
        }

        await _productRepository.InsertAsync(product);

        return product;
    }
}