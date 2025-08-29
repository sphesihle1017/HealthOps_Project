using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        [Required]
        public int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }

        [Required]
        public int ConsumableId { get; set; }
        [ForeignKey(nameof(ConsumableId))]
        public Consumable Consumable { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
