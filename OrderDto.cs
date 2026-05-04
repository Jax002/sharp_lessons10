using System.ComponentModel.DataAnnotations;

namespace sharp_lessons10
{
    public class OrderDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string CustomerName { get; set; } = string.Empty;

        [Range(0.01, 10000.00)]
        public decimal TotalAmount { get; set; }
    }
}
