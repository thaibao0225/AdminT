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
        [Route("/rolies/Details")]
        public ActionResult Details(string id)
        {
            return View(_roleService.GetRoleById(id));
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
        [Route("/rolies/Edit")]
        public ActionResult Edit(string id)
        {
            return View(_roleService.GetRoleById(id));
        }

        // POST: RoliesController/Edit/5
        [Route("/rolies/Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
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
        [Route("/rolies/Delete")]
        public ActionResult Delete(string id)
        {
            return View(_roleService.GetRoleById(id));
        }

        // POST: RoliesController/Delete/5
        [Route("/rolies/Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
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
