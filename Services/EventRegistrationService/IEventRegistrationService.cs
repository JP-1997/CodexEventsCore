
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
        List<RegistrationInfo> fetchRegistrationInfosByUserId(int userId);

        int isUserRegisteredInEvent(int userId, int eventId);

        List<EventRegistration> fetchRegistrationInfosByEventId(int eventId);

        EventRegistration fetchEventRegistrationById(int eventRegistrationId);

        int ApproveRequest(int eventRegistrationId);

        int UpdateEventRegistration(EventRegistration er);

        int RejectRequest(int eventRegistrationId);

    }
}
