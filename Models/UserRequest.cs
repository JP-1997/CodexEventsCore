using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Models
{
    [NotMapped]
    public class UserRequest
    {
        public int RegistrationId { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Status { get; set; }
    }
}
