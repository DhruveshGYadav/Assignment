using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool AddUser(User user);
        bool AddUserExperience(UserExperience userExperience);
        bool DeleteUser(int id);
        List<UserExperience> GetExperiences(int userId);
        List<User> GetUsers();
        bool UpdateUser(User user);
    }
}
