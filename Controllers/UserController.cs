using CodexEvents.DataAccessLayer.UserRepository;
using CodexEvents.Models;
using CodexEvents.Services.EventRegistrationService;
using CodexEvents.Services.EventService;
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
        IEventService _IEventService;
        IEventRegistrationService _IEventRegistrationService;

        public UserController(IUserRepository IUserRepository, IProfileService IProfileService, IEventService IEventService, IEventRegistrationService IEventRegistrationService)
        {
            _IUserRepository = IUserRepository;
            _IProfileService = IProfileService;
            _IEventService = IEventService;
            _IEventRegistrationService = IEventRegistrationService;
        }
        public IActionResult Dashboard()
        {
            int userId = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            List<RegistrationInfo> ris = _IEventRegistrationService.fetchRegistrationInfosByUserId(userId);
            return View(ris);
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

        public IActionResult ShowEventDetails()
        {
            int userId = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            int eventId = Convert.ToInt32(HttpContext.Request.Query["eventId"].ToString());
            var eventInfo = _IEventService.FetchEventById(eventId);
            ViewBag.Event = eventInfo;
            int result = _IEventRegistrationService.isUserRegisteredInEvent(userId, eventId);
            if(result > 0)
            {
                string prerequisite = _IEventRegistrationService.fetchPrerequisites(result);
                ViewBag.prerequisite = prerequisite;
            }
            else
            {
                ViewBag.prerequisite = null;
            }
            ViewBag.UserAlreadyRegistered = result;
            return View();
        }

        public IActionResult RaiseRequest()
        {
            int eventId = Convert.ToInt32(HttpContext.Request.Query["eventId"].ToString());
            int userId = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            int result = _IEventRegistrationService.RaiseRequest(userId, eventId);
            if(result > 0)
            {
                return RedirectToAction("RequestRaisedSuccessfully", "User");
            }
            else
            {
                return RedirectToAction("RequestRaiseUnsuccessful", "User");
            }
        }

        public IActionResult RequestRaisedSuccessfully()
        {
            return View();
        }

        public IActionResult RequestRaiseUnsuccessful()
        {
            return View();
        }

        public IActionResult ShowUpcomingEvents()
        {
            List<Event> upcomingEvents = _IEventService.fetchUpcomingEvents();
            return View(upcomingEvents);
        }

        public IActionResult ShowChangePassword()
        {
            return RedirectToAction("ChangePassword", "LoginAndReg");
        }
    }
}
