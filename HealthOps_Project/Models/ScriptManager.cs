using System.ComponentModel.DataAnnotations;

namespace HealthOps_Project.Models
{
    public class ScriptManager
    {
        [Key]
        public int ScriptManagerId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(150)]
        public string? ContactInfo { get; set; }

        // Navigation
        public ICollection<Prescription>? ManagedPrescriptions { get; set; }
    }
}
