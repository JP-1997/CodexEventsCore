﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Models
{
    [NotMapped]
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
