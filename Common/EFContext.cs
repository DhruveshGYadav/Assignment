using Common.Models;
using Microsoft.EntityFrameworkCore;

namespace Common
{
    public class EFContext:DbContext
    {
        public EFContext(DbContextOptions dbContext):base(dbContext) { }
        public DbSet<User> User { get; set; }

        public DbSet<UserExperience> UserExperience { get; set; }
    }
}