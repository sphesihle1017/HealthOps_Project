using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class Medication
    {
        [Key]
        public int MedicationId { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? DosageInstructions { get; set; }

        [Required]
        public int PrescriptionId { get; set; }
        [ForeignKey(nameof(PrescriptionId))]
        public Prescription Prescription { get; set; }
    }
}
