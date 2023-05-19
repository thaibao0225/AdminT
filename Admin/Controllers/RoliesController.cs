using Client.Models;
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
        public async Task<ActionResult> Edit(string id, RoleModel roleModel)
        {
            try
            {
                await _roleService.EditRole(roleModel);
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
        public async Task<ActionResult> Delete(string id, RoleModel roleModel)
        {
            try
            {
                await _roleService.DeleteRole(roleModel.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
