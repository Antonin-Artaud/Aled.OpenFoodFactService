using System;
using System.Threading.Tasks;
using Aled.OpenFoodFactService.Dtos;
using Aled.OpenFoodFactService.Services;
using Microsoft.Extensions.Logging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.DependencyInjection;

namespace Aled.OpenFoodFactService.BackgroundJobs;

public class UpdatingDatabaseJob : AsyncBackgroundJob<UpdatingDatabaseJobArgs>, ITransientDependency
{
    private readonly ILogger<UpdatingDatabaseJob> _logger;
    private readonly IUpdatingDatabaseService _updatingDatabaseService;

    public UpdatingDatabaseJob(ILogger<UpdatingDatabaseJob> logger, IUpdatingDatabaseService updatingDatabaseService)
    {
        _logger = logger;
        _updatingDatabaseService = updatingDatabaseService;
    }

    public override async Task ExecuteAsync(UpdatingDatabaseJobArgs args)
    {
        _logger.LogInformation("Updating database started at {DateTime}", args.StartDate);

        await _updatingDatabaseService.UpdateDatabaseAsync();

        _logger.LogInformation("Updating database completed at {DateTime}", DateTime.Now);
    }
}