using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTools.Models;

namespace EssentialTools.Tests
{
	[TestClass]
	public class UnitTest1
	{
		private IDiscountHelper getTestObject()
		{
			return new MinimumDiscountHelper();
		}
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			IDiscountHelper target = getTestObject();
			decimal total = 200;

			// Act
			var discountedTotal = target.ApplyDiscount(total);

			// Assert
			Assert.AreEqual(total * 0.9M, discountedTotal);
		}
	}
}
