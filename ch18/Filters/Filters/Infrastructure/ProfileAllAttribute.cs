using System.Diagnostics;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
	public class ProfileAllAttribute : ActionFilterAttribute
	{
		private Stopwatch timer = Stopwatch.StartNew();

		public override void OnActionExecuting ( ActionExecutingContext filterContext)
		{
			timer = Stopwatch.StartNew();
		}

		public override void OnResultExecuted(ResultExecutedContext filterContext)
		{
			timer.Stop();

			filterContext.HttpContext.Response.Write(
				$"<div>Total elapsed time: {timer.Elapsed.TotalMilliseconds:N3} milliseconds.</div>");
		}
	}
}