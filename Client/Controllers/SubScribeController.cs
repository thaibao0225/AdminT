using Client.Data;
using Client.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Client.Controllers
{
    public class SubScribeController : Controller
    {
        private readonly ILogger<SubScribeController> _logger;
        private readonly ApplicationDbContext _context;

        public SubScribeController(ILogger<SubScribeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: SubScribeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubScribeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubScribeController/Create
        [Route("/subscribe")]
        public async Task<ActionResult> Create(string email)
        {
            var subscribe = _context.SubscribeEmail;
            var subscribeCreate = new SubscribeEmail()
            {
                Id = Guid.NewGuid().ToString(),
                Email = email
            };
            subscribe.Add(subscribeCreate);
            await _context.SaveChangesAsync();


            return Redirect("/");
        }


        // GET: SubScribeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubScribeController/Edit/5
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

        // GET: SubScribeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubScribeController/Delete/5
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
