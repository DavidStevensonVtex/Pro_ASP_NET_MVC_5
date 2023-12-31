﻿using System.Collections.Generic;
using System.Linq;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
	public interface IProductRepository
	{
		IQueryable<Product> Products { get; }
	}
}
