using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsStore.Domain.Entities;

namespace SportsStore.UnitTests
{
	[TestClass]
	public class CartTests
	{
		[TestMethod]
		public void Can_Add_New_Lines()
		{
			// Arrange - create some test products
			Product p1 = new Product { ProductID = 1, Name = "P1" };
			Product p2 = new Product { ProductID = 2, Name = "P2" };

			// Arrange - create a new cart
			Cart target = new Cart();

			// Act
			target.AddItem(p1, 1);
			target.AddItem(p2, 1);
			CartLine[] results = target.Lines.ToArray();

			// Assert
			Assert.AreEqual(results.Length, 2);
			Assert.AreEqual(results[0].Product, p1);
			Assert.AreEqual(results[1].Product, p2);
		}

		[TestMethod]
		public void Can_Add_Quantity_For_Existing_Lines()
		{
			// Arrange - create some test products
			Product p1 = new Product { ProductID = 1, Name = "P1" };
			Product p2 = new Product { ProductID = 2, Name = "P2" };

			// Arrange - create a new cart
			Cart target = new Cart();

			// Act
			target.AddItem(p1, 1);
			target.AddItem(p2, 1);
			target.AddItem(p1, 10);
			CartLine[] results = target.Lines.ToArray();

			// Assert
			Assert.AreEqual(results.Length, 2);
			Assert.AreEqual(results[0].Quantity, 11);
			Assert.AreEqual(results[1].Quantity, 1);
		}

		[TestMethod]
		public void Can_Remove_Lines()
		{
			// Arrange - create some test products
			Product p1 = new Product { ProductID = 1, Name = "P1" };
			Product p2 = new Product { ProductID = 2, Name = "P2" };
			Product p3 = new Product { ProductID = 3, Name = "P3" };

			// Arrange - create a new cart
			Cart target = new Cart();
			// Arrange - add some products to the cart
			target.AddItem(p1, 1);
			target.AddItem(p2, 3);
			target.AddItem(p3, 5);
			target.AddItem(p2, 1);

			// Act
			target.RemoveLine(p2);

			// Assert
			Assert.AreEqual(0, target.Lines.Where(c => c.Product == p2).Count());
			Assert.AreEqual(2, target.Lines.Count());
		}

		[TestMethod]
		public void Calculate_Cart_Total()
		{
			// Arrange - create some test products
			Product p1 = new Product { ProductID = 1, Name = "P1", Price = 100M };
			Product p2 = new Product { ProductID = 2, Name = "P2", Price = 50M  };

			// Arrange - create a new cart
			Cart target = new Cart();

			// Act
			target.AddItem(p1, 1);
			target.AddItem(p2, 1);
			target.AddItem(p1, 3);
			decimal result = target.ComputeTotalValue();

			// Assert
			Assert.AreEqual(450M, result);
		}

		[TestMethod]
		public void Can_Clear_Contents()
		{
			// Arrange - create some test products
			Product p1 = new Product { ProductID = 1, Name = "P1", Price = 100M };
			Product p2 = new Product { ProductID = 2, Name = "P2", Price = 50M };

			// Arrange - create a new cart
			Cart target = new Cart();
			target.AddItem(p1, 1);
			target.AddItem(p2, 1);

			// Act - reset the cart
			target.Clear();
			Assert.AreEqual(0, target.Lines.Count());
		}
	}
}
