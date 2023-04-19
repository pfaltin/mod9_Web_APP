using System;
using DemoWebShop.Models;

namespace DemoWebShop.Services.Cart
{
	public class CartItem
	{

		public Product Product { get; set; }
		public decimal Quatity { get; set; }
		public decimal Price { get; set; }

		public decimal GetTotal()
		{
			decimal total = Quatity * Product.Price;
			return total;
		}

	}
}

