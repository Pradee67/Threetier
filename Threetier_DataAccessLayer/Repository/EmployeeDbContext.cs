using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Threetier_DataAccessLayer.Repository.Entities;

namespace Threetier_DataAccessLayer.Repository
{
    public class EmployeeDbContext:DbContext
    {
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;initial catalog=Assignment;integrated security=true");
        }
        public DbSet<Employee> employees { get; set; }
    }
}
