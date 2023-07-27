using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Services.Interfaces
{
    public interface IUserSerice
    {
        bool AddUser(User user);
        bool AddUserExperience(UserExperience userExperience);
        bool DeleteUser(int id);
        List<UserExperience> GetExperiences(int id);
        List<User> GetUsers();
        bool UpdateUser(User user);
    }
}
