using CodexEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.DataAccessLayer.UserRepository
{
    public interface IUserRepository
    {
        int AddUser(User user);
        User getUserInfo(int userId);
    }
}
