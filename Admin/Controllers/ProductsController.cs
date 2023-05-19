using Client.Models;
using Client.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;
        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        // GET: ProductsController
        [Route("/products")]
        public ActionResult Index()
        {
            return View(_productsService.GetAllProduct());
        }

        // GET: ProductsController/Details/5
        [Route("/products/detail")]
        public ActionResult Details(string id)
        {
            return View(_productsService.GetProductDetail(id));
        }

        // GET: ProductsController/Create
        [Route("/products/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [Route("/products/create")]
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

        // GET: ProductsController/Edit/5
        [Route("/products/edit")]
        public ActionResult Edit(string id)
        {
            return View(_productsService.GetProductDetail(id));
        }

        // POST: ProductsController/Edit/5
        [Route("/products/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, ProductsModel productsModel)
        {
            try
            {
                await _productsService.EditProduct(productsModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        [Route("/products/delete")]
        public ActionResult Delete(string id)
        {
            return View(_productsService.GetProductDetail(id));
        }

        // POST: ProductsController/Delete/5
        [Route("/products/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, ProductsModel productsModel)
        {
            try
            {

                await _productsService.DeleteProduct(productsModel.pd_Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
