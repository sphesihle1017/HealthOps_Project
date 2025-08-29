using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class NurseInstruction
    {
        [Key]
        public int InstructionId { get; set; }

        [Required]
        [StringLength(300)]
        public string InstructionText { get; set; }

        public DateTime DateGiven { get; set; } = DateTime.UtcNow;

        [Required]
        [ForeignKey(nameof(Nurse))]
        public int NurseId { get; set; }

        [Required]
        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }

        // Navigation Properties
        public Nurse Nurse { get; set; }
        public Patient Patient { get; set; }
    }
}
