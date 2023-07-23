using System;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Linq;

namespace HelperMethods.Infrastructure
{
	public static class CustomHelpers
	{
		public static MvcHtmlString ListArrayItems ( this HtmlHelper html, string[] list )
		{
			XElement ul = new XElement("ul",
				list.ToList().Select(li => new XElement("li", li))
			);

			return new MvcHtmlString(ul.ToString());
		}

		public static string DisplayMessage ( this HtmlHelper html, string msg )
		{
			return $"This is the message: <p>{msg}</p>";
		}
	}
}