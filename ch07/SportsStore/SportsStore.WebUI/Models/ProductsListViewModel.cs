using System.Linq;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
	public class ProductsListViewModel
	{
		public IQueryable<Product> Products { get; set; }
		public PagingInfo PagingInfo { get; set; }
	}
}