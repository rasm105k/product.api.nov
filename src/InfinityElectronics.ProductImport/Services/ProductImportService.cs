using InfinityElectronics.ProductImport.Interfaces;
using InfinityElectronics.Shared;
using InfinityElectronics.Shared.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace InfinityElectronics.ProductImport.Services
{
    public class ProductImportService(ILogger<ProductImportService> logger, IProductRepository productRepository) : IProductImportService
    {
        public void ImportProduct(string productBody)
        {
            try
            {
                var product = JsonConvert.DeserializeObject<Product>(productBody);
                var existingProduct = productRepository.GetProduct(product.Id);

                if(existingProduct == null)
                {
                    productRepository.AddProduct(product);
                    return;
                }

                if (existingProduct.LastUpdated.Equals(product.LastUpdated))
                    return;

                productRepository.UpdateProduct(product);
            }
            catch (Exception e)
            {
                logger.LogError(e, "Failed to import product {Product}", productBody);
                throw;
            }
        }
    }
}
