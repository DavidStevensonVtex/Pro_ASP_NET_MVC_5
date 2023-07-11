namespace TestingDemo.Models
{
	public interface IUserRepository
	{
		void Add(User newUser);
		User FetchByLoginName(string loginName);
		void SubmitChanges();
	}
}
