using System.Web.Mvc;

namespace WorkingWithRazor.Infrastructure
{
	public class CustomLocationViewEngine : RazorViewEngine
	{
		public CustomLocationViewEngine()
		{
			ViewLocationFormats = new string[]
			{
				"~/Views/{1}/{0}.cshtml",
				"~/Views/{1}/{0}.cshtml"
			};
		}
	}
}