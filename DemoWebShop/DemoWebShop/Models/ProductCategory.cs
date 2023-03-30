using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoWebShop.Models
{
	public class ProductCategory
	{

		[Key]
		public int ProductCategoryId { get; set; }

		[Required]
		public int CategoryId { get; set; }
		[ForeignKey("CategoryId")] // 1. nacin pisanj
		public Category? Category { get; set; }


		[Required]
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))] // 2. nacin pisanja
        public Product? Product { get; set; }






    }
}

