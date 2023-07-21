using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public class SimpleMessageAttribute : FilterAttribute, IActionFilter
	{
		public string Message { get; set; }
		public void OnActionExecuting(ActionExecutingContext filterContext)
		{
			filterContext.HttpContext.Response.Write($"<div>[Before Action: {Message}]</div>");
		}

		public void OnActionExecuted(ActionExecutedContext filterContext)
		{
			filterContext.HttpContext.Response.Write($"<div>[After Action: {Message}]</div>");
		}
	}
}