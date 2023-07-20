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
			RedirectToRouteResult result = target.Redirect2();

			// Assert - check the result
			Assert.IsFalse(result.Permanent);
			Assert.AreEqual("Example", result.RouteValues["controller"]);
			Assert.AreEqual("Index", result.RouteValues["action"]);
			Assert.AreEqual("MyID", result.RouteValues["ID"]);
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
			Assert.AreEqual("Hello", result.ViewBag.Message);
			Assert.IsInstanceOfType(result.ViewBag.Date, typeof(System.DateTime));
		}
	}
}
