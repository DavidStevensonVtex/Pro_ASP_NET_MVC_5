﻿using System;
using System.Diagnostics;
using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
	public class HomeController : Controller
    {
        private Stopwatch timer;

        [Authorize(Users = "admin")]
        public string Index()
        {
            return "This is the Index action on the Home controller";
        }

        [GoogleAuth]
        [Authorize(Users = "bob@google.com")]
        public string List()
		{
            return "This is the List action on the Home controller";
		}

        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "RangeError")]
        public string RangeTest(int id)
		{
            if ( id > 100 )
			{
                return $"The id value is {id}";
			}
            else
			{
                throw new ArgumentOutOfRangeException("id", id, "");
			}
		}

        public string FilterTest()
		{
            return "This is the FilterTest action";
		}

		protected override void OnActionExecuting(ActionExecutingContext filterContext)
		{
            timer = Stopwatch.StartNew();
		}

        protected override void OnResultExecuted (ResultExecutedContext filterContext)
		{
            timer.Stop();
            filterContext.HttpContext.Response.Write(
                $"<div>Total elapsed time: {timer.Elapsed.TotalMilliseconds:N3} milliseconds.</div>");
        }
    }
}