using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthOps_Project.Models
{
    public class Bed
    {
        [Key]
        public int BedId { get; set; }

        [Required, StringLength(50)]
        public string BedNumber { get; set; } = string.Empty;

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public int WardId { get; set; }
        [ForeignKey(nameof(WardId))]
        public Ward Ward { get; set; }
    }
}
