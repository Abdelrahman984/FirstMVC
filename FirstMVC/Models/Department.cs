using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Department name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Manager name is required.")]
        public string ManagerName { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}