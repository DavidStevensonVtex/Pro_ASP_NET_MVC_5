﻿namespace EssentialTools.Models
{
	public class DefaultDiscountHelper : IDiscountHelper
	{
		public decimal discountSize;

		public DefaultDiscountHelper(decimal discountParam)
		{
			discountSize = discountParam;
		}

		public decimal ApplyDiscount(decimal totalParam)
		{
			return (totalParam - (discountSize / 100m * totalParam));
		}
	}
}