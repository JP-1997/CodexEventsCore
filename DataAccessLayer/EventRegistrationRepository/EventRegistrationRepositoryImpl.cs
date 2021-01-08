using CodexEvents.Models;
using CodexEvents.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.DataAccessLayer.EventRegistrationRepository
{
    public class EventRegistrationRepositoryImpl : IEventRegistrationRepository
    {
        private CodexEventsDbContext _context;

        public EventRegistrationRepositoryImpl(CodexEventsDbContext context)
        {
            _context = context;
        }

        public int AddRegistration(EventRegistration er)
        {
            _context.EventRegistrations.Add(er);
            return _context.SaveChanges();
        }

        public async Task<List<EventRegistration>> fetchEventRegistrationsByUserId(int userId)
        {
            var records = await _context.EventRegistrations.Where(er => er.UserId == userId).Select(er => er).ToListAsync();
            return records;
        }

        public EventRegistration findEventRegistrationByUserIdAndEventId(int userId, int eventId)
        {
            EventRegistration er = _context.EventRegistrations.Where(er => er.UserId == userId && er.EventId == eventId).Select(er => er).FirstOrDefault();
            return er;
        }
    }
}
