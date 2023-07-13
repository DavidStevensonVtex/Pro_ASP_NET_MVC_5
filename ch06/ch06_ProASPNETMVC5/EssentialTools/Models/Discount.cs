namespace EssentialTools.Models
{
	public class Discount : IDiscountHelper
	{
		public decimal ApplyDiscount(decimal totalParam)
		{
			return (totalParam - (10m / 100m * totalParam));
		}
	}
}