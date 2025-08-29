using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class Visitation
    {
        [Key]
        public int VisitationId { get; set; }

        [Required]
        public DateTime VisitDate { get; set; }

        [StringLength(200)]
        public string? VisitorName { get; set; }

        [Required]
        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }

        [ForeignKey(nameof(Doctor))]
        public int? DoctorId { get; set; }

        // Navigation Properties
        public Patient Patient { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
