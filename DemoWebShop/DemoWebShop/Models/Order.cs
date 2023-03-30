using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using DemoWebShop.Areas.Identity.Data;

namespace DemoWebShop.Models
{
	public class Order
	{
		[Key]
		public int OrderId { get; set; }

		[Required]
		[Column(TypeName = "datetime")]
		public DateTime DateTime { get; set; } = DateTime.Now;

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal SubTotal { get; set; }= 0.00M;

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Tax { get; set; } = 0.00M;

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Total { get; set; } = 0.00M;

        [Required]
        [Column(TypeName = "nvarchar(450)")]
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))] // 2. nacin pisanja
        public ApplicationUser? User { get; set; }


        //TODO Billing i shiping

        //TODO Customers klasa


    }
}

