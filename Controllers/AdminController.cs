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
    public class AdminController : Controller
    {
        IUserRepository _IUserRepository;
        IProfileService _IProfileService;
        IEventService _IEventService;
        IEventRegistrationService _IEventRegistrationService;

        public AdminController(IUserRepository IUserRepository, IProfileService IProfileService, IEventService IEventService, IEventRegistrationService IEventRegistrationService)
        {
            _IUserRepository = IUserRepository;
            _IProfileService = IProfileService;
            _IEventService = IEventService;
            _IEventRegistrationService = IEventRegistrationService;
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

        public IActionResult ManageRequests()
        {
            int eventId = Convert.ToInt32(HttpContext.Request.Query["eventId"].ToString());
            string eventName = _IEventService.FetchEventById(eventId).Name;
            List<EventRegistration> ers = _IEventRegistrationService.fetchRegistrationInfosByEventId(eventId);
            List<UserRequest> urs = new List<UserRequest>();
            foreach(EventRegistration er in ers)
            {
                User user = _IUserRepository.getUserInfo(er.UserId);
                if(user != null)
                {
                    UserRequest ur = new UserRequest();
                    ur.RegistrationId = er.Id;
                    ur.UserId = er.UserId;
                    ur.UserName = user.FirstName + " " + user.LastName;
                    ur.Status = er.Status;
                    urs.Add(ur);
                }
            }
            ViewBag.UserRequests = urs;
            ViewBag.EventId = eventId;
            ViewBag.EventName = eventName;
            return View();
        }

        public IActionResult ShowRequest()
        {
            int eventRegistrationId = Convert.ToInt32(HttpContext.Request.Query["requestId"].ToString());
            EventRegistration eventRegistration = _IEventRegistrationService.fetchEventRegistrationById(eventRegistrationId);
            Event e = _IEventService.FetchEventById(eventRegistration.EventId);
            if(e.AvailableSeats == 0)
            {
                eventRegistration.Status = "REGISTRATIONS ARE OVER";
                _IEventRegistrationService.UpdateEventRegistration(eventRegistration);
                ViewBag.RegistrationsOver = 1;
            }
            User user = _IUserRepository.getUserInfo(eventRegistration.UserId);
            UserRequest ur = new UserRequest();
            ur.RegistrationId = eventRegistrationId;
            ur.UserId = user.Id;
            ur.UserName = user.FirstName + " " + user.LastName;
            ur.Status = eventRegistration.Status;
            ViewBag.UserRequest = ur;
            ViewBag.EventId = e.Id;
            ViewBag.EventName = e.Name;
            ViewBag.RegistrationsOver = 0;
            return View();
        }

        public IActionResult ApproveRequest()
        {
            int eventRegistrationId = Convert.ToInt32(HttpContext.Request.Query["requestId"].ToString());
            EventRegistration eventRegistration = _IEventRegistrationService.fetchEventRegistrationById(eventRegistrationId);
            int eventId = eventRegistration.EventId;
            int result = _IEventRegistrationService.ApproveRequest(eventRegistrationId);
            //return RedirectToAction("ManageRequests", new { eventId = eventId });
            return RedirectToAction("AddPreRequisites", new { requestId = eventRegistrationId });
        }

        public IActionResult AddPreRequisites()
        {
            int eventRegistrationId = Convert.ToInt32(HttpContext.Request.Query["requestId"].ToString());
            EventRegistration eventRegistration = _IEventRegistrationService.fetchEventRegistrationById(eventRegistrationId);
            int eventId = eventRegistration.EventId;
            Event e = _IEventService.FetchEventById(eventId);
            ViewBag.EventId = eventId;
            ViewBag.EventName = e.Name;
            User user = _IUserRepository.getUserInfo(eventRegistration.UserId);
            ViewBag.UserId = user.Id;
            ViewBag.UserName = user.FirstName + " " + user.LastName;
            ViewBag.EventRegistrationId = eventRegistrationId;
            ViewBag.Prerequisite = eventRegistration.PreRequisite;
            return View();
        }

        [HttpPost]
        public IActionResult UpdatePreRequisites(PrerequisiteViewModel p)
        {
            int eventRegistrationId = p.RequestId;
            EventRegistration eventRegistration = _IEventRegistrationService.fetchEventRegistrationById(eventRegistrationId);
            eventRegistration.PreRequisite = p.Prerequisite;
            _IEventRegistrationService.UpdateEventRegistration(eventRegistration);
            return RedirectToAction("ManageRequests", new { eventId = eventRegistration.EventId });
        }

        public IActionResult RejectRequest()
        {
            int eventRegistrationId = Convert.ToInt32(HttpContext.Request.Query["requestId"].ToString());
            EventRegistration eventRegistration = _IEventRegistrationService.fetchEventRegistrationById(eventRegistrationId);
            int eventId = eventRegistration.EventId;
            int result = _IEventRegistrationService.RejectRequest(eventRegistrationId);
            return RedirectToAction("ManageRequests", new { eventId = eventId });
        }
    }
}
