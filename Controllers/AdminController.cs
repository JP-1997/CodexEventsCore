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
    public class AdminController : Controller
    {
        IUserRepository _IUserRepository;
        IProfileService _IProfileService;

        public AdminController(IUserRepository IUserRepository, IProfileService IProfileService)
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
    }
}
