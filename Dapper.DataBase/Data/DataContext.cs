using Dapper.DataBase.Model;
using Microsoft.EntityFrameworkCore;

namespace Dapper.DataBase.Data
{
    public class DataContext : DbContext
    {
      
        public DataContext(DbContextOptions<DataContext> options)
         : base(options)
        {
            
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
