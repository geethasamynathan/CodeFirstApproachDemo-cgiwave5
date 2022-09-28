using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DepartmentEmployeeDAL
{
    internal class DesignTimeDbContextFactory :IDesignTimeDbContextFactory<DepartmentEmployeeDbContext>
    {
        public DepartmentEmployeeDbContext CreateDbContext(string[] args)
        {
             IConfigurationRoot configuration=new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<DepartmentEmployeeDbContext>();
            var connectionstring = configuration.GetConnectionString("myconnection");
            builder.UseSqlServer(connectionstring);
            return new DepartmentEmployeeDbContext(builder.Options);
        }
    }
}
