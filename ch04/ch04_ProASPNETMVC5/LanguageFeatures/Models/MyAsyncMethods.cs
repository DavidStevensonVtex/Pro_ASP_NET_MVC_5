﻿using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
	public class MyAsyncMethods
	{
		public static Task<long?> GetPageLength()
		{
			HttpClient client = new HttpClient();

			var httpTask = client.GetAsync("http://apress.com");

			// We could do other things here while we are waiting 
			// for the HTTP request to complete

			return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) =>
			{
				return antecedent.Result.Content.Headers.ContentLength;
			});
		}
	}
}