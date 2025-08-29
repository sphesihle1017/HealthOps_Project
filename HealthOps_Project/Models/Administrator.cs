using System.ComponentModel.DataAnnotations;

namespace HealthOps_Project.Models
{
    public class Administrator
    {
        [Key]
        public int AdministratorId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(15)]
        public string? PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }
    }
}
