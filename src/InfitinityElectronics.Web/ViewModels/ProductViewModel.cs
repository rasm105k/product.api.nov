using InfinityElectronics.Shared.Models;

namespace InfitinityElectronics.Web.ViewModels
{
    public struct ProductViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public static ProductViewModel Map(Product product)
        {
            var viewModel = new ProductViewModel();

            viewModel.Id = product.Id;
            viewModel.Name = product.Name;
            viewModel.Category = product.Category;
            viewModel.Description = product.Description;
            viewModel.Image = product.Image;
            viewModel.Price = product.Price;

            return viewModel;
        }
    }
}
