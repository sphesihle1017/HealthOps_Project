using System.ComponentModel.DataAnnotations;

namespace HealthOps_Project.Models
{
    public class StockManager
    {
        [Key]
        public int StockManagerId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(150)]
        public string? ContactInfo { get; set; }

        // Navigation
        public ICollection<Order>? Orders { get; set; }
    }
}
