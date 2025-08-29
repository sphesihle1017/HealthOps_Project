using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class Diagnosis
    {
        [Key]
        public int DiagnosisId { get; set; }

        [Required]
        [StringLength(200)]
        public string Condition { get; set; }

        [Required]
        public DateTime DateDiagnosed { get; set; }

        [Required]
        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }

        [Required]
        [ForeignKey(nameof(Doctor))]
        public int DoctorId { get; set; }

        public string? Notes { get; set; }

        // Navigation Properties
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
