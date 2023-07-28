using Common.Models;
using Common.Repositories.Interfaces;
using Common.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Services
{
    public class UserService : IUserSerice
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool AddUser(User user)
        {
            return _userRepository.AddUser(user);
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public List<UserExperience> GetExperiences(int id)
        {
            return _userRepository.GetExperiences(id);
        }

        public bool AddUserExperience(UserExperience userExperience)
        {
            return _userRepository.AddUserExperience(userExperience);
        }

        public bool UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
        public bool UpdateUserExperience(UserExperience userex)
        {
            return _userRepository.UpdateUserExperience(userex);
        }

        public bool DeleteUser(int id)
        {
            return _userRepository.DeleteUser(id);
        }
        public bool DeleteUserExperience(int id)
        {
            return _userRepository.DeleteUserExperience(id);
        }
    }
}
