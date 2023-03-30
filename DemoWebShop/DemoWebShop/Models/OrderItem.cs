using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoWebShop.Models
{
	public class OrderItem
	{
        [Key]
        public int OrderItemId { get; set; }

        [Required]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")] // 1. nacin pisanj
        public Category? Category { get; set; }


        [Required]
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))] // 2. nacin pisanja
        public Product? Product { get; set; }


        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Quantity { get; set; } = 0;

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Price { get; set; } = 0.00M;

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Total { get; set; } = 0.00M;






    }
}

