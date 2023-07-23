using System.IO;
using System.Web.Mvc;

namespace Views.Infrastructure
{
	public class DebugDataView : IView
	{
		private void Write(TextWriter writer, string template, params object[] values)
		{
			writer.Write(string.Format(template, values) + "<p/>");
		}

		void IView.Render(ViewContext viewContext, TextWriter writer)
		{
			Write(writer, "---Routing Data---");
			foreach ( string key in viewContext.RouteData.Values.Keys)
			{
				Write(writer, $"Key: {key}, Value: {viewContext.RouteData.Values[key]}");
			}

			Write(writer, "---View Data---");
			foreach ( string key in viewContext.ViewData.Keys)
			{
				Write(writer, $"Key: {key}, Value: {viewContext.ViewData[key]}");
			}
		}
	}
}