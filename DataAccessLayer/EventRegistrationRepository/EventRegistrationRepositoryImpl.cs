using CodexEvents.Models;
using CodexEvents.Persistence;
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
    }
}
