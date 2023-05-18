﻿using Client.Service.Interface;
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
            return View();
        }

        // GET: CouponController/Create
        [Route("/coupons/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CouponController/Create
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

        // GET: CouponController/Edit/5
        [Route("/coupons/edit")]
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: CouponController/Edit/5
        [Route("/coupons/edit")]
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

        // GET: CouponController/Delete/5
        [Route("/coupons/delete")]
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: CouponController/Delete/5
        [Route("/coupons/delete")]
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
