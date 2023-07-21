using System.Web;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
	public class CustomAuthAttribute : AuthorizeAttribute
	{
		private bool localAllowed;

		public CustomAuthAttriute(bool allowedParam)
		{
			localAllowed = allowedParam;
		}

		protected override bool AuthorizeCore(HttpContextBase httpContext)
		{
			if (httpContext.Request.IsLocal)
			{
				return localAllowed;
			}
			else
			{
				return true;
			}
		}
	}
}