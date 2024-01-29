using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Contexts
{
    public class RequestTarkerContext : DbContext
    {
        public RequestTarkerContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=DESKTOP-9L5BOE7;Integrated Security=true;Initial catalog=dbRequestTraker");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}