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

        //[Required]
        [Column(TypeName = "nvarchar(450)")]
        [StringLength(450)]
        public string? UserId { get; set; }
        [ForeignKey(nameof(UserId))] // 2. nacin pisanja
        public ApplicationUser? User { get; set; }


        //TODO Billing i shiping

        //TODO Customers klasa

        //TODO osobne info korisnika
        [Required(ErrorMessage = "First name is requied")]
        [StringLength(32, ErrorMessage = "requied")]
        [Column(TypeName = "nvarchar(32)")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Last name is requied")]
        [StringLength(32, ErrorMessage = "requied")]
        [Column(TypeName = "nvarchar(32)")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone requied")]
        [StringLength(32, ErrorMessage = "requied")]
        [Column(TypeName = "nvarchar(32)")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email requied")]
        [StringLength(32, ErrorMessage = "requied")]
        [EmailAddress]
        [Column(TypeName = "nvarchar(32)")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address requied")]
        [StringLength(90, ErrorMessage = "requied")]
        [Column(TypeName = "nvarchar(90)")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City requied")]
        [StringLength(32, ErrorMessage = "requied")]
        [Column(TypeName = "nvarchar(32)")]
        public string City { get; set; }

        [Required(ErrorMessage = "Post code requied")]
        [StringLength(32, ErrorMessage = "requied")]
        [Column(TypeName = "nvarchar(32)")]
        public string PostalCode { get; set; }


        [Required(ErrorMessage = "Country requied")]
        [StringLength(32, ErrorMessage = "requied")]
        [Column(TypeName = "nvarchar(32)")]
        public string Country { get; set; }

        
        [StringLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        public string Message { get; set; }

    }
}

