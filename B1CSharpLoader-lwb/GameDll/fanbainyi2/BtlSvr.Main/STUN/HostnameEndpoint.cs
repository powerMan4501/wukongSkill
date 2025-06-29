using System;
using System.Net;
using System.Net.Sockets;

namespace STUN;

public class HostnameEndpoint
{
	public string Hostname { get; }

	public ushort Port { get; }

	private HostnameEndpoint(string host, ushort port)
	{
		Hostname = host;
		Port = port;
	}

	public static bool TryParse(string s, out HostnameEndpoint result, ushort defaultPort = 0)
	{
		result = null;
		if (string.IsNullOrEmpty(s))
		{
			return false;
		}
		int num = s.Length;
		int num2 = s.LastIndexOf(':');
		if (num2 > 0)
		{
			if (s[num2 - 1] == ']')
			{
				num = num2;
			}
			else if (s.AsSpan(0, num2).LastIndexOf(':') == -1)
			{
				num = num2;
			}
		}
		string text = s.Substring(0, num);
		UriHostNameType uriHostNameType = Uri.CheckHostName(text);
		if ((uint)(uriHostNameType - 2) > 2u)
		{
			return false;
		}
		if (num == s.Length || ushort.TryParse(s.AsSpan(num + 1).ToString(), out defaultPort))
		{
			result = new HostnameEndpoint(text, defaultPort);
			return true;
		}
		return false;
	}

	public override string ToString()
	{
		if (IPAddress.TryParse(Hostname, out var address) && address.AddressFamily == AddressFamily.InterNetworkV6)
		{
			return $"[{address}]:{Port}";
		}
		return $"{Hostname}:{Port}";
	}
}
