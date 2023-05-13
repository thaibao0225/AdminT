using Client.Data;
using Client.Entites;
using Client.Service;
using Client.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Client.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;
        private readonly ApplicationDbContext _context;
        private CartService _cartService;
        private readonly IContactUserService _contactService;

        public ContactController(ILogger<ContactController> logger, ApplicationDbContext context, IContactUserService contactService)
        {
            _logger = logger;
            _context = context;
            _cartService = new CartService(context);
            _contactService = contactService;
        }
        // GET: ContactController
        [Route("/contact")]
        public async Task<ActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.CountProductInCart = 0;
            if (userId is not null )
            {
                string cartId = await _cartService.GetCartId(userId.ToString());
                ViewBag.CountProductInCart = _cartService.CountProductInCart(cartId);
            }

            return View();
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(string Name, string Email, string Phone, string Message)
        {
            try
            {
                await _contactService.CreateContactUser(Name, Email, Phone, Message);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactController/Edit/5
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

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactController/Delete/5
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
