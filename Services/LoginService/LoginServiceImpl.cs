using CodexEvents.Models;
using CodexEvents.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Services.LoginService
{
    public class LoginServiceImpl : ILoginService
    {
        private CodexEventsDbContext _context;

        public LoginServiceImpl(CodexEventsDbContext context)
        {
            _context = context;
        }

        public User ValidateUser(string email, string password)
        {
            try
            {
                var validate = (from u in _context.Users
                                where u.Email == email && u.Password == password
                                select u).SingleOrDefault();
                return validate;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
