using System.Globalization;

namespace System.Net;

internal class HttpProtocolUtils
{
	private HttpProtocolUtils()
	{
	}

	internal static DateTime string2date(string S)
	{
		if (HttpDateParse.ParseHttpDate(S, out var dtOut))
		{
			return dtOut;
		}
		throw new ProtocolViolationException(SR.GetString("net_baddate"));
	}

	internal static string date2string(DateTime D)
	{
		DateTimeFormatInfo dateTimeFormatInfo = new DateTimeFormatInfo();
		return D.ToUniversalTime().ToString("R", dateTimeFormatInfo);
	}
}
