using InfinityElectronics.Shared.Models;

namespace InfinityElectronics.Shared
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts(int currentPage, int pageSize)
        {
            using var dbContext = new ProductApplicationDbContext();
            var products = dbContext.Products.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return products;
        }

        public Product? GetProduct(string? id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return null;

            using var dbContext = new ProductApplicationDbContext();
            return dbContext.Products.FirstOrDefault(x => x.Id == id);
        }

        public void AddProduct(Product product)
        {
            using var dbContext = new ProductApplicationDbContext();
            dbContext.Products.Add(product);
        }


        public void UpdateProduct(Product product)
        {
            using var dbContext = new ProductApplicationDbContext();
            dbContext.Products.Update(product);
        }
    }
}
