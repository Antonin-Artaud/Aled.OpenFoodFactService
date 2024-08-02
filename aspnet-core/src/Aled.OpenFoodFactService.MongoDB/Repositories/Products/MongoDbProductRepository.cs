using System;
using System.Threading.Tasks;
using Aled.OpenFoodFactService.Entities.Products;
using Aled.OpenFoodFactService.Managers.Products;
using Aled.OpenFoodFactService.MongoDB;
using MongoDB.Driver;
using Volo.Abp.Domain.Repositories.MongoDB;
using Volo.Abp.MongoDB;

namespace Aled.OpenFoodFactService.Repositories.Products;

public class MongoDbProductRepository : MongoDbRepository<OpenFoodFactServiceMongoDbContext, Product, Guid>,
    IMongoDbProductRepository
{
    public MongoDbProductRepository(IMongoDbContextProvider<OpenFoodFactServiceMongoDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }

    public async Task<bool> AnyAsync(string code)
    {
        var filter = Builders<Product>.Filter.Eq(p => p.Code, code);
        var collection = await GetCollectionAsync();

        return await collection.Find(filter).AnyAsync();
    }

    public async Task<Product> GetAsync(string code)
    {
        var filter = Builders<Product>.Filter.Eq(p => p.Code, code);
        var collection = await GetCollectionAsync();

        return await collection.Find(filter).FirstAsync();
    }
}