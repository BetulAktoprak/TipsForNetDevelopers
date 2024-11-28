using DataAccess.Context;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthChecks.BackgroundServices;

public class DatabaseHealthChecksService : BackgroundService
{
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly TimeSpan _interval = TimeSpan.FromSeconds(300);

    public DatabaseHealthChecksService(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var healthCheckService = scope.ServiceProvider.GetRequiredService<HealthCheckService>();
                // var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                var context = new AppDbContext();
                var result = await healthCheckService.CheckHealthAsync(cancellationToken: stoppingToken);

                var healthCheckResult = new DataAccess.Models.HealthCheckResult
                {
                    Timestamp = DateTime.Now,
                    Status = result.Status.ToString(),
                    Description = result.Entries["Sql Server"].Description
                };

                context.HealthCheckResults.Add(healthCheckResult);
                await context.SaveChangesAsync(stoppingToken);
            }

            await Task.Delay(_interval, stoppingToken);
        }
    }
}
