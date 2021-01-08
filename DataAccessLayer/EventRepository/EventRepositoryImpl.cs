using CodexEvents.Models;
using CodexEvents.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.DataAccessLayer.EventRepository
{
    public class EventRepositoryImpl : IEventRepository
    {
        private CodexEventsDbContext _context;

        public EventRepositoryImpl(CodexEventsDbContext context)
        {
            _context = context;
        }

        public int AddEvent(Event e)
        {
            _context.Events.Add(e);
            return _context.SaveChanges();
        }

        public async Task<List<Event>> fetchEventsByAdminId(int AdminId)
        {
            var records = await _context.Events.Where(e => e.EventAdminId == AdminId).Select(e => e).ToListAsync();
            return records;
        }

        public Event GetEvent(int eventId)
        {
            var result = (from e in _context.Events where e.Id == eventId select e).SingleOrDefault();
            return result;
        }

        public async Task<List<Event>> getUpcomingEvents()
        {
            var records = await _context.Events.Where(e => e.Time >= DateTime.Now).ToListAsync();
            return records;
        }

        public int updateEvent(Event e)
        {
            _context.Entry(e).State = EntityState.Modified;
            return _context.SaveChanges();
        }
    }
}
