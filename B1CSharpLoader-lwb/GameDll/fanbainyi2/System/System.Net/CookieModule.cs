namespace System.Net;

internal static class CookieModule
{
	internal static void OnSendingHeaders(HttpWebRequest httpWebRequest)
	{
		try
		{
			if (httpWebRequest.CookieContainer != null)
			{
				httpWebRequest.Headers.RemoveInternal("Cookie");
				string optCookie;
				string cookieHeader = httpWebRequest.CookieContainer.GetCookieHeader(httpWebRequest.GetRemoteResourceUri(), out optCookie);
				if (cookieHeader.Length > 0)
				{
					httpWebRequest.Headers["Cookie"] = cookieHeader;
				}
			}
		}
		catch
		{
		}
	}

	internal static void OnReceivedHeaders(HttpWebRequest httpWebRequest)
	{
		try
		{
			if (httpWebRequest.CookieContainer == null)
			{
				return;
			}
			HttpWebResponse httpResponse = httpWebRequest._HttpResponse;
			if (httpResponse == null)
			{
				return;
			}
			CookieCollection cookieCollection = null;
			try
			{
				string setCookie = httpResponse.Headers.SetCookie;
				if (setCookie != null && setCookie.Length > 0)
				{
					cookieCollection = httpWebRequest.CookieContainer.CookieCutter(httpResponse.ResponseUri, "Set-Cookie", setCookie, isThrow: false);
				}
			}
			catch
			{
			}
			try
			{
				string setCookie2 = httpResponse.Headers.SetCookie2;
				if (setCookie2 != null && setCookie2.Length > 0)
				{
					CookieCollection cookieCollection2 = httpWebRequest.CookieContainer.CookieCutter(httpResponse.ResponseUri, "Set-Cookie2", setCookie2, isThrow: false);
					if (cookieCollection != null && cookieCollection.Count != 0)
					{
						cookieCollection.Add(cookieCollection2);
					}
					else
					{
						cookieCollection = cookieCollection2;
					}
				}
			}
			catch
			{
			}
			if (cookieCollection != null)
			{
				httpResponse.Cookies = cookieCollection;
			}
		}
		catch
		{
		}
	}
}
