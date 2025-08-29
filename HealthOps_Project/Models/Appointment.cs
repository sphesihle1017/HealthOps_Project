using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public TimeSpan AppointmentTime { get; set; }

        [Required]
        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }

        [Required]
        [ForeignKey(nameof(Doctor))]
        public int DoctorId { get; set; }

        [StringLength(500)]
        public string? Notes { get; set; }

        // Navigation Properties
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
