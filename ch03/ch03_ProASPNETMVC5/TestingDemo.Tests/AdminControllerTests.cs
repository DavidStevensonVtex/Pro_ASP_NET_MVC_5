using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingDemo.Controllers;
using TestingDemo.Models;

namespace TestingDemo.Tests
{
	[TestClass]
	public class AdminControllerTests
	{
		[TestMethod]
		public void CanChangeLoginName()
		{
			// Arrange (set up a scenario)
			User user = new User() { LoginName = "Bob" };
			FakeRepository repositoryParam = new FakeRepository();
			repositoryParam.Add(user);
			AdminController target = new AdminController(repositoryParam);
			string oldLoginParam = user.LoginName;
			string newLoginParam = "Joe";

			// Act (attempt the operation)
			target.ChangeLoginName(oldLoginParam, newLoginParam);

			// Assert (verify the result)
			Assert.AreEqual(newLoginParam, user.LoginName);
			Assert.IsTrue(repositoryParam.DidSubmitChanges);
		}
	}
}
