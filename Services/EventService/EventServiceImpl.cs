using CodexEvents.DataAccessLayer.EventRepository;
using CodexEvents.DataAccessLayer.UserRepository;
using CodexEvents.Models;
using CodexEvents.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Services.EventService
{
    public class EventServiceImpl : IEventService
    {
        private CodexEventsDbContext _context;
        IEventRepository _IEventRepository;

        public EventServiceImpl(CodexEventsDbContext context, IEventRepository IEventRepository)
        {
            _context = context;
            _IEventRepository = IEventRepository;
        }

        public int addEvent(Event e, int adminId)
        {
            e.AvailableSeats = e.TotalSeats;
            e.PendingRequests = 0;
            e.EventAdminId = adminId;
            return _IEventRepository.AddEvent(e);
            
        }

        public bool DeleteEvent(int eventId)
        {
            var e = _context.Events.Find(eventId);
            _context.Events.Remove(e);
            int result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Event FetchEventById(int eventId)
        {
            return _IEventRepository.GetEvent(eventId);
        }

        public List<Event> fetchMyEvents(int EventAdminId)
        {
            var events = _IEventRepository.fetchEventsByAdminId(EventAdminId);
            events.Wait();
            List<Event> fetchedEvents = events.Result;
            return fetchedEvents;
        }

        public List<Event> fetchUpcomingEvents()
        {
            var upcomingEventsRecords = _IEventRepository.getUpcomingEvents();
            upcomingEventsRecords.Wait();
            List<Event> upcomingEvents = upcomingEventsRecords.Result;
            return upcomingEvents;
        }

        public int UpdateEvent(Event e)
        {
            var oldEvent = _context.Events.Find(e.Id);
            oldEvent.Name = e.Name;
            oldEvent.Description = e.Description;
            oldEvent.Time = e.Time;
            oldEvent.Location = e.Location;
            oldEvent.AvailableSeats = e.TotalSeats - oldEvent.TotalSeats + oldEvent.AvailableSeats;
            oldEvent.TotalSeats = e.TotalSeats;
            //var newAvailableSeats = ((Convert.ToInt32(e.TotalSeats) - Convert.ToInt32(oldEvent.TotalSeats)) + Convert.ToInt32(oldEvent.AvailableSeats));
            _context.Entry(oldEvent).State = EntityState.Modified;
            _context.SaveChanges();
            return e.Id;
        }
    }
}
