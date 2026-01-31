using System.ComponentModel.DataAnnotations;

namespace dockerproject.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Length(2,20)]
        public string? Name { get; set; }

        [Required]
        [Length(2, 200)]
        public string? Address { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
    }
}
