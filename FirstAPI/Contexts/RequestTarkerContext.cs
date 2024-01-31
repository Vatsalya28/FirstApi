using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Contexts
{
    public class RequestTarkerContext : DbContext
    {
        public RequestTarkerContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Departmnet> Departments { get; set; }
    }
}