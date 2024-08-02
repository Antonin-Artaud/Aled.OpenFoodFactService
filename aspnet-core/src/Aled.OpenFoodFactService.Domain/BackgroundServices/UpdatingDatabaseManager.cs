using System;
using System.Threading.Tasks;
using Aled.OpenFoodFactService.Dtos;
using Volo.Abp.BackgroundJobs;

namespace Aled.OpenFoodFactService.BackgroundServices;

public class UpdatingDatabaseManager(IBackgroundJobManager backgroundJobManager) : IUpdatingDatabaseManager
{
    public async Task UpdateDatabaseAsync(DateTime startDate)
    {
        var args = new UpdatingDatabaseJobArgs
        {
            StartDate = startDate
        };

        await backgroundJobManager.EnqueueAsync(args);
    }
}