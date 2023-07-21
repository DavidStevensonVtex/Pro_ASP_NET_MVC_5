﻿using System;
using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
	public class HomeController : Controller
    {
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

        [RangeException]
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
    }
}