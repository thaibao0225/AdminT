using Client.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class RoliesController : Controller
    {
        private readonly IRoliesService _roleService;
        public RoliesController(IRoliesService roleService)
        {
            _roleService = roleService;
        }

        // GET: RoliesController
        [Route("/rolies")]
        public ActionResult Index()
        {
            return View(_roleService.GetAllRolies());
        }

        // GET: RoliesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoliesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoliesController/Create
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

        // GET: RoliesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoliesController/Edit/5
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

        // GET: RoliesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoliesController/Delete/5
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
