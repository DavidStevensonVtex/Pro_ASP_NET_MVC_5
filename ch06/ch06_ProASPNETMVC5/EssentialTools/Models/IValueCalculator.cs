using System.Collections.Generic;

namespace EssentialTools.Models
{
	interface IValueCalculator
	{
		decimal ValueProducts(IEnumerable<Product> products);
	}
}
