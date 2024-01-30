using FirstAPI.Contexts;
using FirstAPI.Interfaces;
using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Repositories
{
    public class EmployeeRepository : IRepository<int, Employee>
    {
        readonly RequestTarkerContext _context;
        public EmployeeRepository()
        {
            _context = new RequestTarkerContext();
        }
        public async Task<Employee> Add(Employee item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Task<Employee> Delete(int key)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetAsync(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetAsync()
        {
            var employees = _context.Employees.Include(e=>e.Department).ToList();
            return employees;
        }

        public Task<Employee> Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}