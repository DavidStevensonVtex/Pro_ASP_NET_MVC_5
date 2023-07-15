﻿using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.Controllers
{
	public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository productRepository)
		{
            repository = productRepository;
		}

        public ViewResult List(string category, int page = 1)
		{
            ProductsListViewModel model = 
                new ProductsListViewModel
                {
                    Products = repository.Products
                        .Where(p => category == null || p.Category == category)
                        .OrderBy(p => p.ProductID)
                        .Skip((page - 1) * PageSize)
                        .Take(PageSize)
                        .ToList(),
                        PagingInfo = new PagingInfo
                        {
                            CurrentPage = page,
                            ItemsPerPage = PageSize,
                            TotalItems = repository.Products
                                .Where(p => category == null || p.Category == category)
                                .Count()
                        },
                        CurrentCategory = category
                };

            return View(model);
		}
    }
}