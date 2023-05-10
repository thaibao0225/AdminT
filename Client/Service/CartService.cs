using Client.Data;
using Client.Entites;
using Client.Models;

namespace Client.Service
{
    public class CartService : ICartService
    {
       
        private readonly ApplicationDbContext _context;
        public CartService( ApplicationDbContext context)
        {
            
            _context = context;
        }
        public async Task<string> GetCartId(string userId = "")
        {

            if((userId == "") || (userId == null))
            {
                return "";
            }

            var cartCheck = _context.Cart.FirstOrDefault(x => x.cart_UserID == userId);
            if(cartCheck == null)
            {
                string cartId = Guid.NewGuid().ToString();
                Cart cartCreate = new Cart()
                {
                    cart_Id = cartId,
                    cart_UserID = userId
                };

                await _context.Cart.AddAsync(cartCreate);
                await _context.SaveChangesAsync();
                
                return cartId;
            }

            return cartCheck.cart_Id;
        }

        public async Task<Task> AddProductToCart(string productId, string cartId, string size = "S", int quantity = 1, string color = "Red")
        {
            var productInCart = _context.ProductInCart.FirstOrDefault(x => x.pic_ProductId == productId && x.pic_CartId == cartId);
            if(productInCart != null)
            {
                productInCart.pic_size = size;
                productInCart.pic_color = color;
                productInCart.pic_amount = quantity;

                await _context.SaveChangesAsync();

                return Task.CompletedTask;
            }

            ProductInCart productInCartCreate = new ProductInCart()
            {
                pic_CartId = cartId,
                pic_ProductId = productId,
                pic_amount = quantity,
                pic_color = color,
                pic_size = size
            };

            await _context.ProductInCart.AddAsync(productInCartCreate);
            await _context.SaveChangesAsync();

            return Task.CompletedTask;
        }


        public  List<ProductsInCartModel> GetAllProductInCart(string cartId)
        {
            var productInCart = from pic in _context.ProductInCart 
                                join p in _context.Products on pic.pic_ProductId equals p.pd_Id
                                where(pic.pic_CartId == cartId)
                                select new { pic, p };

            if(productInCart.Any())
            {
                var productInCartModel = productInCart.Select(x => new ProductsInCartModel()
                {
                    pic_ProductId = x.pic.pic_ProductId,
                    pic_ProductName = x.p.pd_Name,
                    pic_CartId = x.pic.pic_CartId,
                    pic_color = x.pic.pic_color,
                    pic_quantity = x.pic.pic_amount,
                    pic_size = x.pic.pic_size,
                    pic_ProductImg = x.p.pd_Img1,
                    pic_ProductPrice = x.p.pd_Price

                });
                return productInCartModel.ToList();
            }

            return null;
        }
        public async Task CloseProductInCart(string productId, string cartId)
        {
            var productInCart = _context.ProductInCart.FirstOrDefault(x => x.pic_ProductId == productId && x.pic_CartId == cartId);

            if(productInCart != null)
            {
                _context.ProductInCart.Remove(productInCart);
                await _context.SaveChangesAsync();
            }
        }


        public int CountProductInCart(string cartId)
        {
            var productInCart = _context.ProductInCart.Where(x => x.pic_CartId == cartId);

            return productInCart.Count() != 0 ? productInCart.Count() : 0;
        }

        public int GetTotalPrice(List<ProductsInCartModel>? productsInCartModels = null)
        {
            if(productsInCartModels != null)
            {
                int sumPrice = 0;
                foreach (var item in productsInCartModels)
                {
                    sumPrice = sumPrice + item.pic_SumPrice;
                }

                return sumPrice;
            }
            return 0;
            
        }
    }
}
