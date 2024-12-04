using System;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using InfinityElectronics.ProductImport.Interfaces;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace InfinityElectronics.ProductImport
{
    public class ProductImportServiceBusTrigger
    {
        private readonly ILogger<ProductImportServiceBusTrigger> _logger;
        private readonly IProductImportService productImportService;

        public ProductImportServiceBusTrigger(ILogger<ProductImportServiceBusTrigger> logger, IProductImportService productImportService)
        {
            _logger = logger;
            this.productImportService = productImportService;
        }

        [Function(nameof(ProductImportServiceBusTrigger))]
        public async Task Run([ServiceBusTrigger("productImport-queue", Connection = "")] ServiceBusReceivedMessage message, ServiceBusMessageActions messageActions)
        {
            productImportService.ImportProduct(message.Body.ToString());
            await messageActions.CompleteMessageAsync(message);
        }
    }
}
