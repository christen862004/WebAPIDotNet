using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDotNet.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string NAme { get; set; }
        public string? Address { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department? Department { get; set; }
    }
}
