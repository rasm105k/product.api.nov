using InfitinityElectronics.Web.ViewModels;

namespace InfitinityElectronics.Web.Services
{
    public interface IProductService
    {
        ProductViewModel? GetProduct(string id);
        List<ProductViewModel> GetProducts(int currentPage, int pageSize);
    }
}
