using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Models
{
    [NotMapped]
    public class PrerequisiteViewModel
    {
        public int RequestId { get; set; }
        public string Prerequisite { get; set; }
    }
}
