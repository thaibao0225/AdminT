using Client.Data;
using Client.Service;
using Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Client.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;
        private readonly ApplicationDbContext _context;
        private CartService _cartService;
        private CouponServcice _couponService;

        public CartController(ILogger<CartController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            _cartService = new CartService(context);
            _couponService = new CouponServcice(context);
        }

        // GET: CartController
        [Route("cart")]
        [HttpGet("{couponCode}")]
        public async Task<ActionResult> Index(string couponCode = "")
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            string cartId = await _cartService.GetCartId(userId);

            if (cartId == "")
            {
                return Redirect("/accessdenied");
            }


            CouponModel couponModels = _couponService.GetCoupon(couponCode);
            ViewBag.CouponPrice = 0;
            ViewBag.CouponCode = couponCode;

            var productInCart = _cartService.GetAllProductInCart(cartId);
            int sumPrise = _cartService.GetTotalPrice(productInCart);
            ViewBag.SumPrice = sumPrise;
            if (couponModels != null)
            {
                ViewBag.CouponPrice = couponModels.CouponPrice;
                ViewBag.SumPrice = sumPrise - couponModels.CouponPrice;
            }
            
            

            ViewBag.CountProductInCart = 0;
            if (userId.Any())
            {
                ViewBag.CountProductInCart = _cartService.CountProductInCart(cartId);
            }

            return View(productInCart);
        }

        // GET: CartController/Details/5
        [Route("/closeproduct")]
        [HttpGet("{id}")]
        public async Task<ActionResult> CloseProduct(string id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            string cartId = await _cartService.GetCartId(userId);

            if (cartId == "")
            {
                return Redirect("/accessdenied");
            }

            await _cartService.CloseProductInCart(id, cartId);

            return RedirectToAction(nameof(Index));
        }


        // GET: CartController/Details/5
        [Route("/updatecart")]
        public ActionResult UpdateCart(int id)
        {
            return View();
        }

        
    }
}
