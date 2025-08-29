using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class Treatment
    {
        [Key]
        public int TreatmentId { get; set; }

        [Required]
        [StringLength(200)]
        public string TreatmentName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }

        // Navigation Properties
        public Patient Patient { get; set; }
    }
}
