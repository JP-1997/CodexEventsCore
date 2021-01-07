using CodexEvents.DataAccessLayer.UserRepository;
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

        public AdminController(IUserRepository IUserRepository)
        {
            _IUserRepository = IUserRepository;
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
    }
}
