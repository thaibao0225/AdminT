using Client.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly IProductsService _productsService;
        private readonly IBillService  _billService;

        public PaymentsController(IProductsService productsService, IBillService billService)
        {
            _productsService = productsService;
            _billService = billService;
        }
        // GET: PaymentsController
        [Route("/payments")]
        public ActionResult Index()
        {
            return View(_billService.GetAllBill());
        }

        // GET: PaymentsController/Details/5
        [Route("/payments/confirm")]
        public async Task<ActionResult> ConfirmBill(string id)
        {
            await _billService.ChangeConfirmStatus(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: PaymentsController/Details/5
        [Route("/payments/waitpickup")]
        public async Task<ActionResult> WaitPickupBill(string id)
        {
            await _billService.ChangeWaitPickupStatus(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: PaymentsController/Details/5
        [Route("/payments/delivering")]
        public async Task<ActionResult> DeliveringBill(string id)
        {
            await _billService.ChangeDeliveringStatus(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: PaymentsController/Details/5
        [Route("/payments/delivered")]
        public async Task<ActionResult> DeliveredBill(string id)
        {
            await _billService.ChangeDeliveredStatus(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: PaymentsController/Details/5
        [Route("/payments/cancelled")]
        public async Task<ActionResult> CancelledBill(string id)
        {
            await _billService.ChangeCancelledStatus(id);
            return RedirectToAction(nameof(Index));
        }


        // GET: PaymentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaymentsController/Create
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

        // GET: PaymentsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PaymentsController/Edit/5
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

        // GET: PaymentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PaymentsController/Delete/5
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
