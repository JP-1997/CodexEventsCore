using CodexEvents.Models;
using CodexEvents.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Services.ProfileService
{
    public class ProfileServiceImpl : IProfileService
    {
        private CodexEventsDbContext _context;

        public ProfileServiceImpl(CodexEventsDbContext context)
        {
            _context = context;
        }

        public bool UpdateUser(User user)
        {
            var oldUser = _context.Users.Find(user.Id);
            oldUser.FirstName = user.FirstName;
            oldUser.LastName = user.LastName;
            oldUser.DateOfBirth = user.DateOfBirth;
            oldUser.Gender = user.Gender;
            oldUser.Country = user.Country;
            oldUser.PhoneNumber = user.PhoneNumber;
            _context.Entry(oldUser).State = EntityState.Modified;
            int result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
