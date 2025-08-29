using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class Admission
    {
        [Key]
        public int AdmissionId { get; set; }

        [Required]
        public int PatientId { get; set; }
        [ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; }

        [Required]
        public int WardId { get; set; }
        [ForeignKey(nameof(WardId))]
        public Ward Ward { get; set; }

        [Required]
        public int BedId { get; set; }
        [ForeignKey(nameof(BedId))]
        public Bed Bed { get; set; }

        [Required]
        public DateTime AdmissionDate { get; set; }

        public DateTime? DischargeDate { get; set; }
    }
}
