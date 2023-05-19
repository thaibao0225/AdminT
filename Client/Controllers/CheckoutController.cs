using Client.Data;
using Client.Entites;
using Client.Models;
using Client.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Client.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ILogger<CheckoutController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly ProductsService _products;
        private readonly CartService _cartService;
        private readonly BillService _billservice;
        private readonly CouponServcice _couponServcice;

        public CheckoutController(ILogger<CheckoutController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            _products = new ProductsService(context);
            _cartService = new CartService(context);
            _billservice = new BillService(context);
            _couponServcice = new CouponServcice(context);

        }

        // GET: CheckoutController
        [Route("/checkout")]
        [HttpGet("{couponCode}")]
        public async Task<ActionResult> Index(string couponCode)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            int sumPrise = 0;
            ViewBag.CountProductInCart = 0;
            if (userId.Any())
            {
                string cartId = await _cartService.GetCartId(userId.ToString());
                ViewBag.CountProductInCart = _cartService.CountProductInCart(cartId);
                 
                var productInCart = _cartService.GetAllProductInCart(cartId);
                ViewBag.ProductInCart = productInCart;
                sumPrise = _cartService.GetTotalPrice(productInCart);
            }
            ViewBag.Total = sumPrise;
            ViewBag.DisCount = 0;
            CouponModel couponModels = _couponServcice.GetCoupon(couponCode);
            if(couponModels != null)
            {
                sumPrise = sumPrise - couponModels.CouponPrice;
                ViewBag.DisCount = couponModels.CouponPrice;
                ViewBag.Total = sumPrise;
            }
            
            return View();
        }

        // GET: CheckoutController/Details/5
        public ActionResult Details(int id)
        {

            
            return View();
        }

        // GET: CheckoutController/Create
        public ActionResult Create()
        {
            return RedirectToAction(nameof(Index));
        }

        // POST: CheckoutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var cartId = await _cartService.GetCartId(userId);
                var productsInCart = _cartService.GetAllProductInCart(cartId);
                await _billservice.CreateBillForUser(collection, userId, productsInCart);
                await _cartService.ClearCartByCartId(cartId);


                // Caculator
                return Redirect("/");
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckoutController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckoutController/Edit/5
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

        // GET: CheckoutController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckoutController/Delete/5
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
