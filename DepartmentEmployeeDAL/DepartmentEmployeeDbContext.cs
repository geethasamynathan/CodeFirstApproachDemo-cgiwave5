using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DepartmentEmployeeDAL
{
    public class DepartmentEmployeeDbContext:DbContext
    {
        public DepartmentEmployeeDbContext(DbContextOptions options):base(options)
        {

        }
        protected void OnModelCreating(ModelBuilder buiilder)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
