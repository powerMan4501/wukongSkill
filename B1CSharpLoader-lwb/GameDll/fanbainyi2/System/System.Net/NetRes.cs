using System.Globalization;

namespace System.Net;

internal class NetRes
{
	private NetRes()
	{
	}

	public static string GetWebStatusString(string Res, WebExceptionStatus Status)
	{
		string text = SR.GetString(WebExceptionMapping.GetWebStatusString(Status));
		string format = SR.GetString(Res);
		return string.Format(CultureInfo.CurrentCulture, format, new object[1] { text });
	}

	public static string GetWebStatusString(WebExceptionStatus Status)
	{
		return SR.GetString(WebExceptionMapping.GetWebStatusString(Status));
	}

	public static string GetWebStatusCodeString(HttpStatusCode statusCode, string statusDescription)
	{
		int num = (int)statusCode;
		string text = "(" + num.ToString(NumberFormatInfo.InvariantInfo) + ")";
		string text2 = null;
		try
		{
			text2 = SR.GetString("net_httpstatuscode_" + statusCode, null);
		}
		catch
		{
		}
		if (text2 != null && text2.Length > 0)
		{
			text = text + " " + text2;
		}
		else if (statusDescription != null && statusDescription.Length > 0)
		{
			text = text + " " + statusDescription;
		}
		return text;
	}

	public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription)
	{
		int num = (int)statusCode;
		string text = "(" + num.ToString(NumberFormatInfo.InvariantInfo) + ")";
		string text2 = null;
		try
		{
			text2 = SR.GetString("net_ftpstatuscode_" + statusCode, null);
		}
		catch
		{
		}
		if (text2 != null && text2.Length > 0)
		{
			text = text + " " + text2;
		}
		else if (statusDescription != null && statusDescription.Length > 0)
		{
			text = text + " " + statusDescription;
		}
		return text;
	}
}
