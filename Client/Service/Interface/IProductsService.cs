using Client.Models;

namespace Client.Service.Interface
{
    public interface IProductsService
    {
        public List<ProductsModel> GetAllProduct();
        public List<ProductsModel> GetProductList(int size);
        public List<ProductsModel> GetProductsInType(string type, int size);
        public List<ProductsModel> GetProductsInSex(string sex, int size);
        public List<CategoriesModel> GetCategories(int size = 0);
        public ProductsModel GetProductDetail(string productId = "");
        public List<ProductsModel> GetProductSearch(string productName);

    }
}
