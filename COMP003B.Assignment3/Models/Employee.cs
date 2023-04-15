using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment3.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string? EmpName { get; set; }
        public string? Occupation { get; set; }

         [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid salary.")]
        public int Salary { get; set; }
    }
}