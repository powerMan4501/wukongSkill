using System.Runtime.CompilerServices;

namespace System.Net;

internal static class HttpStatusDescription
{
	private static readonly string[][] httpStatusDescriptions = new string[6][]
	{
		null,
		new string[3] { "Continue", "Switching Protocols", "Processing" },
		new string[8] { "OK", "Created", "Accepted", "Non-Authoritative Information", "No Content", "Reset Content", "Partial Content", "Multi-Status" },
		new string[8] { "Multiple Choices", "Moved Permanently", "Found", "See Other", "Not Modified", "Use Proxy", null, "Temporary Redirect" },
		new string[27]
		{
			"Bad Request", "Unauthorized", "Payment Required", "Forbidden", "Not Found", "Method Not Allowed", "Not Acceptable", "Proxy Authentication Required", "Request Timeout", "Conflict",
			"Gone", "Length Required", "Precondition Failed", "Request Entity Too Large", "Request-Uri Too Long", "Unsupported Media Type", "Requested Range Not Satisfiable", "Expectation Failed", null, null,
			null, null, "Unprocessable Entity", "Locked", "Failed Dependency", null, "Upgrade Required"
		},
		new string[8] { "Internal Server Error", "Not Implemented", "Bad Gateway", "Service Unavailable", "Gateway Timeout", "Http Version Not Supported", null, "Insufficient Storage" }
	};

	[FriendAccessAllowed]
	internal static string Get(HttpStatusCode code)
	{
		return Get((int)code);
	}

	internal static string Get(int code)
	{
		if (code >= 100 && code < 600)
		{
			int num = code / 100;
			int num2 = code % 100;
			if (num2 < httpStatusDescriptions[num].Length)
			{
				return httpStatusDescriptions[num][num2];
			}
		}
		return null;
	}
}
