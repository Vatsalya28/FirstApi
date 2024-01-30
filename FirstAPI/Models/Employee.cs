using System.ComponentModel.DataAnnotations.Schema;

namespace FirstAPI.Models
{
    public class Employee : IEquatable<Employee>
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string? Pic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? DepartmentId { get; set; }
        //This one is just for navigation and will not be created as an attribute in table
        [ForeignKey("DepartmentId")]
        public Departmnet? Department { get; set; }


        public Employee()
        {
            Id = 0;
        }
        public Employee(int id, string name, string email, string phone, string? pic, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Pic = pic;
            DateOfBirth = dateOfBirth;
        }

        public Employee(string name, string email, string phone, string? pic, DateTime dateOfBirth)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Pic = pic;
            DateOfBirth = dateOfBirth;
        }

        public bool Equals(Employee? other)
        {
            var employee = other ?? new Employee();
            return this.Id.Equals(employee.Id);
        }

    }
}