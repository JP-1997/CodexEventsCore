using CodexEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Services.EventService
{
    public interface IEventService
    {
        List<Event> fetchMyEvents(int EventAdminId);

        int addEvent(Event e, int adminId);

        Event FetchEventById(int eventId);

        int UpdateEvent(Event e);

        bool DeleteEvent(int eventId);
    }
}
