using CodexEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Services.ProfileService
{
    public interface IProfileService
    {
        bool UpdateUser(User user);
    }
}
