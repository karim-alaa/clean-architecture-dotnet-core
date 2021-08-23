using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Threading.Tasks;

namespace RechargeAutoAction.Jobs.ManageRechargeCases
{
    [DisallowConcurrentExecution]
    public class StayAliveJob : IJob
    {
        private readonly IServiceProvider _provider;
        private readonly ILogger<StayAliveJob> _logger;
        public StayAliveJob(IServiceProvider provider, ILogger<StayAliveJob> logger)
        {
            _provider = provider;
            _logger = logger;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            await StartStayAliveJob();
            await Task.CompletedTask;
        }

        private async Task StartStayAliveJob()
        {
            _logger.LogInformation("Stay Alive Job Running..." + DateTime.Now.ToString());
        }

    }
}
