using Common.Models;
using Common.Repositories.Interfaces;

using Dapper;

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EFContext _context;
        private readonly SqlConnection DbConnection;

        public UserRepository(EFContext context, IConfiguration configuration)
        {
            _context = context;
            DbConnection = new SqlConnection(configuration.GetConnectionString("DbConnection"));
        }
        public bool AddUser(User user)
        {
            var obj = new
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                DOB = user.DOB,
                Address = user.Address
            };

            var res = DbConnection.Execute("AddUserSP", obj, commandType: System.Data.CommandType.StoredProcedure);
            return res == 1;
        }

        public List<User> GetUsers()
        {
            return _context.User.ToList();
        }

        public List<UserExperience> GetExperiences(int userId)
        {
            return _context.UserExperience.Where(e => e.UserId == userId).ToList();
        }

        public bool AddUserExperience(UserExperience userExperience)
        {
            var obj = new
            {
                FromDate = userExperience.FromDate,
                ToDate = userExperience.ToDate,
                Position = userExperience.Position,
                CompanyName = userExperience.CompanyName,
                UserId = userExperience.UserId
            };
            var res = DbConnection.Execute("AddUserExperiencesSP", obj, commandType: System.Data.CommandType.StoredProcedure);
            return res == 1;
        }

        public bool UpdateUser(User user)
        {
            _context.User.Update(user);
            return _context.SaveChanges() == 1;
        }
        public bool UpdateUserExperience(UserExperience userex)
        {
            _context.UserExperience.Update(userex);
            return _context.SaveChanges() == 1;
        }
        public bool DeleteUser(int id)
        {
            var data = _context.User.Find(id);
            var childdata = _context.UserExperience.Where(w => w.UserId == id).ToList();
            _context.UserExperience.RemoveRange(childdata);
            _context.User.Remove(data);
            return _context.SaveChanges() == 1;
        }
        public bool DeleteUserExperience(int id)
        {
            var data = _context.UserExperience.Find(id);            
            _context.UserExperience.Remove(data);
            return _context.SaveChanges() == 1;
        }
    }
}
