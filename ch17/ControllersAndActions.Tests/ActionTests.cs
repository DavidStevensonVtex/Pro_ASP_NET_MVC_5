using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControllersAndActions.Controllers;

namespace ControllersAndActions.Tests
{
	[TestClass]
	public class ActionTests
	{
		[TestMethod]
		public void ControllerTest()
		{
			// Arrange - create the controller
			ExampleController target = new ExampleController();

			// Act - call the action method
			HttpStatusCodeResult result = target.StatusCode();

			// Assert - check the result
			Assert.AreEqual(401, result.StatusCode);
		}

		[TestMethod]
		public void ViewSelectionTest()
		{
			// Arrange - create the controller
			ExampleController target = new ExampleController();

			// Act - call the action method
			ViewResult result = target.Index();

			// Assert - check the result
			Assert.AreEqual("", result.ViewName);
			Assert.AreEqual("Hello", result.TempData["Message"]);
			Assert.IsInstanceOfType(result.TempData["Date"], typeof(System.DateTime));
		}
	}
}
