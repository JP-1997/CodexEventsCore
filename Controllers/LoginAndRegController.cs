using CodexEvents.DataAccessLayer.UserRepository;
using CodexEvents.Models;
using CodexEvents.Services.LoginService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                            if(Role == "USER")
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

    
    }
}
