using System.Reflection;
using DataAccess.DbConfigEfCore;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.DbContextEfCore
{
    public class EntityFrameworkDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<EntityDepartment> Departments {get; set;}
        public DbSet<EntitySection> Sections {get; set;}
        public DbSet<EntityPerson> Persons {get; set;}
        public DbSet<EntityAppointment> Appointments {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
            ("Server=*;Database=*;Integrated Security=true;TrustServerCertificate = true;");
            optionsBuilder.EnableSensitiveDataLogging(true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            OnModel.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}