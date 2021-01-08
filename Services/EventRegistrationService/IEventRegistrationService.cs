using CodexEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Services.EventRegistrationService
{
    public interface IEventRegistrationService
    {
        int RaiseRequest(int userId, int eventId);
        List<Event> fetchEventsByUserId(int userId);

        int isUserRegisteredInEvent(int userId, int eventId);
    }
}
