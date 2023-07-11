using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingDemo.Models
{
	public class DefaultUserRepository
	{
		private List<User> userList = new List<User>();

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
			// implement me
		}
	}
}