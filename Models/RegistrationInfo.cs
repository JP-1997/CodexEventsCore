using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Models
{
    [NotMapped]
    public class RegistrationInfo
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventTime { get; set; }
        public string EventLocation { get; set; }
        public string RequestStatus { get; set; }
    }
}
