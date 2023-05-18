using Client.Models;
using Client.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService _categoriesService;
        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        // GET: CategoriesController
        [Route("/categories")]
        public ActionResult Index()
        {
            return View(_categoriesService.GetAllCategories());
        }

        // GET: CategoriesController/Details/5
        [Route("/categories/detail")]
        public ActionResult Details(string id)
        {
            return View(_categoriesService.getCategoryById(id));
        }

        // GET: CategoriesController/Create
        [Route("/categories/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [Route("/categories/create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CategoriesModel categoriesModel)
        {
            try
            {
                await _categoriesService.createCategory(categoriesModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        [Route("/categories/edit")]
        public ActionResult Edit(string id)
        {
            return View(_categoriesService.getCategoryById(id));
        }

        // POST: CategoriesController/Edit/5
        [Route("/categories/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, CategoriesModel categoriesModel)
        {
            try
            {
                await _categoriesService.editCategory(categoriesModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Delete/5
        [Route("/categories/delete")]
        public ActionResult Delete(string id)
        {
            return View(_categoriesService.getCategoryById(id));
        }

        // POST: CategoriesController/Delete/5
        [Route("/categories/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, CategoriesModel categoriesModel)
        {
            try
            {
                await _categoriesService.deleteCategoryById(categoriesModel.CategoryId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
