using FirstAPI.Interfaces;
using FirstAPI.Models;

using FirstAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //static List<Employee> employees = new List<Employee> { 
        //    new Employee(101,"Ramu","ramu@gmail.com","9876543210","",new DateTime(2000,10,19)),
        //    new Employee(102,"Somu","somu@gmail.com","4321098765","",new DateTime(2001,1,26))};
        IRepository<int, Employee> _repo;
        public EmployeeController()
        {
            _repo = new EmployeeRepository();
        }
        [HttpGet]
        public async Task<List<Employee>> GetEmployees()
        {
            var employees = await _repo.GetAsync();
            return employees;
        }

        [HttpPost]
        public async Task<Employee> Post(Employee employee)
        {
            employee = await _repo.Add(employee);
            return employee;
        }
    }
}