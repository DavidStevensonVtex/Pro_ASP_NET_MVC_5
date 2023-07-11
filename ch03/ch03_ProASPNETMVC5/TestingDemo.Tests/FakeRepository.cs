using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingDemo.Models;

namespace TestingDemo.Tests
{
	public class FakeRepository : IUserRepository
	{
		private List<User> userList = new List<User>();
		public bool DidSubmitChanges = false;

		public void Add(User newUser)
		{
			userList.Add(newUser);
		}

		public User FetchByLoginName(string loginName)
		{
			return userList.Find(u => u.LoginName == loginName);
		}

		public void SubmitChanges()
		{
			DidSubmitChanges = true;
		}

	}
}
