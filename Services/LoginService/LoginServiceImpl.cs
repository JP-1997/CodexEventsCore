using CodexEvents.Models;
using CodexEvents.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

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
                var account = (from u in _context.Users
                                where u.Email == email
                                select u).SingleOrDefault();
                if(account == null || !BC.Verify(password, account.Password))
                {
                    return null;
                }
                else
                {
                    return account;
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
