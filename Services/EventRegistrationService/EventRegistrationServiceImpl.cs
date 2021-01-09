﻿using CodexEvents.DataAccessLayer.EventRegistrationRepository;
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

        public List<RegistrationInfo> fetchRegistrationInfosByUserId(int userId)
        {
            var eventRegistrationsRecords =_IEventRegistrationRepository.fetchEventRegistrationsByUserId(userId);
            eventRegistrationsRecords.Wait();
            List<EventRegistration> ers = eventRegistrationsRecords.Result;
            List<Event> events = new List<Event>();
            List<RegistrationInfo> ris = new List<RegistrationInfo>();
            foreach (EventRegistration er in ers)
            {
                Event e = _IEventRepository.GetEvent(er.EventId);
                //events.Add(e);
                RegistrationInfo ri = new RegistrationInfo();
                ri.Id = er.Id;
                ri.EventId = e.Id;
                ri.EventName = e.Name;
                ri.EventTime = e.Time;
                ri.EventLocation = e.Location;
                ri.RequestStatus = er.Status;
                ris.Add(ri);
            }
            return ris;
        }

        public int isUserRegisteredInEvent(int userId, int eventId)
        {
            EventRegistration er = _IEventRegistrationRepository.findEventRegistrationByUserIdAndEventId(userId, eventId);
            if(er != null)
            {
                return 1;
            }
            else
            {
                return -1;
            }
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
