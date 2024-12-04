using System;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace InfinityElectronics.ProductImport
{
    public class ProductImportServiceBusTrigger
    {
        private readonly ILogger<ProductImportServiceBusTrigger> _logger;

        public ProductImportServiceBusTrigger(ILogger<ProductImportServiceBusTrigger> logger)
        {
            _logger = logger;
        }

        [Function(nameof(ProductImportServiceBusTrigger))]
        public async Task Run(
            [ServiceBusTrigger("productImport-queue", Connection = "")]
            ServiceBusReceivedMessage message,
            ServiceBusMessageActions messageActions)
        {
            _logger.LogInformation("Message ID: {id}", message.MessageId);
            _logger.LogInformation("Message Body: {body}", message.Body);
            _logger.LogInformation("Message Content-Type: {contentType}", message.ContentType);

            // Complete the message
            await messageActions.CompleteMessageAsync(message);
        }
    }
}
