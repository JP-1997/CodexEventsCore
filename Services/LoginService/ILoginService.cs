using CodexEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Services.LoginService
{
    public interface ILoginService
    {
        User ValidateUser(string email, string password);
    }
}
