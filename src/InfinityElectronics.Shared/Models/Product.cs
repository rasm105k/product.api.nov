﻿namespace InfinityElectronics.Shared.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
