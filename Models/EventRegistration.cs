using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Models
{
    public class EventRegistration
    {
        [Key]
        public int Id { get; set; }

        public int EventId { get; set; }

        public int UserId { get; set; }

        public string Status { get; set; }

        public string PreRequisite { get; set; }
    }
}
