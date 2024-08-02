using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Aled.OpenFoodFactService.Data;

/* This is used if database provider does't define
 * IOpenFoodFactServiceDbSchemaMigrator implementation.
 */
public class NullOpenFoodFactServiceDbSchemaMigrator : IOpenFoodFactServiceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
