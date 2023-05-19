using Client.Models;

namespace Client.Service.Interface
{
    public interface ICartService
    {
        public Task<string> GetCartId(string userId = "");
        public Task<Task> AddProductToCart(string productId, string cartId, string size, int quantity, string color);
        public List<ProductsInCartModel> GetAllProductInCart(string cartId);
        public Task<bool> ClearCartByCartId(string cartId);
    }
}
