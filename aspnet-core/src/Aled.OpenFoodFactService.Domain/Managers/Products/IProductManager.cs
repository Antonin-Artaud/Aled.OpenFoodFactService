using System.Threading.Tasks;
using Aled.OpenFoodFactService.Entities.Products;

namespace Aled.OpenFoodFactService.Managers.Products;

public interface IProductManager
{
    Task<Product> GetOrCreateAsync(string code);
}