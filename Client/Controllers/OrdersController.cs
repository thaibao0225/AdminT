using Client.Data;
using Client.Entites;
using Client.Models.Static;
using Client.Service;
using Client.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Client.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IBillService _billService;
        private readonly ICartService _cartService;

        public OrdersController(ILogger<OrdersController> logger, ApplicationDbContext context, IBillService billService, ICartService cartService)
        {
            _logger = logger;
            _context = context;
            _billService = billService;
            _cartService = cartService;
        }
        // GET: OrdersController
        [Route("/orders")]
        public async Task<ActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            ViewBag.CountProductInCart = 0;
            if (userId != null)
            {
                string cartId = await _cartService.GetCartId(userId.ToString());
                ViewBag.CountProductInCart = _cartService.CountProductInCart(cartId);
            }

            return View(_billService.GetAllBillByUserId(userId));
        }

        // GET: OrdersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrdersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrdersController/Create
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

        // GET: OrdersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrdersController/Edit/5
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

        // GET: OrdersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrdersController/Delete/5
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
