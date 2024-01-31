using System.ComponentModel.DataAnnotations;

namespace FirstAPI.Models
{
    public class Departmnet
    {
        [Key]
        public int DeparmentNumber { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}