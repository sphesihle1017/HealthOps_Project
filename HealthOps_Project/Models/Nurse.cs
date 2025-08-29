using System.ComponentModel.DataAnnotations;

namespace HealthOps_Project.Models
{
    public class Nurse
    {
            [Key]
            public int NurseId { get; set; }

            [Required]
            [StringLength(100)]
            public string FirstName { get; set; }

            [Required]
            [StringLength(100)]
            public string LastName { get; set; }

            [StringLength(15)]
            public string? PhoneNumber { get; set; }

            [StringLength(100)]
            public string? Department { get; set; }

            // Navigation Properties
            public ICollection<NurseInstruction> NurseInstructions { get; set; }
            public ICollection<VitalSign> VitalSigns { get; set; }
    }
}
