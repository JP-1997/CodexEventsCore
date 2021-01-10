using CodexEvents.DataAccessLayer.UserRepository;
using CodexEvents.Models;
using CodexEvents.Services.LoginService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace CodexEvents.Controllers
{
    public class LoginAndRegController : Controller
    {
        IUserRepository _IUserRepository;
        ILoginService _ILoginService;

        public LoginAndRegController(IUserRepository IUserRepository, ILoginService ILoginService)
        {
            _IUserRepository = IUserRepository;
            _ILoginService = ILoginService;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            try
            {
                if(!string.IsNullOrEmpty(loginViewModel.Email) && !string.IsNullOrEmpty(loginViewModel.Password))
                {
                    var Email = loginViewModel.Email;
                    var Password = loginViewModel.Password;

                    var result = _ILoginService.ValidateUser(Email, Password);

                    if(result != null)
                    {
                        if(result.Id == 0 || result.Id < 0)
                        {
                            ViewBag.errormessage = "Invalid Credentials !";
                        }
                        else
                        {
                            var Role = result.Role;
                            remove_Anonymous_Cookies();
                            HttpContext.Session.SetString("UserID", Convert.ToString(result.Id));
                            HttpContext.Session.SetString("RoleID", Convert.ToString(result.Role));
                            HttpContext.Session.SetString("Username", Convert.ToString(result.Email));
                            if (Role == "USER")
                            {
                                return RedirectToAction("Dashboard", "User");
                            }
                            else if(Role == "ADMIN")
                            {
                                return RedirectToAction("Dashboard", "Admin");
                            }
                        }
                    }
                    else
                    {
                        ViewBag.errormessage = "Invalid Credentials !";
                        return View();
                    }
                }
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            user.Role = "USER";
            var passwordInRaw = user.Password;
            var hashedPassword = BC.HashPassword(passwordInRaw);
            user.Password = hashedPassword;
            if(_IUserRepository.AddUser(user) > 0)
            {
                return View("RegisteredSuccessfully");
            }
            else
            {
                return View("RegistrationUnsuccessful");
            }
        }

        public IActionResult ShowLogin()
        {
            return RedirectToAction("Login");
        }

        public IActionResult ShowReg()
        {
            return RedirectToAction("Register");
        }

        [NonAction]
        public void remove_Anonymous_Cookies()
        {
            if (Request.Cookies["EventChannel"] != null)
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Append("EventChannel", "", option);
            }
        }

        public IActionResult Logout()
        {
            try
            {
                CookieOptions option = new CookieOptions();

                if (Request.Cookies["EventChannel"] != null)
                {
                    option.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Append("EventChannel", "", option);
                }

                HttpContext.Session.Clear();
                return RedirectToAction("Login", "LoginAndReg");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
