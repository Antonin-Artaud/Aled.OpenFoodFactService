using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Aled.OpenFoodFactService;

public interface IHealthCheckAppService : IApplicationService
{
    Task<string> GetStatusAsync();
}