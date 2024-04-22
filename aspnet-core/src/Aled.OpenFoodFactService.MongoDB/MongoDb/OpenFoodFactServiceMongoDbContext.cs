﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Aled.OpenFoodFactService.MongoDb;

[ConnectionStringName("Default")]
public class OpenFoodFactServiceMongoDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //modelBuilder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}