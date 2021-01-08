using CodexEvents.DataAccessLayer.UserRepository;
using CodexEvents.Models;
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
    public class AdminController : Controller
    {
        IUserRepository _IUserRepository;
        IProfileService _IProfileService;
        IEventService _IEventService;

        public AdminController(IUserRepository IUserRepository, IProfileService IProfileService, IEventService IEventService)
        {
            _IUserRepository = IUserRepository;
            _IProfileService = IProfileService;
            _IEventService = IEventService;
        }

        public IActionResult Dashboard()
        {
            int adminId = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            List<Event> events = _IEventService.fetchMyEvents(adminId);
            return View(events);
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

        public IActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEvent(Event e)
        {
            int adminId = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            //e.EventAdminId = adminId;
            int result = _IEventService.addEvent(e, adminId);
            if(result > 0)
            {
                return RedirectToAction("AddEventSuccessful", "Admin");
            }
            else
            {
                return RedirectToAction("Dashboard", "Admin");
            }
        }

        public IActionResult AddEventSuccessful()
        {
            return View();
        }

        public IActionResult ShowEvent()
        {
            int eventId = Convert.ToInt32(HttpContext.Request.Query["eventId"].ToString());
            var e = _IEventService.FetchEventById(eventId);
            var eventInfo = _IEventService.FetchEventById(eventId);
            ViewBag.Event = eventInfo;
            return View();
        }

        public IActionResult ShowEditEvent()
        {
            int eventId = Convert.ToInt32(HttpContext.Request.Query["eventId"].ToString());
            return RedirectToAction("EditMyEvent", new { eventId = eventId });
        }

        public IActionResult EditMyEvent()
        {
            int eventId = Convert.ToInt32(HttpContext.Request.Query["eventId"].ToString());
            var eventInfo = _IEventService.FetchEventById(eventId);
            ViewBag.Event = eventInfo;
            return View();
        }

        public IActionResult UpdateEvent(Event e)
        {
            int eventId = _IEventService.UpdateEvent(e);
            return RedirectToAction("ShowEvent", new { eventId = eventId });
        }

        public IActionResult ShowDeleteEvent()
        {
            int eventId = Convert.ToInt32(HttpContext.Request.Query["eventId"].ToString());
            var eventInfo = _IEventService.FetchEventById(eventId);
            ViewBag.Event = eventInfo;
            return View();
        }

        public IActionResult DeleteMyEvent(Event e)
        {
            _IEventService.DeleteEvent(e.Id);
            return View();
        }
    }
}
