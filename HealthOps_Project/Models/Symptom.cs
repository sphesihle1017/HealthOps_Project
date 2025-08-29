using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class Symptom
    {
        [Key]
        public int SymptomId { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public DateTime DateRecorded { get; set; } = DateTime.UtcNow;

        [Required]
        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }

        // Navigation Properties
        public Patient Patient { get; set; }
    }
}
