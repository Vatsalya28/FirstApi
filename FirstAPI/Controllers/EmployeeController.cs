using FirstAPI.Interfaces;
using FirstAPI.Models;
using FirstAPI.Models.DTOs;

using FirstAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeAdminService _adminService;

        //static List<Employee> employees = new List<Employee> { 
        //    new Employee(101,"Ramu","ramu@gmail.com","9876543210","",new DateTime(2000,10,19)),
        //    new Employee(102,"Somu","somu@gmail.com","4321098765","",new DateTime(2001,1,26))};

        public EmployeeController(IEmployeeAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet]
        public async Task<List<Employee>> GetEmployees()
        {
            var employees = await _adminService.GetEmployeeListAsync();
            return employees;
        }
        [HttpGet("GetById")]
        public async Task<ActionResult<Employee>> GetEmployees(int id)
        {
            var employee = await _adminService.GetEmployee(id);

            if (employee == null)
            {
                return NotFound(); // Return 404 Not Found if the employee with the given id is not found
            }

            return employee;
        }


        [HttpPost]
        public async Task<Employee> Post(Employee employee)
        {
            employee = await _adminService.AddEmployee(employee);
            return employee;
        }
        [HttpPut]
        public async Task<Employee> UpdateDepartment(EmployeeDepartmentDTO employeeDto)
        {
            var employee = await _adminService.ChangeEmployeeDepartmnetAsync(employeeDto.Id, employeeDto.DepartmentId);
            return employee;
        }
        [Route("[controller]/ChangePhone")]
        [HttpPut]
        public async Task<Employee> UpdatePhone(EmployeePhoneDTO employeeDto)
        {
            var employee = await _adminService.ChangeEmployeePhoneAsync(employeeDto.Id, employeeDto.Phone);
            return employee;
        }
    }
}