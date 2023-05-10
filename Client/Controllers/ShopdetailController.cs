using Client.Data;
using Client.Entites;
using Client.Models.Static;
using Client.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Client.Controllers
{
    public class ShopdetailController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private CartService _cartService;

        public ShopdetailController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            _cartService = new CartService(context);
        }
        // GET: ShopdetailController
        [Route("/shop/detail")]
        public async Task<ActionResult> Index(string id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ProductsService products = new ProductsService(_context);

            ViewBag.ProductHostTrend = products.GetProductList(4);


            ViewBag.CountProductInCart = 0;
            if (userId != null)
            {
                string cartId = await _cartService.GetCartId(userId.ToString());
                ViewBag.CountProductInCart = _cartService.CountProductInCart(cartId);
            }

            return View(products.GetProductDetail(id));
        }

        // GET: ShopdetailController/Create
        [Route("/shop/addtocart")]
        [HttpGet("{productId}&{quantity}")]
        public async Task<ActionResult> AddToCart(string productId, string quantity)
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string cartId = await _cartService.GetCartId(userId);

            if (cartId == "")
            {
                return Redirect("/accessdenied");
            }
            await _cartService.AddProductToCart(productId, cartId);

            return Redirect("/cart");
        }

        // POST: ShopdetailController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddToCart(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopdetailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopdetailController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopdetailController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopdetailController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopdetailController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopdetailController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
