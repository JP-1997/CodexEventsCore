using CodexEvents.Models;
using CodexEvents.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.DataAccessLayer.UserRepository
{
    public class UserRepositoryImpl : IUserRepository
    {
        private CodexEventsDbContext _context;

        public UserRepositoryImpl(CodexEventsDbContext context)
        {
            _context = context;
        }
        public int AddUser(User user)
        {
            _context.Users.Add(user);
            return _context.SaveChanges();
        }
    }
}
