using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class Discharge
    {
        [Key]
        public int DischargeId { get; set; }

        [Required]
        public DateTime DischargeDate { get; set; }

        [StringLength(200)]
        public string? Reason { get; set; }

        [Required]
        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }

        // Navigation Properties
        public Patient Patient { get; set; }
    }
}
