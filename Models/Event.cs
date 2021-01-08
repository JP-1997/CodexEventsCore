using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Models
{
    public class Event
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }

        public DateTime Time { get; set; }

        public string Location { get; set; }

        public int TotalSeats { get; set; }

        public int AvailableSeats { get; set; }

        public int EventAdminId { get; set; }

        public int PendingRequests { get; set; }
    }
}
