﻿using InfinityElectronics.Shared.Models;

namespace InfinityElectronics.Shared
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(int currentPage, int pageSize);
        Product? GetProduct(string? id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
    }
}