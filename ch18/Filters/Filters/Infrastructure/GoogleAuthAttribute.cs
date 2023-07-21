using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Filters.Infrastructure
{
	public class GoogleAuthAttribute : FilterAttribute, IAuthenticationFilter
	{
		public void OnAuthentication(AuthenticationContext filterContext)
		{
			// not implemented
		}

		public void OnAuthenticationChallenge(AuthenticationChallengeContext context)
		{
			if (context.Result == null) 
			{
				context.Result = new RedirectToRouteResult(
					new RouteValueDictionary
					{
						{ "controller", "GoogleAccount" },
						{ "action", "Login" },
						{ "returnUrl", context.HttpContext.Request.RawUrl }
					});
			}
		}
	}
}