using Client.Models;
using Client.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: AccountController
        [Route("/accounts")]
        public ActionResult Index()
        {
            return View(_userService.GetUsers());
        }

        [Route("/accounts/Details")]
        // GET: AccountController/Details/5
        public ActionResult Details(string id)
        {
            return View(_userService.GetUserById(id));
        }


        // GET: AccountController/Edit/5
        [Route("/accounts/edit")]
        public ActionResult Edit(string id)
        {
            return View(_userService.GetUserById(id));
        }

        // POST: AccountController/Edit/5
        [Route("/accounts/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, UserModel userModel)
        {
            try
            {
                await _userService.EditUser(userModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [Route("/accounts/delete")]

        // GET: AccountController/Delete/5
        public ActionResult Delete(string id)
        {
            return View(_userService.GetUserById(id));
        }

        // POST: AccountController/Delete/5
        [Route("/accounts/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, UserModel userModel)
        {
            try
            {
                await _userService.DeleteUser(userModel.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
