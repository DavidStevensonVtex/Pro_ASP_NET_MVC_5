﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository productRepository)
		{
            repository = productRepository;
		}

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult List()
		{
            return View(repository.Products);
		}
    }
}