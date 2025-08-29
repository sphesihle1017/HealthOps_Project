using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class DoctorVisit
    {
        [Key]
        public int VisitId { get; set; }

        [Required]
        public DateTime VisitDate { get; set; }

        [Required]
        public int DoctorId { get; set; }
        [ForeignKey(nameof(DoctorId))]
        public Doctor Doctor { get; set; }

        [Required]
        public int PatientId { get; set; }
        [ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; }

        [StringLength(1000)]
        public string? Notes { get; set; }
    }
}
