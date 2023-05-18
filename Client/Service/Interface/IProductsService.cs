using Client.Models;

namespace Client.Service.Interface
{
    public interface IProductsService
    {
        public Task<bool> createProduct(ProductsModel productsModel);
        public List<ProductsModel> GetAllProduct();
        public List<ProductsModel> GetProductList(int size);
        public List<ProductsModel> GetProductsInType(string type, int size);
        public List<ProductsModel> GetProductsInSex(string sex, int size);
        public ProductsModel GetProductDetail(string productId = "");
        public List<ProductsModel> GetProductSearch(string productName);
        public Task<bool> EditProduct(ProductsModel productsModel);
        public Task<bool> DeleteProduct(string id);

    }
}
