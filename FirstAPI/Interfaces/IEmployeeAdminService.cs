using FirstAPI.Models;

namespace FirstAPI.Interfaces
{
    public interface IEmployeeAdminService : IEmployeeUserService
    {
        public Task<List<Employee>> GetEmployeeListAsync();

        public Task<Employee> AddEmployee(Employee employee);
        public Task<Employee> ChangeEmployeePhoneAsync(int id, string phone);
        public Task<Employee> ChangeEmployeeDepartmnetAsync(int id, int departmnetId);
    }
}