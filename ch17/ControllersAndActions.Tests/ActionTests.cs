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
			RedirectResult result = target.Redirect();

			// Assert - check the result
			Assert.IsTrue(result.Permanent);
			Assert.AreEqual("/Example/Index", result.Url);
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
