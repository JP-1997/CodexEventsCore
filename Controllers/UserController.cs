using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ShowLogin()
        {
            return RedirectToAction("Login");
        }

        public IActionResult ShowReg()
        {
            return RedirectToAction("Register");
        }
    }
}
