using Client.Models;
using Client.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponServcice _couponServcice;
        public CouponController(ICouponServcice couponServcice)
        {
            _couponServcice = couponServcice;
        }

        // GET: CouponController
        [Route("/coupons")]
        public ActionResult Index()
        {
            return View(_couponServcice.GetAllCoupon());
        }

        // GET: CouponController/Details/5
        [Route("/coupons/detail")]
        public ActionResult Details(string id)
        {
            return View(_couponServcice.GetCouponById(id));
        }

        // GET: CouponController/Create
        [Route("/coupons/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CouponController/Create
        [Route("/coupons/create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CouponModel couponModel)
        {
            try
            {
                await _couponServcice.SetCoupon(couponModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CouponController/Edit/5
        [Route("/coupons/edit")]
        public ActionResult Edit(string id)
        {
            return View(_couponServcice.GetCouponById(id));
        }

        // POST: CouponController/Edit/5
        [Route("/coupons/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, CouponModel couponModel)
        {
            try
            {
                await _couponServcice.EditCoupon(couponModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CouponController/Delete/5
        [Route("/coupons/delete")]
        public ActionResult Delete(string id)
        {
            return View(_couponServcice.GetCouponById(id));
        }

        // POST: CouponController/Delete/5
        [Route("/coupons/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, CouponModel couponModel)
        {
            try
            {
                await _couponServcice.DeleteCoupon(couponModel.CouponId);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
