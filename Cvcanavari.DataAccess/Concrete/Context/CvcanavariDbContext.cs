using Cvcanavari.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Cvcanavari.DataAccess.Concrete.Context
{
    public class CvcanavariDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection.String);
        }

        public DbSet<Cv> Cvs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
