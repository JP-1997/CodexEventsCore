using CodexEvents.DataAccessLayer.UserRepository;
using CodexEvents.Models;
using CodexEvents.Services.ProfileService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Controllers
{
    public class UserController : Controller
    {

        IUserRepository _IUserRepository;
        IProfileService _IProfileService;

        public UserController(IUserRepository IUserRepository, IProfileService IProfileService)
        {
            _IUserRepository = IUserRepository;
            _IProfileService = IProfileService;
        }
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult ShowProfile()
        {
            var userInfo = _IUserRepository.getUserInfo(Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            ViewBag.User = userInfo;
            return View();
        }

        public IActionResult ShowDashboard()
        {
            return RedirectToAction("Dashboard");
        }

        public IActionResult ShowEditProfile()
        {
            return RedirectToAction("EditProfile");
        }

        public IActionResult EditProfile()
        {
            var userInfo = _IUserRepository.getUserInfo(Convert.ToInt32(HttpContext.Session.GetString("UserID")));
            ViewBag.User = userInfo;
            return View();
        }

        public IActionResult UpdateProfile(User user)
        {
            _IProfileService.UpdateUser(user);
            return RedirectToAction("ShowProfile");
        }

        public IActionResult ShowDeleteProfile()
        {
            return View();
        }

        public IActionResult DeleteProfile()
        {
            int userId = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            _IProfileService.DeleteUser(userId);
            return View();
        }

        public IActionResult ShowHome()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult PerformLogout()
        {
            return RedirectToAction("Logout", "LoginAndReg");
        }
    }
}
