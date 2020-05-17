using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace dotnetcore_healthchecks_sample
{
    public class TodoHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            // ...

            return Task.FromResult(HealthCheckResult.Healthy());
        }
    }
}