using InfinityElectronics.Shared;
using InfitinityElectronics.Web.ViewModels;
using Microsoft.Extensions.Caching.Memory;

namespace InfitinityElectronics.Web.Services
{
    public class ProductService(IMemoryCache memoryCache, IProductRepository productRepository) : IProductService
    {
        public ProductViewModel? GetProduct(string id)
        {
            var cachedProduct = memoryCache.GetOrCreate(id, x =>
            {
                var product = productRepository.GetProduct(id);

                var productViewModel = ProductViewModel.Map(product);

                return productViewModel;
            });

            return cachedProduct;
        }

        public List<ProductViewModel> GetProducts(int currentPage, int pageSize)
        {
            var products = productRepository.GetProducts(currentPage, pageSize);

            var paginatedProducts = products.Select(ProductViewModel.Map).ToList();

            return paginatedProducts ?? new List<ProductViewModel>();
        }
    }
}
