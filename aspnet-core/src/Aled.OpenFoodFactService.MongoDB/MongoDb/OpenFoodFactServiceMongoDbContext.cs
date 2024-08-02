using Aled.OpenFoodFactService.Entities.Products;
using MongoDB.Bson;
using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Aled.OpenFoodFactService.MongoDB;

[ConnectionStringName("Default")]
public class OpenFoodFactServiceMongoDbContext : AbpMongoDbContext
{
    public IMongoCollection<Product> Products => Collection<Product>();

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(e =>
        {
            e.CollectionName = $"{OpenFoodFactServiceConsts.DbTablePrefix}{nameof(Products)}";
            e.ConfigureIndexes(indexes =>
            {
                indexes.CreateOne(
                    new CreateIndexModel<BsonDocument>(
                        Builders<BsonDocument>.IndexKeys.Ascending("Code"),
                        new CreateIndexOptions { Unique = true }
                    )
                );
            });
        });
    }
}