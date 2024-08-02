using System.Threading.Tasks;

namespace Aled.OpenFoodFactService.Data;

public interface IOpenFoodFactServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
