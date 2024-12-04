using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace InfinityElectronics.ProductImport
{
    public class ProductImportTimerTrigger
    {
        private readonly ILogger _logger;

        public ProductImportTimerTrigger(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<ProductImportTimerTrigger>();
        }

        [Function("ProductImportTimerTrigger")]
        //Runs every night at 12
        public void Run([TimerTrigger("0 0 0 * * *")] TimerInfo myTimer)
        {
            //Here should be a call to trigger a full product import from the ERP system to the queue trigger
        }
    }
}
