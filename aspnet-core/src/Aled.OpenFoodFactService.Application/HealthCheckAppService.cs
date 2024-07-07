using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Clients;
using Volo.Abp.Users;

namespace Aled.OpenFoodFactService;

[Authorize]
public class HealthCheckAppService : OpenFoodFactServiceAppService, IHealthCheckAppService
{
    private readonly ICurrentClient _currentClient;
    private readonly ICurrentUser _currentUser;
    public HealthCheckAppService(ICurrentClient currentClient, ICurrentUser currentUser)
    {
        _currentClient = currentClient;
        _currentUser = currentUser;
    }

    public Task<string> GetStatusAsync()
    {
        var client = _currentClient;
        var user = _currentUser;
        return Task.FromResult("Healthy!");
    }
}