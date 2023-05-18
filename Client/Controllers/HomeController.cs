using Client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Client.Service;
using Client.Data;
using Client.Models.Static;
using System.Security.Claims;
using Client.Service.Interface;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private ProductsService _products;
        private CartService _cartService;
        private ICategoriesService _categoriesService;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, ICategoriesService categoriesService)
        {
            _logger = logger;
            _context = context;
            _products = new ProductsService(context);
            _cartService = new CartService(context);
            _categoriesService = categoriesService;


        }

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            ViewBag.ProductHostTrend = _products.GetProductsInType(CategoryCommon.HOTTREND, 3);
            ViewBag.ProductBestSaler = _products.GetProductsInType(CategoryCommon.BESTSALER, 3);
            ViewBag.ProductFeature = _products.GetProductsInType(CategoryCommon.FEATURE, 3);

            ViewBag.Categories = _categoriesService.GetCategories();

            ViewBag.CountProductInCart = 0;
            if (userId != null)
            {
                string cartId = await _cartService.GetCartId(userId.ToString());
                ViewBag.CountProductInCart = _cartService.CountProductInCart(cartId);
            }
            

            return View(_products.GetProductList(8));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}