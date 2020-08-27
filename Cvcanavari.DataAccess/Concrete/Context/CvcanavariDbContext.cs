using Cvcanavari.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cvcanavari.DataAccess.Concrete.Context
{
    public class CvcanavariDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection.String);
        }

        public DbSet<Cv> Cvs { get; set; }
    }
}
