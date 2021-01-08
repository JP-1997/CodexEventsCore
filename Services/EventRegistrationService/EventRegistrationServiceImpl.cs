using CodexEvents.DataAccessLayer.EventRegistrationRepository;
using CodexEvents.DataAccessLayer.EventRepository;
using CodexEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Services.EventRegistrationService
{
    public class EventRegistrationServiceImpl : IEventRegistrationService
    {
        IEventRepository _IEventRepository;
        IEventRegistrationRepository _IEventRegistrationRepository;

        public EventRegistrationServiceImpl(IEventRepository IEventRepository, IEventRegistrationRepository IEventRegistrationRepository)
        {
            _IEventRepository = IEventRepository;
            _IEventRegistrationRepository = IEventRegistrationRepository;
        }


        public int RaiseRequest(int userId, int eventId)
        {
            EventRegistration er = new EventRegistration();
            er.UserId = userId;
            er.EventId = eventId;
            er.Status = "PENDING APPROVAL";
            int result = _IEventRegistrationRepository.AddRegistration(er);
            if(result > 0)
            {
                Event e =_IEventRepository.GetEvent(eventId);
                e.AvailableSeats = e.AvailableSeats - 1;
                _IEventRepository.updateEvent(e);
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
