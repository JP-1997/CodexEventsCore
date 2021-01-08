using CodexEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.DataAccessLayer.EventRepository
{
    public interface IEventRepository
    {
        Task<List<Event>> fetchEventsByAdminId(int AdminId);

        int AddEvent(Event e);

        Event GetEvent(int eventId);

        Task<List<Event>> getUpcomingEvents();

        int updateEvent(Event e);
    }
}
