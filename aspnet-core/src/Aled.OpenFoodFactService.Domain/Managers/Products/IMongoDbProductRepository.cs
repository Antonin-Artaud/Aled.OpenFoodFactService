using System;
using System.Threading.Tasks;
using Aled.OpenFoodFactService.Entities.Products;
using Volo.Abp.Domain.Repositories;

namespace Aled.OpenFoodFactService.Managers.Products;

public interface IMongoDbProductRepository : IRepository<Product, Guid>
{
    Task<bool> AnyAsync(string code);

    Task<Product> GetAsync(string code);
}