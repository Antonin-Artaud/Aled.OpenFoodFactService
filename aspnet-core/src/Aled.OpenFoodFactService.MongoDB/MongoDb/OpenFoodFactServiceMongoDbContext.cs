using Aled.OpenFoodFactService.Entities.Products;
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
        base.CreateModel(modelBuilder);
        
        modelBuilder.Entity<Product>(e =>
        {
            e.CollectionName = $"{OpenFoodFactServiceConsts.DbTablePrefix}{nameof(Products)}";
        });
    }
}
