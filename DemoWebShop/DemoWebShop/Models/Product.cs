﻿using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoWebShop.Models
{
	public class Product
	{
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal InStock { get; set; } = 0;

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Price { get; set; } = 0.00M;

        [Column(TypeName = "nvarchar(200)")]
        public string? Image { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string? Sku { get; set; }









    }
}

