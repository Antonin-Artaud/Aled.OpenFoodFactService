using System;
using System.Threading.Tasks;
using Aled.OpenFoodFactService.Entities.Products;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace Aled.OpenFoodFactService;

public class OpenFoodFactServiceDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Product, Guid> _productRepository;

    public OpenFoodFactServiceDataSeedContributor(IRepository<Product, Guid> productRepository)
    {
        _productRepository = productRepository;
    }

    [UnitOfWork]
    public async Task SeedAsync(DataSeedContext context)
    {
        await CreateProductsAsync();
    }

    private async Task CreateProductsAsync()
    {
        if (await _productRepository.GetCountAsync() <= 0)
        {
            await _productRepository.InsertAsync(
                new Product
                {
                    Code = "5449000000439",
                    ProductDetails = new ProductDetails
                    {
                        ProductName = "Coca-Cola",
                        Brands = "Coca-Cola",
                        IngredientsText =
                            "carbonated water, sugar, colour (caramel e150), acid (phosphoric acid), natural flavourings (including caffeine)",
                        Allergens = "None",
                        ImageFrontUrl =
                            "https://images.openfoodfacts.org/images/products/544/900/000/0439/front_en.292.400.jpg"
                    }
                },
                true
            );
        }
    }
}