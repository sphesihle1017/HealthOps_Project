using System.ComponentModel.DataAnnotations;

namespace HealthOps_Project.Models
{
    public class HospitalStore
    {
        [Key]
        public int StoreId { get; set; }

        [Required]
        [StringLength(100)]
        public string StoreName { get; set; }

        [StringLength(255)]
        public string? Location { get; set; }

        // Navigation Properties
        public ICollection<Consumable> Consumables { get; set; }
    }
}
