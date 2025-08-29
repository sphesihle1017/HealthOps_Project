using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class Prescription
    {
        [Key]
        public int PrescriptionId { get; set; }

        [Required]
        public DateTime DatePrescribed { get; set; }

        [Required]
        public int PatientId { get; set; }
        [ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; }

        [Required]
        public int DoctorId { get; set; }
        [ForeignKey(nameof(DoctorId))]
        public Doctor Doctor { get; set; }

        [Required]
        public int ScriptManagerId { get; set; }
        [ForeignKey(nameof(ScriptManagerId))]
        public ScriptManager ScriptManager { get; set; }

        // Navigation
        public ICollection<Medication>? Medications { get; set; }
    }
}
