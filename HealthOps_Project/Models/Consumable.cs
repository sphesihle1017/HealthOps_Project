using System.ComponentModel.DataAnnotations;

namespace HealthOps_Project.Models
{
    public class Consumable
    {
        [Key]
        public int ConsumableId { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Quantity { get; set; }

        [StringLength(50)]
        public string? Unit { get; set; }

        // Navigation
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
