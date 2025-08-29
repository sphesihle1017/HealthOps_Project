using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class VitalSign
    {
        [Key]
        public int VitalSignId { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; } // e.g., Blood Pressure, Temperature

        [Required]
        public double Value { get; set; }

        [Required]
        public DateTime DateRecorded { get; set; }

        [Required]
        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }

        [Required]
        [ForeignKey(nameof(Nurse))]
        public int NurseId { get; set; }

        // Navigation Properties
        public Patient Patient { get; set; }
        public Nurse Nurse { get; set; }
    }
}
