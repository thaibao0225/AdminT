using Client.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class ContentController : Controller
    {
        private readonly IContactUserService _contacUserService;
        public ContentController(IContactUserService contacUserService)
        {
            _contacUserService = contacUserService;
        }

        // GET: ContentController
        [Route("/contents")]
        public ActionResult Index()
        {
            return View(_contacUserService.GetAllContact());
        }

        // GET: ContentController/Details/5
        [Route("/contents/detail")]
        public ActionResult Details(string id)
        {
            return View();
        }

        // GET: ContentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContentController/Create
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

        // GET: ContentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContentController/Edit/5
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

        // GET: ContentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContentController/Delete/5
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
