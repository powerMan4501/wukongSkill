using System.Text;

namespace System.Net.Cache;

internal class ResponseCacheControl
{
	internal bool Public;

	internal bool Private;

	internal string[] PrivateHeaders;

	internal bool NoCache;

	internal string[] NoCacheHeaders;

	internal bool NoStore;

	internal bool MustRevalidate;

	internal bool ProxyRevalidate;

	internal int MaxAge;

	internal int SMaxAge;

	internal bool IsNotEmpty
	{
		get
		{
			if (!Public && !Private && !NoCache && !NoStore && !MustRevalidate && !ProxyRevalidate && MaxAge == -1)
			{
				return SMaxAge != -1;
			}
			return true;
		}
	}

	internal ResponseCacheControl()
	{
		MaxAge = (SMaxAge = -1);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (Public)
		{
			stringBuilder.Append(" public");
		}
		if (Private)
		{
			stringBuilder.Append(" private");
			if (PrivateHeaders != null)
			{
				stringBuilder.Append('=');
				for (int i = 0; i < PrivateHeaders.Length - 1; i++)
				{
					stringBuilder.Append(PrivateHeaders[i]).Append(',');
				}
				stringBuilder.Append(PrivateHeaders[PrivateHeaders.Length - 1]);
			}
		}
		if (NoCache)
		{
			stringBuilder.Append(" no-cache");
			if (NoCacheHeaders != null)
			{
				stringBuilder.Append('=');
				for (int j = 0; j < NoCacheHeaders.Length - 1; j++)
				{
					stringBuilder.Append(NoCacheHeaders[j]).Append(',');
				}
				stringBuilder.Append(NoCacheHeaders[NoCacheHeaders.Length - 1]);
			}
		}
		if (NoStore)
		{
			stringBuilder.Append(" no-store");
		}
		if (MustRevalidate)
		{
			stringBuilder.Append(" must-revalidate");
		}
		if (ProxyRevalidate)
		{
			stringBuilder.Append(" proxy-revalidate");
		}
		if (MaxAge != -1)
		{
			stringBuilder.Append(" max-age=").Append(MaxAge);
		}
		if (SMaxAge != -1)
		{
			stringBuilder.Append(" s-maxage=").Append(SMaxAge);
		}
		return stringBuilder.ToString();
	}
}
